namespace TradingSolutions.Reports
{
    partial class InventoryTransactions
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportInventoryTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTransactions1 = new TradingSolutions.ReportDataSets.InventoryTransactions();
            this.label1 = new System.Windows.Forms.Label();
            this.com_prod = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_to = new System.Windows.Forms.DateTimePicker();
            this.dt_from = new System.Windows.Forms.DateTimePicker();
            this.btn_filter = new DevComponents.DotNetBar.ButtonX();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportInventoryTransactionsTableAdapter = new TradingSolutions.ReportDataSets.InventoryTransactionsTableAdapters.ReportInventoryTransactionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportInventoryTransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTransactions1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportInventoryTransactionsBindingSource
            // 
            this.reportInventoryTransactionsBindingSource.DataMember = "ReportInventoryTransactions";
            this.reportInventoryTransactionsBindingSource.DataSource = this.inventoryTransactions1;
            // 
            // inventoryTransactions1
            // 
            this.inventoryTransactions1.DataSetName = "InventoryTransactions";
            this.inventoryTransactions1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product";
            // 
            // com_prod
            // 
            this.com_prod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_prod.FormattingEnabled = true;
            this.com_prod.Location = new System.Drawing.Point(117, 24);
            this.com_prod.Name = "com_prod";
            this.com_prod.Size = new System.Drawing.Size(318, 21);
            this.com_prod.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(810, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(623, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "From";
            // 
            // dt_to
            // 
            this.dt_to.Location = new System.Drawing.Point(745, 29);
            this.dt_to.Name = "dt_to";
            this.dt_to.Size = new System.Drawing.Size(200, 22);
            this.dt_to.TabIndex = 10;
            // 
            // dt_from
            // 
            this.dt_from.Location = new System.Drawing.Point(539, 29);
            this.dt_from.Name = "dt_from";
            this.dt_from.Size = new System.Drawing.Size(200, 22);
            this.dt_from.TabIndex = 9;
            // 
            // btn_filter
            // 
            this.btn_filter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_filter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_filter.Location = new System.Drawing.Point(987, 17);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(116, 34);
            this.btn_filter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_filter.TabIndex = 8;
            this.btn_filter.Text = "Filter";
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "InventoryTransactionsDS";
            reportDataSource1.Value = this.reportInventoryTransactionsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TradingSolutions.Reports.InventoryTransactions.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 64);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1293, 651);
            this.reportViewer1.TabIndex = 13;
            // 
            // reportInventoryTransactionsTableAdapter
            // 
            this.reportInventoryTransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // InventoryTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 727);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dt_to);
            this.Controls.Add(this.dt_from);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.com_prod);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "InventoryTransactions";
            this.Text = "MetroForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InventoryTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportInventoryTransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTransactions1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox com_prod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_to;
        private System.Windows.Forms.DateTimePicker dt_from;
        private DevComponents.DotNetBar.ButtonX btn_filter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reportInventoryTransactionsBindingSource;
        private ReportDataSets.InventoryTransactions inventoryTransactions1;
        private ReportDataSets.InventoryTransactionsTableAdapters.ReportInventoryTransactionsTableAdapter reportInventoryTransactionsTableAdapter;
    }
}