namespace TradingSolutions.Reports
{
    partial class BalanceSheet
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
            this.reportBalanceSheetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.balanceSheet1 = new TradingSolutions.ReportDataSets.BalanceSheet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportBalanceSheetTableAdapter = new TradingSolutions.ReportDataSets.BalanceSheetTableAdapters.ReportBalanceSheetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportBalanceSheetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceSheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportBalanceSheetBindingSource
            // 
            this.reportBalanceSheetBindingSource.DataMember = "ReportBalanceSheet";
            this.reportBalanceSheetBindingSource.DataSource = this.balanceSheet1;
            // 
            // balanceSheet1
            // 
            this.balanceSheet1.DataSetName = "BalanceSheet";
            this.balanceSheet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "BalanceSheetDS";
            reportDataSource1.Value = this.reportBalanceSheetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TradingSolutions.Reports.BalanceSheet.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1370, 750);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportBalanceSheetTableAdapter
            // 
            this.reportBalanceSheetTableAdapter.ClearBeforeFill = true;
            // 
            // BalanceSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.reportViewer1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BalanceSheet";
            this.Text = "MetroForm";
            this.Load += new System.EventHandler(this.BalanceSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportBalanceSheetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceSheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reportBalanceSheetBindingSource;
        private ReportDataSets.BalanceSheet balanceSheet1;
        private ReportDataSets.BalanceSheetTableAdapters.ReportBalanceSheetTableAdapter reportBalanceSheetTableAdapter;
    }
}