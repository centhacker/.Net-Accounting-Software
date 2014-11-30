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
    public partial class GenerateFinancialStatements : DevComponents.DotNetBar.Metro.MetroForm
    {
        public GenerateFinancialStatements()
        {
            InitializeComponent();
        }

        private void GenerateFinancialStatements_Load(object sender, EventArgs e)
        {
            lstFiscalYear.DataSource = TradingBLL.Muneeb.Accounts.ShowFiscalYEar();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want To Close This Year?", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TradingBLL.Muneeb.Accounts.InsertFiscalYear(dateTimeInput1.Value);
            }
            else
            {
                //Do Nothing
            }
            
                
            
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            lstFiscalYear.DataSource = TradingBLL.Muneeb.Accounts.ShowFiscalYEar();
        }
    }
}