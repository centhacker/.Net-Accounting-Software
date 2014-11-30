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
    public partial class InvoiceSupplier : DevComponents.DotNetBar.Metro.MetroForm
    {
        public InvoiceSupplier()
        {
            InitializeComponent();
        }

        private void InvoiceSupplier_Load(object sender, EventArgs e)
        {
            combo_supp.DataSource = TradingBLL.Muneeb.Scalars.ShowSupplierNameWithShipmentName();


            this.reportViewer1.RefreshReport();
        }

      

        private void btn_filter_Click(object sender, EventArgs e)
        {
           
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void OwnerEquity_Load(object sender, EventArgs e)
        {

        }

        private void btn_filter_Click_1(object sender, EventArgs e)
        {

            String[] GetParameters = combo_supp.Text.Split('|');
            this.reportInvoiceSupplierTableAdapter.Fill(this.invoiceSupplier1.ReportInvoiceSupplier, Convert.ToInt32(GetParameters[0]), GetParameters[1], GetParameters[2]);
            this.reportViewer1.RefreshReport();
        }
    }
}