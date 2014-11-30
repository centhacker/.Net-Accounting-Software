namespace TradingSolutions.Reports
{
    partial class OwnerEquity
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportOwnerEquityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ownerEquity1 = new TradingSolutions.ReportDataSets.OwnerEquity();
            this.reportOwnerEquityTableAdapter = new TradingSolutions.ReportDataSets.OwnerEquityTableAdapters.ReportOwnerEquityTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportOwnerEquityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerEquity1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "OwnerEquityDS";
            reportDataSource1.Value = this.reportOwnerEquityBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TradingSolutions.Reports.ReportOwnerEquity.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1370, 750);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // reportOwnerEquityBindingSource
            // 
            this.reportOwnerEquityBindingSource.DataMember = "ReportOwnerEquity";
            this.reportOwnerEquityBindingSource.DataSource = this.ownerEquity1;
            // 
            // ownerEquity1
            // 
            this.ownerEquity1.DataSetName = "OwnerEquity";
            this.ownerEquity1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportOwnerEquityTableAdapter
            // 
            this.reportOwnerEquityTableAdapter.ClearBeforeFill = true;
            // 
            // OwnerEquity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.reportViewer1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "OwnerEquity";
            this.Text = "MetroForm";
            this.Load += new System.EventHandler(this.OwnerEquity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportOwnerEquityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerEquity1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reportOwnerEquityBindingSource;
        private ReportDataSets.OwnerEquity ownerEquity1;
        private ReportDataSets.OwnerEquityTableAdapters.ReportOwnerEquityTableAdapter reportOwnerEquityTableAdapter;
    }
}