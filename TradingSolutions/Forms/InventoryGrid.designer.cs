namespace TradingSolutions.Forms
{
    partial class grdInventoryGrid
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
            this.dtFrom = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dtTo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdInventory = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdInventory.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFrom
            // 
            // 
            // 
            // 
            this.dtFrom.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFrom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFrom.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFrom.ButtonDropDown.Visible = true;
            this.dtFrom.IsPopupCalendarOpen = false;
            this.dtFrom.Location = new System.Drawing.Point(175, 12);
            // 
            // 
            // 
            this.dtFrom.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFrom.MonthCalendar.BackgroundStyle.Class = "";
            this.dtFrom.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFrom.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFrom.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFrom.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFrom.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFrom.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFrom.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtFrom.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFrom.MonthCalendar.DisplayMonth = new System.DateTime(2013, 5, 1, 0, 0, 0, 0);
            this.dtFrom.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtFrom.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFrom.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFrom.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFrom.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFrom.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtFrom.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFrom.MonthCalendar.TodayButtonVisible = true;
            this.dtFrom.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(200, 22);
            this.dtFrom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFrom.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(94, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "FROM";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(384, 12);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "TO";
            // 
            // dtTo
            // 
            // 
            // 
            // 
            this.dtTo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTo.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtTo.ButtonDropDown.Visible = true;
            this.dtTo.IsPopupCalendarOpen = false;
            this.dtTo.Location = new System.Drawing.Point(465, 13);
            // 
            // 
            // 
            this.dtTo.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtTo.MonthCalendar.BackgroundStyle.Class = "";
            this.dtTo.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTo.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtTo.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtTo.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtTo.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtTo.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtTo.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtTo.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtTo.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtTo.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTo.MonthCalendar.DisplayMonth = new System.DateTime(2013, 5, 1, 0, 0, 0, 0);
            this.dtTo.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtTo.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtTo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtTo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtTo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtTo.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtTo.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTo.MonthCalendar.TodayButtonVisible = true;
            this.dtTo.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(200, 22);
            this.dtTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtTo.TabIndex = 3;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(94, 71);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(251, 42);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 4;
            this.buttonX1.Text = "FILTER";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdInventory);
            this.groupBox1.Location = new System.Drawing.Point(94, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1264, 619);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INVENTORY BY PRODUCTS";
            // 
            // grdInventory
            // 
            this.grdInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdInventory.EnableFastScrolling = true;
            this.grdInventory.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdInventory.Location = new System.Drawing.Point(3, 18);
            // 
            // grdInventory
            // 
            this.grdInventory.MasterTemplate.AllowAddNewRow = false;
            this.grdInventory.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.grdInventory.MasterTemplate.AllowColumnReorder = false;
            this.grdInventory.MasterTemplate.AllowDeleteRow = false;
            this.grdInventory.MasterTemplate.AllowDragToGroup = false;
            this.grdInventory.MasterTemplate.AllowEditRow = false;
            this.grdInventory.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.grdInventory.MasterTemplate.EnableFiltering = true;
            this.grdInventory.Name = "grdInventory";
            this.grdInventory.ShowGroupPanel = false;
            this.grdInventory.Size = new System.Drawing.Size(1258, 598);
            this.grdInventory.TabIndex = 1;
            // 
            // grdInventoryGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dtFrom);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "grdInventoryGrid";
            this.Text = "MetroForm";
            this.Load += new System.EventHandler(this.grdInventoryGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdInventory.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFrom;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtTo;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadGridView grdInventory;
    }
}