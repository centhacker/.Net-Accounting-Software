namespace TradingSolutions.Reports
{
    partial class GeneralJournal
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
            this.reportGeneralJournal = new TradingSolutions.ReportDataSets.ReportGeneralJournal();
            this.reportGeneralJournalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportGeneralJournalTableAdapter = new TradingSolutions.ReportDataSets.ReportGeneralJournalTableAdapters.ReportGeneralJournalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportGeneralJournal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportGeneralJournalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "GeneralJournalDS";
            reportDataSource1.Value = this.reportGeneralJournalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TradingSolutions.Reports.GeneralJournal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1370, 750);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // reportGeneralJournal
            // 
            this.reportGeneralJournal.DataSetName = "ReportGeneralJournal";
            this.reportGeneralJournal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportGeneralJournalBindingSource
            // 
            this.reportGeneralJournalBindingSource.DataMember = "ReportGeneralJournal";
            this.reportGeneralJournalBindingSource.DataSource = this.reportGeneralJournal;
            // 
            // reportGeneralJournalTableAdapter
            // 
            this.reportGeneralJournalTableAdapter.ClearBeforeFill = true;
            // 
            // GeneralJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.reportViewer1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GeneralJournal";
            this.Text = "MetroForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GeneralJournal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportGeneralJournal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportGeneralJournalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reportGeneralJournalBindingSource;
        private ReportDataSets.ReportGeneralJournal reportGeneralJournal;
        private ReportDataSets.ReportGeneralJournalTableAdapters.ReportGeneralJournalTableAdapter reportGeneralJournalTableAdapter;
    }
}