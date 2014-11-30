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
    public partial class Payment_To_Order : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Payment_To_Order()
        {
            InitializeComponent();
        }

        private void Payment_To_Order_Load(object sender, EventArgs e)
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
                grid_invoices.DataSource = TradingBLL.Muneeb.Payments.ShowInvoicesBuyer();
                
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
                
                grd_orders.DataSource = TradingBLL.Muneeb.Payments.ShowOrderPayments(grid_invoices.SelectedRows[0].Cells[0].Value.ToString());
                txt_invoice_no.Text = grid_invoices.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch 
            {
                
                
            }
            this.Cursor = Cursors.Arrow;
        }

        private void grd_orders_SelectionChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                
                grd_order_details.DataSource = TradingBLL.Muneeb.Payments.ShowOrderDetailsPayments(grd_orders.SelectedRows[0].Cells[0].Value.ToString());
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

        private void btn_Relaod_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            grd_accounts.DataSource = null;
            grd_order_details.DataSource = null;
            grd_orders.DataSource = null;
            grid_invoices.DataSource = null;
            try
            {
                grd_accounts.DataSource = TradingBLL.Muneeb.CRUD.ShowBank();
                grid_invoices.DataSource = TradingBLL.Muneeb.Payments.ShowInvoicesBuyer();

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
                if (TradingBLL.Muneeb.Payments.PaymentOfShipmentBuyer(out Exception,txt_invoice_no.Text,txt_payment.Text,txt_bank_accno.Text,combox_paytype.Text,txt_payment.Text))
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
            grid_invoices.DataSource = TradingBLL.Muneeb.Payments.ShowInvoicesBuyer();
            this.Cursor = Cursors.Arrow;
        }
    }
}