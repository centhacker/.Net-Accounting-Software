using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace TradingSolutions.Forms
{
    public partial class PackingListSupplier : DevComponents.DotNetBar.Metro.MetroForm
    {
        public PackingListSupplier()
        {
            InitializeComponent();
        }

        private void PackingListSupplier_Load(object sender, EventArgs e)
        {
            //this.grid_invoices.TableElement.RowHeight = 40;
            this.Cursor = Cursors.WaitCursor;
            grid_invoices.DataSource = TradingBLL.Muneeb.Payments.ShowInvoicesSupplier();
            this.Cursor = Cursors.Arrow;
        }

        private void grid_invoices_SelectionChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                txt_invoice_no.Text = grid_invoices.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch
            {


            }
            this.Cursor = Cursors.Arrow;
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (TradingBLL.Muneeb.CRUD.InsertPackingList(txt_invoice_no.Text, txt_packinglist.Text))
            {
                MessageBox.Show("Packing List Issued");
            }
            else
            {
                MessageBox.Show("Error!");
            }
            this.Cursor = Cursors.Arrow;
        }
    }
}