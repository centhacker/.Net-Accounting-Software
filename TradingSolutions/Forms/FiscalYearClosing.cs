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
    public partial class FiscalYearClosing : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FiscalYearClosing()
        {
            InitializeComponent();
        }

        private void FiscalYearClosing_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = TradingBLL.Muneeb.Accounts.ShowFiscalYEar();
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            try
            {
                if (TradingBLL.Muneeb.Accounts.InsertFiscalYear(dateTimeInput1.Value))
                {
                    MessageBox.Show("Fiscal Year Closed");
                   
                }
                else
                {
                    MessageBox.Show("Fiscal Year Was Not Closed");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            listBox1.DataSource = TradingBLL.Muneeb.Accounts.ShowFiscalYEar();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            SetDates();
            Reports.TrialBalance obj = new Reports.TrialBalance();
            obj.ShowDialog();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            SetDates();
            Reports.GeneralJournal obj = new Reports.GeneralJournal();
            obj.ShowDialog();
        }

        private void SetDates() {
            TradingBLL.Muneeb.Accounts.TrialBalanceFromDate = DateTime.MinValue;
            TradingBLL.Muneeb.Accounts.TrialBalanceToDate = DateTime.MaxValue;
            String GetCurrentDates = String.Empty;
            if (String.IsNullOrEmpty(listBox1.SelectedValue.ToString()) == false)
            {
                GetCurrentDates = listBox1.SelectedValue.ToString();
                String[] SplitDates = GetCurrentDates.Split('|');
                TradingBLL.Muneeb.Accounts.TrialBalanceFromDate = Convert.ToDateTime(SplitDates[0]);
                TradingBLL.Muneeb.Accounts.TrialBalanceToDate = Convert.ToDateTime(SplitDates[1]);
                

            }
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            SetDates();
            Reports.IncomeStatement obj = new Reports.IncomeStatement();
            obj.ShowDialog();
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            SetDates();
            Reports.OwnerEquity obj = new Reports.OwnerEquity();
            obj.ShowDialog();
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            SetDates();
            Reports.BalanceSheet obj = new Reports.BalanceSheet();
            obj.ShowDialog();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            SetDates();
            Reports.EndingBalance obj = new Reports.EndingBalance();
            obj.ShowDialog();
        }
    }
}