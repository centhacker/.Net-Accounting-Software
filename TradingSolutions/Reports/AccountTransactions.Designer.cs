namespace TradingSolutions.Reports
{
    partial class AccountTransactions
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
            this.reportAccountTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountTransactions1 = new TradingSolutions.ReportDataSets.AccountTransactions();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.reportAccountTransactionTableAdapter = new TradingSolutions.ReportDataSets.AccountTransactionsTableAdapters.ReportAccountTransactionTableAdapter();
            this.grd_accounts = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.reportAccountTransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTransactions1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_accounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_accounts.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // reportAccountTransactionBindingSource
            // 
            this.reportAccountTransactionBindingSource.DataMember = "ReportAccountTransaction";
            this.reportAccountTransactionBindingSource.DataSource = this.accountTransactions1;
            // 
            // accountTransactions1
            // 
            this.accountTransactions1.DataSetName = "AccountTransactions";
            this.accountTransactions1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grd_accounts);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1346, 179);
            this.groupBox4.TabIndex = 60;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Account";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "AccountTransactionDS";
            reportDataSource1.Value = this.reportAccountTransactionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TradingSolutions.Reports.AccountTransaction.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 246);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1343, 492);
            this.reportViewer1.TabIndex = 61;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(15, 194);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(178, 46);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 62;
            this.buttonX1.Text = "Filter";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // reportAccountTransactionTableAdapter
            // 
            this.reportAccountTransactionTableAdapter.ClearBeforeFill = true;
            // 
            // grd_accounts
            // 
            this.grd_accounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_accounts.EnableFastScrolling = true;
            this.grd_accounts.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_accounts.Location = new System.Drawing.Point(3, 18);
            // 
            // grd_accounts
            // 
            this.grd_accounts.MasterTemplate.AllowAddNewRow = false;
            this.grd_accounts.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.grd_accounts.MasterTemplate.AllowColumnReorder = false;
            this.grd_accounts.MasterTemplate.AllowDeleteRow = false;
            this.grd_accounts.MasterTemplate.AllowDragToGroup = false;
            this.grd_accounts.MasterTemplate.AllowEditRow = false;
            this.grd_accounts.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.grd_accounts.MasterTemplate.EnableFiltering = true;
            this.grd_accounts.Name = "grd_accounts";
            this.grd_accounts.ShowGroupPanel = false;
            this.grd_accounts.Size = new System.Drawing.Size(1340, 158);
            this.grd_accounts.TabIndex = 3;
            // 
            // AccountTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox4);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AccountTransactions";
            this.Text = "MetroForm";
            this.Load += new System.EventHandler(this.AccountTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportAccountTransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTransactions1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_accounts.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_accounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reportAccountTransactionBindingSource;
        private ReportDataSets.AccountTransactions accountTransactions1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private ReportDataSets.AccountTransactionsTableAdapters.ReportAccountTransactionTableAdapter reportAccountTransactionTableAdapter;
        private Telerik.WinControls.UI.RadGridView grd_accounts;
    }
}