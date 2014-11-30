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
    public partial class RefundDuty : DevComponents.DotNetBar.Metro.MetroForm
    {
        public RefundDuty()
        {
            InitializeComponent();
        }

        private void RefundDuty_Load(object sender, EventArgs e)
        {
          //  this.grid_invoices.TableElement.RowHeight = 40;
            grid_invoices.DataSource = TradingBLL.Muneeb.Payments.ShowInvoicesBuyer();
            grd_accounts.DataSource = TradingBLL.Muneeb.CRUD.ShowBank();
        }

        private void grid_invoices_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txt_invoice_no.Text = grid_invoices.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch
            {
                
                
            }
        }

        private void grd_accounts_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txt_bank_accno.Text = grd_accounts.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch 
            {
                
                
            }
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {

            //TradingBLL.Muneeb.DB.TradingConnection.Open();
            //TradingBLL.Muneeb.DB.TradingConnection.Open();
            if (String.IsNullOrEmpty(txt_payment.Text)==false)
            {
                try
                {

                    float InvoiceTotal = 0, AccountTotal = 0, Exrate = 0;
                    InvoiceTotal = Convert.ToSingle(Convert.ToSingle(grid_invoices.SelectedRows[0].Cells[2].Value.ToString()) - Convert.ToSingle(txt_payment.Text));
                    AccountTotal = Convert.ToSingle(Convert.ToSingle(grd_accounts.SelectedRows[0].Cells[4].Value.ToString()) + Convert.ToSingle(txt_payment.Text));
                    Exrate = Convert.ToSingle(Convert.ToSingle(grid_invoices.SelectedRows[0].Cells[5].Value.ToString()) * InvoiceTotal);
                    if (TradingBLL.Muneeb.Accounts.RefundInvoice(Convert.ToInt32(txt_invoice_no.Text), InvoiceTotal, Convert.ToInt32(txt_bank_accno.Text), AccountTotal, "DEBIT", Exrate, Convert.ToSingle(txt_payment.Text)))
                    {
                        MessageBox.Show("Invoice Charges Refunded Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Data Not Entered");
                    }
                    grd_accounts.DataSource = null;
                    grid_invoices.DataSource = null;

                    grid_invoices.DataSource = TradingBLL.Muneeb.Payments.ShowInvoicesBuyer();
                    grd_accounts.DataSource = TradingBLL.Muneeb.CRUD.ShowBank();
                    //TradingBLL.Muneeb.DB.TradingConnection.Open();

                }
                catch (Exception ex)
                {
                   //TradingBLL.Muneeb.DB.TradingConnection.Open();
                    MessageBox.Show(ex.ToString());
                }
                
            }
            
        }
    }
}