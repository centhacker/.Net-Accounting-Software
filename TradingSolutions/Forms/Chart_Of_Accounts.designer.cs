namespace TradingSolutions.Forms
{
    partial class Chart_Of_Accounts
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
            this.lab_buyer_log = new DevComponents.DotNetBar.LabelX();
            this.lab_buyer_edate = new DevComponents.DotNetBar.LabelX();
            this.dt_buyer_edate = new System.Windows.Forms.DateTimePicker();
            this.txt_name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblNAme = new DevComponents.DotNetBar.LabelX();
            this.com_type = new System.Windows.Forms.ComboBox();
            this.btn_home = new DevComponents.DotNetBar.ButtonX();
            this.btn_clear = new DevComponents.DotNetBar.ButtonX();
            this.Btn_show = new DevComponents.DotNetBar.ButtonX();
            this.btn_delete = new DevComponents.DotNetBar.ButtonX();
            this.btn_save = new DevComponents.DotNetBar.ButtonX();
            this.grid_chart = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_chart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_buyer_log
            // 
            this.lab_buyer_log.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.lab_buyer_log.BackgroundStyle.Class = "";
            this.lab_buyer_log.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_buyer_log.ForeColor = System.Drawing.Color.Black;
            this.lab_buyer_log.Location = new System.Drawing.Point(36, 207);
            this.lab_buyer_log.Name = "lab_buyer_log";
            this.lab_buyer_log.Size = new System.Drawing.Size(101, 23);
            this.lab_buyer_log.TabIndex = 29;
            this.lab_buyer_log.Text = "Type";
            // 
            // lab_buyer_edate
            // 
            this.lab_buyer_edate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lab_buyer_edate.BackgroundStyle.Class = "";
            this.lab_buyer_edate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_buyer_edate.ForeColor = System.Drawing.Color.Black;
            this.lab_buyer_edate.Location = new System.Drawing.Point(41, 44);
            this.lab_buyer_edate.Name = "lab_buyer_edate";
            this.lab_buyer_edate.Size = new System.Drawing.Size(75, 23);
            this.lab_buyer_edate.TabIndex = 26;
            this.lab_buyer_edate.Text = "Entry Date";
            // 
            // dt_buyer_edate
            // 
            this.dt_buyer_edate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dt_buyer_edate.ForeColor = System.Drawing.Color.Black;
            this.dt_buyer_edate.Location = new System.Drawing.Point(179, 45);
            this.dt_buyer_edate.Name = "dt_buyer_edate";
            this.dt_buyer_edate.Size = new System.Drawing.Size(346, 22);
            this.dt_buyer_edate.TabIndex = 25;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            // 
            // 
            // 
            this.txt_name.Border.Class = "TextBoxBorder";
            this.txt_name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_name.FocusHighlightColor = System.Drawing.Color.LightSteelBlue;
            this.txt_name.FocusHighlightEnabled = true;
            this.txt_name.ForeColor = System.Drawing.Color.Black;
            this.txt_name.Location = new System.Drawing.Point(179, 126);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(346, 22);
            this.txt_name.TabIndex = 28;
            // 
            // lblNAme
            // 
            this.lblNAme.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.lblNAme.BackgroundStyle.Class = "";
            this.lblNAme.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblNAme.ForeColor = System.Drawing.Color.Black;
            this.lblNAme.Location = new System.Drawing.Point(36, 128);
            this.lblNAme.Name = "lblNAme";
            this.lblNAme.Size = new System.Drawing.Size(102, 23);
            this.lblNAme.TabIndex = 27;
            this.lblNAme.Text = "Name";
            // 
            // com_type
            // 
            this.com_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_type.FormattingEnabled = true;
            this.com_type.Location = new System.Drawing.Point(179, 209);
            this.com_type.Name = "com_type";
            this.com_type.Size = new System.Drawing.Size(346, 21);
            this.com_type.TabIndex = 30;
            // 
            // btn_home
            // 
            this.btn_home.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_home.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_home.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Location = new System.Drawing.Point(927, 306);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(125, 35);
            this.btn_home.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_home.TabIndex = 38;
            this.btn_home.Text = "Home";
            // 
            // btn_clear
            // 
            this.btn_clear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_clear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(767, 306);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(125, 35);
            this.btn_clear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_clear.TabIndex = 37;
            this.btn_clear.Text = "Clear";
            // 
            // Btn_show
            // 
            this.Btn_show.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.Btn_show.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Btn_show.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_show.Location = new System.Drawing.Point(603, 306);
            this.Btn_show.Name = "Btn_show";
            this.Btn_show.Size = new System.Drawing.Size(125, 35);
            this.Btn_show.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Btn_show.TabIndex = 36;
            this.Btn_show.Text = "Show Record";
            // 
            // btn_delete
            // 
            this.btn_delete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_delete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(438, 306);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(125, 35);
            this.btn_delete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_delete.TabIndex = 35;
            this.btn_delete.Text = "Delete Record";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(285, 306);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(125, 35);
            this.btn_save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_save.TabIndex = 33;
            this.btn_save.Text = "Save Record";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // grid_chart
            // 
            this.grid_chart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_chart.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grid_chart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_chart.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_chart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.grid_chart.Location = new System.Drawing.Point(3, 18);
            this.grid_chart.Name = "grid_chart";
            this.grid_chart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_chart.Size = new System.Drawing.Size(766, 325);
            this.grid_chart.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grid_chart);
            this.groupBox1.Location = new System.Drawing.Point(115, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 346);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accounts";
            // 
            // Chart_Of_Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1317, 727);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.Btn_show);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.com_type);
            this.Controls.Add(this.lab_buyer_log);
            this.Controls.Add(this.lab_buyer_edate);
            this.Controls.Add(this.dt_buyer_edate);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lblNAme);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Chart_Of_Accounts";
            this.Text = "MetroForm";
            this.Load += new System.EventHandler(this.Chart_Of_Accounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_chart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lab_buyer_log;
        private DevComponents.DotNetBar.LabelX lab_buyer_edate;
        private System.Windows.Forms.DateTimePicker dt_buyer_edate;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_name;
        private DevComponents.DotNetBar.LabelX lblNAme;
        private System.Windows.Forms.ComboBox com_type;
        private DevComponents.DotNetBar.ButtonX btn_home;
        private DevComponents.DotNetBar.ButtonX btn_clear;
        private DevComponents.DotNetBar.ButtonX Btn_show;
        private DevComponents.DotNetBar.ButtonX btn_delete;
        private DevComponents.DotNetBar.ButtonX btn_save;
        private DevComponents.DotNetBar.Controls.DataGridViewX grid_chart;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}