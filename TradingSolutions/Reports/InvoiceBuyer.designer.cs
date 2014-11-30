namespace TradingSolutions.Reports
{
    partial class InvoiceBuyer
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
            this.reportInvoiceBuyerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceBuyer1 = new TradingSolutions.ReportDataSets.InvoiceBuyer();
            this.btn_filter = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_supp = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportInvoiceBuyerTableAdapter = new TradingSolutions.ReportDataSets.InvoiceBuyerTableAdapters.ReportInvoiceBuyerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportInvoiceBuyerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBuyer1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportInvoiceBuyerBindingSource
            // 
            this.reportInvoiceBuyerBindingSource.DataMember = "ReportInvoiceBuyer";
            this.reportInvoiceBuyerBindingSource.DataSource = this.invoiceBuyer1;
            // 
            // invoiceBuyer1
            // 
            this.invoiceBuyer1.DataSetName = "InvoiceBuyer";
            this.invoiceBuyer1.EnforceConstraints = false;
            this.invoiceBuyer1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_filter
            // 
            this.btn_filter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_filter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_filter.Location = new System.Drawing.Point(779, 5);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(168, 43);
            this.btn_filter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_filter.TabIndex = 10;
            this.btn_filter.Text = "Filter";
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Buyer Order Shipment Names";
            // 
            // combo_supp
            // 
            this.combo_supp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_supp.FormattingEnabled = true;
            this.combo_supp.Location = new System.Drawing.Point(194, 5);
            this.combo_supp.Name = "combo_supp";
            this.combo_supp.Size = new System.Drawing.Size(545, 21);
            this.combo_supp.TabIndex = 8;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "InvoiceBuyerDS";
            reportDataSource1.Value = this.reportInvoiceBuyerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TradingSolutions.Reports.InvoiceBuyer.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(9, 96);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1296, 619);
            this.reportViewer1.TabIndex = 15;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // reportInvoiceBuyerTableAdapter
            // 
            this.reportInvoiceBuyerTableAdapter.ClearBeforeFill = true;
            // 
            // InvoiceBuyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 727);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_supp);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "InvoiceBuyer";
            this.Text = "MetroForm";
            this.Load += new System.EventHandler(this.InvoiceBuyer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportInvoiceBuyerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBuyer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btn_filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_supp;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reportInvoiceBuyerBindingSource;
        private ReportDataSets.InvoiceBuyer invoiceBuyer1;
        private ReportDataSets.InvoiceBuyerTableAdapters.ReportInvoiceBuyerTableAdapter reportInvoiceBuyerTableAdapter;
    }
}