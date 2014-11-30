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
    public partial class GeneralJournal : DevComponents.DotNetBar.Metro.MetroForm
    {
        public GeneralJournal()
        {
            InitializeComponent();
        }

        private void GeneralJournal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportGeneralJournal.ReportGeneralJournal' table. You can move, or remove it, as needed.
            this.reportGeneralJournalTableAdapter.Fill(this.reportGeneralJournal._ReportGeneralJournal, TradingBLL.Muneeb.Accounts.TrialBalanceFromDate, TradingBLL.Muneeb.Accounts.TrialBalanceToDate);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}