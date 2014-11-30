using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevComponents.DotNetBar;


namespace TradingSolutions.Forms
{
    public partial class To_Inventory : DevComponents.DotNetBar.Metro.MetroForm
    {
        public To_Inventory()
        {
            InitializeComponent();
        }

        private void btn_inv_home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_inv_clear_Click(object sender, EventArgs e)
        {
            txt_inv_id.Clear();
        //    txt_inv_log.Clear();
            txt_inv_remarks.Clear();
            txt_inv_servcharg.Clear();
            txt_inv_shipname.Clear();
            txt_inv_shiptotal.Clear();
        
        }

        private void To_Inventory_Load(object sender, EventArgs e)
        {
           // this.grd_prods.TableElement.RowHeight = 40;
            txt_inv_servcharg.Text = "0";
          //  grid_inv.ReadOnly = true;
            combox_inv_suppname.DataSource = TradingBLL.Muneeb.Scalars.ShowSupplierNames();
            combox_inv_paytype.DataSource = TradingBLL.Muneeb.Scalars.ShowPaymentNames();
            combox_inv_frename.DataSource = TradingBLL.Muneeb.Scalars.ShowFreightNames();
            combox_inv_curr.DataSource = TradingBLL.Muneeb.Scalars.ShowCurrencyNames();
            combo_prod_names.DataSource = TradingBLL.Muneeb.Scalars.ShowProductNames();
            com_invoice_currency.DataSource = TradingBLL.Muneeb.Scalars.ShowCurrencyNames();

        }

        private void btn_inv_create_Click(object sender, EventArgs e)
        {
            txt_inv_id.ReadOnly = false;
        //    txt_inv_log.ReadOnly = false;
            txt_inv_remarks.ReadOnly = false;
            txt_inv_servcharg.ReadOnly = false;
            txt_inv_shipname.ReadOnly = false;
            txt_inv_shiptotal.ReadOnly = false;

            txt_inv_id.Clear();
          //  txt_inv_log.Clear();
            txt_inv_remarks.Clear();
            txt_inv_servcharg.Clear();
            txt_inv_shipname.Clear();
            txt_inv_shiptotal.Clear();
        }

        private void combo_prod_names_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_cp.Text = TradingBLL.Muneeb.Scalars.ShowProductCostPrice(combo_prod_names.Text);
          //  txt_units.Text = TradingBLL.Muneeb.Scalars.ShowProductSalePrice(combo_prod_names.Text);

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_cp.Text == null || txt_units.Text == null)
            {
                MessageBox.Show("Cannot Add Row, Some feilds were left blank");
            }
            else
            {
                try
                {
                    grd_prods.Rows.Add(1);
                    grd_prods.Rows[grd_prods.RowCount - 1].Cells[0].Value = combo_prod_names.Text;
                    grd_prods.Rows[grd_prods.RowCount - 1].Cells[1].Value = "INVENTORY FROM SUPPLIER";
                    grd_prods.Rows[grd_prods.RowCount - 1].Cells[2].Value = Convert.ToDouble(txt_cp.Text);                    
                    grd_prods.Rows[grd_prods.RowCount - 1].Cells[3].Value = Convert.ToDouble(txt_units.Text);
                    grd_prods.Rows[grd_prods.RowCount - 1].Cells[4].Value = Convert.ToDouble(txt_units.Text) * Convert.ToDouble(txt_cp.Text);

                    Double GetTotal = 0;
                    txt_inv_shiptotal.Clear();
                    for (int row = 0; row < grd_prods.RowCount; row++)
                    {

                        GetTotal += Convert.ToDouble(grd_prods.Rows[row].Cells[4].Value);
                    }
                    txt_inv_shiptotal.Text = GetTotal.ToString();

                  //  txt_inv_shiptotal.Text = 
                }
                catch (Exception ex)
                {


                    MessageBox.Show("Some Fields were blank: " + ex);
                }

              
                txt_units.Clear();
            }
           
        }

      

        private void btn_inv_save_Click(object sender, EventArgs e)
        {
            if (txt_cp .Text == null)
            {
                txt_cp.Text = "0";
            }
            if (txt_inv_remarks .Text == null)
            {
                txt_inv_remarks.Text = "-";
            }
            if (txt_inv_servcharg .Text == null)
            {
                txt_inv_servcharg.Text = "0";
            }
            if (txt_inv_shipname .Text == null)
            {
                txt_inv_shipname.Text = "0";
            }
            if (txt_inv_shiptotal .Text == null)
            {
                txt_inv_shiptotal.Text = "0";
            }
            if (txt_units .Text == null)
            {
                txt_units.Text = "0";
            }
            
            //TradingBLL.Muneeb.DB.TradingConnection.Open();
            //TradingBLL.Muneeb.DB.TradingConnection.Open();
            String GetException;
            int ShipmentId;
            try
            {
                if (TradingBLL.Muneeb.Shipment.InsertShipmentSupplierWithInvoice(out GetException, txt_inv_shipname.Text, combox_inv_suppname.Text, combox_inv_frename.Text, txt_inv_shiptotal.Text, DateTime.Now, DateTime.Now, txt_inv_servcharg.Text, combox_inv_curr.Text, txt_inv_remarks.Text, combox_inv_paytype.Text, com_invoice_currency.Text))
                {
                    ShipmentId = TradingBLL.Muneeb.Scalars.GetShipmentIdForInvoice(txt_inv_shipname.Text, combox_inv_suppname.Text, combox_inv_frename.Text, txt_inv_shiptotal.Text,  txt_inv_servcharg.Text, combox_inv_curr.Text, txt_inv_remarks.Text, combox_inv_paytype.Text);

                    for (int row = 0; row < grd_prods.RowCount; row++)
                    {
                        TradingBLL.Muneeb.Shipment.InsertProductSupplier(ShipmentId,
                            grd_prods.Rows[row].Cells[0].Value.ToString(),
                            grd_prods.Rows[row].Cells[2].Value.ToString(),
                            grd_prods.Rows[row].Cells[3].Value.ToString(),
                            combox_inv_curr.Text,
                            DateTime.Now, DateTime.Now);
                    }
                }
                MessageBox.Show("Shipment Record Successfully Entered and "+GetException);
                //TradingBLL.Muneeb.DB.TradingConnection.Open();
            }
            catch (Exception ex)
            {
               //TradingBLL.Muneeb.DB.TradingConnection.Open();
                MessageBox.Show("Data Was Not Entered: "+ex);
            }
           //TradingBLL.Muneeb.DB.TradingConnection.Open();

            txt_inv_id.Clear();
         //   txt_inv_log.Clear();
            txt_inv_remarks.Clear();
            txt_inv_servcharg.Clear();
            txt_inv_shipname.Clear();
            txt_inv_shiptotal.Clear();

            grd_prods.Rows.Clear();
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            txt_inv_id.Clear();
         //   txt_inv_log.Clear();
            txt_inv_remarks.Clear();
            txt_inv_servcharg.Clear();
            txt_inv_shipname.Clear();
            txt_inv_shiptotal.Clear();

            grd_prods.Rows.Clear();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            if (txt_cp.Text == null)
            {
                txt_cp.Text = "0";
            }
            if (txt_inv_remarks.Text == null)
            {
                txt_inv_remarks.Text = "-";
            }
            if (txt_inv_servcharg.Text == null)
            {
                txt_inv_servcharg.Text = "0";
            }
            if (txt_inv_shipname.Text == null)
            {
                txt_inv_shipname.Text = "0";
            }
            if (txt_inv_shiptotal.Text == null)
            {
                txt_inv_shiptotal.Text = "0";
            }
            if (txt_units.Text == null)
            {
                txt_units.Text = "0";
            }
            
            txt_inv_id.Clear();
         //   txt_inv_log.Clear();
            txt_inv_remarks.Clear();
            txt_inv_servcharg.Clear();
            txt_inv_shipname.Clear();
            txt_inv_shiptotal.Clear();

            grd_prods.Rows.Clear();
        }
    }
}