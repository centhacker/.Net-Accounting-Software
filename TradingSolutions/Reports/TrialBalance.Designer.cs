namespace TradingSolutions.Reports
{
    partial class TrialBalance
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.generateTrialBalanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trialBalance1 = new TradingSolutions.ReportDataSets.TrialBalance();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.generateTrialBalanceTableAdapter = new TradingSolutions.ReportDataSets.TrialBalanceTableAdapters.GenerateTrialBalanceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.generateTrialBalanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trialBalance1)).BeginInit();
            this.SuspendLayout();
            // 
            // generateTrialBalanceBindingSource
            // 
            this.generateTrialBalanceBindingSource.DataMember = "GenerateTrialBalance";
            this.generateTrialBalanceBindingSource.DataSource = this.trialBalance1;
            // 
            // trialBalance1
            // 
            this.trialBalance1.DataSetName = "TrialBalance";
            this.trialBalance1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "TrialBalanceDS";
            reportDataSource2.Value = this.generateTrialBalanceBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TradingSolutions.Reports.TrialBalance.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1362, 742);
            this.reportViewer1.TabIndex = 0;
            // 
            // generateTrialBalanceTableAdapter
            // 
            this.generateTrialBalanceTableAdapter.ClearBeforeFill = true;
            // 
            // TrialBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 742);
            this.Controls.Add(this.reportViewer1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TrialBalance";
            this.Text = "MetroForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TrialBalance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.generateTrialBalanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trialBalance1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ReportDataSets.TrialBalance trialBalance1;
        private System.Windows.Forms.BindingSource generateTrialBalanceBindingSource;
        private ReportDataSets.TrialBalanceTableAdapters.GenerateTrialBalanceTableAdapter generateTrialBalanceTableAdapter;
    }
}