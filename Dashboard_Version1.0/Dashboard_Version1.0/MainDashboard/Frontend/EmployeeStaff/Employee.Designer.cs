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
            cuiButton2 = new CuoreUI.Controls.cuiButton();
            AddBtn = new CuoreUI.Controls.cuiButton();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            FilterBtn = new CuoreUI.Controls.cuiButton();
            TableSearchBar = new CuoreUI.Controls.cuiTextBox();
            EmployeeStaffGridView = new DataGridView();
            EmployeeName = new DataGridViewTextBoxColumn();
            EmployeePosition = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            cuiPanel6.SuspendLayout();
            NotifIconBG.SuspendLayout();
            cuiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeeStaffGridView).BeginInit();
            SuspendLayout();
            // 
            // cuiPanel6
            // 
            cuiPanel6.Controls.Add(DashboardHeader);
            cuiPanel6.Controls.Add(SearchBar);
            cuiPanel6.Controls.Add(NotifIconBG);
            cuiPanel6.Dock = DockStyle.Top;
            cuiPanel6.Location = new Point(0, 0);
            cuiPanel6.Name = "cuiPanel6";
            cuiPanel6.OutlineThickness = 1F;
            cuiPanel6.PanelColor = Color.AliceBlue;
            cuiPanel6.PanelOutlineColor = Color.Transparent;
            cuiPanel6.Rounding = new Padding(8);
            cuiPanel6.Size = new Size(1211, 61);
            cuiPanel6.TabIndex = 9;
            // 
            // DashboardHeader
            // 
            DashboardHeader.BackColor = Color.Transparent;
            DashboardHeader.Content = "Employee";
            DashboardHeader.Font = new Font("Leelawadee UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardHeader.HorizontalAlignment = StringAlignment.Near;
            DashboardHeader.Location = new Point(22, 3);
            DashboardHeader.Margin = new Padding(4, 3, 4, 3);
            DashboardHeader.Name = "DashboardHeader";
            DashboardHeader.Size = new Size(245, 54);
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
            SearchBar.Margin = new Padding(5);
            SearchBar.Multiline = false;
            SearchBar.Name = "SearchBar";
            SearchBar.NormalImageTint = Color.Transparent;
            SearchBar.OutlineColor = Color.DarkGray;
            SearchBar.Padding = new Padding(18, 11, 18, 0);
            SearchBar.PasswordChar = false;
            SearchBar.PlaceholderColor = SystemColors.WindowText;
            SearchBar.PlaceholderText = "Search";
            SearchBar.Rounding = new Padding(8);
            SearchBar.Size = new Size(371, 40);
            SearchBar.TabIndex = 3;
            SearchBar.TextOffset = new Size(0, 0);
            SearchBar.UnderlinedStyle = true;
            // 
            // NotifIconBG
            // 
            NotifIconBG.Controls.Add(NotificationIcon);
            NotifIconBG.GradientAngle = 90F;
            NotifIconBG.Location = new Point(990, 10);
            NotifIconBG.Name = "NotifIconBG";
            NotifIconBG.OutlineThickness = 1F;
            NotifIconBG.PanelColor1 = Color.White;
            NotifIconBG.PanelColor2 = Color.LightGray;
            NotifIconBG.PanelOutlineColor1 = Color.FromArgb(224, 224, 224);
            NotifIconBG.PanelOutlineColor2 = Color.Silver;
            NotifIconBG.Rounding = new Padding(8);
            NotifIconBG.Size = new Size(35, 35);
            NotifIconBG.TabIndex = 12;
            // 
            // NotificationIcon
            // 
            NotificationIcon.BackColor = Color.Transparent;
            NotificationIcon.BackgroundImage = Properties.Resources.bell;
            NotificationIcon.BackgroundImageLayout = ImageLayout.Zoom;
            NotificationIcon.Content = null;
            NotificationIcon.ImageTint = Color.White;
            NotificationIcon.Location = new Point(4, 3);
            NotificationIcon.Margin = new Padding(4, 3, 4, 3);
            NotificationIcon.Name = "NotificationIcon";
            NotificationIcon.OutlineThickness = 1F;
            NotificationIcon.PanelOutlineColor = Color.Empty;
            NotificationIcon.Rotation = 0;
            NotificationIcon.Rounding = new Padding(8);
            NotificationIcon.Size = new Size(28, 28);
            NotificationIcon.TabIndex = 0;
            // 
            // cuiPanel1
            // 
            cuiPanel1.Controls.Add(cuiButton2);
            cuiPanel1.Controls.Add(AddBtn);
            cuiPanel1.Controls.Add(cuiLabel1);
            cuiPanel1.Controls.Add(FilterBtn);
            cuiPanel1.Controls.Add(TableSearchBar);
            cuiPanel1.Controls.Add(EmployeeStaffGridView);
            cuiPanel1.Location = new Point(34, 133);
            cuiPanel1.Margin = new Padding(3, 4, 3, 4);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.FromArgb(224, 224, 224);
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(1000, 900);
            cuiPanel1.TabIndex = 11;
            // 
            // cuiButton2
            // 
            cuiButton2.AutoScroll = true;
            cuiButton2.BackColor = Color.Transparent;
            cuiButton2.CheckButton = false;
            cuiButton2.Checked = false;
            cuiButton2.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton2.CheckedForeColor = Color.White;
            cuiButton2.CheckedImageTint = Color.White;
            cuiButton2.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton2.Content = "Assign Employee";
            cuiButton2.DialogResult = DialogResult.None;
            cuiButton2.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiButton2.ForeColor = Color.White;
            cuiButton2.HoverBackground = Color.SteelBlue;
            cuiButton2.HoveredImageTint = Color.White;
            cuiButton2.HoverForeColor = Color.White;
            cuiButton2.HoverOutline = Color.SteelBlue;
            cuiButton2.Image = Properties.Resources.user_cog;
            cuiButton2.ImageAutoCenter = true;
            cuiButton2.ImageExpand = new Point(3, 3);
            cuiButton2.ImageOffset = new Point(-7, 0);
            cuiButton2.Location = new Point(673, 8);
            cuiButton2.Name = "cuiButton2";
            cuiButton2.NormalBackground = Color.SteelBlue;
            cuiButton2.NormalForeColor = Color.White;
            cuiButton2.NormalImageTint = Color.White;
            cuiButton2.NormalOutline = Color.Transparent;
            cuiButton2.OutlineThickness = 1F;
            cuiButton2.PressedBackground = Color.FromArgb(49, 93, 130);
            cuiButton2.PressedForeColor = Color.White;
            cuiButton2.PressedImageTint = Color.White;
            cuiButton2.PressedOutline = Color.FromArgb(33, 64, 89);
            cuiButton2.Rounding = new Padding(8);
            cuiButton2.Size = new Size(191, 45);
            cuiButton2.TabIndex = 18;
            cuiButton2.TextAlignment = StringAlignment.Center;
            cuiButton2.TextOffset = new Point(0, 0);
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Transparent;
            AddBtn.CheckButton = false;
            AddBtn.Checked = false;
            AddBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            AddBtn.CheckedForeColor = Color.White;
            AddBtn.CheckedImageTint = Color.White;
            AddBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            AddBtn.Content = "Add Employee";
            AddBtn.DialogResult = DialogResult.None;
            AddBtn.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.White;
            AddBtn.HoverBackground = Color.SteelBlue;
            AddBtn.HoveredImageTint = Color.White;
            AddBtn.HoverForeColor = Color.White;
            AddBtn.HoverOutline = Color.SteelBlue;
            AddBtn.Image = Properties.Resources.user_plus;
            AddBtn.ImageAutoCenter = true;
            AddBtn.ImageExpand = new Point(3, 3);
            AddBtn.ImageOffset = new Point(-7, 0);
            AddBtn.Location = new Point(495, 8);
            AddBtn.Margin = new Padding(3, 4, 3, 4);
            AddBtn.Name = "AddBtn";
            AddBtn.NormalBackground = Color.SteelBlue;
            AddBtn.NormalForeColor = Color.White;
            AddBtn.NormalImageTint = Color.White;
            AddBtn.NormalOutline = Color.Transparent;
            AddBtn.OutlineThickness = 1F;
            AddBtn.PressedBackground = Color.FromArgb(49, 93, 130);
            AddBtn.PressedForeColor = Color.White;
            AddBtn.PressedImageTint = Color.White;
            AddBtn.PressedOutline = Color.FromArgb(33, 64, 89);
            AddBtn.Rounding = new Padding(8);
            AddBtn.Size = new Size(172, 45);
            AddBtn.TabIndex = 17;
            AddBtn.TextAlignment = StringAlignment.Center;
            AddBtn.TextOffset = new Point(0, 0);
            AddBtn.Click += AddBtn_Click;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = "Showing";
            cuiLabel1.Font = new Font("Leelawadee UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel1.HorizontalAlignment = StringAlignment.Near;
            cuiLabel1.Location = new Point(37, 836);
            cuiLabel1.Margin = new Padding(4, 3, 4, 3);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(57, 24);
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
            FilterBtn.Location = new Point(870, 8);
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
            FilterBtn.Size = new Size(105, 45);
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
            TableSearchBar.Margin = new Padding(5);
            TableSearchBar.Multiline = false;
            TableSearchBar.Name = "TableSearchBar";
            TableSearchBar.NormalImageTint = Color.Transparent;
            TableSearchBar.OutlineColor = Color.Transparent;
            TableSearchBar.Padding = new Padding(18, 11, 18, 0);
            TableSearchBar.PasswordChar = false;
            TableSearchBar.PlaceholderColor = SystemColors.WindowText;
            TableSearchBar.PlaceholderText = "Search";
            TableSearchBar.Rounding = new Padding(8);
            TableSearchBar.Size = new Size(371, 40);
            TableSearchBar.TabIndex = 13;
            TableSearchBar.TextOffset = new Size(0, 0);
            TableSearchBar.UnderlinedStyle = true;
            // 
            // EmployeeStaffGridView
            // 
            EmployeeStaffGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EmployeeStaffGridView.BackgroundColor = SystemColors.ControlLight;
            EmployeeStaffGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeeStaffGridView.Columns.AddRange(new DataGridViewColumn[] { EmployeeName, EmployeePosition, Email, Edit, Delete });
            EmployeeStaffGridView.Location = new Point(29, 80);
            EmployeeStaffGridView.Margin = new Padding(3, 4, 3, 4);
            EmployeeStaffGridView.Name = "EmployeeStaffGridView";
            EmployeeStaffGridView.RowHeadersWidth = 51;
            EmployeeStaffGridView.Size = new Size(946, 803);
            EmployeeStaffGridView.TabIndex = 0;
            EmployeeStaffGridView.CellContentClick += EmployeeStaffGridView_CellContentClick;
            // 
            // EmployeeName
            // 
            EmployeeName.HeaderText = "Employee Name";
            EmployeeName.MinimumWidth = 6;
            EmployeeName.Name = "EmployeeName";
            // 
            // EmployeePosition
            // 
            EmployeePosition.HeaderText = "Position";
            EmployeePosition.MinimumWidth = 6;
            EmployeePosition.Name = "EmployeePosition";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.Image = Properties.Resources.pencil;
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Image = Properties.Resources.trash_2;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            Controls.Add(cuiPanel1);
            Controls.Add(cuiPanel6);
            Name = "Employee";
            Size = new Size(1211, 1467);
            Load += Employee_Load;
            cuiPanel6.ResumeLayout(false);
            NotifIconBG.ResumeLayout(false);
            cuiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EmployeeStaffGridView).EndInit();
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
        private CuoreUI.Controls.cuiButton cuiButton2;
        private DataGridView EmployeeStaffGridView;
        private CuoreUI.Controls.cuiButton AddBtn;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn EmployeePosition;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}
