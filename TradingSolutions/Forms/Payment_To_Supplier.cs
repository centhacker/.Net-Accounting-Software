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
    public partial class Payment_To_Supplier : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Payment_To_Supplier()
        {
            InitializeComponent();
        }

        private void Payment_To_Supplier_Load(object sender, EventArgs e)
        {
            this.grid_invoices.TableElement.RowHeight = 40;
            this.Cursor = Cursors.WaitCursor;
            try
            {
                String[] Get = new String[TradingBLL.Muneeb.Scalars.ShowPaymentNames().Count];
                for (int inC = 0; inC < Get.Length; inC++)
                {
                    Get[inC] = TradingBLL.Muneeb.Scalars.ShowPaymentNames()[inC];
                }
                combox_paytype.DataSource = Get;
                grd_accounts.DataSource = TradingBLL.Muneeb.CRUD.ShowBank();
                grid_invoices.DataSource = TradingBLL.Muneeb.Payments.ShowInvoicesSupplier();
            }
            catch 
            {
                
                
            }
            this.Cursor = Cursors.Arrow;
        }

        private void grid_invoices_SelectionChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                txt_invoice_no.Text = grid_invoices.SelectedRows[0].Cells[0].Value.ToString();
                grd_details.DataSource = TradingBLL.Muneeb.Payments.ShowInvoiceSupplierDEtails(grid_invoices.SelectedRows[0].Cells[0].Value.ToString());
            }
            catch 
            {
                
                
            }
            this.Cursor = Cursors.Arrow;
        }

        private void grd_accounts_SelectionChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                txt_bank_accno.Text = grd_accounts.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch 
            {
                
               
            }
            this.Cursor = Cursors.Arrow;
            
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            String Exception = String.Empty;
            try
            {
                if (TradingBLL.Muneeb.Payments.PaymentOfShipmentSupplier(out Exception, txt_invoice_no.Text, txt_payment.Text, txt_bank_accno.Text, combox_paytype.Text, txt_payment.Text))
                {
                    MessageBox.Show(Exception);
                }
                else
                {
                    MessageBox.Show("Payment to Invoice Was not Recorded");
                    MessageBox.Show(Exception);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show(Exception);
            }
            grid_invoices.DataSource = TradingBLL.Muneeb.Payments.ShowInvoicesSupplier();
            this.Cursor = Cursors.Arrow;
        }
    }
}