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
    public partial class InvoiceBuyer : DevComponents.DotNetBar.Metro.MetroForm
    {
        public InvoiceBuyer()
        {
            InitializeComponent();
        }

        private void InvoiceBuyer_Load(object sender, EventArgs e)
        {
            
            combo_supp.DataSource = TradingBLL.Muneeb.Scalars.ShowBuyerNameOrderNameShipmentNameForInvoice();
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
           
            String[] Get = combo_supp.Text.Split('|');
            this.reportInvoiceBuyerTableAdapter.Fill(this.invoiceBuyer1.ReportInvoiceBuyer,Convert.ToInt32(Get[0]));
            this.reportViewer1.RefreshReport();

           
        }
    }
}