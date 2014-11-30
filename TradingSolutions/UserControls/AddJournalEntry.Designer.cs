namespace TradingSolutions.UserControls
{
    partial class AddJournalEntry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grd_debit = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.btnPost = new DevComponents.DotNetBar.ButtonX();
            this.btnClear = new DevComponents.DotNetBar.ButtonX();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.btnVaidate = new DevComponents.DotNetBar.ButtonX();
            this.metroStatusBar1 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.lblStatus = new DevComponents.DotNetBar.LabelItem();
            this.dtEntryDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_note = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.com_acc = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_debit = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txt_amount_debit = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Date = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txt_amount_credit = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_credit = new DevComponents.DotNetBar.ButtonX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grd_credit = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewDateTimeInputColumn1 = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewDoubleInputColumn1 = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_debit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEntryDate)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_credit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grd_debit);
            this.groupBox3.Location = new System.Drawing.Point(6, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1042, 115);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DEBIT";
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_debit.DefaultCellStyle = dataGridViewCellStyle3;
            this.grd_debit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_debit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.grd_debit.Location = new System.Drawing.Point(3, 18);
            this.grd_debit.Name = "grd_debit";
            this.grd_debit.ReadOnly = true;
            this.grd_debit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grd_debit.Size = new System.Drawing.Size(1036, 94);
            this.grd_debit.TabIndex = 33;
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.Class = "";
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Location = new System.Drawing.Point(421, -8);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(187, 52);
            this.reflectionLabel1.TabIndex = 6;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>GENERAL</i><font color=\"#B02B2C\">POSTING</font></font></b>";
            // 
            // btnPost
            // 
            this.btnPost.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPost.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnPost.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.Location = new System.Drawing.Point(12, 598);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(174, 53);
            this.btnPost.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPost.TabIndex = 7;
            this.btnPost.Text = "POST";
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnClear
            // 
            this.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(372, 598);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(188, 53);
            this.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "CLEAR";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(566, 598);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(188, 53);
            this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "EXIT";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnVaidate
            // 
            this.btnVaidate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVaidate.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnVaidate.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnVaidate.Location = new System.Drawing.Point(192, 598);
            this.btnVaidate.Name = "btnVaidate";
            this.btnVaidate.Size = new System.Drawing.Size(174, 53);
            this.btnVaidate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnVaidate.TabIndex = 10;
            this.btnVaidate.Text = "Validate";
            this.btnVaidate.Click += new System.EventHandler(this.btnVaidate_Click);
            // 
            // metroStatusBar1
            // 
            // 
            // 
            // 
            this.metroStatusBar1.BackgroundStyle.Class = "";
            this.metroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroStatusBar1.ContainerControlProcessDialogKey = true;
            this.metroStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroStatusBar1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroStatusBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lblStatus});
            this.metroStatusBar1.Location = new System.Drawing.Point(0, 662);
            this.metroStatusBar1.Name = "metroStatusBar1";
            this.metroStatusBar1.Size = new System.Drawing.Size(1068, 22);
            this.metroStatusBar1.TabIndex = 11;
            this.metroStatusBar1.Text = "metroStatusBar1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Text = "labelItem1";
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
            this.dtEntryDate.Location = new System.Drawing.Point(87, 73);
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
            this.dtEntryDate.TabIndex = 12;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(15, 73);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(65, 23);
            this.labelX1.TabIndex = 13;
            this.labelX1.Text = "Entry Date";
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
            this.txt_note.Location = new System.Drawing.Point(86, 142);
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(333, 22);
            this.txt_note.TabIndex = 14;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(15, 142);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            this.labelX2.TabIndex = 15;
            this.labelX2.Text = "Note";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(15, 104);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(65, 23);
            this.labelX3.TabIndex = 16;
            this.labelX3.Text = "Account";
            // 
            // com_acc
            // 
            this.com_acc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_acc.FormattingEnabled = true;
            this.com_acc.Location = new System.Drawing.Point(86, 105);
            this.com_acc.Name = "com_acc";
            this.com_acc.Size = new System.Drawing.Size(346, 21);
            this.com_acc.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.txt_amount_debit);
            this.groupBox1.Controls.Add(this.btn_debit);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(15, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1051, 206);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert Account";
            // 
            // btn_debit
            // 
            this.btn_debit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_debit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_debit.Location = new System.Drawing.Point(197, 36);
            this.btn_debit.Name = "btn_debit";
            this.btn_debit.Size = new System.Drawing.Size(140, 43);
            this.btn_debit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_debit.TabIndex = 6;
            this.btn_debit.Text = "RECORD";
            this.btn_debit.Click += new System.EventHandler(this.btn_debit_Click);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(9, 56);
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
            this.txt_amount_debit.Location = new System.Drawing.Point(80, 56);
            this.txt_amount_debit.Name = "txt_amount_debit";
            this.txt_amount_debit.Size = new System.Drawing.Size(87, 22);
            this.txt_amount_debit.TabIndex = 36;
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
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(12, 56);
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
            this.txt_amount_credit.Location = new System.Drawing.Point(83, 56);
            this.txt_amount_credit.Name = "txt_amount_credit";
            this.txt_amount_credit.Size = new System.Drawing.Size(87, 22);
            this.txt_amount_credit.TabIndex = 40;
            // 
            // btn_credit
            // 
            this.btn_credit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_credit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_credit.Location = new System.Drawing.Point(200, 36);
            this.btn_credit.Name = "btn_credit";
            this.btn_credit.Size = new System.Drawing.Size(140, 43);
            this.btn_credit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_credit.TabIndex = 39;
            this.btn_credit.Text = "RECORD";
            this.btn_credit.Click += new System.EventHandler(this.btn_credit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.labelX5);
            this.groupBox2.Controls.Add(this.txt_amount_credit);
            this.groupBox2.Controls.Add(this.btn_credit);
            this.groupBox2.Location = new System.Drawing.Point(12, 383);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1051, 206);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insert Account";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grd_credit);
            this.groupBox4.Location = new System.Drawing.Point(6, 85);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1042, 115);
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
            this.grd_credit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grd_credit.Size = new System.Drawing.Size(1036, 94);
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
            // AddJournalEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 684);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.com_acc);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dtEntryDate);
            this.Controls.Add(this.metroStatusBar1);
            this.Controls.Add(this.btnVaidate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.reflectionLabel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddJournalEntry";
            this.Opacity = 0.9D;
            this.Text = "MetroForm";
            this.TitleText = "<font color=\"#1F497D\">POSTINGS</font>";
            this.Load += new System.EventHandler(this.AddJournalEntry_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_debit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEntryDate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_credit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.Controls.DataGridViewX grd_debit;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.ButtonX btnPost;
        private DevComponents.DotNetBar.ButtonX btnClear;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.ButtonX btnVaidate;
        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar1;
        private DevComponents.DotNetBar.LabelItem lblStatus;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtEntryDate;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_note;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.ComboBox com_acc;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_amount_debit;
        private DevComponents.DotNetBar.ButtonX btn_debit;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn Amount;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_amount_credit;
        private DevComponents.DotNetBar.ButtonX btn_credit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevComponents.DotNetBar.Controls.DataGridViewX grd_credit;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn dataGridViewDateTimeInputColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn dataGridViewDoubleInputColumn1;
    }
}