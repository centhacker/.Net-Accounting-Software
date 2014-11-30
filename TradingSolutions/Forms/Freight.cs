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
    public partial class Freight : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Freight()
        {
            InitializeComponent();
        }

        private void Freight_Load(object sender, EventArgs e)
        {
            this.grid_forwarder.TableElement.RowHeight = 40;
            lab_forwarder_req1.Visible = false;
            lab_forwarder_req2.Visible = false;
            lab_forwarder_req3.Visible = false;
            lab_forwarder_req4.Visible = false;

            txt_forwarder_log.Text = TradingBLL.Muneeb.Utility.LoggedIn;
            grid_forwarder.DataSource = TradingBLL.Muneeb.CRUD.ShowFreight();
        }

        private void btn_forwarder_create_Click_1(object sender, EventArgs e)
        {
            txt_forwarder_id.ReadOnly = false;
            txt_forwarder_name.ReadOnly = false;
            txt_forwarder_contact.ReadOnly = false;
            txt_forwarder_email.ReadOnly = false;
            txt_forwarder_company.ReadOnly = false;
            txt_forwarder_ref.ReadOnly = false;

            txt_forwarder_id.Clear();
            txt_forwarder_name.Clear();
            txt_forwarder_contact.Clear();
            txt_forwarder_email.Clear();
            txt_forwarder_company.Clear();
            txt_forwarder_ref.Clear();

           
        }

        private void btn_forwarder_clear_Click(object sender, EventArgs e)
        {
            txt_forwarder_id.Clear();
            txt_forwarder_name.Clear();
            txt_forwarder_contact.Clear();
            txt_forwarder_email.Clear();
            txt_forwarder_company.Clear();
            txt_forwarder_ref.Clear();
        }

        private void btn_forwarder_home_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_forwarder_save_Click(object sender, EventArgs e)
        {
            if (txt_forwarder_company .Text == null)
            {
                txt_forwarder_company.Text = "-";
            }
            if (txt_forwarder_contact .Text == null)
            {
                txt_forwarder_contact.Text = "-";
            }
            if (txt_forwarder_email.Text == null)
            {
                txt_forwarder_email.Text = "-";
            }
            if (txt_forwarder_name.Text == null)
            {
                txt_forwarder_name.Text = "-";
            }
            if (txt_forwarder_ref .Text == null)
            {
                txt_forwarder_ref.Text = "-";
            }
            if (txt_forwarder_name.Text == "" || txt_forwarder_contact.Text == "" || dt_forwarder_edate.Value == null )
            {
                
                MessageBox.Show("Enter data in the fields indicating *.");
                lab_forwarder_req1.Visible = true;
                lab_forwarder_req2.Visible = true;
                lab_forwarder_req3.Visible = true;
                lab_forwarder_req4.Visible = true;
            }

            else
            {
                try
                {
                    if (TradingBLL.Muneeb.CRUD.InsertFreight(txt_forwarder_name.Text, txt_forwarder_company.Text, txt_forwarder_ref.Text, txt_forwarder_email.Text, dt_forwarder_edate.Value, dt_forwarder_mdate.Value))
                    {
                        MessageBox.Show("Record Inserted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Record Was Not Inserted");
                    }
                    grid_forwarder.DataSource = TradingBLL.Muneeb.CRUD.ShowFreight();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
            }

            txt_forwarder_id.Clear();
            txt_forwarder_name.Clear();
            txt_forwarder_contact.Clear();
            txt_forwarder_email.Clear();
            txt_forwarder_company.Clear();
            txt_forwarder_ref.Clear();
        }

        private void btn_forwarder_update_Click(object sender, EventArgs e)
        {
            if (txt_forwarder_company.Text == null)
            {
                txt_forwarder_company.Text = "-";
            }
            if (txt_forwarder_contact.Text == null)
            {
                txt_forwarder_contact.Text = "-";
            }
            if (txt_forwarder_email.Text == null)
            {
                txt_forwarder_email.Text = "-";
            }
            if (txt_forwarder_name.Text == null)
            {
                txt_forwarder_name.Text = "-";
            }
            if (txt_forwarder_ref.Text == null)
            {
                txt_forwarder_ref.Text = "-";
            }
            if (MessageBox.Show("Press YES to delete the record Or No to Cancel", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Code To be done here
                try
                {
                    if (TradingBLL.Muneeb.CRUD.UpdateFreight(Convert.ToInt32(txt_forwarder_id.Text), txt_forwarder_name.Text, txt_forwarder_company.Text, txt_forwarder_ref.Text, txt_forwarder_email.Text, dt_forwarder_edate.Value, dt_forwarder_mdate.Value))
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
            grid_forwarder.DataSource = TradingBLL.Muneeb.CRUD.ShowFreight();

            txt_forwarder_id.Clear();
            txt_forwarder_name.Clear();
            txt_forwarder_contact.Clear();
            txt_forwarder_email.Clear();
            txt_forwarder_company.Clear();
            txt_forwarder_ref.Clear();
        }

        private void btn_forwarder_delete_Click(object sender, EventArgs e)
        {
            if (txt_forwarder_company.Text == null)
            {
                txt_forwarder_company.Text = "-";
            }
            if (txt_forwarder_contact.Text == null)
            {
                txt_forwarder_contact.Text = "-";
            }
            if (txt_forwarder_email.Text == null)
            {
                txt_forwarder_email.Text = "-";
            }
            if (txt_forwarder_name.Text == null)
            {
                txt_forwarder_name.Text = "-";
            }
            if (txt_forwarder_ref.Text == null)
            {
                txt_forwarder_ref.Text = "-";
            }
            
            if (MessageBox.Show("Press YES to delete the record Or No to Cancel", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (TradingBLL.Muneeb.CRUD.DeleteFreight(Convert.ToInt32(txt_forwarder_id.Text)))
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
            grid_forwarder.DataSource = TradingBLL.Muneeb.CRUD.ShowFreight();

            txt_forwarder_id.Clear();
            txt_forwarder_name.Clear();
            txt_forwarder_contact.Clear();
            txt_forwarder_email.Clear();
            txt_forwarder_company.Clear();
            txt_forwarder_ref.Clear();
        }

        private void grid_forwarder_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txt_forwarder_id.Text = grid_forwarder.SelectedRows[0].Cells[0].Value.ToString();
                txt_forwarder_name.Text = grid_forwarder.SelectedRows[0].Cells[1].Value.ToString();
                txt_forwarder_contact.Text = grid_forwarder.SelectedRows[0].Cells[2].Value.ToString();
                txt_forwarder_email.Text = grid_forwarder.SelectedRows[0].Cells[3].Value.ToString();
                txt_forwarder_company.Text = grid_forwarder.SelectedRows[0].Cells[4].Value.ToString();
                txt_forwarder_ref.Text = grid_forwarder.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {

                TradingBLL.Muneeb.CRUD.log.Error("Freight Form: " + ex);
            }
        }

        private void btn_forwarder_show_Click(object sender, EventArgs e)
        {
            grid_forwarder.DataSource = TradingBLL.Muneeb.CRUD.ShowFreight();
        }

    }
}