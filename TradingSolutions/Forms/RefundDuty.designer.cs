namespace TradingSolutions.Forms
{
    partial class RefundDuty
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
            this.grid_invoices = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_invoice_no = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_payment = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_bank_accno = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_payment = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lab_bank_accno = new DevComponents.DotNetBar.LabelX();
            this.lab_bank_id = new DevComponents.DotNetBar.LabelX();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grd_accounts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_invoices)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_accounts)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_invoices
            // 
            this.grid_invoices.AllowUserToAddRows = false;
            this.grid_invoices.AllowUserToDeleteRows = false;
            this.grid_invoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_invoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_invoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_invoices.Location = new System.Drawing.Point(3, 18);
            this.grid_invoices.Name = "grid_invoices";
            this.grid_invoices.ReadOnly = true;
            this.grid_invoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_invoices.Size = new System.Drawing.Size(1352, 361);
            this.grid_invoices.TabIndex = 0;
            this.grid_invoices.SelectionChanged += new System.EventHandler(this.grid_invoices_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grid_invoices);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1358, 382);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice";
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
            this.txt_invoice_no.Location = new System.Drawing.Point(158, 587);
            this.txt_invoice_no.Name = "txt_invoice_no";
            this.txt_invoice_no.ReadOnly = true;
            this.txt_invoice_no.Size = new System.Drawing.Size(346, 22);
            this.txt_invoice_no.TabIndex = 54;
            // 
            // btn_payment
            // 
            this.btn_payment.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_payment.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_payment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payment.Location = new System.Drawing.Point(15, 451);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(251, 35);
            this.btn_payment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_payment.TabIndex = 53;
            this.btn_payment.Text = "Record Payment";
            this.btn_payment.Click += new System.EventHandler(this.btn_payment_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(15, 587);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(112, 23);
            this.labelX1.TabIndex = 52;
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
            this.txt_bank_accno.Location = new System.Drawing.Point(158, 548);
            this.txt_bank_accno.Name = "txt_bank_accno";
            this.txt_bank_accno.ReadOnly = true;
            this.txt_bank_accno.Size = new System.Drawing.Size(346, 22);
            this.txt_bank_accno.TabIndex = 51;
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
            this.txt_payment.Location = new System.Drawing.Point(158, 507);
            this.txt_payment.Name = "txt_payment";
            this.txt_payment.Size = new System.Drawing.Size(346, 22);
            this.txt_payment.TabIndex = 50;
            // 
            // lab_bank_accno
            // 
            this.lab_bank_accno.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lab_bank_accno.BackgroundStyle.Class = "";
            this.lab_bank_accno.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_bank_accno.ForeColor = System.Drawing.Color.Black;
            this.lab_bank_accno.Location = new System.Drawing.Point(15, 551);
            this.lab_bank_accno.Name = "lab_bank_accno";
            this.lab_bank_accno.Size = new System.Drawing.Size(112, 23);
            this.lab_bank_accno.TabIndex = 49;
            this.lab_bank_accno.Text = "Account Number";
            // 
            // lab_bank_id
            // 
            this.lab_bank_id.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lab_bank_id.BackgroundStyle.Class = "";
            this.lab_bank_id.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_bank_id.ForeColor = System.Drawing.Color.Black;
            this.lab_bank_id.Location = new System.Drawing.Point(15, 509);
            this.lab_bank_id.Name = "lab_bank_id";
            this.lab_bank_id.Size = new System.Drawing.Size(75, 23);
            this.lab_bank_id.TabIndex = 48;
            this.lab_bank_id.Text = "Payment";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grd_accounts);
            this.groupBox4.Location = new System.Drawing.Point(547, 431);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(792, 307);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Account";
            // 
            // grd_accounts
            // 
            this.grd_accounts.AllowUserToAddRows = false;
            this.grd_accounts.AllowUserToDeleteRows = false;
            this.grd_accounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_accounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_accounts.Location = new System.Drawing.Point(3, 18);
            this.grd_accounts.Name = "grd_accounts";
            this.grd_accounts.ReadOnly = true;
            this.grd_accounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_accounts.Size = new System.Drawing.Size(786, 286);
            this.grd_accounts.TabIndex = 1;
            this.grd_accounts.SelectionChanged += new System.EventHandler(this.grd_accounts_SelectionChanged);
            // 
            // RefundDuty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.txt_invoice_no);
            this.Controls.Add(this.btn_payment);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txt_bank_accno);
            this.Controls.Add(this.txt_payment);
            this.Controls.Add(this.lab_bank_accno);
            this.Controls.Add(this.lab_bank_id);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RefundDuty";
            this.Text = "MetroForm";
            this.Load += new System.EventHandler(this.RefundDuty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_invoices)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_accounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_invoices;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_invoice_no;
        private DevComponents.DotNetBar.ButtonX btn_payment;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_bank_accno;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_payment;
        private DevComponents.DotNetBar.LabelX lab_bank_accno;
        private DevComponents.DotNetBar.LabelX lab_bank_id;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView grd_accounts;
    }
}