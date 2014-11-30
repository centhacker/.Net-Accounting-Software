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
    public partial class GeneralJournal : DevComponents.DotNetBar.Metro.MetroForm
    {
        public GeneralJournal()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            UserControls.AddJournalEntry objadg = new UserControls.AddJournalEntry();
            objadg.ShowDialog();
        }

        private void btn_credit_Click(object sender, EventArgs e)
        {

        }

        private void btn_debit_Click(object sender, EventArgs e)
        {

        }

        private void GeneralJournal_Load(object sender, EventArgs e)
        {
            com_acc.DataSource = TradingBLL.Muneeb.Scalars.ShowAccountsInfo();
        }
        private bool ValidateInfo()
        {
          
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
                for (int i = 0; i < grd_debit.RowCount; i++)
                {
                    if (grd_debit.Rows[i].Cells[0].Value == null || grd_debit.Rows[i].Cells[1].Value == null || grd_debit.Rows[i].Cells[2].Value == null || grd_debit.Rows[i].Cells[3].Value == null)
                    {

                        CheckAll = false;
                        break;
                    }
                }
                for (int i = 0; i < grd_credit.RowCount; i++)
                {
                    if (grd_credit.Rows[i].Cells[0].Value == null || grd_credit.Rows[i].Cells[1].Value == null || grd_credit.Rows[i].Cells[2].Value == null || grd_credit.Rows[i].Cells[3].Value == null)
                    {

                        CheckAll = false;
                        break;
                    }
                }
            }

            
            return CheckAll;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            grd_credit.Rows.Clear();
            grd_debit.Rows.Clear();
            grd_voucher.Rows.Clear();
        }

        private void btn_debit_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txt_amount_debit == null || dtEntryDate.Value == null || txt_note.Text == null)
                {
                    MessageBox.Show("Cannot Insert Record one or more Mandatory Feilds are empty");
                }
                else
                {
                    String[] Get = com_acc.Text.Split('|');
                    grd_debit.Rows.Add(1);
                    grd_debit.Rows[grd_debit.RowCount - 1].Cells[0].Value = Convert.ToDateTime(dtEntryDate.Value.ToShortDateString());
                    grd_debit.Rows[grd_debit.RowCount - 1].Cells[1].Value = Convert.ToString(Get[0]);
                    grd_debit.Rows[grd_debit.RowCount - 1].Cells[2].Value = Convert.ToString(Get[1]);
                    grd_debit.Rows[grd_debit.RowCount - 1].Cells[3].Value = txt_note.Text;
                    grd_debit.Rows[grd_debit.RowCount - 1].Cells[4].Value = Convert.ToString(txt_amount_debit.Text);

                }
            }
            catch (Exception ex)
            {
                grd_debit.Rows.Clear();
                MessageBox.Show(ex.ToString());
            }
            txt_amount_debit.Clear();
            
        }

        private void btn_credit_Click_1(object sender, EventArgs e)
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
                    grd_credit.Rows[grd_credit.RowCount - 1].Cells[0].Value = Convert.ToDateTime(dtEntryDate.Value.ToShortDateString());
                    grd_credit.Rows[grd_credit.RowCount - 1].Cells[1].Value = Convert.ToString(Get[0]);
                    grd_credit.Rows[grd_credit.RowCount - 1].Cells[2].Value = Convert.ToString(Get[1]);
                    grd_credit.Rows[grd_credit.RowCount - 1].Cells[3].Value = txt_note.Text;
                    grd_credit.Rows[grd_credit.RowCount - 1].Cells[4].Value = Convert.ToString(txt_amount_credit.Text);

                }
            }
            catch (Exception ex)
            {
                grd_credit.Rows.Clear();
                MessageBox.Show(ex.ToString());
            }
            txt_amount_credit.Clear();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validate())
                {
                    for (int i = 0; i < grd_debit.RowCount; i++)
                    {
                        grd_voucher.Rows.Add(1);
                        grd_voucher.Rows[grd_voucher.RowCount-1].Cells[0].Value = grd_debit.Rows[i].Cells[0].Value.ToString();
                        grd_voucher.Rows[grd_voucher.RowCount - 1].Cells[1].Value = grd_debit.Rows[i].Cells[1].Value.ToString();
                        grd_voucher.Rows[grd_voucher.RowCount - 1].Cells[2].Value = grd_debit.Rows[i].Cells[2].Value.ToString();
                        grd_voucher.Rows[grd_voucher.RowCount - 1].Cells[3].Value = grd_debit.Rows[i].Cells[3].Value.ToString();
                        grd_voucher.Rows[grd_voucher.RowCount - 1].Cells[4].Value = "DEBIT";
                        grd_voucher.Rows[grd_voucher.RowCount - 1].Cells[5].Value = grd_debit.Rows[i].Cells[4].Value.ToString();

                    }
                    for (int i = 0; i < grd_credit.RowCount; i++)
                    {
                        grd_voucher.Rows.Add(1);
                        grd_voucher.Rows[grd_voucher.RowCount - 1].Cells[0].Value = grd_credit.Rows[i].Cells[0].Value.ToString();
                        grd_voucher.Rows[grd_voucher.RowCount-1].Cells[1].Value = grd_credit.Rows[i].Cells[1].Value.ToString();
                        grd_voucher.Rows[grd_voucher.RowCount - 1].Cells[2].Value = grd_credit.Rows[i].Cells[2].Value.ToString();
                        grd_voucher.Rows[grd_voucher.RowCount - 1].Cells[3].Value = grd_credit.Rows[i].Cells[3].Value.ToString();
                        grd_voucher.Rows[grd_voucher.RowCount - 1].Cells[4].Value = "CREDIT";
                        grd_voucher.Rows[grd_voucher.RowCount - 1].Cells[5].Value = grd_credit.Rows[i].Cells[4].Value.ToString();

                    }

                    ClearAllFeilds();
                }
            }
            catch (Exception ex)
            {
                grd_voucher.Rows.Clear();
                MessageBox.Show(ex.ToString());
            }
           
            
        }
        private void ClearAllFeilds() {
            txt_amount_credit.Clear();
            txt_amount_debit.Clear();
            grd_credit.Rows.Clear();
            grd_debit.Rows.Clear();
            txt_note.Clear();

        
        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            try
            {
                //TradingBLL.Muneeb.DB.TradingConnection.Open();
                //TradingBLL.Muneeb.DB.TradingConnection.Open();
                for (int i = 0; i < grd_voucher.RowCount; i++)
                {
                    String AccountId = grd_voucher.Rows[i].Cells[1].Value.ToString();
                    String Edate = Convert.ToDateTime( grd_voucher.Rows[i].Cells[0].Value.ToString()).ToShortDateString();
                    String AccountNum = grd_voucher.Rows[i].Cells[2].Value.ToString();
                    String Description = grd_voucher.Rows[i].Cells[3].Value.ToString();
                    String TransactionType = grd_voucher.Rows[i].Cells[4].Value.ToString();
                    String Amount = grd_voucher.Rows[i].Cells[5].Value.ToString();
                    TradingBLL.Muneeb.Accounts.InsertJournalAndPosting(AccountId
                        ,AccountNum,Amount,Description,TransactionType,Convert.ToDateTime(Edate)                 
                        );
                }
                //TradingBLL.Muneeb.DB.TradingConnection.Open();
               //TradingBLL.Muneeb.DB.TradingConnection.Open();
                MessageBox.Show("Voucher Created Successfully");
                grd_voucher.Rows.Clear();
                ClearAllFeilds();

            }
            catch (Exception ex)
            {
               //TradingBLL.Muneeb.DB.TradingConnection.Open();

               //TradingBLL.Muneeb.DB.TradingConnection.Open();
                MessageBox.Show("Voucher Was not created, Check Balance and Accounting figures");
                MessageBox.Show(ex.ToString());
            }
        }
     
    }
}