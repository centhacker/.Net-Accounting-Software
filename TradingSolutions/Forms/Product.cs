using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace TradingSolutions
{
    public partial class Product : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            this.grid_prod.TableElement.RowHeight = 40;
           
            lab_prod_req1.Visible = false;
            lab_prod_req2.Visible = false;
            lab_prod_req3.Visible = false;
            lab_prod_req4.Visible = false;
            lab_prod_req5.Visible = false;

            txt_prod_log.Text = TradingBLL.Muneeb.Utility.LoggedIn;
            grid_prod.DataSource = TradingBLL.Muneeb.CRUD.ShowProducts();
        }

        private void btn_prod_create_Click_1(object sender, EventArgs e)
        {
           

            txt_prod_id.Clear();
            txt_prod_name.Clear();
            txt_prod_cp.Clear();
            txt_prod_sp.Clear();
            txt_prod_category.Clear();
            txt_prod_desc.Clear();

           
        }

        private void btn_prod_clear_Click(object sender, EventArgs e)
        {
            txt_prod_id.Clear();
            txt_prod_name.Clear();
            txt_prod_cp.Clear();
            txt_prod_sp.Clear();
            txt_prod_category.Clear();
            txt_prod_desc.Clear();
        }

        private void btn_prod_home_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_prod_save_Click(object sender, EventArgs e)
        {
            if (txt_prod_category .Text == null)
            {
                txt_prod_category.Text = "-";
            }
            if (txt_prod_cp .Text == null)
            {
                txt_prod_cp.Text = "0";
            }
            if (txt_prod_desc.Text == null)
            {
                txt_prod_desc.Text = "-";
            }
            if (txt_prod_log .Text == null)
            {
                txt_prod_log.Text = "-";
            }
            if (txt_prod_name .Text == null)
            {
                txt_prod_name.Text = "-";
            }
            if (txt_prod_sp .Text == null)
            {
                txt_prod_sp.Text = "0";
            }
            
            try
            {
                if (txt_prod_name.Text == "" || txt_prod_cp.Text == "" || txt_prod_sp.Text == "" || dt_prod_edate.Value == null)
                {
                    MessageBox.Show("Enter data in the fields indicating *.");
                    lab_prod_req1.Visible = true;
                    lab_prod_req2.Visible = true;
                    lab_prod_req3.Visible = true;
                    lab_prod_req4.Visible = true;
                    lab_prod_req5.Visible = true;
                }

                else
                {
                    if (TradingBLL.Muneeb.CRUD.InsertProduct(txt_prod_name.Text, Convert.ToSingle(txt_prod_cp.Text), Convert.ToSingle(txt_prod_sp.Text), txt_prod_desc.Text, txt_prod_category.Text, dt_prod_edate.Value, dt_prod_mdate.Value))
                    {

                        MessageBox.Show("Record Inserted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Record Was Not Inserted");
                    }
                    grid_prod.DataSource = TradingBLL.Muneeb.CRUD.ShowProducts();


                }
                txt_prod_id.Clear();
                txt_prod_name.Clear();
                txt_prod_cp.Clear();
                txt_prod_sp.Clear();
                txt_prod_category.Clear();
                txt_prod_desc.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btn_prod_update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Press YES to delete the record Or No to Cancel", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (TradingBLL.Muneeb.CRUD.UpdateProduct(Convert.ToInt32(txt_prod_id.Text), txt_prod_name.Text, Convert.ToSingle(txt_prod_cp.Text), Convert.ToSingle(txt_prod_sp.Text), txt_prod_desc.Text, txt_prod_category.Text, dt_prod_edate.Value, dt_prod_mdate.Value))
                {

                    MessageBox.Show("Record Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Record Was Not Updated");
                }
            }
            grid_prod.DataSource = TradingBLL.Muneeb.CRUD.ShowProducts();

            txt_prod_id.Clear();
            txt_prod_name.Clear();
            txt_prod_cp.Clear();
            txt_prod_sp.Clear();
            txt_prod_category.Clear();
            txt_prod_desc.Clear();
        }

        private void btn_prod_delete_Click(object sender, EventArgs e)
        {
            if (txt_prod_category.Text == null)
            {
                txt_prod_category.Text = "-";
            }
            if (txt_prod_cp.Text == null)
            {
                txt_prod_cp.Text = "0";
            }
            if (txt_prod_desc.Text == null)
            {
                txt_prod_desc.Text = "-";
            }
            if (txt_prod_log.Text == null)
            {
                txt_prod_log.Text = "-";
            }
            if (txt_prod_name.Text == null)
            {
                txt_prod_name.Text = "-";
            }
            if (txt_prod_sp.Text == null)
            {
                txt_prod_sp.Text = "0";
            }
            
            if (MessageBox.Show("Press YES to delete the record Or No to Cancel", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try {
                if (TradingBLL.Muneeb.CRUD.DeleteProduct(Convert.ToInt32(txt_prod_id.Text)))
                {

                    MessageBox.Show("Record Deleted Successfully");
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
            grid_prod.DataSource = TradingBLL.Muneeb.CRUD.ShowProducts();

            txt_prod_id.Clear();
            txt_prod_name.Clear();
            txt_prod_cp.Clear();
            txt_prod_sp.Clear();
            txt_prod_category.Clear();
            txt_prod_desc.Clear();
        }

        private void btn_prod_show_Click(object sender, EventArgs e)
        {
            grid_prod.DataSource = TradingBLL.Muneeb.CRUD.ShowProducts();
        }

        private void grid_prod_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txt_prod_id.Text = grid_prod.SelectedRows[0].Cells[0].Value.ToString();
                txt_prod_name.Text = grid_prod.SelectedRows[0].Cells[1].Value.ToString();
                txt_prod_cp.Text = grid_prod.SelectedRows[0].Cells[2].Value.ToString();
                txt_prod_sp.Text = grid_prod.SelectedRows[0].Cells[3].Value.ToString();
                txt_prod_category.Text = grid_prod.SelectedRows[0].Cells[4].Value.ToString();
                txt_prod_desc.Text = grid_prod.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {

                TradingBLL.Muneeb.CRUD.log.Error("Product Form: " + ex);
            }
        }

    }
}