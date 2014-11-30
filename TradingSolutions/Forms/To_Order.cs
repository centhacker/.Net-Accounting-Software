using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.SqlClient;

namespace TradingSolutions.Forms
{
    public partial class To_Order : DevComponents.DotNetBar.Metro.MetroForm
    {
        public To_Order()
        {
            InitializeComponent();
        }

        private void btn_ord_home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ord_clear_Click(object sender, EventArgs e)
        {
            txt_ord_id.Clear();
            txt_ord_log.Clear();
            txt_ord_remarks.Clear();
            txt_ord_servcharg.Clear();
            txt_ord_shipname.Clear();
            txt_ord_shiptotal.Clear();
        }

        private void To_Order_Load(object sender, EventArgs e)
        {
            this.grd_order_details.TableElement.RowHeight = 40;
            txt_ord_servcharg.Text = "0";
          
            com_invoice_currency.DataSource = TradingBLL.Muneeb.Scalars.ShowCurrencyNames();
            combox_ord_curr.DataSource = TradingBLL.Muneeb.Scalars.ShowCurrencyNames();
            combox_ord_paytype.DataSource = TradingBLL.Muneeb.Scalars.ShowPaymentNames();
            grd_orders.DataSource = TradingBLL.Muneeb.Scalars.ShowBuyerNamesWithOrderNames();
          //  grid_ord.ReadOnly = true;
        }

        private void btn_ord_create_Click(object sender, EventArgs e)
        {
           

            txt_ord_id.Clear();
            txt_ord_log.Clear();
            txt_ord_remarks.Clear();
            txt_ord_servcharg.Clear();
            txt_ord_shipname.Clear();
            txt_ord_shiptotal.Clear();
        }

        private void grp_ord_1_Enter(object sender, EventArgs e)
        {

        }

        private void grd_orders_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                lbl_orderID.Text = TradingBLL.Muneeb.Scalars.ShowOrderID(grd_orders.SelectedRows[0].Cells[0].Value.ToString(),
                grd_orders.SelectedRows[0].Cells[1].Value.ToString(),
                grd_orders.SelectedRows[0].Cells[2].Value.ToString(),
            grd_orders.SelectedRows[0].Cells[3].Value.ToString(), DateTime.Now, DateTime.Now, DateTime.Now).ToString();
                grd_order_details.DataSource = null;
                grd_order_details.DataSource = TradingBLL.Muneeb.CRUD.ShowOrderDetails(lbl_orderID.Text);
            
            }
            catch (Exception)
            {
                //Nothing
                
            }

            try
            {
                txt_ord_shiptotal.Clear();
                float Total = 0;
                for (int row = 0; row < grd_order_details.RowCount; row++)
                {
                    Total += Convert.ToSingle(grd_order_details.Rows[row].Cells[5].Value.ToString());
                }
                txt_ord_shiptotal.Text = Total.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            
        }

        private void btn_ord_save_Click(object sender, EventArgs e)
        {
            if (txt_ord_remarks .Text == null)
            {
                txt_ord_remarks.Text = "-";
            }
            if (txt_ord_servcharg .Text == null)
            {
                txt_ord_servcharg.Text = "0";
            }
            if (txt_ord_shipname .Text == null)
            {
                txt_ord_shipname.Text = "-";
            }
            if (txt_ord_shiptotal .Text == null)
            {
                txt_ord_shiptotal.Text = "0";
            }
            try
            {
                bool CheckQuantity = false;
                for (int i = 0; i < grd_order_details.RowCount; i++)
                {
                    CheckQuantity = false;
                    CheckQuantity = TradingBLL.Muneeb.Shipment.CheckProductInInventory(grd_order_details.Rows[i].Cells[0].Value.ToString(),
                        grd_order_details.Rows[i].Cells[2].Value.ToString());
                    if (!(CheckQuantity))
                    {

                        MessageBox.Show("Inventory for Product: " + grd_order_details.Rows[i].Cells[0].Value.ToString() + " has not enough units to make this transaction");
                        break;
                    }
                }
                if (CheckQuantity)
                {
                    String ShipmentID = String.Empty;
                    if (TradingBLL.Muneeb.Shipment.InsertShipmentOrderWithInvoice(txt_ord_shipname.Text, txt_ord_remarks.Text, grd_orders.SelectedRows[0].Cells[0].Value.ToString(),
                        combox_ord_paytype.Text, txt_ord_shiptotal.Text, dt_ord_edate.Value, dt_ord_edate.Value, grd_orders.SelectedRows[0].Cells[1].Value.ToString(), txt_ord_servcharg.Text, combox_ord_curr.Text
                        , lbl_orderID.Text, com_invoice_currency.Text))
                    {
                        ShipmentID = TradingBLL.Muneeb.Scalars.ShowShipmentOrdersId(txt_ord_shipname.Text, lbl_orderID.Text, grd_orders.SelectedRows[0].Cells[1].Value.ToString()
                            , txt_ord_shiptotal.Text, txt_ord_servcharg.Text, combox_ord_paytype.Text, combox_ord_curr.Text).ToString();
                        for (int row = 0; row < grd_order_details.RowCount; row++)
                        {
                            TradingBLL.Muneeb.Shipment.InsertOrderInventory(ShipmentID, grd_order_details.Rows[row].Cells[0].Value.ToString(),
                                combox_ord_curr.Text, grd_order_details.Rows[row].Cells[2].Value.ToString(), grd_order_details.Rows[row].Cells[1].Value.ToString(),
                                dt_ord_edate.Value, dt_ord_edate.Value);
                        }
                        MessageBox.Show("Shipment Record Successfully Entered and Invoice has been Generated");
                    }
                }
                else
                {
                    MessageBox.Show("Transaction was not completed!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            txt_ord_id.Clear();
            txt_ord_log.Clear();
            txt_ord_remarks.Clear();
            txt_ord_servcharg.Clear();
            txt_ord_shipname.Clear();
            txt_ord_shiptotal.Clear();
            grd_orders.DataSource = null;
            grd_orders.DataSource = TradingBLL.Muneeb.Scalars.ShowBuyerNamesWithOrderNames();
         //   grd_order_details.Rows.Clear();
        }

        private void grd_order_details_DataSourceChanged(object sender, EventArgs e)
        {
            try
            {
                txt_ord_shiptotal.Clear();
                float Total = 0;
                for (int row = 0; row < grd_order_details.RowCount; row++)
                {
                    Total += Convert.ToSingle( grd_order_details.Rows[row].Cells[5].Value.ToString());
                }
                txt_ord_shiptotal.Text = Total.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void grd_order_details_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txt_ord_shiptotal.Clear();
                float Total = 0;
                for (int row = 0; row < grd_order_details.RowCount; row++)
                {
                    Total += Convert.ToSingle(grd_order_details.Rows[row].Cells[5].Value.ToString());
                }
                txt_ord_shiptotal.Text = Total.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}