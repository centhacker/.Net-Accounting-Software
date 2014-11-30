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
    public partial class OwnerEquity : DevComponents.DotNetBar.Metro.MetroForm
    {
        public OwnerEquity()
        {
            InitializeComponent();
        }

        private void OwnerEquity_Load(object sender, EventArgs e)
        {

            this.reportOwnerEquityTableAdapter.Fill(this.ownerEquity1.ReportOwnerEquity, TradingBLL.Muneeb.Accounts.TrialBalanceFromDate, TradingBLL.Muneeb.Accounts.TrialBalanceToDate);
            this.reportViewer1.RefreshReport();
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}