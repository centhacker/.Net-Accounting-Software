using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TradingBLL;
using log4net;
namespace TradingSolutions

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            log4net.Config.XmlConfigurator.Configure();
           // Class1.log.Debug("\n"+"Log done");
          //  dataGridViewX1.DataSource = TradingBLL.Class1.GetDummy();
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
