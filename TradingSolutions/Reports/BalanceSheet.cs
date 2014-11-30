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
    public partial class BalanceSheet : DevComponents.DotNetBar.Metro.MetroForm
    {
        public BalanceSheet()
        {
            InitializeComponent();
        }

        private void BalanceSheet_Load(object sender, EventArgs e)
        {

            this.reportBalanceSheetTableAdapter.Fill(this.balanceSheet1.ReportBalanceSheet, TradingBLL.Muneeb.Accounts.TrialBalanceFromDate, TradingBLL.Muneeb.Accounts.TrialBalanceToDate);
            this.reportViewer1.RefreshReport();
          
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
        }
    }
}