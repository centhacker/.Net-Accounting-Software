namespace TradingSolutions.Forms
{
    partial class Order
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
            this.grid_order = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txt_order_ref = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lab_order_req2 = new DevComponents.DotNetBar.LabelX();
            this.lab_order_req1 = new DevComponents.DotNetBar.LabelX();
            this.txt_order_name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lab_order_ref = new DevComponents.DotNetBar.LabelX();
            this.grp_order_1 = new System.Windows.Forms.GroupBox();
            this.lbl_id = new DevComponents.DotNetBar.LabelX();
            this.combox_inv_curr = new System.Windows.Forms.ComboBox();
            this.txt_order_total = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lab_inv_curr = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txt_order_buyer_name = new System.Windows.Forms.ComboBox();
            this.lab_order_name = new DevComponents.DotNetBar.LabelX();
            this.lab_order_buyid = new DevComponents.DotNetBar.LabelX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_units = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_cp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.combo_prod_names = new System.Windows.Forms.ComboBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.grd_prods = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.Units = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.Total = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.grd_order_details = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_home = new DevComponents.DotNetBar.ButtonX();
            this.btn_clear = new DevComponents.DotNetBar.ButtonX();
            this.Btn_show = new DevComponents.DotNetBar.ButtonX();
            this.btn_delete = new DevComponents.DotNetBar.ButtonX();
            this.btn_update = new DevComponents.DotNetBar.ButtonX();
            this.btn_save = new DevComponents.DotNetBar.ButtonX();
            this.lab_order_req5 = new DevComponents.DotNetBar.LabelX();
            this.lab_order_req3 = new DevComponents.DotNetBar.LabelX();
            this.dt_order_shdate = new System.Windows.Forms.DateTimePicker();
            this.lab_order_shipdate = new DevComponents.DotNetBar.LabelX();
            this.dt_order_rdate = new System.Windows.Forms.DateTimePicker();
            this.dt_order_date = new System.Windows.Forms.DateTimePicker();
            this.lab_order_date = new DevComponents.DotNetBar.LabelX();
            this.lab_order_reqdate = new DevComponents.DotNetBar.LabelX();
            this.lab_order_req6 = new DevComponents.DotNetBar.LabelX();
            this.lab_order_req4 = new DevComponents.DotNetBar.LabelX();
            this.lab_order_edate = new DevComponents.DotNetBar.LabelX();
            this.dt_order_edate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.grid_order)).BeginInit();
            this.grp_order_1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_prods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_order_details)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_order
            // 
            this.grid_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_order.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grid_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_order.DefaultCellStyle = dataGridViewCellStyle4;
            this.grid_order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_order.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.grid_order.Location = new System.Drawing.Point(3, 21);
            this.grid_order.Name = "grid_order";
            this.grid_order.ReadOnly = true;
            this.grid_order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_order.Size = new System.Drawing.Size(477, 94);
            this.grid_order.TabIndex = 17;
            this.grid_order.SelectionChanged += new System.EventHandler(this.grid_order_SelectionChanged);
            // 
            // txt_order_ref
            // 
            this.txt_order_ref.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            // 
            // 
            // 
            this.txt_order_ref.Border.Class = "TextBoxBorder";
            this.txt_order_ref.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_order_ref.FocusHighlightColor = System.Drawing.Color.LightSteelBlue;
            this.txt_order_ref.FocusHighlightEnabled = true;
            this.txt_order_ref.ForeColor = System.Drawing.Color.Black;
            this.txt_order_ref.Location = new System.Drawing.Point(162, 104);
            this.txt_order_ref.Name = "txt_order_ref";
            this.txt_order_ref.Size = new System.Drawing.Size(346, 25);
            this.txt_order_ref.TabIndex = 9;
            // 
            // lab_order_req2
            // 
            // 
            // 
            // 
            this.lab_order_req2.BackgroundStyle.Class = "";
            this.lab_order_req2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_order_req2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_order_req2.Location = new System.Drawing.Point(515, 107);
            this.lab_order_req2.Name = "lab_order_req2";
            this.lab_order_req2.Size = new System.Drawing.Size(18, 23);
            this.lab_order_req2.TabIndex = 13;
            this.lab_order_req2.Text = "*";
            // 
            // lab_order_req1
            // 
            // 
            // 
            // 
            this.lab_order_req1.BackgroundStyle.Class = "";
            this.lab_order_req1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_order_req1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_order_req1.Location = new System.Drawing.Point(515, 65);
            this.lab_order_req1.Name = "lab_order_req1";
            this.lab_order_req1.Size = new System.Drawing.Size(18, 23);
            this.lab_order_req1.TabIndex = 12;
            this.lab_order_req1.Text = "*";
            // 
            // txt_order_name
            // 
            this.txt_order_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            // 
            // 
            // 
            this.txt_order_name.Border.Class = "TextBoxBorder";
            this.txt_order_name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_order_name.FocusHighlightColor = System.Drawing.Color.LightSteelBlue;
            this.txt_order_name.FocusHighlightEnabled = true;
            this.txt_order_name.ForeColor = System.Drawing.Color.Black;
            this.txt_order_name.Location = new System.Drawing.Point(162, 63);
            this.txt_order_name.Name = "txt_order_name";
            this.txt_order_name.Size = new System.Drawing.Size(346, 25);
            this.txt_order_name.TabIndex = 8;
            // 
            // lab_order_ref
            // 
            this.lab_order_ref.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.lab_order_ref.BackgroundStyle.Class = "";
            this.lab_order_ref.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_order_ref.ForeColor = System.Drawing.Color.Black;
            this.lab_order_ref.Location = new System.Drawing.Point(19, 106);
            this.lab_order_ref.Name = "lab_order_ref";
            this.lab_order_ref.Size = new System.Drawing.Size(102, 23);
            this.lab_order_ref.TabIndex = 3;
            this.lab_order_ref.Text = "Order Reference";
            // 
            // grp_order_1
            // 
            this.grp_order_1.Controls.Add(this.lab_order_req5);
            this.grp_order_1.Controls.Add(this.lab_order_req3);
            this.grp_order_1.Controls.Add(this.dt_order_shdate);
            this.grp_order_1.Controls.Add(this.lab_order_shipdate);
            this.grp_order_1.Controls.Add(this.dt_order_rdate);
            this.grp_order_1.Controls.Add(this.dt_order_date);
            this.grp_order_1.Controls.Add(this.lab_order_date);
            this.grp_order_1.Controls.Add(this.lab_order_reqdate);
            this.grp_order_1.Controls.Add(this.lab_order_req6);
            this.grp_order_1.Controls.Add(this.lab_order_req4);
            this.grp_order_1.Controls.Add(this.lab_order_edate);
            this.grp_order_1.Controls.Add(this.dt_order_edate);
            this.grp_order_1.Controls.Add(this.lbl_id);
            this.grp_order_1.Controls.Add(this.combox_inv_curr);
            this.grp_order_1.Controls.Add(this.txt_order_total);
            this.grp_order_1.Controls.Add(this.lab_inv_curr);
            this.grp_order_1.Controls.Add(this.labelX3);
            this.grp_order_1.Controls.Add(this.txt_order_buyer_name);
            this.grp_order_1.Controls.Add(this.lab_order_req2);
            this.grp_order_1.Controls.Add(this.lab_order_req1);
            this.grp_order_1.Controls.Add(this.txt_order_ref);
            this.grp_order_1.Controls.Add(this.txt_order_name);
            this.grp_order_1.Controls.Add(this.lab_order_ref);
            this.grp_order_1.Controls.Add(this.lab_order_name);
            this.grp_order_1.Controls.Add(this.lab_order_buyid);
            this.grp_order_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_order_1.Location = new System.Drawing.Point(39, 12);
            this.grp_order_1.Name = "grp_order_1";
            this.grp_order_1.Size = new System.Drawing.Size(1260, 217);
            this.grp_order_1.TabIndex = 11;
            this.grp_order_1.TabStop = false;
            this.grp_order_1.Text = "Info";
            this.grp_order_1.Enter += new System.EventHandler(this.grp_order_1_Enter);
            // 
            // lbl_id
            // 
            this.lbl_id.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.lbl_id.BackgroundStyle.Class = "";
            this.lbl_id.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_id.ForeColor = System.Drawing.Color.Black;
            this.lbl_id.Location = new System.Drawing.Point(539, 62);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(112, 23);
            this.lbl_id.TabIndex = 32;
            this.lbl_id.Visible = false;
            // 
            // combox_inv_curr
            // 
            this.combox_inv_curr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.combox_inv_curr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_inv_curr.ForeColor = System.Drawing.Color.Black;
            this.combox_inv_curr.FormattingEnabled = true;
            this.combox_inv_curr.Location = new System.Drawing.Point(162, 183);
            this.combox_inv_curr.Name = "combox_inv_curr";
            this.combox_inv_curr.Size = new System.Drawing.Size(346, 25);
            this.combox_inv_curr.TabIndex = 30;
            // 
            // txt_order_total
            // 
            this.txt_order_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            // 
            // 
            // 
            this.txt_order_total.Border.Class = "TextBoxBorder";
            this.txt_order_total.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_order_total.FocusHighlightColor = System.Drawing.Color.LightSteelBlue;
            this.txt_order_total.FocusHighlightEnabled = true;
            this.txt_order_total.ForeColor = System.Drawing.Color.Black;
            this.txt_order_total.Location = new System.Drawing.Point(162, 142);
            this.txt_order_total.Name = "txt_order_total";
            this.txt_order_total.Size = new System.Drawing.Size(346, 25);
            this.txt_order_total.TabIndex = 16;
            // 
            // lab_inv_curr
            // 
            this.lab_inv_curr.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.lab_inv_curr.BackgroundStyle.Class = "";
            this.lab_inv_curr.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_inv_curr.ForeColor = System.Drawing.Color.Black;
            this.lab_inv_curr.Location = new System.Drawing.Point(19, 185);
            this.lab_inv_curr.Name = "lab_inv_curr";
            this.lab_inv_curr.Size = new System.Drawing.Size(75, 23);
            this.lab_inv_curr.TabIndex = 31;
            this.lab_inv_curr.Text = "Currency";
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
            this.labelX3.Location = new System.Drawing.Point(19, 144);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(102, 23);
            this.labelX3.TabIndex = 15;
            this.labelX3.Text = "Order Total";
            // 
            // txt_order_buyer_name
            // 
            this.txt_order_buyer_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_order_buyer_name.FormattingEnabled = true;
            this.txt_order_buyer_name.Location = new System.Drawing.Point(162, 19);
            this.txt_order_buyer_name.Name = "txt_order_buyer_name";
            this.txt_order_buyer_name.Size = new System.Drawing.Size(346, 25);
            this.txt_order_buyer_name.TabIndex = 14;
            // 
            // lab_order_name
            // 
            this.lab_order_name.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.lab_order_name.BackgroundStyle.Class = "";
            this.lab_order_name.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_order_name.ForeColor = System.Drawing.Color.Black;
            this.lab_order_name.Location = new System.Drawing.Point(19, 65);
            this.lab_order_name.Name = "lab_order_name";
            this.lab_order_name.Size = new System.Drawing.Size(112, 23);
            this.lab_order_name.TabIndex = 2;
            this.lab_order_name.Text = "Order Name";
            // 
            // lab_order_buyid
            // 
            this.lab_order_buyid.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.lab_order_buyid.BackgroundStyle.Class = "";
            this.lab_order_buyid.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_order_buyid.ForeColor = System.Drawing.Color.Black;
            this.lab_order_buyid.Location = new System.Drawing.Point(19, 24);
            this.lab_order_buyid.Name = "lab_order_buyid";
            this.lab_order_buyid.Size = new System.Drawing.Size(112, 23);
            this.lab_order_buyid.TabIndex = 1;
            this.lab_order_buyid.Text = "Buyer Name";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.txt_units);
            this.groupBox2.Controls.Add(this.labelX4);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.txt_cp);
            this.groupBox2.Controls.Add(this.combo_prod_names);
            this.groupBox2.Controls.Add(this.labelX2);
            this.groupBox2.Controls.Add(this.grd_prods);
            this.groupBox2.Controls.Add(this.labelX1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(39, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(777, 439);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products";
            // 
            // txt_units
            // 
            this.txt_units.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            // 
            // 
            // 
            this.txt_units.Border.Class = "TextBoxBorder";
            this.txt_units.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_units.FocusHighlightColor = System.Drawing.Color.LightSteelBlue;
            this.txt_units.FocusHighlightEnabled = true;
            this.txt_units.ForeColor = System.Drawing.Color.Black;
            this.txt_units.Location = new System.Drawing.Point(467, 29);
            this.txt_units.Name = "txt_units";
            this.txt_units.Size = new System.Drawing.Size(114, 25);
            this.txt_units.TabIndex = 27;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(422, 31);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(30, 23);
            this.labelX4.TabIndex = 26;
            this.labelX4.Text = "Units";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(587, 25);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(184, 35);
            this.btn_add.TabIndex = 24;
            this.btn_add.Text = "Add/Calculate";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_cp
            // 
            this.txt_cp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            // 
            // 
            // 
            this.txt_cp.Border.Class = "TextBoxBorder";
            this.txt_cp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_cp.FocusHighlightColor = System.Drawing.Color.LightSteelBlue;
            this.txt_cp.FocusHighlightEnabled = true;
            this.txt_cp.ForeColor = System.Drawing.Color.Black;
            this.txt_cp.Location = new System.Drawing.Point(296, 29);
            this.txt_cp.Name = "txt_cp";
            this.txt_cp.Size = new System.Drawing.Size(108, 25);
            this.txt_cp.TabIndex = 21;
            // 
            // combo_prod_names
            // 
            this.combo_prod_names.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.combo_prod_names.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_prod_names.ForeColor = System.Drawing.Color.Black;
            this.combo_prod_names.FormattingEnabled = true;
            this.combo_prod_names.Location = new System.Drawing.Point(60, 30);
            this.combo_prod_names.Name = "combo_prod_names";
            this.combo_prod_names.Size = new System.Drawing.Size(185, 25);
            this.combo_prod_names.TabIndex = 21;
            this.combo_prod_names.SelectedIndexChanged += new System.EventHandler(this.combo_prod_names_SelectedIndexChanged);
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
            this.labelX2.Location = new System.Drawing.Point(259, 31);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(30, 23);
            this.labelX2.TabIndex = 20;
            this.labelX2.Text = "Cost";
            // 
            // grd_prods
            // 
            this.grd_prods.AllowUserToAddRows = false;
            this.grd_prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_prods.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grd_prods.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grd_prods.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.grd_prods.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grd_prods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_prods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.To,
            this.Cost,
            this.Units,
            this.Total});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_prods.DefaultCellStyle = dataGridViewCellStyle5;
            this.grd_prods.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.grd_prods.Location = new System.Drawing.Point(6, 81);
            this.grd_prods.Name = "grd_prods";
            this.grd_prods.ReadOnly = true;
            this.grd_prods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_prods.Size = new System.Drawing.Size(765, 346);
            this.grd_prods.TabIndex = 17;
            this.grd_prods.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.grd_prods_UserAddedRow);
            this.grd_prods.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.grd_prods_UserDeletedRow);
            // 
            // Product
            // 
            this.Product.HeaderText = "Product Name";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // To
            // 
            this.To.HeaderText = "To :";
            this.To.Name = "To";
            this.To.ReadOnly = true;
            // 
            // Cost
            // 
            // 
            // 
            // 
            this.Cost.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.Cost.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.Cost.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Cost.BackgroundStyle.TextColor = System.Drawing.Color.Black;
            this.Cost.HeaderText = "Cost";
            this.Cost.Increment = 1D;
            this.Cost.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // Units
            // 
            // 
            // 
            // 
            this.Units.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.Units.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.Units.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Units.BackgroundStyle.TextColor = System.Drawing.Color.Black;
            this.Units.HeaderText = "Units";
            this.Units.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.Units.Name = "Units";
            this.Units.ReadOnly = true;
            // 
            // Total
            // 
            // 
            // 
            // 
            this.Total.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.Total.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.Total.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Total.BackgroundStyle.TextColor = System.Drawing.Color.Black;
            this.Total.HeaderText = "Total";
            this.Total.Increment = 1D;
            this.Total.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
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
            this.labelX1.Location = new System.Drawing.Point(10, 30);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(61, 23);
            this.labelX1.TabIndex = 20;
            this.labelX1.Text = "Product";
            // 
            // grd_order_details
            // 
            this.grd_order_details.AllowUserToAddRows = false;
            this.grd_order_details.AllowUserToDeleteRows = false;
            this.grd_order_details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_order_details.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grd_order_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_order_details.DefaultCellStyle = dataGridViewCellStyle6;
            this.grd_order_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_order_details.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.grd_order_details.Location = new System.Drawing.Point(3, 21);
            this.grd_order_details.Name = "grd_order_details";
            this.grd_order_details.ReadOnly = true;
            this.grd_order_details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_order_details.Size = new System.Drawing.Size(476, 332);
            this.grd_order_details.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.grd_order_details);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(823, 359);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 356);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Details";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.grid_order);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(822, 235);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(483, 118);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "All Orders";
            // 
            // btn_home
            // 
            this.btn_home.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_home.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_home.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Location = new System.Drawing.Point(712, 235);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(98, 35);
            this.btn_home.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_home.TabIndex = 32;
            this.btn_home.Text = "Home";
            this.btn_home.Click += new System.EventHandler(this.btn_order_home_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_clear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(592, 235);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(114, 35);
            this.btn_clear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_clear.TabIndex = 31;
            this.btn_clear.Text = "Clear";
            this.btn_clear.Click += new System.EventHandler(this.btn_order_clear_Click);
            // 
            // Btn_show
            // 
            this.Btn_show.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Btn_show.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Btn_show.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_show.Location = new System.Drawing.Point(461, 235);
            this.Btn_show.Name = "Btn_show";
            this.Btn_show.Size = new System.Drawing.Size(125, 35);
            this.Btn_show.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Btn_show.TabIndex = 30;
            this.Btn_show.Text = "Show Record";
            // 
            // btn_delete
            // 
            this.btn_delete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_delete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(335, 235);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(120, 35);
            this.btn_delete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_delete.TabIndex = 29;
            this.btn_delete.Text = "Delete Record";
            this.btn_delete.Click += new System.EventHandler(this.btn_order_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_update.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(201, 235);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(128, 35);
            this.btn_update.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_update.TabIndex = 28;
            this.btn_update.Text = "Update Record";
            this.btn_update.Click += new System.EventHandler(this.btn_updateRecord_Click);
            // 
            // btn_save
            // 
            this.btn_save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(39, 235);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(156, 35);
            this.btn_save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_save.TabIndex = 27;
            this.btn_save.Text = "Save Record";
            this.btn_save.Click += new System.EventHandler(this.btn_order_save_Click);
            // 
            // lab_order_req5
            // 
            // 
            // 
            // 
            this.lab_order_req5.BackgroundStyle.Class = "";
            this.lab_order_req5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_order_req5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_order_req5.Location = new System.Drawing.Point(1206, 115);
            this.lab_order_req5.Name = "lab_order_req5";
            this.lab_order_req5.Size = new System.Drawing.Size(18, 23);
            this.lab_order_req5.TabIndex = 44;
            this.lab_order_req5.Text = "*";
            // 
            // lab_order_req3
            // 
            // 
            // 
            // 
            this.lab_order_req3.BackgroundStyle.Class = "";
            this.lab_order_req3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_order_req3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_order_req3.Location = new System.Drawing.Point(1206, 33);
            this.lab_order_req3.Name = "lab_order_req3";
            this.lab_order_req3.Size = new System.Drawing.Size(18, 23);
            this.lab_order_req3.TabIndex = 43;
            this.lab_order_req3.Text = "*";
            // 
            // dt_order_shdate
            // 
            this.dt_order_shdate.Location = new System.Drawing.Point(913, 115);
            this.dt_order_shdate.Name = "dt_order_shdate";
            this.dt_order_shdate.Size = new System.Drawing.Size(287, 25);
            this.dt_order_shdate.TabIndex = 42;
            // 
            // lab_order_shipdate
            // 
            this.lab_order_shipdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.lab_order_shipdate.BackgroundStyle.Class = "";
            this.lab_order_shipdate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_order_shipdate.ForeColor = System.Drawing.Color.Black;
            this.lab_order_shipdate.Location = new System.Drawing.Point(740, 118);
            this.lab_order_shipdate.Name = "lab_order_shipdate";
            this.lab_order_shipdate.Size = new System.Drawing.Size(101, 23);
            this.lab_order_shipdate.TabIndex = 41;
            this.lab_order_shipdate.Text = "Shipped Date";
            // 
            // dt_order_rdate
            // 
            this.dt_order_rdate.Location = new System.Drawing.Point(913, 73);
            this.dt_order_rdate.Name = "dt_order_rdate";
            this.dt_order_rdate.Size = new System.Drawing.Size(287, 25);
            this.dt_order_rdate.TabIndex = 40;
            // 
            // dt_order_date
            // 
            this.dt_order_date.Location = new System.Drawing.Point(913, 33);
            this.dt_order_date.Name = "dt_order_date";
            this.dt_order_date.Size = new System.Drawing.Size(287, 25);
            this.dt_order_date.TabIndex = 39;
            // 
            // lab_order_date
            // 
            this.lab_order_date.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.lab_order_date.BackgroundStyle.Class = "";
            this.lab_order_date.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_order_date.ForeColor = System.Drawing.Color.Black;
            this.lab_order_date.Location = new System.Drawing.Point(740, 35);
            this.lab_order_date.Name = "lab_order_date";
            this.lab_order_date.Size = new System.Drawing.Size(75, 23);
            this.lab_order_date.TabIndex = 38;
            this.lab_order_date.Text = "Order Date";
            // 
            // lab_order_reqdate
            // 
            this.lab_order_reqdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.lab_order_reqdate.BackgroundStyle.Class = "";
            this.lab_order_reqdate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_order_reqdate.ForeColor = System.Drawing.Color.Black;
            this.lab_order_reqdate.Location = new System.Drawing.Point(740, 76);
            this.lab_order_reqdate.Name = "lab_order_reqdate";
            this.lab_order_reqdate.Size = new System.Drawing.Size(101, 23);
            this.lab_order_reqdate.TabIndex = 37;
            this.lab_order_reqdate.Text = "Required Date";
            // 
            // lab_order_req6
            // 
            // 
            // 
            // 
            this.lab_order_req6.BackgroundStyle.Class = "";
            this.lab_order_req6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_order_req6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_order_req6.Location = new System.Drawing.Point(1206, 158);
            this.lab_order_req6.Name = "lab_order_req6";
            this.lab_order_req6.Size = new System.Drawing.Size(18, 23);
            this.lab_order_req6.TabIndex = 36;
            this.lab_order_req6.Text = "*";
            // 
            // lab_order_req4
            // 
            // 
            // 
            // 
            this.lab_order_req4.BackgroundStyle.Class = "";
            this.lab_order_req4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_order_req4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_order_req4.Location = new System.Drawing.Point(1206, 74);
            this.lab_order_req4.Name = "lab_order_req4";
            this.lab_order_req4.Size = new System.Drawing.Size(18, 23);
            this.lab_order_req4.TabIndex = 35;
            this.lab_order_req4.Text = "*";
            // 
            // lab_order_edate
            // 
            this.lab_order_edate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.lab_order_edate.BackgroundStyle.Class = "";
            this.lab_order_edate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_order_edate.ForeColor = System.Drawing.Color.Black;
            this.lab_order_edate.Location = new System.Drawing.Point(740, 157);
            this.lab_order_edate.Name = "lab_order_edate";
            this.lab_order_edate.Size = new System.Drawing.Size(75, 23);
            this.lab_order_edate.TabIndex = 34;
            this.lab_order_edate.Text = "Entry Date";
            // 
            // dt_order_edate
            // 
            this.dt_order_edate.Location = new System.Drawing.Point(913, 153);
            this.dt_order_edate.Name = "dt_order_edate";
            this.dt_order_edate.Size = new System.Drawing.Size(287, 25);
            this.dt_order_edate.TabIndex = 33;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1317, 727);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_show);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.grp_order_1);
            this.Controls.Add(this.btn_save);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_order)).EndInit();
            this.grp_order_1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_prods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_order_details)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX grid_order;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_order_ref;
        private DevComponents.DotNetBar.LabelX lab_order_req2;
        private DevComponents.DotNetBar.LabelX lab_order_req1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_order_name;
        private DevComponents.DotNetBar.LabelX lab_order_ref;
        private System.Windows.Forms.GroupBox grp_order_1;
        private DevComponents.DotNetBar.LabelX lab_order_name;
        private DevComponents.DotNetBar.LabelX lab_order_buyid;
        private System.Windows.Forms.ComboBox txt_order_buyer_name;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_units;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.Button btn_add;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_cp;
        private System.Windows.Forms.ComboBox combo_prod_names;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX grd_prods;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn Cost;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn Units;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn Total;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_order_total;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.DataGridViewX grd_order_details;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox combox_inv_curr;
        private DevComponents.DotNetBar.LabelX lab_inv_curr;
        private DevComponents.DotNetBar.LabelX lbl_id;
        private DevComponents.DotNetBar.ButtonX btn_home;
        private DevComponents.DotNetBar.ButtonX btn_clear;
        private DevComponents.DotNetBar.ButtonX Btn_show;
        private DevComponents.DotNetBar.ButtonX btn_delete;
        private DevComponents.DotNetBar.ButtonX btn_update;
        private DevComponents.DotNetBar.ButtonX btn_save;
        private DevComponents.DotNetBar.LabelX lab_order_req5;
        private DevComponents.DotNetBar.LabelX lab_order_req3;
        private System.Windows.Forms.DateTimePicker dt_order_shdate;
        private DevComponents.DotNetBar.LabelX lab_order_shipdate;
        private System.Windows.Forms.DateTimePicker dt_order_rdate;
        private System.Windows.Forms.DateTimePicker dt_order_date;
        private DevComponents.DotNetBar.LabelX lab_order_date;
        private DevComponents.DotNetBar.LabelX lab_order_reqdate;
        private DevComponents.DotNetBar.LabelX lab_order_req6;
        private DevComponents.DotNetBar.LabelX lab_order_req4;
        private DevComponents.DotNetBar.LabelX lab_order_edate;
        private System.Windows.Forms.DateTimePicker dt_order_edate;
    }
}