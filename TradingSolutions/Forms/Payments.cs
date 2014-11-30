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
    public partial class Payments : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Payments()
        {
            InitializeComponent();
        }

        private void btn_payment_home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_payment_clear_Click(object sender, EventArgs e)
        {
            txt_payment_id.Clear();
            txt_payment_type.Clear();
            txt_payment_log.Clear();
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            this.grid_payment.TableElement.RowHeight = 40;
            txt_payment_log.Text = TradingBLL.Muneeb.Utility.LoggedIn;
            
            
            lab_payment_req1.Visible = false;
            lab_payment_req2.Visible = false;
            grid_payment.DataSource = TradingBLL.Muneeb.CRUD.ShowPayments();
        }

        private void btn_payment_create_Click(object sender, EventArgs e)
        {
            txt_payment_id.ReadOnly = false;
            txt_payment_type.ReadOnly = false;
            txt_payment_log.ReadOnly = false;

            txt_payment_id.Clear();
            txt_payment_type.Clear();
            txt_payment_log.Clear();

           
        }

        private void btn_payment_save_Click(object sender, EventArgs e)
        {
            if (txt_payment_type.Text  == null)
            {
                txt_payment_type.Text = "-";
            }
         

            if (txt_payment_type.Text == "")
            {
                MessageBox.Show("Enter data in the fields indicating *.");
                lab_payment_req1.Visible = true;
                lab_payment_req2.Visible = true;
            }

            else
            {
                try
                {
                    if (TradingBLL.Muneeb.CRUD.InsertPayments(txt_payment_type.Text, dt_payment_edate.Value, dt_payment_mdate.Value))
                    {

                        grid_payment.DataSource = TradingBLL.Muneeb.CRUD.ShowPayments();
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

            txt_payment_id.Clear();
            txt_payment_type.Clear();
            txt_payment_log.Clear();
        }

        private void btn_payment_delete_Click(object sender, EventArgs e)
        {
            if (txt_payment_type.Text == null)
            {
                txt_payment_type.Text = "-";
            }
         
            
            if (MessageBox.Show("Press YES to delete the record Or No to Cancel", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (TradingBLL.Muneeb.CRUD.DeletePayments(txt_payment_type.Text))
                    {
                        grid_payment.DataSource = TradingBLL.Muneeb.CRUD.ShowPayments();
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


            txt_payment_id.Clear();
            txt_payment_type.Clear();
            txt_payment_log.Clear();
        }

        private void btn_payment_show_Click(object sender, EventArgs e)
        {
            grid_payment.DataSource = TradingBLL.Muneeb.CRUD.ShowPayments();

            txt_payment_id.Clear();
            txt_payment_type.Clear();
            txt_payment_log.Clear();
        }

        private void grid_payment_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txt_payment_type.Text = grid_payment.SelectedRows[0].Cells[0].Value.ToString();


            }
            catch (Exception ex)
            {
                TradingBLL.Muneeb.CRUD.log.Error("Order Form: " + ex);

            }
        }
    }
}