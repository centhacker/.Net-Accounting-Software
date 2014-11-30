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
    public partial class InventoryTransactions : DevComponents.DotNetBar.Metro.MetroForm
    {
        public InventoryTransactions()
        {
            InitializeComponent();
        }

        private void InventoryTransactions_Load(object sender, EventArgs e)
        {
            com_prod.DataSource = TradingBLL.Muneeb.Scalars.ShowProductNames();
            this.reportInventoryTransactionsTableAdapter.Fill(this.inventoryTransactions1.ReportInventoryTransactions,null,dt_to.Value,dt_from.Value);
            this.reportViewer1.RefreshReport();
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            this.reportInventoryTransactionsTableAdapter.Fill(this.inventoryTransactions1.ReportInventoryTransactions, com_prod.Text, dt_to.Value, dt_from.Value);
            this.reportViewer1.RefreshReport();
        }
    }
}