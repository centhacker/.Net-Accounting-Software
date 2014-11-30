namespace TradingSolutions.Forms
{
    partial class ShowProductsByPackingList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grdProducts = new Telerik.WinControls.UI.RadGridView();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbList
            // 
            this.cmbList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbList.FormattingEnabled = true;
            this.cmbList.Location = new System.Drawing.Point(158, 36);
            this.cmbList.Name = "cmbList";
            this.cmbList.Size = new System.Drawing.Size(425, 21);
            this.cmbList.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "PACKING LISTS OF INVOICES";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(158, 93);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(251, 52);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 65;
            this.buttonX1.Text = "Show Products";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grdProducts);
            this.groupBox3.Location = new System.Drawing.Point(12, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1346, 554);
            this.groupBox3.TabIndex = 66;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Details";
            // 
            // grdProducts
            // 
            this.grdProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProducts.EnableFastScrolling = true;
            this.grdProducts.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdProducts.Location = new System.Drawing.Point(3, 18);
            // 
            // grdProducts
            // 
            this.grdProducts.MasterTemplate.AllowAddNewRow = false;
            this.grdProducts.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.grdProducts.MasterTemplate.AllowColumnReorder = false;
            this.grdProducts.MasterTemplate.AllowDeleteRow = false;
            this.grdProducts.MasterTemplate.AllowDragToGroup = false;
            this.grdProducts.MasterTemplate.AllowEditRow = false;
            this.grdProducts.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.grdProducts.MasterTemplate.EnableFiltering = true;
            this.grdProducts.Name = "grdProducts";
            this.grdProducts.ShowGroupPanel = false;
            this.grdProducts.Size = new System.Drawing.Size(1340, 533);
            this.grdProducts.TabIndex = 2;
            // 
            // ShowProductsByPackingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbList);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ShowProductsByPackingList";
            this.Text = "MetroForm";
            this.Load += new System.EventHandler(this.ShowProductsByPackingList_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbList;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Telerik.WinControls.UI.RadGridView grdProducts;
    }
}