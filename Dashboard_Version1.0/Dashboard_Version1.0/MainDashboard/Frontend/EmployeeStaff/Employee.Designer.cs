namespace MainDashboard
{
    partial class Employee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cuiPanel6 = new CuoreUI.Controls.cuiPanel();
            DashboardHeader = new CuoreUI.Controls.cuiLabel();
            SearchBar = new CuoreUI.Controls.cuiTextBox();
            NotifIconBG = new CuoreUI.Controls.cuiGradientPanel();
            NotificationIcon = new CuoreUI.Controls.cuiPictureBox();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            FilterBtn = new CuoreUI.Controls.cuiButton();
            TableSearchBar = new CuoreUI.Controls.cuiTextBox();
            dataGridView1 = new DataGridView();
            cuiPanel6.SuspendLayout();
            NotifIconBG.SuspendLayout();
            cuiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cuiPanel6
            // 
            cuiPanel6.Controls.Add(DashboardHeader);
            cuiPanel6.Controls.Add(SearchBar);
            cuiPanel6.Controls.Add(NotifIconBG);
            cuiPanel6.Dock = DockStyle.Top;
            cuiPanel6.Location = new Point(0, 0);
            cuiPanel6.Margin = new Padding(3, 4, 3, 4);
            cuiPanel6.Name = "cuiPanel6";
            cuiPanel6.OutlineThickness = 1F;
            cuiPanel6.PanelColor = Color.AliceBlue;
            cuiPanel6.PanelOutlineColor = Color.Transparent;
            cuiPanel6.Rounding = new Padding(8);
            cuiPanel6.Size = new Size(1211, 81);
            cuiPanel6.TabIndex = 9;
            // 
            // DashboardHeader
            // 
            DashboardHeader.BackColor = Color.Transparent;
            DashboardHeader.Content = "Employee";
            DashboardHeader.Font = new Font("Leelawadee UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardHeader.HorizontalAlignment = StringAlignment.Near;
            DashboardHeader.Location = new Point(25, 4);
            DashboardHeader.Margin = new Padding(5, 4, 5, 4);
            DashboardHeader.Name = "DashboardHeader";
            DashboardHeader.Size = new Size(280, 72);
            DashboardHeader.TabIndex = 1;
            DashboardHeader.VerticalAlignment = StringAlignment.Center;
            // 
            // SearchBar
            // 
            SearchBar.BackColor = Color.Transparent;
            SearchBar.BackgroundColor = Color.White;
            SearchBar.Content = "";
            SearchBar.FocusBackgroundColor = Color.White;
            SearchBar.FocusImageTint = Color.White;
            SearchBar.FocusOutlineColor = Color.DarkGray;
            SearchBar.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchBar.ForeColor = Color.Gray;
            SearchBar.Image = null;
            SearchBar.ImageExpand = new Point(5, 5);
            SearchBar.ImageOffset = new Point(0, 0);
            SearchBar.Location = new Point(686, 13);
            SearchBar.Margin = new Padding(5, 5, 5, 5);
            SearchBar.Multiline = false;
            SearchBar.Name = "SearchBar";
            SearchBar.NormalImageTint = Color.Transparent;
            SearchBar.OutlineColor = Color.DarkGray;
            SearchBar.Padding = new Padding(22, 15, 22, 0);
            SearchBar.PasswordChar = false;
            SearchBar.PlaceholderColor = SystemColors.WindowText;
            SearchBar.PlaceholderText = "Search";
            SearchBar.Rounding = new Padding(8);
            SearchBar.Size = new Size(424, 53);
            SearchBar.TabIndex = 3;
            SearchBar.TextOffset = new Size(0, 0);
            SearchBar.UnderlinedStyle = true;
            // 
            // NotifIconBG
            // 
            NotifIconBG.Controls.Add(NotificationIcon);
            NotifIconBG.GradientAngle = 90F;
            NotifIconBG.Location = new Point(1131, 13);
            NotifIconBG.Margin = new Padding(3, 4, 3, 4);
            NotifIconBG.Name = "NotifIconBG";
            NotifIconBG.OutlineThickness = 1F;
            NotifIconBG.PanelColor1 = Color.White;
            NotifIconBG.PanelColor2 = Color.LightGray;
            NotifIconBG.PanelOutlineColor1 = Color.FromArgb(224, 224, 224);
            NotifIconBG.PanelOutlineColor2 = Color.Silver;
            NotifIconBG.Rounding = new Padding(8);
            NotifIconBG.Size = new Size(40, 47);
            NotifIconBG.TabIndex = 12;
            // 
            // NotificationIcon
            // 
            NotificationIcon.BackColor = Color.Transparent;
            NotificationIcon.BackgroundImage = Properties.Resources.bell;
            NotificationIcon.BackgroundImageLayout = ImageLayout.Zoom;
            NotificationIcon.Content = null;
            NotificationIcon.ImageTint = Color.White;
            NotificationIcon.Location = new Point(5, 4);
            NotificationIcon.Margin = new Padding(5, 4, 5, 4);
            NotificationIcon.Name = "NotificationIcon";
            NotificationIcon.OutlineThickness = 1F;
            NotificationIcon.PanelOutlineColor = Color.Empty;
            NotificationIcon.Rotation = 0;
            NotificationIcon.Rounding = new Padding(8);
            NotificationIcon.Size = new Size(32, 37);
            NotificationIcon.TabIndex = 0;
            // 
            // cuiPanel1
            // 
            cuiPanel1.Controls.Add(cuiButton1);
            cuiPanel1.Controls.Add(cuiLabel1);
            cuiPanel1.Controls.Add(FilterBtn);
            cuiPanel1.Controls.Add(TableSearchBar);
            cuiPanel1.Controls.Add(dataGridView1);
            cuiPanel1.Location = new Point(34, 133);
            cuiPanel1.Margin = new Padding(3, 4, 3, 4);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.FromArgb(224, 224, 224);
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(1143, 1200);
            cuiPanel1.TabIndex = 11;
            // 
            // cuiButton1
            // 
            cuiButton1.BackColor = Color.Transparent;
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton1.CheckedForeColor = Color.White;
            cuiButton1.CheckedImageTint = Color.White;
            cuiButton1.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton1.Content = "Add Employee";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiButton1.ForeColor = Color.White;
            cuiButton1.HoverBackground = Color.SteelBlue;
            cuiButton1.HoveredImageTint = Color.White;
            cuiButton1.HoverForeColor = Color.White;
            cuiButton1.HoverOutline = Color.SteelBlue;
            cuiButton1.Image = Properties.Resources.user_plus;
            cuiButton1.ImageAutoCenter = true;
            cuiButton1.ImageExpand = new Point(3, 3);
            cuiButton1.ImageOffset = new Point(-7, 0);
            cuiButton1.Location = new Point(784, 11);
            cuiButton1.Margin = new Padding(3, 4, 3, 4);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.SteelBlue;
            cuiButton1.NormalForeColor = Color.White;
            cuiButton1.NormalImageTint = Color.White;
            cuiButton1.NormalOutline = Color.Transparent;
            cuiButton1.OutlineThickness = 1F;
            cuiButton1.PressedBackground = Color.FromArgb(49, 93, 130);
            cuiButton1.PressedForeColor = Color.White;
            cuiButton1.PressedImageTint = Color.White;
            cuiButton1.PressedOutline = Color.FromArgb(33, 64, 89);
            cuiButton1.Rounding = new Padding(8);
            cuiButton1.Size = new Size(192, 60);
            cuiButton1.TabIndex = 17;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextOffset = new Point(0, 0);
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = "Showing";
            cuiLabel1.Font = new Font("Leelawadee UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel1.HorizontalAlignment = StringAlignment.Near;
            cuiLabel1.Location = new Point(42, 1115);
            cuiLabel1.Margin = new Padding(5, 4, 5, 4);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(65, 32);
            cuiLabel1.TabIndex = 16;
            cuiLabel1.VerticalAlignment = StringAlignment.Center;
            // 
            // FilterBtn
            // 
            FilterBtn.AutoScroll = true;
            FilterBtn.BackColor = Color.Transparent;
            FilterBtn.CheckButton = false;
            FilterBtn.Checked = false;
            FilterBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            FilterBtn.CheckedForeColor = Color.White;
            FilterBtn.CheckedImageTint = Color.White;
            FilterBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            FilterBtn.Content = "Filter";
            FilterBtn.DialogResult = DialogResult.None;
            FilterBtn.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FilterBtn.ForeColor = Color.Black;
            FilterBtn.HoverBackground = Color.White;
            FilterBtn.HoveredImageTint = Color.White;
            FilterBtn.HoverForeColor = Color.Black;
            FilterBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            FilterBtn.Image = Properties.Resources.sliders_horizontal;
            FilterBtn.ImageAutoCenter = true;
            FilterBtn.ImageExpand = new Point(0, 0);
            FilterBtn.ImageOffset = new Point(-5, 0);
            FilterBtn.Location = new Point(994, 11);
            FilterBtn.Margin = new Padding(3, 4, 3, 4);
            FilterBtn.Name = "FilterBtn";
            FilterBtn.NormalBackground = Color.White;
            FilterBtn.NormalForeColor = Color.Black;
            FilterBtn.NormalImageTint = Color.White;
            FilterBtn.NormalOutline = Color.Black;
            FilterBtn.OutlineThickness = 1F;
            FilterBtn.PressedBackground = Color.WhiteSmoke;
            FilterBtn.PressedForeColor = Color.Black;
            FilterBtn.PressedImageTint = Color.White;
            FilterBtn.PressedOutline = Color.Black;
            FilterBtn.Rounding = new Padding(8);
            FilterBtn.Size = new Size(120, 60);
            FilterBtn.TabIndex = 15;
            FilterBtn.TextAlignment = StringAlignment.Center;
            FilterBtn.TextOffset = new Point(0, 0);
            // 
            // TableSearchBar
            // 
            TableSearchBar.BackColor = Color.Transparent;
            TableSearchBar.BackgroundColor = Color.White;
            TableSearchBar.BorderStyle = BorderStyle.FixedSingle;
            TableSearchBar.Content = "";
            TableSearchBar.FocusBackgroundColor = Color.White;
            TableSearchBar.FocusImageTint = Color.White;
            TableSearchBar.FocusOutlineColor = Color.Transparent;
            TableSearchBar.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TableSearchBar.ForeColor = Color.Gray;
            TableSearchBar.Image = null;
            TableSearchBar.ImageExpand = new Point(0, 0);
            TableSearchBar.ImageOffset = new Point(0, 0);
            TableSearchBar.Location = new Point(29, 13);
            TableSearchBar.Margin = new Padding(5, 5, 5, 5);
            TableSearchBar.Multiline = false;
            TableSearchBar.Name = "TableSearchBar";
            TableSearchBar.NormalImageTint = Color.Transparent;
            TableSearchBar.OutlineColor = Color.Transparent;
            TableSearchBar.Padding = new Padding(22, 15, 22, 0);
            TableSearchBar.PasswordChar = false;
            TableSearchBar.PlaceholderColor = SystemColors.WindowText;
            TableSearchBar.PlaceholderText = "Search";
            TableSearchBar.Rounding = new Padding(8);
            TableSearchBar.Size = new Size(424, 53);
            TableSearchBar.TabIndex = 13;
            TableSearchBar.TextOffset = new Size(0, 0);
            TableSearchBar.UnderlinedStyle = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 80);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1086, 980);
            dataGridView1.TabIndex = 0;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            Controls.Add(cuiPanel1);
            Controls.Add(cuiPanel6);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Employee";
            Size = new Size(1211, 1467);
            Load += Employee_Load;
            cuiPanel6.ResumeLayout(false);
            NotifIconBG.ResumeLayout(false);
            cuiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel6;
        private CuoreUI.Controls.cuiLabel DashboardHeader;
        private CuoreUI.Controls.cuiTextBox SearchBar;
        private CuoreUI.Controls.cuiGradientPanel NotifIconBG;
        private CuoreUI.Controls.cuiPictureBox NotificationIcon;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiButton FilterBtn;
        private CuoreUI.Controls.cuiTextBox TableSearchBar;
        private DataGridView dataGridView1;
        private CuoreUI.Controls.cuiButton cuiButton1;
    }
}
