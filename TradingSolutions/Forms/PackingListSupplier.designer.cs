namespace TradingSolutions.Forms
{
    partial class PackingListSupplier
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
            this.btn_payment = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_packinglist = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lab_bank_id = new DevComponents.DotNetBar.LabelX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grid_invoices = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_invoices)).BeginInit();
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
            this.txt_invoice_no.Location = new System.Drawing.Point(146, 587);
            this.txt_invoice_no.Name = "txt_invoice_no";
            this.txt_invoice_no.ReadOnly = true;
            this.txt_invoice_no.Size = new System.Drawing.Size(346, 22);
            this.txt_invoice_no.TabIndex = 66;
            // 
            // btn_payment
            // 
            this.btn_payment.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_payment.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_payment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payment.Location = new System.Drawing.Point(3, 451);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(251, 35);
            this.btn_payment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_payment.TabIndex = 65;
            this.btn_payment.Text = "Record LIST";
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
            this.labelX1.Location = new System.Drawing.Point(3, 587);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(112, 23);
            this.labelX1.TabIndex = 64;
            this.labelX1.Text = "Invoice Number";
            // 
            // txt_packinglist
            // 
            this.txt_packinglist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            // 
            // 
            // 
            this.txt_packinglist.Border.Class = "TextBoxBorder";
            this.txt_packinglist.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_packinglist.FocusHighlightColor = System.Drawing.Color.LightSteelBlue;
            this.txt_packinglist.FocusHighlightEnabled = true;
            this.txt_packinglist.ForeColor = System.Drawing.Color.Black;
            this.txt_packinglist.Location = new System.Drawing.Point(146, 507);
            this.txt_packinglist.Name = "txt_packinglist";
            this.txt_packinglist.Size = new System.Drawing.Size(346, 22);
            this.txt_packinglist.TabIndex = 63;
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
            this.lab_bank_id.Location = new System.Drawing.Point(3, 509);
            this.lab_bank_id.Name = "lab_bank_id";
            this.lab_bank_id.Size = new System.Drawing.Size(75, 23);
            this.lab_bank_id.TabIndex = 62;
            this.lab_bank_id.Text = "Packing List";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grid_invoices);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1358, 382);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice";
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
            // PackingListSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.txt_invoice_no);
            this.Controls.Add(this.btn_payment);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txt_packinglist);
            this.Controls.Add(this.lab_bank_id);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PackingListSupplier";
            this.Text = "MetroForm";
            this.Load += new System.EventHandler(this.PackingListSupplier_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_invoices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txt_invoice_no;
        private DevComponents.DotNetBar.ButtonX btn_payment;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_packinglist;
        private DevComponents.DotNetBar.LabelX lab_bank_id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grid_invoices;
    }
}