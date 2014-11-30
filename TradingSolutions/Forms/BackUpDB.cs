using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;

using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace TradingSolutions.Forms
{
    public partial class BackUpDB : DevComponents.DotNetBar.Metro.MetroForm
    {
        public BackUpDB()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                //SaveFileDialog sv = new SaveFileDialog();
                //sv.ShowDialog();
                ////TradingBLL.Muneeb.DB.TradingConnection.Open();
                //SqlCommand bk = new SqlCommand(@"backup database [" + Application.StartupPath + "\\Trading.mdf] To Disk = '" + sv.FileName + "' with init,stats=10", TradingBLL.Muneeb.DB.TradingConnection);
                //bk.ExecuteNonQuery();
                //TradingBLL.Muneeb.DB.TradingConnection.Close();
                //MessageBox.Show("Back Up Created");
            }
            catch
            {
                MessageBox.Show("Cannot Create Backup");

            }
            this.Cursor = Cursors.Arrow;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            openBakFile.ShowDialog();
            if (string.IsNullOrEmpty(openBakFile.FileName))
            {
                MessageBox.Show("Select file first!");
            }
            else
            {
                //txtBackupSql.Text = string.Empty;
                Restore(Application.StartupPath + "\\Trading.mdf", openBakFile.FileName);

            }


        }

        void Restore(string DatabaseFullPath, string backUpPath)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                //using (SqlConnection con = TradingBLL.Muneeb.DB.TradingConnection)
                //{
                //    con.Open();

                //    string UseMaster = "USE master";
                //    SqlCommand UseMasterCommand = new SqlCommand(UseMaster, con);
                //    UseMasterCommand.ExecuteNonQuery();

                //    string Alter1 = @"ALTER DATABASE [" + DatabaseFullPath + "] SET Single_User WITH Rollback Immediate";
                //    SqlCommand Alter1Cmd = new SqlCommand(Alter1, con);
                //    Alter1Cmd.ExecuteNonQuery();

                //    string Restore = @"RESTORE DATABASE [" + DatabaseFullPath + "] FROM DISK = N'" + backUpPath + @"' WITH  FILE = 1,  NOUNLOAD,  STATS = 10";
                //    SqlCommand RestoreCmd = new SqlCommand(Restore, con);
                //    RestoreCmd.ExecuteNonQuery();

                //    string Alter2 = @"ALTER DATABASE [" + DatabaseFullPath + "] SET Multi_User";
                //    SqlCommand Alter2Cmd = new SqlCommand(Alter2, con);
                //    Alter2Cmd.ExecuteNonQuery();
                //    MessageBox.Show("Database Restore Sucessfully");
                //}
            }

            catch (Exception ex)
            {
                MessageBox.Show("Database Restore Failed" + ex.Message);
            }


            this.Cursor = Cursors.Arrow;
        }

        private void BackUpDB_Load(object sender, EventArgs e)
        {

        }
    }
}