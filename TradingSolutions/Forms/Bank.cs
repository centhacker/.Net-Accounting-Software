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
    public partial class Bank : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Bank()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            txt_bank_accbal.Clear();
            txt_bank_accname.Clear();
            txt_bank_accno.Clear();
          //  txt_bank_acctype.Clear();
            txt_bank_address.Clear();
            txt_bank_bracode.Clear();
            txt_bank_branch.Clear();
            txt_bank_curr.Clear();
            txt_bank_email.Clear();
            txt_bank_id.Clear();
         //   txt_bank_log.Clear();
            txt_bank_no.Clear();
            this.Cursor = Cursors.Arrow;
        }

        private void Bank_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.grid_bank.TableElement.RowHeight = 40;
            txt_bank_acctype.DataSource = new String[] { "Supplier","Freight","Personal"};
            
            lab_bank_req1.Visible = false;
            lab_bank_req2.Visible = false;
            lab_bank_req3.Visible = false;
            lab_bank_req4.Visible = false;
            lab_bank_req5.Visible = false;
            lab_bank_req6.Visible = false;
           // lab_bank_req7.Visible = true;
            grid_bank.DataSource = TradingBLL.Muneeb.CRUD.ShowBank();
           // txt_bank_log.Text = TradingBLL.Muneeb.Utility.LoggedIn;
            this.Cursor = Cursors.Arrow;

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            txt_bank_accbal.ReadOnly = false;
            txt_bank_accname.ReadOnly = false;
            txt_bank_accno.ReadOnly = false;
          //  txt_bank_acctype.ReadOnly = false;
            txt_bank_address.ReadOnly = false;
            txt_bank_bracode.ReadOnly = false;
            txt_bank_branch.ReadOnly = false;
            txt_bank_curr.ReadOnly = false;
            txt_bank_email.ReadOnly = false;
            txt_bank_id.ReadOnly = false;
          //  txt_bank_log.ReadOnly = false;
            txt_bank_no.ReadOnly = false;

            txt_bank_accbal.Clear();
            txt_bank_accname.Clear();
            txt_bank_accno.Clear();
         //   txt_bank_acctype.Clear();
            txt_bank_address.Clear();
            txt_bank_bracode.Clear();
            txt_bank_branch.Clear();
            txt_bank_curr.Clear();
            txt_bank_email.Clear();
            txt_bank_id.Clear();
          //  txt_bank_log.Clear();
            txt_bank_no.Clear();
            this.Cursor = Cursors.Arrow;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (txt_bank_accbal .Text == null)
            {
                txt_bank_accbal.Text = "0";
            }
            if (txt_bank_accname .Text == null)
            {
                txt_bank_accname.Text = "-";
            }
            if (txt_bank_accno .Text == null)
            {
                txt_bank_accno.Text = "-";
            }
            if (txt_bank_acctype .Text == null)
            {
                txt_bank_acctype.Text = "-";
            }
            if (txt_bank_address .Text == null)
            {
                txt_bank_address.Text = "-";
            }
            if (txt_bank_bracode .Text == null)
            {
                txt_bank_bracode.Text = "-";
            }
            if (txt_bank_branch .Text == null)
            {
                txt_bank_branch.Text = "-";
            }
            if (txt_bank_curr .Text == null)
            {
                txt_bank_curr.Text = "-";
            }
            if (txt_bank_email .Text == null)
            {
                txt_bank_email .Text ="-";
            }
            if (txt_bank_no.Text == null)
            {
                txt_bank_no.Text = "-";
            }
            
            
            if (txt_bank_accno.Text == "" || txt_bank_accname.Text == "" || txt_bank_branch.Text == "" || txt_bank_bracode.Text == "" || txt_bank_curr.Text == "" || txt_bank_no.Text == "" )
            {

                MessageBox.Show("Enter data in the fields indicating *.");
                lab_bank_req1.Visible = true;
                lab_bank_req2.Visible = true;
                lab_bank_req3.Visible = true;
                lab_bank_req4.Visible = true;
                lab_bank_req5.Visible = true;
                lab_bank_req6.Visible = true;
                lab_bank_req6.Visible = true;
            }
            else
            {
                if (TradingBLL.Muneeb.CRUD.InsertBank(txt_bank_accno.Text,txt_bank_accname.Text,txt_bank_acctype.Text,txt_bank_accbal.Text,
                    txt_bank_accbal.Text, txt_bank_address.Text, txt_bank_bracode.Text, txt_bank_curr.Text, txt_bank_email.Text, txt_bank_no.Text, DateTime.Now, DateTime.Now))
                {
                    MessageBox.Show("New Account Successfully Opened");
                }
                else
                {
                    MessageBox.Show("Account Was Not Opened");
                }
            }
            grid_bank.DataSource = null;
            grid_bank.DataSource = TradingBLL.Muneeb.CRUD.ShowBank();
            this.Cursor = Cursors.Arrow;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (txt_bank_accbal.Text == null)
            {
                txt_bank_accbal.Text = "0";
            }
            if (txt_bank_accname.Text == null)
            {
                txt_bank_accname.Text = "-";
            }
            if (txt_bank_accno.Text == null)
            {
                txt_bank_accno.Text = "-";
            }
            if (txt_bank_acctype.Text == null)
            {
                txt_bank_acctype.Text = "-";
            }
            if (txt_bank_address.Text == null)
            {
                txt_bank_address.Text = "-";
            }
            if (txt_bank_bracode.Text == null)
            {
                txt_bank_bracode.Text = "-";
            }
            if (txt_bank_branch.Text == null)
            {
                txt_bank_branch.Text = "-";
            }
            if (txt_bank_curr.Text == null)
            {
                txt_bank_curr.Text = "-";
            }
            if (txt_bank_email.Text == null)
            {
                txt_bank_email.Text = "-";
            }
            if (txt_bank_no.Text == null)
            {
                txt_bank_no.Text = "-";
            }

            if (MessageBox.Show("Press YES to delete the record Or No to Cancel", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (TradingBLL.Muneeb.CRUD.DeleteBank(txt_bank_id.Text))
                {
                    MessageBox.Show("Bank Account Deleted");
                }
                else
                {
                    MessageBox.Show("Account Was Not Deleted");
                }
            }
            grid_bank.DataSource = null;
            grid_bank.DataSource = TradingBLL.Muneeb.CRUD.ShowBank();
            this.Cursor = Cursors.Arrow;
        }

        private void btn_update_Click(object sender, EventArgs e)

        {
            this.Cursor = Cursors.WaitCursor;
           
            txt_bank_accbal.Clear();
            txt_bank_accname.Clear();
            txt_bank_accno.Clear();
           // txt_bank_acctype.Clear();
            txt_bank_address.Clear();
            txt_bank_bracode.Clear();
            txt_bank_branch.Clear();
            txt_bank_curr.Clear();
            txt_bank_email.Clear();
            txt_bank_id.Clear();
        //    txt_bank_log.Clear();
            txt_bank_no.Clear();
            this.Cursor = Cursors.Arrow;


        }

        private void grid_bank_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void Btn_show_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            grid_bank.DataSource = TradingBLL.Muneeb.CRUD.ShowBank();
            this.Cursor = Cursors.Arrow;
        }

        private void grid_bank_SelectionChanged_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                txt_bank_id.Text = grid_bank.SelectedRows[0].Cells[0].Value.ToString();
                txt_bank_accno.Text = grid_bank.SelectedRows[0].Cells[1].Value.ToString();
                txt_bank_accname.Text = grid_bank.SelectedRows[0].Cells[2].Value.ToString();
                txt_bank_acctype.Text = grid_bank.SelectedRows[0].Cells[3].Value.ToString();
                txt_bank_accbal.Text = grid_bank.SelectedRows[0].Cells[4].Value.ToString();
                txt_bank_branch.Text = grid_bank.SelectedRows[0].Cells[5].Value.ToString();
                txt_bank_address.Text = grid_bank.SelectedRows[0].Cells[6].Value.ToString();
                txt_bank_bracode.Text = grid_bank.SelectedRows[0].Cells[7].Value.ToString();
                txt_bank_no.Text = grid_bank.SelectedRows[0].Cells[8].Value.ToString();
                txt_bank_email.Text = grid_bank.SelectedRows[0].Cells[9].Value.ToString();
                txt_bank_curr.Text = grid_bank.SelectedRows[0].Cells[10].Value.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            this.Cursor = Cursors.Arrow;
        }
    }
}