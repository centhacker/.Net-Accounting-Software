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
    public partial class grdInventoryGrid : DevComponents.DotNetBar.Metro.MetroForm
    {
        public grdInventoryGrid()
        {
            InitializeComponent();
        }

        private String Cath = String.Empty;
        private void grdInventoryGrid_Load(object sender, EventArgs e)
        {
            this.grdInventory.TableElement.RowHeight = 40;
            grdInventory.DataSource = TradingBLL.Muneeb.Utility.InventoryGrid(dtFrom.Value,dtTo.Value,out Cath);
            if (Cath != "")
            {
                MessageBox.Show(Cath.ToString());  
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Cath = "";
            grdInventory.DataSource = TradingBLL.Muneeb.Utility.InventoryGrid(dtFrom.Value, dtTo.Value, out Cath);
            if (Cath != "")
            {
                MessageBox.Show(Cath.ToString());
            }
        }
    }
}