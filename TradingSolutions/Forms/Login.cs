using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using System.Data.SqlClient;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace TradingSolutions
{
    public partial class Login : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            String GetException = String.Empty;
            if (TradingBLL.Muneeb.Utility.CheckUser(txt_username.Text,txt_pwd.Text,out GetException))
            {
                BackupDatabase();
               TradingBLL.Muneeb.Accounts.UpdateFiscalYearForLogin();
               TradingBLL.Muneeb.Utility.LoggedIn = txt_username.Text;
               txt_username.Text = TradingBLL.Muneeb.Utility.LoggedIn;
                Main_Page mp = new Main_Page ();
                mp.ShowDialog();
            }
            else
            {
                MessageBox.Show(GetException);
            }
            this.Cursor = Cursors.Arrow;
        }

        private void Login_Load(object sender, EventArgs e)
        {
          //  //TradingBLL.Muneeb.DB.TradingConnection.Open();
        }

        private void BackupDatabase() {
            try
            {
                //TradingBLL.Muneeb.DB.TradingConnection.Open();

                SqlCommand bk = new SqlCommand(@"backup database [" + Application.StartupPath + "\\Trading.mdf] To Disk = '" + "Automated" + "' with init,stats=10", TradingBLL.Muneeb.DB.TradingConnection);
                bk.ExecuteNonQuery();
               //TradingBLL.Muneeb.DB.TradingConnection.Open();
              //  MessageBox.Show("Back Up Created");
            }
            catch
            {
              //  MessageBox.Show("Cannot Create Backup");

            }
        }

    }
}