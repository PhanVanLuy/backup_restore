using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Data.SqlClient;

namespace bk_restore
{
    static class Program
    {
        public static string ServerName = null;
        public static string UserName = null;
        public static string Password = null;
        public static string ConnectionString;

        public static SqlDataAdapter DataAdapter = null;
        public static string TempDatabaseName = "tempdb";
        public static string DefaultPath = AppDomain.CurrentDomain.BaseDirectory + "\\Devices";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Login());
        }
        public static bool Connect()
        {
            try
            {
                ConnectionString = $"Data Source={ServerName};" +
                                          $"Initial Catalog={TempDatabaseName};" +
                                          $"User ID={UserName};" +
                                          $"password={Password}";
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                }
                return true;
            }
            catch (Exception)
            {
                //ShowError(ex);
                return false;
            }
        }
        public static int ExecSqlNonQuery(string cmdText, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(cmdText, con))
                {
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandTimeout = 600;
                    try
                    {
                        command.ExecuteNonQuery();
                        return 0;
                    }
                    catch (SqlException ex)
                    {
                        DialogResult result = 
                            MessageBox.Show(ex.Message, "Lỗi phát sinh từ câu lệnh query SQL",  MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand, 
                            MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
                        return ex.State;
                    }
                }
            }
        }
    }
}
