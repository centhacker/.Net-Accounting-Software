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
    public partial class ShowProductsByPackingList : DevComponents.DotNetBar.Metro.MetroForm
    {
        public ShowProductsByPackingList()
        {
            InitializeComponent();
        }

        private void ShowProductsByPackingList_Load(object sender, EventArgs e)
        {
            this.grdProducts.TableElement.RowHeight = 40;
            cmbList.DataSource = TradingBLL.Muneeb.Scalars.ShowPackingList();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            grdProducts.DataSource = TradingBLL.Muneeb.CRUD.ShowProductsOfPackingList(cmbList.Text);
        }
    }
}