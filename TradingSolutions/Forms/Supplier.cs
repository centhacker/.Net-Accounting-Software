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
    public partial class Supplier : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            this.grid_supp.TableElement.RowHeight = 40;
            lab_supp_req1.Visible = false;
            lab_supp_req2.Visible = false;
            lab_supp_req3.Visible = false;
            lab_supp_req4.Visible = false;

            txt_supp_log.Text = TradingBLL.Muneeb.Utility.LoggedIn;
            grid_supp.DataSource = TradingBLL.Muneeb.CRUD.ShowSupplier();
        }
        
        private void btn_supp_clear_Click(object sender, EventArgs e)
        {
            txt_supp_id.Clear();
            txt_supp_name.Clear();
            txt_supp_contact.Clear();
            txt_supp_email.Clear();
            txt_supp_company.Clear();
            txt_supp_remarks.Clear();
        }


        private void btn_supp_home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_supp_create_Click(object sender, EventArgs e)
        {
            txt_supp_id.ReadOnly = false;
            txt_supp_name.ReadOnly = false;
            txt_supp_contact.ReadOnly = false;
            txt_supp_email.ReadOnly = false;
            txt_supp_company.ReadOnly = false;
            txt_supp_remarks.ReadOnly = false;

            txt_supp_id.Clear();
            txt_supp_name.Clear();
            txt_supp_contact.Clear();
            txt_supp_email.Clear();
            txt_supp_company.Clear();
            txt_supp_remarks.Clear();

           
        }

        private void btn_supp_save_Click(object sender, EventArgs e)
        {
            if (txt_supp_company .Text == null)
            {
                txt_supp_company.Text = "-";
            }
            if (txt_supp_contact .Text == null)
            {
                txt_supp_contact.Text = "-";
            }
            if (txt_supp_email .Text == null)
            {
                txt_supp_email.Text = "-";
            }
            if (txt_supp_remarks .Text == null)
            {
                txt_supp_remarks.Text = "-";
            }
            if (txt_supp_name .Text == null)
            {
                txt_supp_name.Text = "-";
            }
            

            
            
            if (txt_supp_name.Text == "" || txt_supp_contact.Text == "" || dt_supp_edate.Value == null)
            {


                MessageBox.Show("Enter data in the fields indicating *.");
                lab_supp_req1.Visible = true;
                lab_supp_req2.Visible = true;
                lab_supp_req3.Visible = true;
                lab_supp_req4.Visible = true;
            
            }

            else
            {
                try
                {
                    if (TradingBLL.Muneeb.CRUD.InsertSupplier(txt_supp_name.Text, txt_supp_contact.Text, txt_supp_email.Text, txt_supp_company.Text, txt_supp_remarks.Text, dt_supp_edate.Value, dt_supp_mdate.Value))
                    {
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
                grid_supp.DataSource = TradingBLL.Muneeb.CRUD.ShowSupplier();
                
            }

            txt_supp_id.Clear();
            txt_supp_name.Clear();
            txt_supp_contact.Clear();
            txt_supp_email.Clear();
            txt_supp_company.Clear();
            txt_supp_remarks.Clear();
        }

        private void btn_supp_update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Press YES to delete the record Or No to Cancel", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try {

                if (TradingBLL.Muneeb.CRUD.UpdateSupplier(Convert.ToInt32(txt_supp_id.Text), txt_supp_name.Text, txt_supp_contact.Text, txt_supp_email.Text, txt_supp_company.Text, txt_supp_remarks.Text, dt_supp_edate.Value, dt_supp_mdate.Value))
                {

                    MessageBox.Show("Record Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Record Was Not Updated");
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
            }
            grid_supp.DataSource = TradingBLL.Muneeb.CRUD.ShowSupplier();

            txt_supp_id.Clear();
            txt_supp_name.Clear();
            txt_supp_contact.Clear();
            txt_supp_email.Clear();
            txt_supp_company.Clear();
            txt_supp_remarks.Clear();
        }

        private void btn_supp_delete_Click(object sender, EventArgs e)
        {
            if (txt_supp_company.Text == null)
            {
                txt_supp_company.Text = "-";
            }
            if (txt_supp_contact.Text == null)
            {
                txt_supp_contact.Text = "-";
            }
            if (txt_supp_email.Text == null)
            {
                txt_supp_email.Text = "-";
            }
            if (txt_supp_remarks.Text == null)
            {
                txt_supp_remarks.Text = "-";
            }
            if (txt_supp_name.Text == null)
            {
                txt_supp_name.Text = "-";
            }


            if (MessageBox.Show("Press YES to delete the record Or No to Cancel", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try {
                if (TradingBLL.Muneeb.CRUD.DeleteSupplier(Convert.ToInt32(txt_supp_id.Text)))
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
            grid_supp.DataSource = TradingBLL.Muneeb.CRUD.ShowSupplier();

            txt_supp_id.Clear();
            txt_supp_name.Clear();
            txt_supp_contact.Clear();
            txt_supp_email.Clear();
            txt_supp_company.Clear();
            txt_supp_remarks.Clear();
        }

        private void btn_supp_show_Click(object sender, EventArgs e)
        {
            grid_supp.DataSource = TradingBLL.Muneeb.CRUD.ShowSupplier();
        }

        private void grid_supp_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txt_supp_id.Text = grid_supp.SelectedRows[0].Cells[0].Value.ToString();
                txt_supp_name.Text = grid_supp.SelectedRows[0].Cells[1].Value.ToString();
                txt_supp_contact.Text = grid_supp.SelectedRows[0].Cells[2].Value.ToString();
                txt_supp_email.Text = grid_supp.SelectedRows[0].Cells[3].Value.ToString();
                txt_supp_company.Text = grid_supp.SelectedRows[0].Cells[4].Value.ToString();
                txt_supp_remarks.Text = grid_supp.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {

                TradingBLL.Muneeb.CRUD.log.Error("Supplier Form: " + ex);
            }
        }

    }
}