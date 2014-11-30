namespace TradingSolutions.Reports
{
    partial class InvoiceSupplier
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
            this.reportInvoiceSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceSupplier1 = new TradingSolutions.ReportDataSets.InvoiceSupplier();
            this.combo_supp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportInvoiceSupplierTableAdapter = new TradingSolutions.ReportDataSets.InvoiceSupplierTableAdapters.ReportInvoiceSupplierTableAdapter();
            this.btn_filter = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.reportInvoiceSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceSupplier1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportInvoiceSupplierBindingSource
            // 
            this.reportInvoiceSupplierBindingSource.DataMember = "ReportInvoiceSupplier";
            this.reportInvoiceSupplierBindingSource.DataSource = this.invoiceSupplier1;
            // 
            // invoiceSupplier1
            // 
            this.invoiceSupplier1.DataSetName = "InvoiceSupplier";
            this.invoiceSupplier1.EnforceConstraints = false;
            this.invoiceSupplier1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // combo_supp
            // 
            this.combo_supp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_supp.FormattingEnabled = true;
            this.combo_supp.Location = new System.Drawing.Point(197, 16);
            this.combo_supp.Name = "combo_supp";
            this.combo_supp.Size = new System.Drawing.Size(440, 21);
            this.combo_supp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Supplier And Shipment Name";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "InvoiceSupplierDS";
            reportDataSource1.Value = this.reportInvoiceSupplierBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TradingSolutions.Reports.InvoiceSupplier.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 73);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1293, 642);
            this.reportViewer1.TabIndex = 8;
            // 
            // reportInvoiceSupplierTableAdapter
            // 
            this.reportInvoiceSupplierTableAdapter.ClearBeforeFill = true;
            // 
            // btn_filter
            // 
            this.btn_filter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_filter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_filter.Location = new System.Drawing.Point(675, 12);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(117, 42);
            this.btn_filter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_filter.TabIndex = 11;
            this.btn_filter.Text = "Filter";
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click_1);
            // 
            // InvoiceSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 727);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_supp);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "InvoiceSupplier";
            this.Text = "MetroForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InvoiceSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportInvoiceSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceSupplier1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_supp;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reportInvoiceSupplierBindingSource;
        private ReportDataSets.InvoiceSupplier invoiceSupplier1;
        private ReportDataSets.InvoiceSupplierTableAdapters.ReportInvoiceSupplierTableAdapter reportInvoiceSupplierTableAdapter;
        private DevComponents.DotNetBar.ButtonX btn_filter;
    }
}