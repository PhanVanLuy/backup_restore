using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace bk_restore
{
    public partial class frm_main : DevExpress.XtraEditors.XtraForm
    {
        public frm_main()
        {
            InitializeComponent();
            bindingProperties();

        }

        private void loadPath()
        {
            if (Properties.Settings.Default.DefaultPath == string.Empty)
            {
                if (XtraMessageBox.Show("Device sẽ được lưu ở: " + Program.DefaultPath
                    + "\nBạn muốn tiếp tục? (Chọn NO để thay đổi vị trí lưu)", "QUESTION", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    using (var fbd = new FolderBrowserDialog())
                    {
                        DialogResult result = fbd.ShowDialog();

                        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                        {
                            Properties.Settings.Default.DefaultPath = fbd.SelectedPath;

                        }
                    }

                } else
                {
                    Properties.Settings.Default.DefaultPath = Program.DefaultPath;
                }
                Properties.Settings.Default.Save();

            }
        }

        private void bindingProperties()
        {
            tbDatabaseName.DataBindings.Add(new Binding("EditValue", bdsdatabases, "name", true));
            tbBackupPosition.DataBindings.Add(new Binding("EditValue", bdsPositionBackup, "position", true));
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string queryString;
            string dbName = tbDatabaseName.Text;
            string deviceName = formatDeviceName(dbName);
            if (cbDeleteOldBackUp.Checked)
            {
                if (XtraMessageBox.Show("Bạn có chắc xóa toàn bộ file backup cũ\n" +
                                                "Bạn chắc chắn muốn tiếp tục?", "QUESTION",
                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    return;
                this.backupsetTableAdapter.Fill(tempdbDataSet.backupset, dbName);
                for (int index = 0; index < bdsBackupset.Count; index++)
                {
                    int backup_set_id = int.Parse(((DataRowView)bdsBackupset[index])["backup_set_id"].ToString());
                    deleteBackup(backup_set_id);
                }


                queryString = string.Format(Queries.BACKUP_WITH_INIT, dbName, deviceName);

            }
            else
            {
                queryString = string.Format(Queries.BACKUP, dbName, deviceName);
            }

            string note = XtraInputBox.Show(this, "Nhập diễn giải:", "Tạo bản sao lưu", string.Empty);

            if (note != string.Empty && !cbDeleteOldBackUp.Checked)
            {
                queryString += $" WITH NAME = N'{note}'";
            }
            else if(note != string.Empty && cbDeleteOldBackUp.Checked)
            {
                queryString += $" , NAME = N'{note}'";
            }
            else { return; }
            
            int resultExec = Program.ExecSqlNonQuery(queryString , Program.ConnectionString);
            if (resultExec != 0)
            {
                return;
            }
            else
            {

                XtraMessageBox.Show("Thực hiện sao lưu thành công", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.sp_BackupTableAdapter.Fill(this.tempdbDataSet.position_backup, dbName);
                toggleBtnRestore(true);
                cbDeleteOldBackUp.Checked = false;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frm_Main_Load(object sender, EventArgs e)
        {

            loadInit();
            loadPath();
        }
        void loadInit()
        {
            // TODO: This line of code loads data into the 'tempdbDataSet1.backup_devices' table. You can move, or remove it, as needed.
            this.backup_devicesTableAdapter.Fill(this.tempdbDataSet.backup_devices);
            // TODO: This line of code loads data into the 'tempdbDataSet.databases' table. You can move, or remove it, as needed.
            this.databasesTableAdapter.Fill(this.tempdbDataSet.databases);
            checkTimeCheck();
        }

        private void txtDatabaseName_EditValueChanged(object sender, EventArgs e)
        {
            string dbName = tbDatabaseName.Text;

            if (string.IsNullOrEmpty(dbName))
            {
                return;
            }

            this.sp_BackupTableAdapter.Fill(this.tempdbDataSet.position_backup, dbName);

            if (bdsDevices.Find("name", "DEV_" + dbName) < 0)//=-1 thi cho ngdung tao device
            {
                stateIsExistDevice(false);//false:chua co device
            }
            else
            {
                stateIsExistDevice(true);//true: co device roi
            }

        }

        private void stateIsExistDevice(bool isExistDevice)
        {
            btnDevice.Enabled = !isExistDevice;
            bttCreateDevice.Enabled = !isExistDevice;

            btnBackup.Enabled = isExistDevice;
            bttBackup.Enabled = isExistDevice;
            bttDeleteDevice.Enabled = isExistDevice;
            
            backupsetTableAdapter.Fill(tempdbDataSet.backupset, tbDatabaseName.Text);

            if (bdsBackupset.Count > 0 && isExistDevice)
            {
                toggleBtnRestore(true);
            }
            else
            {
                toggleBtnRestore(false);

            }
            
        }

        private string formatDeviceName(string dbName)
        {
            return string.Format("DEV_{0}", dbName);
        }

        private void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ("".Equals(tbBackupPosition.Text))
            {
                XtraMessageBox.Show("Phục hồi thất bại", "FAIL",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string dbName = tbDatabaseName.Text;

            if (bciRestoreWithTime.Checked)
            {
                DateTime thoiDiemStopAt = DateTime.Parse(dePickDate.DateTime.ToString("MM/dd/yyyy") + " " + tePickTime.Time.ToString("HH:mm:ss"));
                if (checkValidTimeRestore(thoiDiemStopAt))
                {
                    if (XtraMessageBox.Show($"Bạn chắc chắn muốn restore database [{dbName}] về thời điểm [{(thoiDiemStopAt)}]?",
                                                    "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                      
                        int resultExec = RestoreWithTime(thoiDiemStopAt);
                        if (resultExec == 0)
                        {
                            XtraMessageBox.Show("Phục hồi thành công", "SUCCESS",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Program.Connect();
                        }
                        else
                        {
                            XtraMessageBox.Show($"Phục hồi thất bại\nError State: {resultExec}", "FAIL",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                if (XtraMessageBox.Show($"Bạn chắc chắn muốn restore database [{dbName}] về bản backup [{tbBackupPosition.Text}]?",
                                                    "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int resultExec = Restore();
                    if (resultExec == 0)
                    {
                        XtraMessageBox.Show("Phục hồi thành công", "SUCCESS",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show($"Phục hồi thất bại\nError State: {resultExec}", "FAIL",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private int  Restore()
        {
            string queryString = string.Format(Queries.RESTORE,
                tbDatabaseName.Text,
                formatDeviceName(tbDatabaseName.Text),
                tbBackupPosition.Text);
            int resultExec = 0;
                resultExec = Program.ExecSqlNonQuery(queryString, Program.ConnectionString);
           
            return resultExec;
        }

        private int RestoreWithTime(DateTime timeStopAt)
        {

            string dbName = tbDatabaseName.Text;
            string deviceName = formatDeviceName(dbName);
            string position = tbBackupPosition.Text;
            string logFilePath = Properties.Settings.Default.DefaultPath + $"\\{dbName}.trn";

            string queryString = string.Format(Queries.RESTORE_WITH_TIME,
                                                        dbName, logFilePath, deviceName, position);

            int resultExec = 0;
                resultExec = Program.ExecSqlNonQuery(queryString, Program.ConnectionString);
            


            if (resultExec != 0)
            {
                queryString = string.Format(Queries.ERROR_RESTORE,dbName,deviceName,position);
               
                    Program.ExecSqlNonQuery(queryString, Program.ConnectionString);
              
                return resultExec;
            }

            queryString = string.Format(Queries.RESTORE_WITH_STOPAT, dbName, logFilePath, timeStopAt);
                resultExec = Program.ExecSqlNonQuery(queryString, Program.ConnectionString);
            
            if (resultExec != 0)
            {
                queryString = string.Format(Queries.ERROR_RESTORE, dbName, deviceName, position);
                {
                    Program.ExecSqlNonQuery(queryString, Program.ConnectionString);
                    return resultExec;
                }
            }

            queryString = string.Format(Queries.SET_MULTI_USER,dbName);
                resultExec = Program.ExecSqlNonQuery(queryString, Program.ConnectionString);
                
            
            return 0;
        }

        private bool checkValidTimeRestore(DateTime thoiDiemStopAt)
        {
            
            DateTime ngayGioBackup = (DateTime)((DataRowView)bdsPositionBackup.Current)["backup_start_date"];
            if (thoiDiemStopAt > DateTime.Now)
            {
                XtraMessageBox.Show("Thời điểm muốn phục hồi phải trước thời điểm hiện tại",
                    "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            if ((dePickDate.DateTime.Date < ngayGioBackup.Date) ||//sau ngày
                (dePickDate.DateTime.Date == ngayGioBackup.Date &&(thoiDiemStopAt.TimeOfDay.Ticks < ngayGioBackup.TimeOfDay.Ticks)))// chung ngày, sau giờ
            {
                XtraMessageBox.Show("Thời điểm muốn phục hồi phải sau thời điểm bản sao lưu cuối cùng ",
                    "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnDevice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string deviceName = formatDeviceName(tbDatabaseName.Text);
            string physicalName = Properties.Settings.Default.DefaultPath + "\\" + deviceName + ".bak";



            string queryString = string.Format(Queries.CREATE_DEVICE, deviceName, physicalName);


            int resultExec = Program.ExecSqlNonQuery(queryString, Program.ConnectionString);

            if (resultExec == 0)
            {
                XtraMessageBox.Show("Tạo device thành công", "SUCCESS",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.backup_devicesTableAdapter.Fill(this.tempdbDataSet.backup_devices);
                stateIsExistDevice(true);
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadInit();
        }

        private void bciRestoreWithTime_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            checkTimeCheck();
        }
        void checkTimeCheck()
        {
            if (bciRestoreWithTime.Checked)
            {
                lbTimeRestore.Visible = true;
                dePickDate.Visible = true;
                tePickTime.Visible = true;
                neHuongdan.Visible = true;

                dePickDate.DateTime = DateTime.Now;
                tePickTime.Time = DateTime.Now.AddMinutes(-1);
            }
            else
            {
                lbTimeRestore.Visible = false;
                dePickDate.Visible = false;
                tePickTime.Visible = false;
                neHuongdan.Visible = false;
            }
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            if(XtraMessageBox.Show("Bạn chắc chắn muốn xóa file backup này?", "QUESTION",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;


            int backup_set_id= int.Parse(((DataRowView)bdsPositionBackup.Current)["backup_set_id"].ToString());
            if (deleteBackup(backup_set_id) == 0)
            {
                XtraMessageBox.Show("Đã xóa file backup", "SUCCESS",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Xóa file backup thất bại", "FAIL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sp_BackupTableAdapter.Fill(tempdbDataSet.position_backup, tbDatabaseName.Text);

            if (bdsBackupset.Count <= 0) { toggleBtnRestore(false); } else { toggleBtnRestore(true); }
            
        }
        private void toggleBtnRestore(bool isOn)
        {
           
            btnRestore.Enabled = isOn;
            bttRestore.Enabled = isOn;
            bciRestoreWithTime.Enabled = isOn;
            if(isOn)
            {
                bttDeleteDevice.Enabled = isOn;
            }
        }

        private int deleteBackup(int backup_set_id)
        {

            restore_historyTableAdapter.Fill(tempdbDataSet.restore_history, backup_set_id);

            string query = string.Format(Queries.DELETE_BACKUP, backup_set_id);
            int restoreCount = bdsRestoreHistory.Count;
           
            if (restoreCount > 0)
            {
                string queryDelete = "";
                string history_id;
                for (int i = 0; i<restoreCount; i++)
                {
                    history_id= ((DataRowView)bdsRestoreHistory[i])["restore_history_id"].ToString();
                    queryDelete += string.Format(Queries.DELETE_RESTORE_HISTORY, history_id);
                }
                query = queryDelete + query;//xoa history truoc
            }
           
            return Program.ExecSqlNonQuery(query, Program.ConnectionString);
        }

        private void bttRestore_Click(object sender, EventArgs e)
        {
            btnRestore.PerformClick();
        }

        private void bttDeleteDevice_Click(object sender, EventArgs e)
        {
            sp_BackupTableAdapter.Fill(tempdbDataSet.position_backup, tbDatabaseName.Text);

            if (bdsPositionBackup.Count > 0)
            {
                XtraMessageBox.Show("Device này có chứa các bản sao lưu \nBạn cần phải xóa hết các back up trước khi xóa device!", "CAUTION",
                MessageBoxButtons.OK, MessageBoxIcon.Information); 
                 return;
                
            }
            else
            {
                if (XtraMessageBox.Show("Bạn chắc chắn muốn xóa device này?", "QUESTION",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }

            string query = string.Format(Queries.DELETE_DEVICE,formatDeviceName(tbDatabaseName.Text));

            if (Program.ExecSqlNonQuery(query, Program.ConnectionString)==0)
            {
                XtraMessageBox.Show("Đã xóa device thành công", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Xóa device thất  bại", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            stateIsExistDevice(false);
        }

        private void bttCreateDevice_Click(object sender, EventArgs e)
        {
            btnDevice.PerformClick();
        }

        private void bttBackup_Click(object sender, EventArgs e)
        {
            btnBackup.PerformClick();
        }

        private void gcDatabases_Click(object sender, EventArgs e)
        {

        }

        private void gcBackup_Click(object sender, EventArgs e)
        {

        }

        private void cmsBackupRow_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
