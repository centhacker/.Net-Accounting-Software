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
    public partial class Order : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Order()
        {
            InitializeComponent();
        }

        private void btn_order_home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_order_clear_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
           // txt_order_id.Clear();
          //  txt_order_buyer_name.Clear();
            txt_order_name.Clear();
            txt_order_total.Clear();
            txt_order_ref.Clear();
            //txt_order_log.Clear();
            txt_order_buyer_name.DataSource = TradingBLL.Muneeb.Scalars.ShowBuyerNames();
            this.Cursor = Cursors.Arrow;
        }

        private void Order_Load(object sender, EventArgs e)
        {
           // this.grid_order.TableElement.RowHeight = 40;
            this.Cursor = Cursors.WaitCursor;
            combox_inv_curr.DataSource = TradingBLL.Muneeb.Scalars.ShowCurrencyNames();
           // txt_order_id.ReadOnly = true;
           // txt_order_buyer_name.ReadOnly = true;
           
          //  txt_order_log.ReadOnly = true;
            lab_order_req1.Visible = false;
            lab_order_req2.Visible = false;
            lab_order_req3.Visible = false;
            lab_order_req4.Visible = false;
            lab_order_req5.Visible = false;
            lab_order_req6.Visible = false;
          //  lab_order_req7.Visible = false;
            grd_prods.AllowUserToDeleteRows = true;
            txt_order_buyer_name.DataSource = TradingBLL.Muneeb.Scalars.ShowBuyerNames();
            grid_order.DataSource = TradingBLL.Muneeb.CRUD.ShowOrders();
            combo_prod_names.DataSource = TradingBLL.Muneeb.Scalars.ShowProductNames();
           // txt_order_log.Text = TradingBLL.Muneeb.Utility.LoggedIn;
            this.Cursor = Cursors.Arrow;
        }

        private void btn_order_create_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
           // txt_order_id.ReadOnly = false;
           // txt_order_buyer_name.ReadOnly = false;
            txt_order_name.ReadOnly = false;
            txt_order_ref.ReadOnly = false;
           // txt_order_log.ReadOnly = false;

           // txt_order_id.Clear();
           // txt_order_buyer_name.Clear();
            txt_order_name.Clear();
            txt_order_ref.Clear();
           // txt_order_log.Clear();
            this.Cursor = Cursors.Arrow;
           
        }

        private void btn_order_save_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (txt_order_buyer_name.Text == null)
            {
                txt_order_buyer_name.Text = "";
            }
            if (txt_order_total.Text == null)
            {
                txt_order_total.Text = "0";
            }
            if (txt_cp .Text == null)
            {
                txt_cp.Text = "0";
            }
            if (txt_order_name.Text == null)
            {
                txt_order_name.Text = "-";
            }
            if (txt_order_ref .Text == null)
            {
                txt_order_ref.Text = "-";
            }
            if (txt_units .Text == null)
            {
                txt_units.Text = "0";
            }

            if (txt_order_buyer_name.Text == "" || txt_order_name.Text == "" || dt_order_date.Text == "" || dt_order_rdate.Text == "" || dt_order_shdate.Text == "" || dt_order_edate.Text == "" )
            {
                MessageBox.Show("Enter data in the fields indicating *.");
                lab_order_req1.Visible = true;
                lab_order_req2.Visible = true;
                lab_order_req3.Visible = true;
                lab_order_req4.Visible = true;
                lab_order_req5.Visible = true;
                lab_order_req6.Visible = true;
              //  lab_order_req7.Visible = true;
            }

            else
            {
                try
                {
                    if (TradingBLL.Muneeb.CRUD.InsertOrder(txt_order_buyer_name.Text, txt_order_name.Text, txt_order_total.Text, dt_order_date.Value, dt_order_rdate.Value, dt_order_shdate.Value, txt_order_ref.Text, dt_order_edate.Value, DateTime.Now))
                    {
                        int OrderID = TradingBLL.Muneeb.Scalars.ShowOrderID(txt_order_buyer_name.Text, txt_order_name.Text, txt_order_total.Text, txt_order_ref.Text, dt_order_date.Value, dt_order_rdate.Value, dt_order_shdate.Value);
                        for (int row = 0; row < grd_prods.RowCount; row++)
                        {
                            TradingBLL.Muneeb.CRUD.InsertOrderProducts(OrderID, grd_prods.Rows[row].Cells[0].Value.ToString(),
                                grd_prods.Rows[row].Cells[2].Value.ToString(),
                                grd_prods.Rows[row].Cells[3].Value.ToString(),
                               combox_inv_curr.Text, "", grd_prods.Rows[row].Cells[4].Value.ToString());
                        }
                        grid_order.DataSource = TradingBLL.Muneeb.CRUD.ShowOrders();
                        MessageBox.Show("Record Inserted Successfully");
                        grd_prods.Rows.Clear();
                        txt_cp.Clear();
                        txt_units.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Record Was Not Inserted");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
                
            }
            txt_order_total.Clear();
            txt_order_name.Clear();
            txt_order_ref.Clear();
            this.Cursor = Cursors.Arrow;
        }

        private void grp_order_1_Enter(object sender, EventArgs e)
        {
            
        }

        private void btn_order_delete_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (txt_order_buyer_name.Text == null)
            {
                txt_order_buyer_name.Text = "";
            }
            if (txt_order_total.Text == null)
            {
                txt_order_total.Text = "0";
            }
            if (txt_cp.Text == null)
            {
                txt_cp.Text = "0";
            }
            if (txt_order_name.Text == null)
            {
                txt_order_name.Text = "-";
            }
            if (txt_order_ref.Text == null)
            {
                txt_order_ref.Text = "-";
            }
            if (txt_units.Text == null)
            {
                txt_units.Text = "0";
            }
            
            if (MessageBox.Show("Press YES to delete the record Or No to Cancel", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try {
                if (TradingBLL.Muneeb.CRUD.DeleteOrder(txt_order_name.Text, txt_order_buyer_name.Text, txt_order_total.Text, dt_order_rdate.Value, dt_order_shdate.Value))
                {
                    grid_order.DataSource = TradingBLL.Muneeb.CRUD.ShowOrders();
                    MessageBox.Show("Record Successfully Deleted");
                }
                else
                {
                    MessageBox.Show("Record Was Not Deleted");
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
            }

            txt_order_name.Clear();
            txt_order_ref.Clear();
            this.Cursor = Cursors.Arrow;
        }

        private void grid_order_SelectionChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                
                for (int i = 0; i < txt_order_buyer_name.Items.Count; i++)
                {
                    if (txt_order_buyer_name.Items[i].ToString()== grid_order.SelectedRows[0].Cells[0].Value.ToString())
                    {
                        txt_order_buyer_name.Text = grid_order.SelectedRows[0].Cells[0].Value.ToString();
                    }
                }
                txt_order_total.Text = grid_order.SelectedRows[0].Cells[6].Value.ToString();
                txt_order_name.Text = grid_order.SelectedRows[0].Cells[1].Value.ToString();
                dt_order_date.Value = Convert.ToDateTime( grid_order.SelectedRows[0].Cells[2].Value);
                dt_order_rdate.Value =Convert.ToDateTime( grid_order.SelectedRows[0].Cells[3].Value);
                dt_order_shdate.Value =Convert.ToDateTime( grid_order.SelectedRows[0].Cells[4].Value);
                txt_order_ref.Text = grid_order.SelectedRows[0].Cells[5].Value.ToString();
              lbl_id.Text =  TradingBLL.Muneeb.Scalars.ShowOrderID(txt_order_buyer_name.Text,txt_order_name.Text,txt_order_total.Text,txt_order_ref.Text,dt_order_date.Value,dt_order_rdate.Value,dt_order_shdate.Value).ToString();
              grd_order_details.DataSource = null;
              grd_order_details.DataSource = TradingBLL.Muneeb.CRUD.ShowOrderDetails(lbl_id.Text);
            }
            catch (Exception ex)
            {
                TradingBLL.Muneeb.CRUD.log.Error("Order Form: "+ex);
                
            }
            this.Cursor = Cursors.Arrow;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
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
                    txt_order_total.Clear();
                    for (int row = 0; row < grd_prods.RowCount; row++)
                    {

                        GetTotal += Convert.ToDouble(grd_prods.Rows[row].Cells[4].Value);
                    }
                    txt_order_total.Text = GetTotal.ToString();
                    //  txt_inv_shiptotal.Text = 
                }
                catch (Exception ex)
                {


                    MessageBox.Show("Some Fields were blank: " + ex);
                }

                this.Cursor = Cursors.Arrow;
            }
        }

        private void grd_prods_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
                try
                {
                    Double GetTotal = 0;
                    txt_order_total.Clear();
                    for (int row = 0; row < grd_prods.RowCount; row++)
                    {

                        GetTotal += Convert.ToDouble(grd_prods.Rows[row].Cells[4].Value);
                    }
                    txt_units.Clear();
                    txt_order_total.Text = GetTotal.ToString();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
                this.Cursor = Cursors.Arrow;   
        }

        private void combo_prod_names_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            txt_cp.Text = TradingBLL.Muneeb.Scalars.ShowProductSalePrice(combo_prod_names.Text);
            this.Cursor = Cursors.Arrow;
        }

        private void btn_updateRecord_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (MessageBox.Show("Press YES to delete the record Or No to Cancel", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txt_order_buyer_name.Text == "" || txt_order_name.Text == "" || dt_order_date.Text == "" || dt_order_rdate.Text == "" || dt_order_shdate.Text == "" || dt_order_edate.Text == "")
                {
                    MessageBox.Show("Enter data in the fields indicating *.");
                    lab_order_req1.Visible = true;
                    lab_order_req2.Visible = true;
                    lab_order_req3.Visible = true;
                    lab_order_req4.Visible = true;
                    lab_order_req5.Visible = true;
                    lab_order_req6.Visible = true;
                    //  lab_order_req7.Visible = true;
                }

                else
                {
                    try
                    {

                        if (TradingBLL.Muneeb.CRUD.UpdateOrder(Convert.ToInt32(lbl_id.Text), txt_order_buyer_name.Text, txt_order_name.Text, txt_order_total.Text, dt_order_date.Value, dt_order_rdate.Value, dt_order_shdate.Value, txt_order_ref.Text, dt_order_edate.Value, DateTime.Now))
                        {

                            for (int row = 0; row < grd_prods.RowCount; row++)
                            {
                                TradingBLL.Muneeb.CRUD.InsertOrderProducts(Convert.ToInt32(lbl_id.Text), grd_prods.Rows[row].Cells[0].Value.ToString(),
                                    grd_prods.Rows[row].Cells[2].Value.ToString(),
                                    grd_prods.Rows[row].Cells[3].Value.ToString(),
                                   combox_inv_curr.Text, "", grd_prods.Rows[row].Cells[4].Value.ToString());
                            }
                            grid_order.DataSource = TradingBLL.Muneeb.CRUD.ShowOrders();
                            MessageBox.Show("Record Inserted Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Record Was Not Inserted");
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.ToString());
                    }


                }
            }
            txt_order_name.Clear();
            txt_order_ref.Clear();
            this.Cursor = Cursors.Arrow;
        }

        private void grd_prods_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            txt_order_total.Clear();
            float Total = 0;
            for (int row = 0; row < grd_prods.RowCount; row++)
            {
                Total += Convert.ToSingle( grd_prods.Rows[row].Cells[4].Value.ToString());
            }
            txt_order_total.Text = Total.ToString();
            this.Cursor = Cursors.Arrow;
        }
    }
}