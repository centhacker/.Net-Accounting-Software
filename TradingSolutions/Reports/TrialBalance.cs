using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace TradingSolutions.Reports
{
    public partial class TrialBalance : DevComponents.DotNetBar.Metro.MetroForm
    {
        public TrialBalance()
        {
            InitializeComponent();
        }

        private void TrialBalance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trialBalance1.GenerateTrialBalance' table. You can move, or remove it, as needed.
            this.generateTrialBalanceTableAdapter.Fill(this.trialBalance1.GenerateTrialBalance, TradingBLL.Muneeb.Accounts.TrialBalanceFromDate, TradingBLL.Muneeb.Accounts.TrialBalanceToDate);
            // TODO: This line of code loads data into the 'reportGeneralJournal.ReportGeneralJournal' table. You can move, or remove it, as needed.         
         
            this.reportViewer1.RefreshReport();
            
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
           

        }
    }
}