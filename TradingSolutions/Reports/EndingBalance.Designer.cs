namespace TradingSolutions.Reports
{
    partial class EndingBalance
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
            this.endingBalance1 = new TradingSolutions.ReportDataSets.EndingBalance();
            this.reportEndingBalanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportEndingBalanceTableAdapter = new TradingSolutions.ReportDataSets.EndingBalanceTableAdapters.ReportEndingBalanceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.endingBalance1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportEndingBalanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "EndingBalanceDS";
            reportDataSource1.Value = this.reportEndingBalanceBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TradingSolutions.Reports.EndingBalance.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1370, 750);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // endingBalance1
            // 
            this.endingBalance1.DataSetName = "EndingBalance";
            this.endingBalance1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportEndingBalanceBindingSource
            // 
            this.reportEndingBalanceBindingSource.DataMember = "ReportEndingBalance";
            this.reportEndingBalanceBindingSource.DataSource = this.endingBalance1;
            // 
            // reportEndingBalanceTableAdapter
            // 
            this.reportEndingBalanceTableAdapter.ClearBeforeFill = true;
            // 
            // EndingBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.reportViewer1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EndingBalance";
            this.Text = "MetroForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EndingBalance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.endingBalance1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportEndingBalanceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reportEndingBalanceBindingSource;
        private ReportDataSets.EndingBalance endingBalance1;
        private ReportDataSets.EndingBalanceTableAdapters.ReportEndingBalanceTableAdapter reportEndingBalanceTableAdapter;
    }
}