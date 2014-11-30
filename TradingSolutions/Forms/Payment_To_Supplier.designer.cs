namespace TradingSolutions.Forms
{
    partial class Payment_To_Supplier
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
            this.txt_invoice_no = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_Relaod = new DevComponents.DotNetBar.ButtonX();
            this.btn_payment = new DevComponents.DotNetBar.ButtonX();
            this.combox_paytype = new System.Windows.Forms.ComboBox();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_bank_accno = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_payment = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lab_bank_accno = new DevComponents.DotNetBar.LabelX();
            this.lab_bank_id = new DevComponents.DotNetBar.LabelX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grid_invoices = new Telerik.WinControls.UI.RadGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grd_accounts = new Telerik.WinControls.UI.RadGridView();
            this.grd_details = new Telerik.WinControls.UI.RadGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_invoices)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_accounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_details)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_invoice_no
            // 
            this.txt_invoice_no.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            // 
            // 
            // 
            this.txt_invoice_no.Border.Class = "TextBoxBorder";
            this.txt_invoice_no.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_invoice_no.FocusHighlightColor = System.Drawing.Color.LightSteelBlue;
            this.txt_invoice_no.FocusHighlightEnabled = true;
            this.txt_invoice_no.ForeColor = System.Drawing.Color.Black;
            this.txt_invoice_no.Location = new System.Drawing.Point(155, 148);
            this.txt_invoice_no.Name = "txt_invoice_no";
            this.txt_invoice_no.ReadOnly = true;
            this.txt_invoice_no.Size = new System.Drawing.Size(346, 22);
            this.txt_invoice_no.TabIndex = 58;
            // 
            // btn_Relaod
            // 
            this.btn_Relaod.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Relaod.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Relaod.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Relaod.Location = new System.Drawing.Point(269, 12);
            this.btn_Relaod.Name = "btn_Relaod";
            this.btn_Relaod.Size = new System.Drawing.Size(251, 35);
            this.btn_Relaod.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Relaod.TabIndex = 57;
            this.btn_Relaod.Text = "Reload Data";
            // 
            // btn_payment
            // 
            this.btn_payment.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_payment.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_payment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payment.Location = new System.Drawing.Point(12, 12);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(251, 35);
            this.btn_payment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_payment.TabIndex = 56;
            this.btn_payment.Text = "Record Payment";
            this.btn_payment.Click += new System.EventHandler(this.btn_payment_Click);
            // 
            // combox_paytype
            // 
            this.combox_paytype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.combox_paytype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_paytype.ForeColor = System.Drawing.Color.Black;
            this.combox_paytype.FormattingEnabled = true;
            this.combox_paytype.Location = new System.Drawing.Point(155, 224);
            this.combox_paytype.Name = "combox_paytype";
            this.combox_paytype.Size = new System.Drawing.Size(346, 21);
            this.combox_paytype.TabIndex = 55;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(12, 224);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(112, 23);
            this.labelX3.TabIndex = 54;
            this.labelX3.Text = "Payment Type";
            // 
            // textBoxX1
            // 
            this.textBoxX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.FocusHighlightColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxX1.FocusHighlightEnabled = true;
            this.textBoxX1.ForeColor = System.Drawing.Color.Black;
            this.textBoxX1.Location = new System.Drawing.Point(155, 185);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(346, 22);
            this.textBoxX1.TabIndex = 53;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(12, 185);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(112, 23);
            this.labelX2.TabIndex = 52;
            this.labelX2.Text = "Voucher Number";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(12, 148);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(112, 23);
            this.labelX1.TabIndex = 51;
            this.labelX1.Text = "Invoice Number";
            // 
            // txt_bank_accno
            // 
            this.txt_bank_accno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            // 
            // 
            // 
            this.txt_bank_accno.Border.Class = "TextBoxBorder";
            this.txt_bank_accno.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_bank_accno.FocusHighlightColor = System.Drawing.Color.LightSteelBlue;
            this.txt_bank_accno.FocusHighlightEnabled = true;
            this.txt_bank_accno.ForeColor = System.Drawing.Color.Black;
            this.txt_bank_accno.Location = new System.Drawing.Point(155, 109);
            this.txt_bank_accno.Name = "txt_bank_accno";
            this.txt_bank_accno.ReadOnly = true;
            this.txt_bank_accno.Size = new System.Drawing.Size(346, 22);
            this.txt_bank_accno.TabIndex = 50;
            // 
            // txt_payment
            // 
            this.txt_payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            // 
            // 
            // 
            this.txt_payment.Border.Class = "TextBoxBorder";
            this.txt_payment.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_payment.FocusHighlightColor = System.Drawing.Color.LightSteelBlue;
            this.txt_payment.FocusHighlightEnabled = true;
            this.txt_payment.ForeColor = System.Drawing.Color.Black;
            this.txt_payment.Location = new System.Drawing.Point(155, 68);
            this.txt_payment.Name = "txt_payment";
            this.txt_payment.Size = new System.Drawing.Size(346, 22);
            this.txt_payment.TabIndex = 49;
            // 
            // lab_bank_accno
            // 
            this.lab_bank_accno.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.lab_bank_accno.BackgroundStyle.Class = "";
            this.lab_bank_accno.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_bank_accno.ForeColor = System.Drawing.Color.Black;
            this.lab_bank_accno.Location = new System.Drawing.Point(12, 112);
            this.lab_bank_accno.Name = "lab_bank_accno";
            this.lab_bank_accno.Size = new System.Drawing.Size(112, 23);
            this.lab_bank_accno.TabIndex = 48;
            this.lab_bank_accno.Text = "Account Number";
            // 
            // lab_bank_id
            // 
            this.lab_bank_id.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.lab_bank_id.BackgroundStyle.Class = "";
            this.lab_bank_id.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_bank_id.ForeColor = System.Drawing.Color.Black;
            this.lab_bank_id.Location = new System.Drawing.Point(12, 70);
            this.lab_bank_id.Name = "lab_bank_id";
            this.lab_bank_id.Size = new System.Drawing.Size(75, 23);
            this.lab_bank_id.TabIndex = 47;
            this.lab_bank_id.Text = "Payment";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grid_invoices);
            this.groupBox1.Location = new System.Drawing.Point(15, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1287, 168);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INVOICES";
            // 
            // grid_invoices
            // 
            this.grid_invoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_invoices.EnableFastScrolling = true;
            this.grid_invoices.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_invoices.Location = new System.Drawing.Point(3, 18);
            // 
            // grid_invoices
            // 
            this.grid_invoices.MasterTemplate.AllowAddNewRow = false;
            this.grid_invoices.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.grid_invoices.MasterTemplate.AllowColumnReorder = false;
            this.grid_invoices.MasterTemplate.AllowDeleteRow = false;
            this.grid_invoices.MasterTemplate.AllowDragToGroup = false;
            this.grid_invoices.MasterTemplate.AllowEditRow = false;
            this.grid_invoices.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.grid_invoices.MasterTemplate.EnableFiltering = true;
            this.grid_invoices.Name = "grid_invoices";
            this.grid_invoices.ShowGroupPanel = false;
            this.grid_invoices.Size = new System.Drawing.Size(1281, 147);
            this.grid_invoices.TabIndex = 1;
            this.grid_invoices.SelectionChanged += new System.EventHandler(this.grid_invoices_SelectionChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grd_accounts);
            this.groupBox4.Location = new System.Drawing.Point(513, 40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(792, 179);
            this.groupBox4.TabIndex = 60;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Account";
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
            this.grd_accounts.Size = new System.Drawing.Size(786, 158);
            this.grd_accounts.TabIndex = 2;
            this.grd_accounts.SelectionChanged += new System.EventHandler(this.grd_accounts_SelectionChanged);
            // 
            // grd_details
            // 
            this.grd_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_details.EnableFastScrolling = true;
            this.grd_details.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_details.Location = new System.Drawing.Point(3, 18);
            // 
            // grd_details
            // 
            this.grd_details.MasterTemplate.AllowAddNewRow = false;
            this.grd_details.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.grd_details.MasterTemplate.AllowColumnReorder = false;
            this.grd_details.MasterTemplate.AllowDeleteRow = false;
            this.grd_details.MasterTemplate.AllowDragToGroup = false;
            this.grd_details.MasterTemplate.AllowEditRow = false;
            this.grd_details.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.grd_details.MasterTemplate.EnableFiltering = true;
            this.grd_details.Name = "grd_details";
            this.grd_details.ShowGroupPanel = false;
            this.grd_details.Size = new System.Drawing.Size(1287, 298);
            this.grd_details.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grd_details);
            this.groupBox3.Location = new System.Drawing.Point(12, 396);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1293, 319);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Details";
            // 
            // Payment_To_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1317, 727);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txt_invoice_no);
            this.Controls.Add(this.btn_Relaod);
            this.Controls.Add(this.btn_payment);
            this.Controls.Add(this.combox_paytype);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txt_bank_accno);
            this.Controls.Add(this.txt_payment);
            this.Controls.Add(this.lab_bank_accno);
            this.Controls.Add(this.lab_bank_id);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Payment_To_Supplier";
            this.Text = "MetroForm";
            this.Load += new System.EventHandler(this.Payment_To_Supplier_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_invoices)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_accounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_details)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txt_invoice_no;
        private DevComponents.DotNetBar.ButtonX btn_Relaod;
        private DevComponents.DotNetBar.ButtonX btn_payment;
        private System.Windows.Forms.ComboBox combox_paytype;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_bank_accno;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_payment;
        private DevComponents.DotNetBar.LabelX lab_bank_accno;
        private DevComponents.DotNetBar.LabelX lab_bank_id;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadGridView grid_invoices;
        private System.Windows.Forms.GroupBox groupBox4;
        private Telerik.WinControls.UI.RadGridView grd_accounts;
        private Telerik.WinControls.UI.RadGridView grd_details;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}