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
    public partial class AccountTransaction : DevComponents.DotNetBar.Metro.MetroForm
    {
        public AccountTransaction()
        {
            InitializeComponent();
        }

        private void AccountTransaction_Load(object sender, EventArgs e)
        {
           this.grid_bank.TableElement.RowHeight = 40;
            this.Cursor = Cursors.WaitCursor;
            txt_type.DataSource = new string[] {"credit","debit" };
            grid_bank.DataSource = TradingBLL.Muneeb.CRUD.ShowBank();
            this.Cursor = Cursors.Arrow;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (TradingBLL.Muneeb.Accounts.AccountTransaction(grid_bank.SelectedRows[0].Cells[0].Value.ToString(),txt_type.Text,txtRefrence.Text,txt_expense.Text))
                {
                    MessageBox.Show("Account Successfully Updated");
                }
            }
            catch (Exception wx)
            {

                MessageBox.Show(wx.ToString());
            }
            grid_bank.DataSource = TradingBLL.Muneeb.CRUD.ShowBank();
            this.Cursor = Cursors.Arrow;
        }
    }
}