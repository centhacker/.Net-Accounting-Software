using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.SqlClient;


namespace TradingSolutions.Reports
{
    public partial class AccountTransactions : DevComponents.DotNetBar.Metro.MetroForm
    {
        public AccountTransactions()
        {
            InitializeComponent();
        }

        private void AccountTransactions_Load(object sender, EventArgs e)
        {
            grd_accounts.DataSource = TradingBLL.Muneeb.CRUD.ShowBank();
            this.reportViewer1.RefreshReport();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
              
                this.reportAccountTransactionTableAdapter.Fill(this.accountTransactions1.ReportAccountTransaction, Convert.ToInt32(grd_accounts.SelectedRows[0].Cells[0].Value.ToString()));
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }


       
 
        
        
    }
}