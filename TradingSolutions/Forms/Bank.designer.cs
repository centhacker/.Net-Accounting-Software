namespace TradingSolutions.Forms
{
    partial class Bank
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
            this.btn_clear = new DevComponents.DotNetBar.ButtonX();
            this.lab_bank_req1 = new DevComponents.DotNetBar.LabelX();
            this.Btn_show = new DevComponents.DotNetBar.ButtonX();
            this.btn_delete = new DevComponents.DotNetBar.ButtonX();
            this.txt_bank_address = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lab_bank_address = new DevComponents.DotNetBar.LabelX();
            this.btn_save = new DevComponents.DotNetBar.ButtonX();
            this.lab_bank_req2 = new DevComponents.DotNetBar.LabelX();
            this.lab_bank_req3 = new DevComponents.DotNetBar.LabelX();
            this.txt_bank_branch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_bank_accbal = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.grp_bank_1 = new System.Windows.Forms.GroupBox();
            this.lab_bank_email = new DevComponents.DotNetBar.LabelX();
            this.lab_bank_req6 = new DevComponents.DotNetBar.LabelX();
            this.lab_bank_req4 = new DevComponents.DotNetBar.LabelX();
            this.lab_bank_req5 = new DevComponents.DotNetBar.LabelX();
            this.txt_bank_curr = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_bank_email = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_bank_no = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_bank_bracode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lab_bank_curr = new DevComponents.DotNetBar.LabelX();
            this.lab_bank_no = new DevComponents.DotNetBar.LabelX();
            this.lab_bank_bracode = new DevComponents.DotNetBar.LabelX();
            this.txt_bank_acctype = new System.Windows.Forms.ComboBox();
            this.txt_bank_accname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_bank_accno = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_bank_id = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lab_bank_branch = new DevComponents.DotNetBar.LabelX();
            this.lab_bank_accbal = new DevComponents.DotNetBar.LabelX();
            this.lab_bank_acctype = new DevComponents.DotNetBar.LabelX();
            this.lab_bank_accname = new DevComponents.DotNetBar.LabelX();
            this.lab_bank_accno = new DevComponents.DotNetBar.LabelX();
            this.lab_bank_id = new DevComponents.DotNetBar.LabelX();
            this.btn_home = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grid_bank = new Telerik.WinControls.UI.RadGridView();
            this.grp_bank_1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_bank)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_clear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(922, 364);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(125, 35);
            this.btn_clear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_clear.TabIndex = 34;
            this.btn_clear.Text = "Clear";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lab_bank_req1
            // 
            // 
            // 
            // 
            this.lab_bank_req1.BackgroundStyle.Class = "";
            this.lab_bank_req1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_bank_req1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_bank_req1.Location = new System.Drawing.Point(515, 66);
            this.lab_bank_req1.Name = "lab_bank_req1";
            this.lab_bank_req1.Size = new System.Drawing.Size(18, 23);
            this.lab_bank_req1.TabIndex = 19;
            this.lab_bank_req1.Text = "*";
            // 
            // Btn_show
            // 
            this.Btn_show.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.Btn_show.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Btn_show.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_show.Location = new System.Drawing.Point(758, 364);
            this.Btn_show.Name = "Btn_show";
            this.Btn_show.Size = new System.Drawing.Size(125, 35);
            this.Btn_show.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Btn_show.TabIndex = 33;
            this.Btn_show.Text = "Show Record";
            this.Btn_show.Click += new System.EventHandler(this.Btn_show_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_delete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(593, 364);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(125, 35);
            this.btn_delete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_delete.TabIndex = 32;
            this.btn_delete.Text = "Delete Record";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_bank_address
            // 
            this.txt_bank_address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            // 
            // 
            // 
            this.txt_bank_address.Border.Class = "TextBoxBorder";
            this.txt_bank_address.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_bank_address.FocusHighlightColor = System.Drawing.Color.LightSteelBlue;
            this.txt_bank_address.FocusHighlightEnabled = true;
            this.txt_bank_address.ForeColor = System.Drawing.Color.Black;
            this.txt_bank_address.Location = new System.Drawing.Point(163, 269);
            this.txt_bank_address.Name = "txt_bank_address";
            this.txt_bank_address.Size = new System.Drawing.Size(346, 25);
            this.txt_bank_address.TabIndex = 13;
            // 
            // lab_bank_address
            // 
            this.lab_bank_address.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.lab_bank_address.BackgroundStyle.Class = "";
            this.lab_bank_address.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_bank_address.ForeColor = System.Drawing.Color.Black;
            this.lab_bank_address.Location = new System.Drawing.Point(20, 269);
            this.lab_bank_address.Name = "lab_bank_address";
            this.lab_bank_address.Size = new System.Drawing.Size(112, 23);
            this.lab_bank_address.TabIndex = 12;
            this.lab_bank_address.Text = "Address";
            // 
            // btn_save
            // 
            this.btn_save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(445, 364);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(125, 35);
            this.btn_save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_save.TabIndex = 30;
            this.btn_save.Text = "Save Record";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lab_bank_req2
            // 
            // 
            // 
            // 
            this.lab_bank_req2.BackgroundStyle.Class = "";
            this.lab_bank_req2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_bank_req2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_bank_req2.Location = new System.Drawing.Point(515, 109);
            this.lab_bank_req2.Name = "lab_bank_req2";
            this.lab_bank_req2.Size = new System.Drawing.Size(18, 23);
            this.lab_bank_req2.TabIndex = 20;
            this.lab_bank_req2.Text = "*";
            // 
            // lab_bank_req3
            // 
            // 
            // 
            // 
            this.lab_bank_req3.BackgroundStyle.Class = "";
            this.lab_bank_req3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_bank_req3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_bank_req3.Location = new System.Drawing.Point(515, 229);
            this.lab_bank_req3.Name = "lab_bank_req3";
            this.lab_bank_req3.Size = new System.Drawing.Size(18, 23);
            this.lab_bank_req3.TabIndex = 21;
            this.lab_bank_req3.Text = "*";
            // 
            // txt_bank_branch
            // 
            this.txt_bank_branch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            // 
            // 
            // 
            this.txt_bank_branch.Border.Class = "TextBoxBorder";
            this.txt_bank_branch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_bank_branch.FocusHighlightColor = System.Drawing.Color.LightSteelBlue;
            this.txt_bank_branch.FocusHighlightEnabled = true;
            this.txt_bank_branch.ForeColor = System.Drawing.Color.Black;
            this.txt_bank_branch.Location = new System.Drawing.Point(163, 229);
            this.txt_bank_branch.Name = "txt_bank_branch";
            this.txt_bank_branch.Size = new System.Drawing.Size(346, 25);
            this.txt_bank_branch.TabIndex = 11;
            // 
            // txt_bank_accbal
            // 
            this.txt_bank_accbal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            // 
            // 
            // 
            this.txt_bank_accbal.Border.Class = "TextBoxBorder";
            this.txt_bank_accbal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_bank_accbal.FocusHighlightColor = System.Drawing.Color.LightSteelBlue;
            this.txt_bank_accbal.FocusHighlightEnabled = true;
            this.txt_bank_accbal.ForeColor = System.Drawing.Color.Black;
            this.txt_bank_accbal.Location = new System.Drawing.Point(163, 189);
            this.txt_bank_accbal.Name = "txt_bank_accbal";
            this.txt_bank_accbal.Size = new System.Drawing.Size(346, 25);
            this.txt_bank_accbal.TabIndex = 10;
            // 
            // grp_bank_1
            // 
            this.grp_bank_1.Controls.Add(this.lab_bank_email);
            this.grp_bank_1.Controls.Add(this.lab_bank_req6);
            this.grp_bank_1.Controls.Add(this.lab_bank_req4);
            this.grp_bank_1.Controls.Add(this.lab_bank_req5);
            this.grp_bank_1.Controls.Add(this.txt_bank_curr);
            this.grp_bank_1.Controls.Add(this.txt_bank_email);
            this.grp_bank_1.Controls.Add(this.txt_bank_no);
            this.grp_bank_1.Controls.Add(this.txt_bank_bracode);
            this.grp_bank_1.Controls.Add(this.lab_bank_curr);
            this.grp_bank_1.Controls.Add(this.lab_bank_no);
            this.grp_bank_1.Controls.Add(this.lab_bank_bracode);
            this.grp_bank_1.Controls.Add(this.txt_bank_acctype);
            this.grp_bank_1.Controls.Add(this.lab_bank_req3);
            this.grp_bank_1.Controls.Add(this.lab_bank_req2);
            this.grp_bank_1.Controls.Add(this.lab_bank_req1);
            this.grp_bank_1.Controls.Add(this.txt_bank_address);
            this.grp_bank_1.Controls.Add(this.lab_bank_address);
            this.grp_bank_1.Controls.Add(this.txt_bank_branch);
            this.grp_bank_1.Controls.Add(this.txt_bank_accbal);
            this.grp_bank_1.Controls.Add(this.txt_bank_accname);
            this.grp_bank_1.Controls.Add(this.txt_bank_accno);
            this.grp_bank_1.Controls.Add(this.txt_bank_id);
            this.grp_bank_1.Controls.Add(this.lab_bank_branch);
            this.grp_bank_1.Controls.Add(this.lab_bank_accbal);
            this.grp_bank_1.Controls.Add(this.lab_bank_acctype);
            this.grp_bank_1.Controls.Add(this.lab_bank_accname);
            this.grp_bank_1.Controls.Add(this.lab_bank_accno);
            this.grp_bank_1.Controls.Add(this.lab_bank_id);
            this.grp_bank_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_bank_1.Location = new System.Drawing.Point(39, 29);
            this.grp_bank_1.Name = "grp_bank_1";
            this.grp_bank_1.Size = new System.Drawing.Size(1133, 315);
            this.grp_bank_1.TabIndex = 26;
            this.grp_bank_1.TabStop = false;
            this.grp_bank_1.Text = "Info";
            // 
            // lab_bank_email
            // 
            this.lab_bank_email.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.lab_bank_email.BackgroundStyle.Class = "";
            this.lab_bank_email.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_bank_email.ForeColor = System.Drawing.Color.Black;
            this.lab_bank_email.Location = new System.Drawing.Point(615, 112);
            this.lab_bank_email.Name = "lab_bank_email";
            this.lab_bank_email.Size = new System.Drawing.Size(112, 23);
            this.lab_bank_email.TabIndex = 39;
            this.lab_bank_email.Text = "Bank Email";
            // 
            // lab_bank_req6
            // 
            // 
            // 
            // 
            this.lab_bank_req6.BackgroundStyle.Class = "";
            this.lab_bank_req6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_bank_req6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_bank_req6.Location = new System.Drawing.Point(1110, 151);
            this.lab_bank_req6.Name = "lab_bank_req6";
            this.lab_bank_req6.Size = new System.Drawing.Size(18, 23);
            this.lab_bank_req6.TabIndex = 47;
            this.lab_bank_req6.Text = "*";
            // 
            // lab_bank_req4
            // 
            // 
            // 
            // 
            this.lab_bank_req4.BackgroundStyle.Class = "";
            this.lab_bank_req4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_bank_req4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_bank_req4.Location = new System.Drawing.Point(1110, 27);
            this.lab_bank_req4.Name = "lab_bank_req4";
            this.lab_bank_req4.Size = new System.Drawing.Size(18, 23);
            this.lab_bank_req4.TabIndex = 46;
            this.lab_bank_req4.Text = "*";
            // 
            // lab_bank_req5
            // 
            // 
            // 
            // 
            this.lab_bank_req5.BackgroundStyle.Class = "";
            this.lab_bank_req5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_bank_req5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_bank_req5.Location = new System.Drawing.Point(1110, 69);
            this.lab_bank_req5.Name = "lab_bank_req5";
            this.lab_bank_req5.Size = new System.Drawing.Size(18, 23);
            this.lab_bank_req5.TabIndex = 45;
            this.lab_bank_req5.Text = "*";
            // 
            // txt_bank_curr
            // 
            this.txt_bank_curr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            // 
            // 
            // 
            this.txt_bank_curr.Border.Class = "TextBoxBorder";
            this.txt_bank_curr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_bank_curr.FocusHighlightColor = System.Drawing.Color.LightSteelBlue;
            this.txt_bank_curr.FocusHighlightEnabled = true;
            this.txt_bank_curr.ForeColor = System.Drawing.Color.Black;
            this.txt_bank_curr.Location = new System.Drawing.Point(758, 151);
            this.txt_bank_curr.Name = "txt_bank_curr";
            this.txt_bank_curr.Size = new System.Drawing.Size(346, 25);
            this.txt_bank_curr.TabIndex = 44;
            // 
            // txt_bank_email
            // 
            this.txt_bank_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            // 
            // 
            // 
            this.txt_bank_email.Border.Class = "TextBoxBorder";
            this.txt_bank_email.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_bank_email.FocusHighlightColor = System.Drawing.Color.LightSteelBlue;
            this.txt_bank_email.FocusHighlightEnabled = true;
            this.txt_bank_email.ForeColor = System.Drawing.Color.Black;
            this.txt_bank_email.Location = new System.Drawing.Point(758, 110);
            this.txt_bank_email.Name = "txt_bank_email";
            this.txt_bank_email.Size = new System.Drawing.Size(346, 25);
            this.txt_bank_email.TabIndex = 43;
            // 
            // txt_bank_no
            // 
            this.txt_bank_no.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            // 
            // 
            // 
            this.txt_bank_no.Border.Class = "TextBoxBorder";
            this.txt_bank_no.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_bank_no.FocusHighlightColor = System.Drawing.Color.LightSteelBlue;
            this.txt_bank_no.FocusHighlightEnabled = true;
            this.txt_bank_no.ForeColor = System.Drawing.Color.Black;
            this.txt_bank_no.Location = new System.Drawing.Point(758, 68);
            this.txt_bank_no.Name = "txt_bank_no";
            this.txt_bank_no.Size = new System.Drawing.Size(346, 25);
            this.txt_bank_no.TabIndex = 42;
            // 
            // txt_bank_bracode
            // 
            this.txt_bank_bracode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            // 
            // 
            // 
            this.txt_bank_bracode.Border.Class = "TextBoxBorder";
            this.txt_bank_bracode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_bank_bracode.FocusHighlightColor = System.Drawing.Color.LightSteelBlue;
            this.txt_bank_bracode.FocusHighlightEnabled = true;
            this.txt_bank_bracode.ForeColor = System.Drawing.Color.Black;
            this.txt_bank_bracode.Location = new System.Drawing.Point(758, 27);
            this.txt_bank_bracode.Name = "txt_bank_bracode";
            this.txt_bank_bracode.Size = new System.Drawing.Size(346, 25);
            this.txt_bank_bracode.TabIndex = 41;
            // 
            // lab_bank_curr
            // 
            this.lab_bank_curr.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.lab_bank_curr.BackgroundStyle.Class = "";
            this.lab_bank_curr.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_bank_curr.ForeColor = System.Drawing.Color.Black;
            this.lab_bank_curr.Location = new System.Drawing.Point(615, 153);
            this.lab_bank_curr.Name = "lab_bank_curr";
            this.lab_bank_curr.Size = new System.Drawing.Size(102, 23);
            this.lab_bank_curr.TabIndex = 40;
            this.lab_bank_curr.Text = "Currency";
            // 
            // lab_bank_no
            // 
            this.lab_bank_no.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.lab_bank_no.BackgroundStyle.Class = "";
            this.lab_bank_no.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_bank_no.ForeColor = System.Drawing.Color.Black;
            this.lab_bank_no.Location = new System.Drawing.Point(615, 71);
            this.lab_bank_no.Name = "lab_bank_no";
            this.lab_bank_no.Size = new System.Drawing.Size(112, 23);
            this.lab_bank_no.TabIndex = 38;
            this.lab_bank_no.Text = "Bank Number";
            // 
            // lab_bank_bracode
            // 
            this.lab_bank_bracode.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.lab_bank_bracode.BackgroundStyle.Class = "";
            this.lab_bank_bracode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_bank_bracode.ForeColor = System.Drawing.Color.Black;
            this.lab_bank_bracode.Location = new System.Drawing.Point(615, 29);
            this.lab_bank_bracode.Name = "lab_bank_bracode";
            this.lab_bank_bracode.Size = new System.Drawing.Size(84, 23);
            this.lab_bank_bracode.TabIndex = 37;
            this.lab_bank_bracode.Text = "Branch Code";
            // 
            // txt_bank_acctype
            // 
            this.txt_bank_acctype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_bank_acctype.FormattingEnabled = true;
            this.txt_bank_acctype.Location = new System.Drawing.Point(163, 150);
            this.txt_bank_acctype.Name = "txt_bank_acctype";
            this.txt_bank_acctype.Size = new System.Drawing.Size(346, 25);
            this.txt_bank_acctype.TabIndex = 36;
            // 
            // txt_bank_accname
            // 
            this.txt_bank_accname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            // 
            // 
            // 
            this.txt_bank_accname.Border.Class = "TextBoxBorder";
            this.txt_bank_accname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_bank_accname.FocusHighlightColor = System.Drawing.Color.LightSteelBlue;
            this.txt_bank_accname.FocusHighlightEnabled = true;
            this.txt_bank_accname.ForeColor = System.Drawing.Color.Black;
            this.txt_bank_accname.Location = new System.Drawing.Point(163, 107);
            this.txt_bank_accname.Name = "txt_bank_accname";
            this.txt_bank_accname.Size = new System.Drawing.Size(346, 25);
            this.txt_bank_accname.TabIndex = 8;
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
            this.txt_bank_accno.Location = new System.Drawing.Point(163, 65);
            this.txt_bank_accno.Name = "txt_bank_accno";
            this.txt_bank_accno.Size = new System.Drawing.Size(346, 25);
            this.txt_bank_accno.TabIndex = 7;
            // 
            // txt_bank_id
            // 
            this.txt_bank_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            // 
            // 
            // 
            this.txt_bank_id.Border.Class = "TextBoxBorder";
            this.txt_bank_id.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_bank_id.FocusHighlightColor = System.Drawing.Color.LightSteelBlue;
            this.txt_bank_id.FocusHighlightEnabled = true;
            this.txt_bank_id.ForeColor = System.Drawing.Color.Black;
            this.txt_bank_id.Location = new System.Drawing.Point(163, 24);
            this.txt_bank_id.Name = "txt_bank_id";
            this.txt_bank_id.Size = new System.Drawing.Size(346, 25);
            this.txt_bank_id.TabIndex = 6;
            // 
            // lab_bank_branch
            // 
            this.lab_bank_branch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.lab_bank_branch.BackgroundStyle.Class = "";
            this.lab_bank_branch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_bank_branch.ForeColor = System.Drawing.Color.Black;
            this.lab_bank_branch.Location = new System.Drawing.Point(20, 231);
            this.lab_bank_branch.Name = "lab_bank_branch";
            this.lab_bank_branch.Size = new System.Drawing.Size(112, 23);
            this.lab_bank_branch.TabIndex = 5;
            this.lab_bank_branch.Text = "Branch";
            // 
            // lab_bank_accbal
            // 
            this.lab_bank_accbal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.lab_bank_accbal.BackgroundStyle.Class = "";
            this.lab_bank_accbal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_bank_accbal.ForeColor = System.Drawing.Color.Black;
            this.lab_bank_accbal.Location = new System.Drawing.Point(20, 191);
            this.lab_bank_accbal.Name = "lab_bank_accbal";
            this.lab_bank_accbal.Size = new System.Drawing.Size(121, 23);
            this.lab_bank_accbal.TabIndex = 4;
            this.lab_bank_accbal.Text = "Opening Balance";
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
            this.lab_bank_acctype.Location = new System.Drawing.Point(20, 150);
            this.lab_bank_acctype.Name = "lab_bank_acctype";
            this.lab_bank_acctype.Size = new System.Drawing.Size(102, 23);
            this.lab_bank_acctype.TabIndex = 3;
            this.lab_bank_acctype.Text = "Account Type";
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
            this.lab_bank_accname.Location = new System.Drawing.Point(20, 109);
            this.lab_bank_accname.Name = "lab_bank_accname";
            this.lab_bank_accname.Size = new System.Drawing.Size(112, 23);
            this.lab_bank_accname.TabIndex = 2;
            this.lab_bank_accname.Text = "Account Name";
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
            this.lab_bank_accno.Location = new System.Drawing.Point(20, 68);
            this.lab_bank_accno.Name = "lab_bank_accno";
            this.lab_bank_accno.Size = new System.Drawing.Size(112, 23);
            this.lab_bank_accno.TabIndex = 1;
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
            this.lab_bank_id.Location = new System.Drawing.Point(20, 26);
            this.lab_bank_id.Name = "lab_bank_id";
            this.lab_bank_id.Size = new System.Drawing.Size(75, 23);
            this.lab_bank_id.TabIndex = 0;
            this.lab_bank_id.Text = "ID";
            // 
            // btn_home
            // 
            this.btn_home.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_home.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_home.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Location = new System.Drawing.Point(1082, 364);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(125, 35);
            this.btn_home.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_home.TabIndex = 35;
            this.btn_home.Text = "Home";
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grid_bank);
            this.groupBox1.Location = new System.Drawing.Point(39, 450);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1133, 220);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BANK";
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
            this.grid_bank.Size = new System.Drawing.Size(1127, 199);
            this.grid_bank.TabIndex = 1;
            this.grid_bank.SelectionChanged += new System.EventHandler(this.grid_bank_SelectionChanged_1);
            // 
            // Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1317, 727);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.Btn_show);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.grp_bank_1);
            this.Controls.Add(this.btn_home);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Bank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Bank_Load);
            this.grp_bank_1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_bank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btn_clear;
        private DevComponents.DotNetBar.LabelX lab_bank_req1;
        private DevComponents.DotNetBar.ButtonX Btn_show;
        private DevComponents.DotNetBar.ButtonX btn_delete;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_bank_address;
        private DevComponents.DotNetBar.LabelX lab_bank_address;
        private DevComponents.DotNetBar.ButtonX btn_save;
        private DevComponents.DotNetBar.LabelX lab_bank_req2;
        private DevComponents.DotNetBar.LabelX lab_bank_req3;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_bank_branch;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_bank_accbal;
        private System.Windows.Forms.GroupBox grp_bank_1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_bank_accname;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_bank_accno;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_bank_id;
        private DevComponents.DotNetBar.LabelX lab_bank_branch;
        private DevComponents.DotNetBar.LabelX lab_bank_accbal;
        private DevComponents.DotNetBar.LabelX lab_bank_acctype;
        private DevComponents.DotNetBar.LabelX lab_bank_accname;
        private DevComponents.DotNetBar.LabelX lab_bank_accno;
        private DevComponents.DotNetBar.LabelX lab_bank_id;
        private DevComponents.DotNetBar.ButtonX btn_home;
        private System.Windows.Forms.ComboBox txt_bank_acctype;
        private DevComponents.DotNetBar.LabelX lab_bank_email;
        private DevComponents.DotNetBar.LabelX lab_bank_req6;
        private DevComponents.DotNetBar.LabelX lab_bank_req4;
        private DevComponents.DotNetBar.LabelX lab_bank_req5;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_bank_curr;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_bank_email;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_bank_no;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_bank_bracode;
        private DevComponents.DotNetBar.LabelX lab_bank_curr;
        private DevComponents.DotNetBar.LabelX lab_bank_no;
        private DevComponents.DotNetBar.LabelX lab_bank_bracode;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadGridView grid_bank;
    }
}