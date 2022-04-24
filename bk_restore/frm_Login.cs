using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bk_restore
{
    public partial class frm_Login : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private Boolean isLoaded = false;
        public frm_Login()
        {
            InitializeComponent();
            btnConnect.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          

        }

        private async void cbbServer_SelectedIndexChangedAsync(object sender, EventArgs e)
        {
            if(isLoaded==false)
            {
                turnAllOn(false);
                string myServer = Environment.MachineName;
                DataTable servers=null;
                 pb_loading.Visible=true;
                await Task.Run(() =>
                {
                    servers = SqlDataSourceEnumerator.Instance.GetDataSources();
                });
                pb_loading.Visible = false;
                for (int i = 0; i < servers.Rows.Count; i++)
                {
                    if (myServer == servers.Rows[i]["ServerName"].ToString()) ///// used to get the servers in the local machine////
                    {
                        if ((servers.Rows[i]["InstanceName"] as string) != null)
                            cbbServer.Items.Add(servers.Rows[i]["ServerName"] + "\\" + servers.Rows[i]["InstanceName"]);
                        else
                            cbbServer.Items.Add(servers.Rows[i]["ServerName"].ToString());
                    }
                }
                isLoaded = true;
                turnAllOn(true);
            }
            //cbbServer.SelectedIndex = 0;
            //ko load đc server là nó out ra
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void turnAllOn(bool isTurn)
        {
            
            btnConnect.Enabled = isTurn;
            btnExit.Enabled = isTurn;
            tbPass.Enabled = isTurn;
            tbUser.Enabled = isTurn;        
        }

        private void login_Click(object sender, EventArgs e)
        {
            Program.ServerName = cbbServer.Text;
            Program.UserName = tbUser.Text;
            Program.Password = tbPass.Text;
            if (Program.Connect() == true)
            {
                frm_main frm_main = new frm_main();
                this.Hide();
                frm_main.Closed += (s, args) =>
                {
                    this.Show();
                };
                frm_main.Show();
            }
            else
            {
                XtraMessageBox.Show("Đăng nhập không thành công!", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
