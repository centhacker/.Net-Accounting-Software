namespace TradingSolutions.Forms
{
    partial class Payments
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
            this.dt_payment_edate = new System.Windows.Forms.DateTimePicker();
            this.txt_payment_type = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_payment_id = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lab_payment_edate = new DevComponents.DotNetBar.LabelX();
            this.lab_payment_type = new DevComponents.DotNetBar.LabelX();
            this.lab_payment_mdate = new DevComponents.DotNetBar.LabelX();
            this.grp_payment_2 = new System.Windows.Forms.GroupBox();
            this.lab_payment_req2 = new DevComponents.DotNetBar.LabelX();
            this.lab_payment_req1 = new DevComponents.DotNetBar.LabelX();
            this.txt_payment_log = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lab_payment_log = new DevComponents.DotNetBar.LabelX();
            this.dt_payment_mdate = new System.Windows.Forms.DateTimePicker();
            this.grp_payment_1 = new System.Windows.Forms.GroupBox();
            this.lab_payment_id = new DevComponents.DotNetBar.LabelX();
            this.btn_home = new DevComponents.DotNetBar.ButtonX();
            this.btn_clear = new DevComponents.DotNetBar.ButtonX();
            this.Btn_show = new DevComponents.DotNetBar.ButtonX();
            this.btn_delete = new DevComponents.DotNetBar.ButtonX();
            this.btn_save = new DevComponents.DotNetBar.ButtonX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grid_payment = new Telerik.WinControls.UI.RadGridView();
            this.grp_payment_2.SuspendLayout();
            this.grp_payment_1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_payment)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_payment_edate
            // 
            this.dt_payment_edate.Location = new System.Drawing.Point(198, 66);
            this.dt_payment_edate.Name = "dt_payment_edate";
            this.dt_payment_edate.Size = new System.Drawing.Size(287, 25);
            this.dt_payment_edate.TabIndex = 0;
            // 
            // txt_payment_type
            // 
            this.txt_payment_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            // 
            // 
            // 
            this.txt_payment_type.Border.Class = "TextBoxBorder";
            this.txt_payment_type.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_payment_type.FocusHighlightColor = System.Drawing.Color.LightSteelBlue;
            this.txt_payment_type.FocusHighlightEnabled = true;
            this.txt_payment_type.ForeColor = System.Drawing.Color.Black;
            this.txt_payment_type.Location = new System.Drawing.Point(163, 65);
            this.txt_payment_type.Name = "txt_payment_type";
            this.txt_payment_type.Size = new System.Drawing.Size(346, 25);
            this.txt_payment_type.TabIndex = 7;
            // 
            // txt_payment_id
            // 
            this.txt_payment_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            // 
            // 
            // 
            this.txt_payment_id.Border.Class = "TextBoxBorder";
            this.txt_payment_id.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_payment_id.FocusHighlightColor = System.Drawing.Color.LightSteelBlue;
            this.txt_payment_id.FocusHighlightEnabled = true;
            this.txt_payment_id.ForeColor = System.Drawing.Color.Black;
            this.txt_payment_id.Location = new System.Drawing.Point(163, 24);
            this.txt_payment_id.Name = "txt_payment_id";
            this.txt_payment_id.Size = new System.Drawing.Size(346, 25);
            this.txt_payment_id.TabIndex = 6;
            // 
            // lab_payment_edate
            // 
            this.lab_payment_edate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.lab_payment_edate.BackgroundStyle.Class = "";
            this.lab_payment_edate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_payment_edate.ForeColor = System.Drawing.Color.Black;
            this.lab_payment_edate.Location = new System.Drawing.Point(25, 66);
            this.lab_payment_edate.Name = "lab_payment_edate";
            this.lab_payment_edate.Size = new System.Drawing.Size(75, 23);
            this.lab_payment_edate.TabIndex = 1;
            this.lab_payment_edate.Text = "Entry Date";
            // 
            // lab_payment_type
            // 
            this.lab_payment_type.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.lab_payment_type.BackgroundStyle.Class = "";
            this.lab_payment_type.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_payment_type.ForeColor = System.Drawing.Color.Black;
            this.lab_payment_type.Location = new System.Drawing.Point(20, 68);
            this.lab_payment_type.Name = "lab_payment_type";
            this.lab_payment_type.Size = new System.Drawing.Size(112, 23);
            this.lab_payment_type.TabIndex = 1;
            this.lab_payment_type.Text = "Payment Type";
            // 
            // lab_payment_mdate
            // 
            this.lab_payment_mdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.lab_payment_mdate.BackgroundStyle.Class = "";
            this.lab_payment_mdate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_payment_mdate.ForeColor = System.Drawing.Color.Black;
            this.lab_payment_mdate.Location = new System.Drawing.Point(25, 149);
            this.lab_payment_mdate.Name = "lab_payment_mdate";
            this.lab_payment_mdate.Size = new System.Drawing.Size(101, 23);
            this.lab_payment_mdate.TabIndex = 2;
            this.lab_payment_mdate.Text = "Modified Date";
            // 
            // grp_payment_2
            // 
            this.grp_payment_2.Controls.Add(this.lab_payment_req2);
            this.grp_payment_2.Controls.Add(this.lab_payment_req1);
            this.grp_payment_2.Controls.Add(this.txt_payment_log);
            this.grp_payment_2.Controls.Add(this.lab_payment_log);
            this.grp_payment_2.Controls.Add(this.dt_payment_mdate);
            this.grp_payment_2.Controls.Add(this.lab_payment_mdate);
            this.grp_payment_2.Controls.Add(this.lab_payment_edate);
            this.grp_payment_2.Controls.Add(this.dt_payment_edate);
            this.grp_payment_2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_payment_2.Location = new System.Drawing.Point(715, 30);
            this.grp_payment_2.Name = "grp_payment_2";
            this.grp_payment_2.Size = new System.Drawing.Size(564, 289);
            this.grp_payment_2.TabIndex = 12;
            this.grp_payment_2.TabStop = false;
            this.grp_payment_2.Text = "Details";
            this.grp_payment_2.Visible = false;
            // 
            // lab_payment_req2
            // 
            // 
            // 
            // 
            this.lab_payment_req2.BackgroundStyle.Class = "";
            this.lab_payment_req2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_payment_req2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_payment_req2.Location = new System.Drawing.Point(491, 149);
            this.lab_payment_req2.Name = "lab_payment_req2";
            this.lab_payment_req2.Size = new System.Drawing.Size(18, 23);
            this.lab_payment_req2.TabIndex = 15;
            this.lab_payment_req2.Text = "*";
            // 
            // lab_payment_req1
            // 
            // 
            // 
            // 
            this.lab_payment_req1.BackgroundStyle.Class = "";
            this.lab_payment_req1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_payment_req1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_payment_req1.Location = new System.Drawing.Point(491, 65);
            this.lab_payment_req1.Name = "lab_payment_req1";
            this.lab_payment_req1.Size = new System.Drawing.Size(18, 23);
            this.lab_payment_req1.TabIndex = 14;
            this.lab_payment_req1.Text = "*";
            // 
            // txt_payment_log
            // 
            this.txt_payment_log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            // 
            // 
            // 
            this.txt_payment_log.Border.Class = "TextBoxBorder";
            this.txt_payment_log.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_payment_log.FocusHighlightColor = System.Drawing.Color.LightSteelBlue;
            this.txt_payment_log.FocusHighlightEnabled = true;
            this.txt_payment_log.ForeColor = System.Drawing.Color.Black;
            this.txt_payment_log.Location = new System.Drawing.Point(198, 229);
            this.txt_payment_log.Name = "txt_payment_log";
            this.txt_payment_log.Size = new System.Drawing.Size(287, 25);
            this.txt_payment_log.TabIndex = 12;
            // 
            // lab_payment_log
            // 
            this.lab_payment_log.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.lab_payment_log.BackgroundStyle.Class = "";
            this.lab_payment_log.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_payment_log.ForeColor = System.Drawing.Color.Black;
            this.lab_payment_log.Location = new System.Drawing.Point(25, 231);
            this.lab_payment_log.Name = "lab_payment_log";
            this.lab_payment_log.Size = new System.Drawing.Size(101, 23);
            this.lab_payment_log.TabIndex = 4;
            this.lab_payment_log.Text = "Logged In As";
            // 
            // dt_payment_mdate
            // 
            this.dt_payment_mdate.Location = new System.Drawing.Point(198, 150);
            this.dt_payment_mdate.Name = "dt_payment_mdate";
            this.dt_payment_mdate.Size = new System.Drawing.Size(287, 25);
            this.dt_payment_mdate.TabIndex = 3;
            // 
            // grp_payment_1
            // 
            this.grp_payment_1.Controls.Add(this.txt_payment_type);
            this.grp_payment_1.Controls.Add(this.txt_payment_id);
            this.grp_payment_1.Controls.Add(this.lab_payment_type);
            this.grp_payment_1.Controls.Add(this.lab_payment_id);
            this.grp_payment_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_payment_1.Location = new System.Drawing.Point(39, 30);
            this.grp_payment_1.Name = "grp_payment_1";
            this.grp_payment_1.Size = new System.Drawing.Size(643, 289);
            this.grp_payment_1.TabIndex = 11;
            this.grp_payment_1.TabStop = false;
            this.grp_payment_1.Text = "Info";
            // 
            // lab_payment_id
            // 
            this.lab_payment_id.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.lab_payment_id.BackgroundStyle.Class = "";
            this.lab_payment_id.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_payment_id.ForeColor = System.Drawing.Color.Black;
            this.lab_payment_id.Location = new System.Drawing.Point(20, 26);
            this.lab_payment_id.Name = "lab_payment_id";
            this.lab_payment_id.Size = new System.Drawing.Size(75, 23);
            this.lab_payment_id.TabIndex = 0;
            this.lab_payment_id.Text = "Payment ID";
            // 
            // btn_home
            // 
            this.btn_home.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_home.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_home.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Location = new System.Drawing.Point(994, 346);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(125, 35);
            this.btn_home.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_home.TabIndex = 32;
            this.btn_home.Text = "Home";
            this.btn_home.Click += new System.EventHandler(this.btn_payment_home_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_clear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(812, 346);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(125, 35);
            this.btn_clear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_clear.TabIndex = 31;
            this.btn_clear.Text = "Clear";
            this.btn_clear.Click += new System.EventHandler(this.btn_payment_clear_Click);
            // 
            // Btn_show
            // 
            this.Btn_show.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Btn_show.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Btn_show.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_show.Location = new System.Drawing.Point(634, 346);
            this.Btn_show.Name = "Btn_show";
            this.Btn_show.Size = new System.Drawing.Size(125, 35);
            this.Btn_show.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Btn_show.TabIndex = 30;
            this.Btn_show.Text = "Show Record";
            this.Btn_show.Click += new System.EventHandler(this.btn_payment_show_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_delete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(461, 346);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(125, 35);
            this.btn_delete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_delete.TabIndex = 29;
            this.btn_delete.Text = "Delete Record";
            this.btn_delete.Click += new System.EventHandler(this.btn_payment_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(287, 346);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(125, 35);
            this.btn_save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_save.TabIndex = 27;
            this.btn_save.Text = "Save Record";
            this.btn_save.Click += new System.EventHandler(this.btn_payment_save_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grid_payment);
            this.groupBox3.Location = new System.Drawing.Point(39, 405);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1240, 310);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Details";
            // 
            // grid_payment
            // 
            this.grid_payment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_payment.EnableFastScrolling = true;
            this.grid_payment.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_payment.Location = new System.Drawing.Point(3, 18);
            // 
            // grid_payment
            // 
            this.grid_payment.MasterTemplate.AllowAddNewRow = false;
            this.grid_payment.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.grid_payment.MasterTemplate.AllowColumnReorder = false;
            this.grid_payment.MasterTemplate.AllowDeleteRow = false;
            this.grid_payment.MasterTemplate.AllowDragToGroup = false;
            this.grid_payment.MasterTemplate.AllowEditRow = false;
            this.grid_payment.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.grid_payment.MasterTemplate.EnableFiltering = true;
            this.grid_payment.Name = "grid_payment";
            this.grid_payment.ShowGroupPanel = false;
            this.grid_payment.Size = new System.Drawing.Size(1234, 289);
            this.grid_payment.TabIndex = 2;
            this.grid_payment.SelectionChanged += new System.EventHandler(this.grid_payment_SelectionChanged);
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1317, 727);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.Btn_show);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.grp_payment_2);
            this.Controls.Add(this.grp_payment_1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Payments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payments";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Payments_Load);
            this.grp_payment_2.ResumeLayout(false);
            this.grp_payment_1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_payment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt_payment_edate;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_payment_type;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_payment_id;
        private DevComponents.DotNetBar.LabelX lab_payment_edate;
        private DevComponents.DotNetBar.LabelX lab_payment_type;
        private DevComponents.DotNetBar.LabelX lab_payment_mdate;
        private System.Windows.Forms.GroupBox grp_payment_2;
        private DevComponents.DotNetBar.LabelX lab_payment_req2;
        private DevComponents.DotNetBar.LabelX lab_payment_req1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_payment_log;
        private DevComponents.DotNetBar.LabelX lab_payment_log;
        private System.Windows.Forms.DateTimePicker dt_payment_mdate;
        private System.Windows.Forms.GroupBox grp_payment_1;
        private DevComponents.DotNetBar.LabelX lab_payment_id;
        private DevComponents.DotNetBar.ButtonX btn_home;
        private DevComponents.DotNetBar.ButtonX btn_clear;
        private DevComponents.DotNetBar.ButtonX Btn_show;
        private DevComponents.DotNetBar.ButtonX btn_delete;
        private DevComponents.DotNetBar.ButtonX btn_save;
        private System.Windows.Forms.GroupBox groupBox3;
        private Telerik.WinControls.UI.RadGridView grid_payment;
    }
}