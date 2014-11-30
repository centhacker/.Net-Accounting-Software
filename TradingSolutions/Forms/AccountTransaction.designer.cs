namespace TradingSolutions.Forms
{
    partial class AccountTransaction
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
            this.txt_type = new System.Windows.Forms.ComboBox();
            this.txt_expense = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lab_bank_acctype = new DevComponents.DotNetBar.LabelX();
            this.lab_bank_accname = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.txtRefrence = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grid_bank = new Telerik.WinControls.UI.RadGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_bank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_bank.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_type
            // 
            this.txt_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_type.FormattingEnabled = true;
            this.txt_type.Location = new System.Drawing.Point(165, 432);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(346, 21);
            this.txt_type.TabIndex = 42;
            // 
            // txt_expense
            // 
            this.txt_expense.AcceptsReturn = true;
            this.txt_expense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            // 
            // 
            // 
            this.txt_expense.Border.Class = "TextBoxBorder";
            this.txt_expense.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_expense.FocusHighlightColor = System.Drawing.Color.LightSteelBlue;
            this.txt_expense.FocusHighlightEnabled = true;
            this.txt_expense.ForeColor = System.Drawing.Color.Black;
            this.txt_expense.Location = new System.Drawing.Point(165, 389);
            this.txt_expense.Name = "txt_expense";
            this.txt_expense.Size = new System.Drawing.Size(346, 22);
            this.txt_expense.TabIndex = 41;
            // 
            // lab_bank_acctype
            // 
            this.lab_bank_acctype.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.lab_bank_acctype.BackgroundStyle.Class = "";
            this.lab_bank_acctype.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_bank_acctype.ForeColor = System.Drawing.Color.Black;
            this.lab_bank_acctype.Location = new System.Drawing.Point(22, 432);
            this.lab_bank_acctype.Name = "lab_bank_acctype";
            this.lab_bank_acctype.Size = new System.Drawing.Size(102, 23);
            this.lab_bank_acctype.TabIndex = 39;
            this.lab_bank_acctype.Text = "Transaction Type";
            // 
            // lab_bank_accname
            // 
            this.lab_bank_accname.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.lab_bank_accname.BackgroundStyle.Class = "";
            this.lab_bank_accname.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_bank_accname.ForeColor = System.Drawing.Color.Black;
            this.lab_bank_accname.Location = new System.Drawing.Point(22, 391);
            this.lab_bank_accname.Name = "lab_bank_accname";
            this.lab_bank_accname.Size = new System.Drawing.Size(112, 23);
            this.lab_bank_accname.TabIndex = 38;
            this.lab_bank_accname.Text = "Total";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(165, 570);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(223, 68);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 43;
            this.buttonX1.Text = "Insert Total";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // txtRefrence
            // 
            this.txtRefrence.AcceptsReturn = true;
            this.txtRefrence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            // 
            // 
            // 
            this.txtRefrence.Border.Class = "TextBoxBorder";
            this.txtRefrence.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRefrence.FocusHighlightColor = System.Drawing.Color.LightSteelBlue;
            this.txtRefrence.FocusHighlightEnabled = true;
            this.txtRefrence.ForeColor = System.Drawing.Color.Black;
            this.txtRefrence.Location = new System.Drawing.Point(165, 347);
            this.txtRefrence.Name = "txtRefrence";
            this.txtRefrence.Size = new System.Drawing.Size(346, 22);
            this.txtRefrence.TabIndex = 45;
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
            this.labelX1.Location = new System.Drawing.Point(22, 349);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(112, 23);
            this.labelX1.TabIndex = 44;
            this.labelX1.Text = "Refrence";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grid_bank);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1346, 310);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ACCOUNT TRANSACTION";
            // 
            // grid_bank
            // 
            this.grid_bank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_bank.EnableFastScrolling = true;
            this.grid_bank.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_bank.Location = new System.Drawing.Point(3, 18);
            // 
            // grid_bank
            // 
            this.grid_bank.MasterTemplate.AllowAddNewRow = false;
            this.grid_bank.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.grid_bank.MasterTemplate.AllowColumnReorder = false;
            this.grid_bank.MasterTemplate.AllowDeleteRow = false;
            this.grid_bank.MasterTemplate.AllowDragToGroup = false;
            this.grid_bank.MasterTemplate.AllowEditRow = false;
            this.grid_bank.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.grid_bank.MasterTemplate.EnableFiltering = true;
            this.grid_bank.Name = "grid_bank";
            this.grid_bank.ShowGroupPanel = false;
            this.grid_bank.Size = new System.Drawing.Size(1340, 289);
            this.grid_bank.TabIndex = 1;
            // 
            // AccountTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtRefrence);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.txt_expense);
            this.Controls.Add(this.lab_bank_acctype);
            this.Controls.Add(this.lab_bank_accname);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AccountTransaction";
            this.Text = "MetroForm";
            this.Load += new System.EventHandler(this.AccountTransaction_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_bank.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_bank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox txt_type;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_expense;
        private DevComponents.DotNetBar.LabelX lab_bank_acctype;
        private DevComponents.DotNetBar.LabelX lab_bank_accname;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRefrence;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadGridView grid_bank;
    }
}