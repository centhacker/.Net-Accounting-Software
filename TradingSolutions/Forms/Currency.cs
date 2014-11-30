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
    public partial class Currency : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Currency()
        {
            InitializeComponent();
        }

        private void btn_curr_home_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.Close();
            this.Cursor = Cursors.Arrow;
        }

        private void btn_curr_clear_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            txt_curr_eid.Clear();
            txt_curr_erate.Clear();
            txt_curr_id.Clear();
            txt_curr_log.Clear();
            txt_curr_name.Clear();
            this.Cursor = Cursors.Arrow;
        }
        static List<String> GetCurrencies;
        private void Currency_Load(object sender, EventArgs e)
        {
            //this.grid_curr.TableElement.RowHeight = 40;
            this.Cursor = Cursors.WaitCursor;
            txt_curr_log.Text = TradingBLL.Muneeb.Utility.LoggedIn;
            list_curr.Items.Clear();
            GetCurrencies = TradingBLL.Muneeb.CRUD.ShowCurrency();
            for (int i = 0; i < GetCurrencies.Count; i++)
            {
                list_curr.Items.Add(GetCurrencies[i].ToString());
            }
            GetCurrencies.Clear();
            
            combox_curr_to.DataSource = null;
            combox_curr_from.DataSource = null;
            combox_curr_to.DataSource = TradingBLL.Muneeb.Scalars.ShowCurrency();
            combox_curr_from.DataSource = TradingBLL.Muneeb.Scalars.ShowCurrency();
            
            txt_curr_name.ReadOnly = false;
            lab_curr_req1.Visible = false;
            lab_curr_req2.Visible = false;
            lab_curr_req3.Visible = false;
          //  lab_curr_req4.Visible = false;
           // lab_curr_req5.Visible = false;
           
            
            grid_curr.ReadOnly = true;
            grid_curr.DataSource = TradingBLL.Muneeb.CRUD.ShowExchangeRate();
            this.Cursor = Cursors.Arrow;
        }

        private void btn_curr_create_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            txt_curr_eid.ReadOnly = false;
            txt_curr_erate.ReadOnly = false;
            txt_curr_id.ReadOnly = false;
            txt_curr_log.ReadOnly = false;
            txt_curr_name.ReadOnly = false;

            txt_curr_eid.Clear();
            txt_curr_erate.Clear();
            txt_curr_id.Clear();
            txt_curr_log.Clear();
            txt_curr_name.Clear();

            if (txt_curr_name.Text != null || txt_curr_eid.Text != null || txt_curr_erate.Text != null || dt_curr_edate.Value != null )
            {

            }

            else
            {
                MessageBox.Show("Enter data in the fields indicating *.");
                lab_curr_req1.Visible = true;
                lab_curr_req2.Visible = true;
                lab_curr_req3.Visible = true;
                //lab_curr_req4.Visible = true;
                //lab_curr_req5.Visible = true;
                lab_curr_req6.Visible = true;
            }
            this.Cursor = Cursors.Arrow;
        }

        private void grp_curr_4_Enter(object sender, EventArgs e)
        {
            
        }

        private void btn_curr_save_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (txt_curr_erate .Text == null)
            {
                txt_curr_erate.Text = "0";
            }
            if (txt_curr_name .Text == null)
            {
                txt_curr_name.Text = "-";
            }

            if (txt_curr_name.Text == "")
            {
                lab_curr_req6.Visible = false;
                MessageBox.Show("Enter data in the fields indicating *.");
            }
            else
            {
                try
                {
                    if (TradingBLL.Muneeb.CRUD.InsertCurrency(txt_curr_name.Text, dt_curr_edate.Value, dt_curr_mdate.Value))
                    {
                        MessageBox.Show("Record Inserted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Record Was Not Inserted");
                    }
                    list_curr.Items.Clear();
                    GetCurrencies = TradingBLL.Muneeb.CRUD.ShowCurrency();
                    for (int i = 0; i < GetCurrencies.Count; i++)
                    {
                        list_curr.Items.Add(GetCurrencies[i].ToString());
                    }
                    GetCurrencies.Clear();
                    combox_curr_to.DataSource = null;
                    combox_curr_from.DataSource = null;
                    combox_curr_to.DataSource = TradingBLL.Muneeb.Scalars.ShowCurrency();
                    combox_curr_from.DataSource = TradingBLL.Muneeb.Scalars.ShowCurrency();
                }
                  
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                   
                }
            }

            txt_curr_eid.Clear();
            txt_curr_erate.Clear();
            txt_curr_id.Clear();
            txt_curr_log.Clear();
            txt_curr_name.Clear();
            this.Cursor = Cursors.Arrow;
        }

        private void btn_create_ex_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (TradingBLL.Muneeb.CRUD.InsertExchangeRate(combox_curr_to.Text,combox_curr_from.Text,txt_curr_erate.Text,dt_curr_edate.Value,dt_curr_mdate.Value))
            {
                MessageBox.Show("Record Inserted Successfully");
            }
            else
            {
                MessageBox.Show("Record Was Not Inserted");

            }
            grid_curr.DataSource = TradingBLL.Muneeb.CRUD.ShowExchangeRate();
            this.Cursor = Cursors.Arrow;
        }

        private void btn_curr_delete_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (txt_curr_erate.Text == null)
            {
                txt_curr_erate.Text = "0";
            }
            if (txt_curr_name.Text == null)
            {
                txt_curr_name.Text = "-";
            }
            try
            {
                if (MessageBox.Show("Press YES to delete the record Or No to Cancel", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (TradingBLL.Muneeb.CRUD.DeleteCurrency(txt_curr_name.Text))
                    {

                        MessageBox.Show("Record Deleted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Record Was Not Deleted");

                    }
                }
                list_curr.Items.Clear();
                GetCurrencies = TradingBLL.Muneeb.CRUD.ShowCurrency();
                for (int i = 0; i < GetCurrencies.Count; i++)
                {
                    list_curr.Items.Add(GetCurrencies[i].ToString());
                }
                GetCurrencies.Clear();
                combox_curr_to.DataSource = null;
                combox_curr_from.DataSource = null;
                combox_curr_to.DataSource = TradingBLL.Muneeb.Scalars.ShowCurrency();
                combox_curr_from.DataSource = TradingBLL.Muneeb.Scalars.ShowCurrency();
                grid_curr.DataSource = TradingBLL.Muneeb.CRUD.ShowExchangeRate();

                txt_curr_eid.Clear();
                txt_curr_erate.Clear();
                txt_curr_id.Clear();
                txt_curr_log.Clear();
                txt_curr_name.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            this.Cursor = Cursors.Arrow;
        }

        private void btn_delete_ex_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            grid_curr.DataSource = TradingBLL.Muneeb.CRUD.ShowExchangeRate();
            this.Cursor = Cursors.Arrow;
        }

        private void btn_curr_up_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Press YES to delete the record Or No to Cancel", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //code
            }
            txt_curr_eid.Clear();
            txt_curr_erate.Clear();
            txt_curr_id.Clear();
            txt_curr_log.Clear();
            txt_curr_name.Clear();
        }
    }
}