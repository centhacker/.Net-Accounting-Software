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
    public partial class Chart_Of_Accounts : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Chart_Of_Accounts()
        {
            InitializeComponent();
        }

        private void Chart_Of_Accounts_Load(object sender, EventArgs e)
        {
           // this.grid_chart.TableElement.RowHeight = 40;
            this.Cursor = Cursors.WaitCursor;
            com_type.DataSource = TradingBLL.Muneeb.Scalars.ShowLedgerTypes();
            grid_chart.DataSource = TradingBLL.Muneeb.CRUD.ShowChartOfAccounts();
            this.Cursor = Cursors.Arrow;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (TradingBLL.Muneeb.Utility.CheckNames(txt_name.Text))
            {
                if (TradingBLL.Muneeb.CRUD.InsertChartOfAccounts(txt_name.Text,com_type.Text,dt_buyer_edate.Value))
                {
                    MessageBox.Show("New Account Saved");
                }
                else
                {
                    MessageBox.Show("Account Cannot be saved");
                }
            }
            else
            {
                MessageBox.Show("Cannot Save Account With Same Name");
            }
            grid_chart.DataSource = TradingBLL.Muneeb.CRUD.ShowChartOfAccounts();
            this.Cursor = Cursors.Arrow;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (TradingBLL.Muneeb.CRUD.DeleteChartOfAccounts(grid_chart.SelectedRows[0].Cells[0].Value.ToString()))
            {
                MessageBox.Show("Account Deleted");
            }
            else
            {
                MessageBox.Show("Account Cannot be Deleted");
            }
            grid_chart.DataSource = TradingBLL.Muneeb.CRUD.ShowChartOfAccounts();
            this.Cursor = Cursors.Arrow;
        }
    }
}