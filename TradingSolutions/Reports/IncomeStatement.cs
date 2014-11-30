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
    public partial class IncomeStatement : DevComponents.DotNetBar.Metro.MetroForm
    {
        public IncomeStatement()
        {
            InitializeComponent();
        }

        private void IncomeStatement_Load(object sender, EventArgs e)
        {
            this.reportIncomeStatementTableAdapter.Fill(this.incomeStatement1.ReportIncomeStatement, TradingBLL.Muneeb.Accounts.TrialBalanceFromDate, TradingBLL.Muneeb.Accounts.TrialBalanceToDate);
            this.reportViewer1.RefreshReport();
            
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            
        }
    }
}