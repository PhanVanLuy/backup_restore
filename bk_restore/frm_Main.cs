using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void bindingProperties()
        {
            tbDatabaseName.DataBindings.Add(new Binding("EditValue", bdsdatabases, "name", true));
            tbBackupPosition.DataBindings.Add(new Binding("EditValue", bdsSTTBackup, "position", true));
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

                for (int index = 0; index < bdsBackupset.Count; index++)
                {
                    string backup_set_id = ((DataRowView)bdsBackupset[index])["backup_set_id"].ToString();
                    DeleteBackup(int.Parse(backup_set_id));
                }

            queryString = string.Format(Queries.BACKUP_WITH_INIT, dbName, deviceName);

            }
            else
            {
                queryString = string.Format(Queries.BACKUP, dbName, deviceName);
            }

            string note = XtraInputBox.Show(this, "Nhập diễn giải:", "Tạo Back up", string.Empty);//lấy diễn giải

            if (note != string.Empty)
            {
                queryString += $" WITH NAME = N'{note}'";
            }
            else { return; }
            
            int resultExec = Program.ExecSqlNonQuery(queryString, Program.ConnectionString);
            if (resultExec != 0)
            {

                return;
            }
            else
            {
                XtraMessageBox.Show("Thực hiện sao lưu thành công", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.sp_BackupTableAdapter.Fill(this.tempdbDataSet.SP_STT_BACKUP, dbName);
                btnRestore.Enabled = true;
            }

        }
        private int DeleteBackup(int backupSetId)
        {
            restore_historyTableAdapter.Fill(tempdbDataSet.restore_history, backupSetId);

            string query = string.Format(Queries.DELETE_BACKUP, backupSetId);

            int restoreCount = bdsRestoreHistory.Count;
            if (restoreCount > 0)
            {
                string queryDeleteRestoreHistory = "";
                for (int index = 0; index < restoreCount; index++)
                {
                    string restore_history_id = ((DataRowView)bdsRestoreHistory[index])["restore_history_id"].ToString();
                    queryDeleteRestoreHistory += string.Format(Queries.DELETE_RESTORE_HISTORY, restore_history_id);
                }
                query = queryDeleteRestoreHistory + query;
            }
         
            return Program.ExecSqlNonQuery(query, Program.ConnectionString);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frm_Main_Load(object sender, EventArgs e)
        {

            loadInit();
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

            if (String.IsNullOrEmpty(dbName))
            {
                return;
            }

            this.sp_BackupTableAdapter.Fill(this.tempdbDataSet.SP_STT_BACKUP, dbName);

            if (bdsDevices.Find("name", "deviceOf" + dbName) < 0)//=-1 thi cho ngdung tao device
            {
                stateIsExistDevice(false);//false:chua co device
            }
            else
            {
                stateIsExistDevice(true);//true: co device roi
            }
            neHuongdan.Text =(string)bdsDevices.Find("name", "deviceOf" + dbName).ToString();

        }

        private void stateIsExistDevice(bool isExistDevice)
        {
            btnDevice.Enabled = !isExistDevice;
            bttCreateDevice.Enabled = !isExistDevice;

            btnBackup.Enabled = isExistDevice;
            bttBackup.Enabled = isExistDevice;

            if (bdsBackupset.Count == 0 && isExistDevice)
            {
                btnRestore.Enabled = true;
                bttRestore.Enabled = true;
            }
            else
            {
                btnRestore.Enabled = false;
                bttRestore.Enabled = false;

            }
        }

        private string formatDeviceName(string dbName)
        {
            return string.Format("deviceOf{0}", dbName);
        }

        private async void btnRestore_ItemClickAsync(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string dbName = tbDatabaseName.Text;

            if (bciRestoreWithTime.Checked)
            {
                DateTime thoiDiemStopAt = DateTime.Parse(dePickDate.DateTime.ToString("MM/dd/yyyy") + " " + tePickTime.Time.ToString("HH:mm:ss"));
                if (checkValidTimeRestore(thoiDiemStopAt))
                {
                    if (XtraMessageBox.Show($"Bạn chắc chắn muốn restore database [{dbName}] về thời điểm [{(thoiDiemStopAt)}]?",
                                                    "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                      
                        int resultExec = await RestoreWithTimeAsync(thoiDiemStopAt);
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
                    int resultExec = await Restore();
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
        private async Task<int> Restore()
        {
            string queryString = string.Format(Queries.RESTORE,
                tbDatabaseName.Text,
                formatDeviceName(tbDatabaseName.Text),
                tbBackupPosition.Text);
            int resultExec = 0;
            await Task.Run(() =>
            {
                resultExec = Program.ExecSqlNonQuery(queryString, Program.ConnectionString);
            });
            return resultExec;
        }

        private async Task<int> RestoreWithTimeAsync(DateTime timeStopAt)
        {

            string dbName = tbDatabaseName.Text;
            string deviceName = formatDeviceName(dbName);
            string position = tbBackupPosition.Text;
            string logFilePath = Program.DefaultPath + $"\\{dbName}.trn";

            string queryString = string.Format(Queries.RESTORE_WITH_TIME,
                                                        dbName, logFilePath, deviceName, position);

         

            int resultExec = 0;
            await Task.Run(() =>
            {
                resultExec = Program.ExecSqlNonQuery(queryString, Program.ConnectionString);
            });


            if (resultExec != 0)
            {
                queryString = string.Format(Queries.ERROR_RESTORE,dbName,deviceName,position);
                await Task.Run(() =>
                {
                    Program.ExecSqlNonQuery(queryString, Program.ConnectionString);
                });
                return resultExec;
            }

            queryString = string.Format(Queries.RESTORE_WITH_TIME_WITH_STOPAT, dbName, logFilePath, timeStopAt);
            await Task.Run(() =>
            {
                resultExec = Program.ExecSqlNonQuery(queryString, Program.ConnectionString);

            });
            
            if (resultExec != 0)
            {
                queryString = string.Format(Queries.ERROR_RESTORE, dbName, deviceName, position);
                await Task.Run(() =>
                {
                    Program.ExecSqlNonQuery(queryString, Program.ConnectionString);

                });
                return resultExec;
            }

            queryString = string.Format(Queries.SET_MULTI_USER,dbName);
            await Task.Run(() =>
            {
                resultExec = Program.ExecSqlNonQuery(queryString, Program.ConnectionString);

            });
            
            return 0;
        }

        private bool checkValidTimeRestore(DateTime thoiDiemStopAt)
        {
            
            DateTime ngayGioBackup = (DateTime)((DataRowView)bdsSTTBackup.Current)["backup_start_date"];
            if (thoiDiemStopAt > DateTime.Now)
            {
                XtraMessageBox.Show("Thời điểm muốn phục hồi phải trước thời điểm hiện tại",
                    "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            if ((dePickDate.DateTime.Date < ngayGioBackup.Date) ||//sau ngày
                (dePickDate.DateTime.Date == ngayGioBackup.Date &&(thoiDiemStopAt.TimeOfDay.Ticks < ngayGioBackup.TimeOfDay.Ticks)))// chung ngày, sau giờ
            {
                XtraMessageBox.Show("Thời điểm muốn phục hồi phải sau thời điểm bản sao lưu ",
                    "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnDevice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string deviceName = formatDeviceName(tbDatabaseName.Text);
            string physicalName = Program.DefaultPath + "\\" + deviceName + ".bak";

            string queryString = string.Format(Queries.CREATE_DEVICE, deviceName, physicalName);

            int resultExec = Program.ExecSqlNonQuery(queryString, Program.ConnectionString);

            if (resultExec == 0)
            {
                XtraMessageBox.Show("Tạo device thành công", "SUCCESS",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.backup_devicesTableAdapter.Fill(this.tempdbDataSet.backup_devices);
                int backupPosition = bdsdatabases.Position;
                neHuongdan.Visible = true;
                neHuongdan.Text = backupPosition.ToString();
                bdsdatabases.MoveFirst();
                bdsdatabases.Position = backupPosition;

                neHuongdan.Text += "/"+backupPosition.ToString();
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
                tePickTime.Time = DateTime.Now;
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
    }
}
