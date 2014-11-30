using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.SqlClient;


namespace TradingSolutions.Reports
{
    public partial class CurrentInventory : DevComponents.DotNetBar.Metro.MetroForm
    {
        public CurrentInventory()
        {
            InitializeComponent();
        }


       
        private void CurrentInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'currenctInventory.ReportCurrentInventory' table. You can move, or remove it, as needed.
            this.reportCurrentInventoryTableAdapter.Fill(this.currenctInventory.ReportCurrentInventory);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }

      
    }
}