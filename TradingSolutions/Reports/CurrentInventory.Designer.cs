namespace TradingSolutions.Reports
{
    partial class CurrentInventory
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
            this.reportCurrentInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currenctInventory = new TradingSolutions.ReportDataSets.CurrenctInventory();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportCurrentInventoryTableAdapter = new TradingSolutions.ReportDataSets.CurrenctInventoryTableAdapters.ReportCurrentInventoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportCurrentInventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenctInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // reportCurrentInventoryBindingSource
            // 
            this.reportCurrentInventoryBindingSource.DataMember = "ReportCurrentInventory";
            this.reportCurrentInventoryBindingSource.DataSource = this.currenctInventory;
            // 
            // currenctInventory
            // 
            this.currenctInventory.DataSetName = "CurrenctInventory";
            this.currenctInventory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CurrentInventoryDS";
            reportDataSource1.Value = this.reportCurrentInventoryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TradingSolutions.Reports.CurrentInventory.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1317, 727);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // reportCurrentInventoryTableAdapter
            // 
            this.reportCurrentInventoryTableAdapter.ClearBeforeFill = true;
            // 
            // CurrentInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 727);
            this.Controls.Add(this.reportViewer1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CurrentInventory";
            this.Text = "MetroForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CurrentInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportCurrentInventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenctInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ReportDataSets.CurrenctInventory currenctInventory;
        private System.Windows.Forms.BindingSource reportCurrentInventoryBindingSource;
        private ReportDataSets.CurrenctInventoryTableAdapters.ReportCurrentInventoryTableAdapter reportCurrentInventoryTableAdapter;
    }
}