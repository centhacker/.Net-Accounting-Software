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
    public partial class EndingBalance : DevComponents.DotNetBar.Metro.MetroForm
    {
        public EndingBalance()
        {
            InitializeComponent();
        }

        private void EndingBalance_Load(object sender, EventArgs e)
        {
            this.reportEndingBalanceTableAdapter.Fill(this.endingBalance1.ReportEndingBalance,TradingBLL.Muneeb.Accounts.TrialBalanceFromDate,TradingBLL.Muneeb.Accounts.TrialBalanceToDate);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}