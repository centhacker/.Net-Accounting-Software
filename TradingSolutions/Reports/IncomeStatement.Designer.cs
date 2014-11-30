namespace TradingSolutions.Reports
{
    partial class IncomeStatement
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
            this.reportIncomeStatementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incomeStatement1 = new TradingSolutions.ReportDataSets.IncomeStatement();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportIncomeStatementTableAdapter = new TradingSolutions.ReportDataSets.IncomeStatementTableAdapters.ReportIncomeStatementTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportIncomeStatementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeStatement1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportIncomeStatementBindingSource
            // 
            this.reportIncomeStatementBindingSource.DataMember = "ReportIncomeStatement";
            this.reportIncomeStatementBindingSource.DataSource = this.incomeStatement1;
            // 
            // incomeStatement1
            // 
            this.incomeStatement1.DataSetName = "IncomeStatement";
            this.incomeStatement1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "IncomeStatement";
            reportDataSource1.Value = this.reportIncomeStatementBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TradingSolutions.Reports.IncomeStatement.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1370, 750);
            this.reportViewer1.TabIndex = 13;
            // 
            // reportIncomeStatementTableAdapter
            // 
            this.reportIncomeStatementTableAdapter.ClearBeforeFill = true;
            // 
            // IncomeStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.reportViewer1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "IncomeStatement";
            this.Text = "MetroForm";
            this.Load += new System.EventHandler(this.IncomeStatement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportIncomeStatementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeStatement1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reportIncomeStatementBindingSource;
        private ReportDataSets.IncomeStatement incomeStatement1;
        private ReportDataSets.IncomeStatementTableAdapters.ReportIncomeStatementTableAdapter reportIncomeStatementTableAdapter;
    }
}