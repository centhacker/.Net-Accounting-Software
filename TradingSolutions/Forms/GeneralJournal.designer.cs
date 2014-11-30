namespace TradingSolutions.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grd_credit = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewDateTimeInputColumn1 = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewDoubleInputColumn1 = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txt_amount_credit = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_credit = new DevComponents.DotNetBar.ButtonX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txt_amount_debit = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_debit = new DevComponents.DotNetBar.ButtonX();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.grd_debit = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Date = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.com_acc = new System.Windows.Forms.ComboBox();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txt_note = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dtEntryDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnVaidate = new DevComponents.DotNetBar.ButtonX();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.btnClear = new DevComponents.DotNetBar.ButtonX();
            this.btnPost = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.grd_voucher = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewDateTimeInputColumn2 = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewDoubleInputColumn2 = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_credit)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_debit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEntryDate)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_voucher)).BeginInit();
            this.SuspendLayout();
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.Class = "";
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Location = new System.Drawing.Point(577, -7);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(175, 70);
            this.reflectionLabel1.TabIndex = 0;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>GENERAL</i><font color=\"#B02B2C\">JOURNAL</font></font></b>";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grd_voucher);
            this.groupBox1.Location = new System.Drawing.Point(12, 436);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1338, 294);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GENERAL VOUCHER";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.labelX5);
            this.groupBox2.Controls.Add(this.txt_amount_credit);
            this.groupBox2.Controls.Add(this.btn_credit);
            this.groupBox2.Location = new System.Drawing.Point(12, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1338, 132);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insert Account";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grd_credit);
            this.groupBox4.Location = new System.Drawing.Point(6, 50);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1323, 75);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CREDIT";
            // 
            // grd_credit
            // 
            this.grd_credit.AllowUserToAddRows = false;
            this.grd_credit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_credit.BackgroundColor = System.Drawing.Color.White;
            this.grd_credit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grd_credit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_credit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewDateTimeInputColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewDoubleInputColumn1});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_credit.DefaultCellStyle = dataGridViewCellStyle4;
            this.grd_credit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_credit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.grd_credit.Location = new System.Drawing.Point(3, 18);
            this.grd_credit.Name = "grd_credit";
            this.grd_credit.ReadOnly = true;
            this.grd_credit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_credit.Size = new System.Drawing.Size(1317, 54);
            this.grd_credit.TabIndex = 33;
            // 
            // dataGridViewDateTimeInputColumn1
            // 
            // 
            // 
            // 
            this.dataGridViewDateTimeInputColumn1.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dataGridViewDateTimeInputColumn1.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.dataGridViewDateTimeInputColumn1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dataGridViewDateTimeInputColumn1.BackgroundStyle.TextColor = System.Drawing.Color.Black;
            this.dataGridViewDateTimeInputColumn1.FillWeight = 38.57869F;
            this.dataGridViewDateTimeInputColumn1.HeaderText = "Date";
            this.dataGridViewDateTimeInputColumn1.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.dataGridViewDateTimeInputColumn1.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dataGridViewDateTimeInputColumn1.MonthCalendar.BackgroundStyle.Class = "";
            this.dataGridViewDateTimeInputColumn1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.dataGridViewDateTimeInputColumn1.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dataGridViewDateTimeInputColumn1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dataGridViewDateTimeInputColumn1.MonthCalendar.DisplayMonth = new System.DateTime(2013, 5, 1, 0, 0, 0, 0);
            this.dataGridViewDateTimeInputColumn1.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dataGridViewDateTimeInputColumn1.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dataGridViewDateTimeInputColumn1.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dataGridViewDateTimeInputColumn1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dataGridViewDateTimeInputColumn1.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dataGridViewDateTimeInputColumn1.Name = "dataGridViewDateTimeInputColumn1";
            this.dataGridViewDateTimeInputColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 38.57869F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Account ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Account Num";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 284.2639F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewDoubleInputColumn1
            // 
            // 
            // 
            // 
            this.dataGridViewDoubleInputColumn1.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dataGridViewDoubleInputColumn1.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.dataGridViewDoubleInputColumn1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dataGridViewDoubleInputColumn1.BackgroundStyle.TextColor = System.Drawing.Color.Black;
            this.dataGridViewDoubleInputColumn1.FillWeight = 38.57869F;
            this.dataGridViewDoubleInputColumn1.HeaderText = "Amount";
            this.dataGridViewDoubleInputColumn1.Increment = 1D;
            this.dataGridViewDoubleInputColumn1.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.dataGridViewDoubleInputColumn1.Name = "dataGridViewDoubleInputColumn1";
            this.dataGridViewDoubleInputColumn1.ReadOnly = true;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(12, 21);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(65, 23);
            this.labelX5.TabIndex = 41;
            this.labelX5.Text = "Amount";
            // 
            // txt_amount_credit
            // 
            this.txt_amount_credit.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_amount_credit.Border.Class = "TextBoxBorder";
            this.txt_amount_credit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_amount_credit.ForeColor = System.Drawing.Color.Black;
            this.txt_amount_credit.Location = new System.Drawing.Point(83, 21);
            this.txt_amount_credit.Name = "txt_amount_credit";
            this.txt_amount_credit.Size = new System.Drawing.Size(87, 22);
            this.txt_amount_credit.TabIndex = 40;
            // 
            // btn_credit
            // 
            this.btn_credit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_credit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_credit.Location = new System.Drawing.Point(200, 21);
            this.btn_credit.Name = "btn_credit";
            this.btn_credit.Size = new System.Drawing.Size(140, 23);
            this.btn_credit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_credit.TabIndex = 39;
            this.btn_credit.Text = "RECORD";
            this.btn_credit.Click += new System.EventHandler(this.btn_credit_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelX4);
            this.groupBox3.Controls.Add(this.txt_amount_debit);
            this.groupBox3.Controls.Add(this.btn_debit);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Location = new System.Drawing.Point(15, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1335, 133);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insert Account";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(9, 21);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(65, 23);
            this.labelX4.TabIndex = 37;
            this.labelX4.Text = "Amount";
            // 
            // txt_amount_debit
            // 
            this.txt_amount_debit.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_amount_debit.Border.Class = "TextBoxBorder";
            this.txt_amount_debit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_amount_debit.ForeColor = System.Drawing.Color.Black;
            this.txt_amount_debit.Location = new System.Drawing.Point(80, 22);
            this.txt_amount_debit.Name = "txt_amount_debit";
            this.txt_amount_debit.Size = new System.Drawing.Size(87, 22);
            this.txt_amount_debit.TabIndex = 36;
            // 
            // btn_debit
            // 
            this.btn_debit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_debit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_debit.Location = new System.Drawing.Point(197, 21);
            this.btn_debit.Name = "btn_debit";
            this.btn_debit.Size = new System.Drawing.Size(140, 23);
            this.btn_debit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_debit.TabIndex = 6;
            this.btn_debit.Text = "RECORD";
            this.btn_debit.Click += new System.EventHandler(this.btn_debit_Click_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.grd_debit);
            this.groupBox5.Location = new System.Drawing.Point(5, 50);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1323, 75);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DEBIT";
            // 
            // grd_debit
            // 
            this.grd_debit.AllowUserToAddRows = false;
            this.grd_debit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_debit.BackgroundColor = System.Drawing.Color.White;
            this.grd_debit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grd_debit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_debit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Account,
            this.Account_num,
            this.Description,
            this.Amount});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_debit.DefaultCellStyle = dataGridViewCellStyle5;
            this.grd_debit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_debit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.grd_debit.Location = new System.Drawing.Point(3, 18);
            this.grd_debit.Name = "grd_debit";
            this.grd_debit.ReadOnly = true;
            this.grd_debit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_debit.Size = new System.Drawing.Size(1317, 54);
            this.grd_debit.TabIndex = 33;
            // 
            // Date
            // 
            // 
            // 
            // 
            this.Date.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.Date.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.Date.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Date.BackgroundStyle.TextColor = System.Drawing.Color.Black;
            this.Date.FillWeight = 38.57869F;
            this.Date.HeaderText = "Date";
            this.Date.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.Date.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.Date.MonthCalendar.BackgroundStyle.Class = "";
            this.Date.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.Date.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.Date.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Date.MonthCalendar.DisplayMonth = new System.DateTime(2013, 5, 1, 0, 0, 0, 0);
            this.Date.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.Date.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.Date.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.Date.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Date.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Account
            // 
            this.Account.FillWeight = 38.57869F;
            this.Account.HeaderText = "Account ID";
            this.Account.Name = "Account";
            this.Account.ReadOnly = true;
            // 
            // Account_num
            // 
            this.Account_num.HeaderText = "Account Num";
            this.Account_num.Name = "Account_num";
            this.Account_num.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.FillWeight = 284.2639F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Amount
            // 
            // 
            // 
            // 
            this.Amount.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.Amount.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.Amount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Amount.BackgroundStyle.TextColor = System.Drawing.Color.Black;
            this.Amount.FillWeight = 38.57869F;
            this.Amount.HeaderText = "Amount";
            this.Amount.Increment = 1D;
            this.Amount.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // com_acc
            // 
            this.com_acc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_acc.FormattingEnabled = true;
            this.com_acc.Location = new System.Drawing.Point(364, 15);
            this.com_acc.Name = "com_acc";
            this.com_acc.Size = new System.Drawing.Size(346, 21);
            this.com_acc.TabIndex = 46;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(293, 14);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(65, 23);
            this.labelX3.TabIndex = 45;
            this.labelX3.Text = "Account";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(716, 15);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            this.labelX2.TabIndex = 44;
            this.labelX2.Text = "Note";
            // 
            // txt_note
            // 
            this.txt_note.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_note.Border.Class = "TextBoxBorder";
            this.txt_note.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_note.ForeColor = System.Drawing.Color.Black;
            this.txt_note.Location = new System.Drawing.Point(787, 14);
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(333, 22);
            this.txt_note.TabIndex = 43;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(6, 15);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(65, 23);
            this.labelX1.TabIndex = 42;
            this.labelX1.Text = "Entry Date";
            // 
            // dtEntryDate
            // 
            // 
            // 
            // 
            this.dtEntryDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtEntryDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEntryDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtEntryDate.ButtonDropDown.Visible = true;
            this.dtEntryDate.IsPopupCalendarOpen = false;
            this.dtEntryDate.Location = new System.Drawing.Point(78, 15);
            // 
            // 
            // 
            this.dtEntryDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtEntryDate.MonthCalendar.BackgroundStyle.Class = "";
            this.dtEntryDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEntryDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtEntryDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtEntryDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtEntryDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtEntryDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtEntryDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtEntryDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtEntryDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtEntryDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEntryDate.MonthCalendar.DisplayMonth = new System.DateTime(2013, 5, 1, 0, 0, 0, 0);
            this.dtEntryDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtEntryDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtEntryDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtEntryDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtEntryDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtEntryDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtEntryDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEntryDate.MonthCalendar.TodayButtonVisible = true;
            this.dtEntryDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtEntryDate.Name = "dtEntryDate";
            this.dtEntryDate.Size = new System.Drawing.Size(200, 22);
            this.dtEntryDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtEntryDate.TabIndex = 41;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.com_acc);
            this.groupBox6.Controls.Add(this.labelX1);
            this.groupBox6.Controls.Add(this.labelX3);
            this.groupBox6.Controls.Add(this.dtEntryDate);
            this.groupBox6.Controls.Add(this.labelX2);
            this.groupBox6.Controls.Add(this.txt_note);
            this.groupBox6.Location = new System.Drawing.Point(15, 55);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1347, 44);
            this.groupBox6.TabIndex = 38;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "General";
            // 
            // btnVaidate
            // 
            this.btnVaidate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVaidate.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnVaidate.Location = new System.Drawing.Point(192, 382);
            this.btnVaidate.Name = "btnVaidate";
            this.btnVaidate.Size = new System.Drawing.Size(174, 53);
            this.btnVaidate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnVaidate.TabIndex = 44;
            this.btnVaidate.Text = "Validate";
            this.btnVaidate.Click += new System.EventHandler(this.btnVaidate_Click);
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(566, 382);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(188, 53);
            this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExit.TabIndex = 43;
            this.btnExit.Text = "EXIT";
            // 
            // btnClear
            // 
            this.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(372, 382);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(188, 53);
            this.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClear.TabIndex = 42;
            this.btnClear.Text = "CLEAR";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPost
            // 
            this.btnPost.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPost.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.Location = new System.Drawing.Point(12, 382);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(174, 53);
            this.btnPost.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPost.TabIndex = 41;
            this.btnPost.Text = "POST";
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(1155, 382);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(195, 53);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 45;
            this.buttonX1.Text = "SAVE VOUCHER";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click_1);
            // 
            // grd_voucher
            // 
            this.grd_voucher.AllowUserToAddRows = false;
            this.grd_voucher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_voucher.BackgroundColor = System.Drawing.Color.White;
            this.grd_voucher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grd_voucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_voucher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewDateTimeInputColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Type,
            this.dataGridViewDoubleInputColumn2});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_voucher.DefaultCellStyle = dataGridViewCellStyle6;
            this.grd_voucher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_voucher.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.grd_voucher.Location = new System.Drawing.Point(3, 18);
            this.grd_voucher.Name = "grd_voucher";
            this.grd_voucher.ReadOnly = true;
            this.grd_voucher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_voucher.Size = new System.Drawing.Size(1332, 273);
            this.grd_voucher.TabIndex = 34;
            // 
            // dataGridViewDateTimeInputColumn2
            // 
            // 
            // 
            // 
            this.dataGridViewDateTimeInputColumn2.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dataGridViewDateTimeInputColumn2.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.dataGridViewDateTimeInputColumn2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dataGridViewDateTimeInputColumn2.BackgroundStyle.TextColor = System.Drawing.Color.Black;
            this.dataGridViewDateTimeInputColumn2.FillWeight = 38.57869F;
            this.dataGridViewDateTimeInputColumn2.HeaderText = "Date";
            this.dataGridViewDateTimeInputColumn2.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.dataGridViewDateTimeInputColumn2.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dataGridViewDateTimeInputColumn2.MonthCalendar.BackgroundStyle.Class = "";
            this.dataGridViewDateTimeInputColumn2.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.dataGridViewDateTimeInputColumn2.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dataGridViewDateTimeInputColumn2.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dataGridViewDateTimeInputColumn2.MonthCalendar.DisplayMonth = new System.DateTime(2013, 5, 1, 0, 0, 0, 0);
            this.dataGridViewDateTimeInputColumn2.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dataGridViewDateTimeInputColumn2.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dataGridViewDateTimeInputColumn2.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dataGridViewDateTimeInputColumn2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dataGridViewDateTimeInputColumn2.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dataGridViewDateTimeInputColumn2.Name = "dataGridViewDateTimeInputColumn2";
            this.dataGridViewDateTimeInputColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 38.57869F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Account ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Account Num";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 284.2639F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Description";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // dataGridViewDoubleInputColumn2
            // 
            // 
            // 
            // 
            this.dataGridViewDoubleInputColumn2.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dataGridViewDoubleInputColumn2.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.dataGridViewDoubleInputColumn2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dataGridViewDoubleInputColumn2.BackgroundStyle.TextColor = System.Drawing.Color.Black;
            this.dataGridViewDoubleInputColumn2.FillWeight = 38.57869F;
            this.dataGridViewDoubleInputColumn2.HeaderText = "Amount";
            this.dataGridViewDoubleInputColumn2.Increment = 1D;
            this.dataGridViewDoubleInputColumn2.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.dataGridViewDoubleInputColumn2.Name = "dataGridViewDoubleInputColumn2";
            this.dataGridViewDoubleInputColumn2.ReadOnly = true;
            // 
            // GeneralJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1362, 742);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.btnVaidate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.reflectionLabel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GeneralJournal";
            this.Text = "MetroForm";
            this.Load += new System.EventHandler(this.GeneralJournal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_credit)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_debit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEntryDate)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_voucher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevComponents.DotNetBar.Controls.DataGridViewX grd_credit;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn dataGridViewDateTimeInputColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn dataGridViewDoubleInputColumn1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_amount_credit;
        private DevComponents.DotNetBar.ButtonX btn_credit;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_amount_debit;
        private DevComponents.DotNetBar.ButtonX btn_debit;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevComponents.DotNetBar.Controls.DataGridViewX grd_debit;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn Amount;
        private System.Windows.Forms.ComboBox com_acc;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_note;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtEntryDate;
        private System.Windows.Forms.GroupBox groupBox6;
        private DevComponents.DotNetBar.ButtonX btnVaidate;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.ButtonX btnClear;
        private DevComponents.DotNetBar.ButtonX btnPost;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX grd_voucher;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn dataGridViewDateTimeInputColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn dataGridViewDoubleInputColumn2;


    }
}