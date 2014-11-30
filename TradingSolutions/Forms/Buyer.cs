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
    public partial class Buyer : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Buyer()
        {
            InitializeComponent();
        }

        private void Buyer_Load(object sender, EventArgs e)
        {
            this.grid_buyer.TableElement.RowHeight = 40;
            this.Cursor = Cursors.WaitCursor;
            lab_buyer_req1.Visible = false;
            lab_buyer_req2.Visible = false;
            lab_buyer_req3.Visible = false;
            lab_buyer_req4.Visible = false;
            lab_buyer_req5.Visible = false;
            
            grid_buyer.DataSource = TradingBLL.Muneeb.CRUD.ShowBuyer();
            
            txt_buyer_log.Text = TradingBLL.Muneeb.Utility.LoggedIn;
            this.Cursor = Cursors.Arrow;
        }

        private void btn_buyer_create_Click_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            txt_buyer_id.ReadOnly = false;
            txt_buyer_name.ReadOnly = false;
            txt_buyer_contact.ReadOnly = false;
            txt_buyer_email.ReadOnly = false;
            txt_buyer_company.ReadOnly = false;
            txt_buyer_remarks.ReadOnly = false;
            txt_buyer_acc.ReadOnly = false;

            txt_buyer_id.Clear();
            txt_buyer_name.Clear();
            txt_buyer_contact.Clear();
            txt_buyer_email.Clear();
            txt_buyer_company.Clear();
            txt_buyer_remarks.Clear();
            txt_buyer_acc.Clear();

            this.Cursor = Cursors.Arrow;

           
        }

        private void btn_buyer_clear_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            txt_buyer_id.Clear();
            txt_buyer_name.Clear();
            txt_buyer_contact.Clear();
            txt_buyer_email.Clear();
            txt_buyer_company.Clear();
            txt_buyer_remarks.Clear();
            txt_buyer_acc.Clear();
            this.Cursor = Cursors.Arrow;
        }

        private void btn_buyer_home_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buyer_save_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (txt_buyer_acc .Text == null)
            {
                txt_buyer_acc.Text = "-";
            }
            if (txt_buyer_company.Text  == null)
            {
                txt_buyer_company.Text  = "-";
            }
            if (txt_buyer_contact.Text  == null)
            {
                txt_buyer_contact.Text  = "-";
            }
            if (txt_buyer_email.Text  == null)
            {
                txt_buyer_email.Text  = "-";
            }
            if (txt_buyer_log.Text == null )
            {
                txt_buyer_log.Text = "-";
            }
            if (txt_buyer_name .Text == null)
            {
                txt_buyer_name.Text = "-";
            }
            if (txt_buyer_remarks .Text == null)
            {
                txt_buyer_remarks.Text = "-";
            }

            if (txt_buyer_name.Text == "" || txt_buyer_contact.Text == "" || txt_buyer_acc.Text == "" || dt_buyer_edate.Value == null )
            {
               
                MessageBox.Show("Enter data in the fields indicating *.");
                lab_buyer_req1.Visible = true;
                lab_buyer_req2.Visible = true;
                lab_buyer_req3.Visible = true;
                lab_buyer_req4.Visible = true;
                lab_buyer_req5.Visible = true;
            }

            else
            {
                try
                {
                    if (TradingBLL.Muneeb.CRUD.InsertBuyer(txt_buyer_name.Text, txt_buyer_contact.Text, txt_buyer_email.Text, txt_buyer_acc.Text, txt_buyer_company.Text, txt_buyer_remarks.Text, dt_buyer_edate.Value, dt_buyer_mdate.Value))
                    {
                        MessageBox.Show("Record Inserted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Record Was Not Inserted");
                    }
                    grid_buyer.DataSource = TradingBLL.Muneeb.CRUD.ShowBuyer();

                    txt_buyer_id.Clear();
                    txt_buyer_name.Clear();
                    txt_buyer_contact.Clear();
                    txt_buyer_email.Clear();
                    txt_buyer_company.Clear();
                    txt_buyer_remarks.Clear();
                    txt_buyer_acc.Clear();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

               
            }
            this.Cursor = Cursors.Arrow;
        }

        private void grid_buyer_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                txt_buyer_id.Text = grid_buyer.SelectedRows[0].Cells[0].Value.ToString();
                txt_buyer_name.Text = grid_buyer.SelectedRows[0].Cells[1].Value.ToString();
                txt_buyer_contact.Text = grid_buyer.SelectedRows[0].Cells[2].Value.ToString();
                txt_buyer_email.Text = grid_buyer.SelectedRows[0].Cells[3].Value.ToString();
                txt_buyer_company.Text = grid_buyer.SelectedRows[0].Cells[4].Value.ToString();
                txt_buyer_remarks.Text = grid_buyer.SelectedRows[0].Cells[5].Value.ToString();
                txt_buyer_acc.Text = grid_buyer.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {

                TradingBLL.Muneeb.CRUD.log.Error("Buyer Form: " + ex);
            }
            this.Cursor = Cursors.Arrow;
        }

        private void btn_buyer_update_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (TradingBLL.Muneeb.CRUD.UpdateBuyer(Convert.ToInt32(txt_buyer_id.Text), txt_buyer_name.Text, txt_buyer_contact.Text, txt_buyer_email.Text, txt_buyer_acc.Text, txt_buyer_company.Text, txt_buyer_remarks.Text, dt_buyer_edate.Value, dt_buyer_mdate.Value))
            {
                MessageBox.Show("Record Updated Successfully");
            }
            else
            {
                MessageBox.Show("Record Was Not Updated");
            }
            grid_buyer.DataSource = TradingBLL.Muneeb.CRUD.ShowBuyer();
            this.Cursor = Cursors.Arrow;
        }

        private void btn_buyer_delete_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (txt_buyer_acc.Text == null)
            {
                txt_buyer_acc.Text = "-";
            }
            if (txt_buyer_company.Text == null)
            {
                txt_buyer_company.Text = "-";
            }
            if (txt_buyer_contact.Text == null)
            {
                txt_buyer_contact.Text = "-";
            }
            if (txt_buyer_email.Text == null)
            {
                txt_buyer_email.Text = "-";
            }
            if (txt_buyer_log.Text == null)
            {
                txt_buyer_log.Text = "-";
            }
            if (txt_buyer_name.Text == null)
            {
                txt_buyer_name.Text = "-";
            }
            if (txt_buyer_remarks.Text == null)
            {
                txt_buyer_remarks.Text = "-";
            }
            
            if (MessageBox.Show("Press YES to delete the record Or No to Cancel", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (TradingBLL.Muneeb.CRUD.DeleteBuyer(Convert.ToInt32(txt_buyer_id.Text)))
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
            grid_buyer.DataSource = TradingBLL.Muneeb.CRUD.ShowBuyer();

            txt_buyer_id.Clear();
            txt_buyer_name.Clear();
            txt_buyer_contact.Clear();
            txt_buyer_email.Clear();
            txt_buyer_company.Clear();
            txt_buyer_remarks.Clear();
            txt_buyer_acc.Clear();
            this.Cursor = Cursors.Arrow;
        }

        private void btn_buyer_show_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            grid_buyer.DataSource = TradingBLL.Muneeb.CRUD.ShowBuyer();
            this.Cursor = Cursors.Arrow;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (txt_buyer_acc.Text == null)
            {
                txt_buyer_acc.Text = "-";
            }
            if (txt_buyer_company.Text == null)
            {
                txt_buyer_company.Text = "-";
            }
            if (txt_buyer_contact.Text == null)
            {
                txt_buyer_contact.Text = "-";
            }
            if (txt_buyer_email.Text == null)
            {
                txt_buyer_email.Text = "-";
            }
            if (txt_buyer_log.Text == null)
            {
                txt_buyer_log.Text = "-";
            }
            if (txt_buyer_name.Text == null)
            {
                txt_buyer_name.Text = "-";
            }
            if (txt_buyer_remarks.Text == null)
            {
                txt_buyer_remarks.Text = "-";
            }

            if (MessageBox.Show("Press YES to delete the record Or No to Cancel", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (TradingBLL.Muneeb.CRUD.UpdateBuyer(Convert.ToInt32( txt_buyer_id.Text),txt_buyer_name.Text,txt_buyer_contact.Text,txt_buyer_email.Text,txt_buyer_acc.Text,txt_buyer_company.Text,txt_buyer_remarks.Text,dt_buyer_edate.Value,dt_buyer_mdate.Value))
                    {
                        MessageBox.Show("Record Updated");
                    }
                    else
                    {
                        MessageBox.Show("Record Was not Updated");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
            txt_buyer_id.Clear();
            txt_buyer_name.Clear();
            txt_buyer_contact.Clear();
            txt_buyer_email.Clear();
            txt_buyer_company.Clear();
            txt_buyer_remarks.Clear();
            txt_buyer_acc.Clear();
            this.Cursor = Cursors.Arrow;
        }

        private void grid_buyer_SelectionChanging(object sender, CancelEventArgs e)
        {

        }

        private void grp_supp_1_Enter(object sender, EventArgs e)
        {

        }
        
       
    }
}