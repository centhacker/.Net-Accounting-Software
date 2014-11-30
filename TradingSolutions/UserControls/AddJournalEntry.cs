using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace TradingSolutions.UserControls
{
    public partial class AddJournalEntry : DevComponents.DotNetBar.Metro.MetroForm
    {
        public AddJournalEntry()
        {
            InitializeComponent();
        }

        private void AddJournalEntry_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            com_acc.DataSource = TradingBLL.Muneeb.Scalars.ShowAccountsInfo();
        }

        private void btnVaidate_Click(object sender, EventArgs e)
        {
            if (ValidateInfo())
            {
                
            }
            else
            {
                MessageBox.Show("Some Feilds Were left Blank Or Accounts Are Not Balanced");
            }
        }

        private  bool ValidateInfo() {
            lblStatus.Text = "Validating";
            bool CheckAll = true;
            float Debit = 0, Credit = 0;
            for (int i = 0; i < grd_debit.RowCount - 1; i++)
            {
                Debit += Convert.ToSingle(grd_debit.Rows[i].Cells[3].Value.ToString());
            }
            for (int i = 0; i < grd_credit.RowCount - 1; i++)
            {
                Credit += Convert.ToSingle(grd_credit.Rows[i].Cells[3].Value.ToString());
            }
            if (Debit == Credit)
            {
                MessageBox.Show("Accounts Balanced");
                
            }
            else
            {
                MessageBox.Show("Accounts not Balanced");
                CheckAll = false;
            }
            if (CheckAll)
            {
                for (int i = 0; i < grd_debit.RowCount ; i++)
                {
                    if (grd_debit.Rows[i].Cells[0].Value == null || grd_debit.Rows[i].Cells[1].Value == null || grd_debit.Rows[i].Cells[2].Value == null || grd_debit.Rows[i].Cells[3].Value == null)
                    {

                        CheckAll = false;
                        break;
                    }
                }
                for (int i = 0; i < grd_credit.RowCount ; i++)
                {
                    if (grd_credit.Rows[i].Cells[0].Value == null || grd_credit.Rows[i].Cells[1].Value == null || grd_credit.Rows[i].Cells[2].Value == null || grd_credit.Rows[i].Cells[3].Value == null)
                    {

                        CheckAll = false;
                        break;
                    }
                }
            }

            lblStatus.Text = "Validation Complete";
            return CheckAll;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Clearing Data";
            grd_credit.Rows.Clear();
            grd_debit.Rows.Clear();
            lblStatus.Text = "Data Cleared";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Exiting";
            this.Close();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {

        }

        private void btn_debit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_amount_debit==null||dtEntryDate.Value==null||txt_note.Text==null)
                {
                    MessageBox.Show("Cannot Insert Record one or more Mandatory Feilds are empty");
                }
                else
                {
                    String[] Get = com_acc.Text.Split('|');
                    grd_debit.Rows.Add(1);
                    grd_debit.Rows[grd_debit.RowCount - 1].Cells[0].Value = Convert.ToDateTime( dtEntryDate.Value.ToShortDateString());
                    grd_debit.Rows[grd_debit.RowCount - 1].Cells[1].Value = Convert.ToString(Get[0]);
                    grd_debit.Rows[grd_debit.RowCount - 1].Cells[2].Value = Convert.ToString(Get[1]);
                    grd_debit.Rows[grd_debit.RowCount - 1].Cells[3].Value = txt_note.Text;
                    grd_debit.Rows[grd_debit.RowCount - 1].Cells[4].Value = Convert.ToString(txt_amount_debit.Text);
                
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            txt_amount_debit.Clear();
            

        }

        private void btn_credit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_amount_credit == null || dtEntryDate.Value == null || txt_note.Text == null)
                {
                    MessageBox.Show("Cannot Insert Record one or more Mandatory Feilds are empty");
                }
                else
                {
                    String[] Get = com_acc.Text.Split('|');
                    grd_credit.Rows.Add(1);
                    grd_credit.Rows[grd_debit.RowCount - 1].Cells[0].Value = Convert.ToDateTime(dtEntryDate.Value.ToShortDateString());
                    grd_credit.Rows[grd_debit.RowCount - 1].Cells[1].Value = Convert.ToString(Get[0]);
                    grd_credit.Rows[grd_debit.RowCount - 1].Cells[2].Value = Convert.ToString(Get[1]);
                    grd_credit.Rows[grd_debit.RowCount - 1].Cells[3].Value = txt_note.Text;
                    grd_credit.Rows[grd_debit.RowCount - 1].Cells[4].Value = Convert.ToString(txt_amount_credit.Text);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            txt_amount_credit.Clear();
        }
    }
}