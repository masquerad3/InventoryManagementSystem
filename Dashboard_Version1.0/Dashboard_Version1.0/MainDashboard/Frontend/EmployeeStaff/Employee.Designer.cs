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
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            AddBtn = new CuoreUI.Controls.cuiButton();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            EmployeeStaffGridView = new DataGridView();
            EmployeeName = new DataGridViewTextBoxColumn();
            EmployeePosition = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            cuiPanel6.SuspendLayout();
            cuiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeeStaffGridView).BeginInit();
            SuspendLayout();
            // 
            // cuiPanel6
            // 
            cuiPanel6.Controls.Add(AddBtn);
            cuiPanel6.Controls.Add(DashboardHeader);
            cuiPanel6.Dock = DockStyle.Top;
            cuiPanel6.Location = new Point(0, 0);
            cuiPanel6.Margin = new Padding(3, 4, 3, 4);
            cuiPanel6.Name = "cuiPanel6";
            cuiPanel6.OutlineThickness = 1F;
            cuiPanel6.PanelColor = Color.AliceBlue;
            cuiPanel6.PanelOutlineColor = Color.Transparent;
            cuiPanel6.Rounding = new Padding(8);
            cuiPanel6.Size = new Size(1384, 81);
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
            // cuiPanel1
            // 
            cuiPanel1.Controls.Add(cuiLabel1);
            cuiPanel1.Controls.Add(EmployeeStaffGridView);
            cuiPanel1.Location = new Point(39, 177);
            cuiPanel1.Margin = new Padding(3, 5, 3, 5);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.FromArgb(224, 224, 224);
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(1143, 1200);
            cuiPanel1.TabIndex = 11;
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
            AddBtn.Location = new Point(985, 16);
            AddBtn.Margin = new Padding(3, 5, 3, 5);
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
            AddBtn.Size = new Size(197, 60);
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
            cuiLabel1.Location = new Point(42, 1115);
            cuiLabel1.Margin = new Padding(5, 4, 5, 4);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(65, 32);
            cuiLabel1.TabIndex = 16;
            cuiLabel1.VerticalAlignment = StringAlignment.Center;
            // 
            // EmployeeStaffGridView
            // 
            EmployeeStaffGridView.AllowUserToAddRows = false;
            EmployeeStaffGridView.AllowUserToDeleteRows = false;
            EmployeeStaffGridView.AllowUserToOrderColumns = true;
            EmployeeStaffGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EmployeeStaffGridView.BackgroundColor = SystemColors.ControlLight;
            EmployeeStaffGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeeStaffGridView.Columns.AddRange(new DataGridViewColumn[] { EmployeeName, EmployeePosition, Email, Edit, Delete });
            EmployeeStaffGridView.Location = new Point(42, 35);
            EmployeeStaffGridView.Margin = new Padding(3, 5, 3, 5);
            EmployeeStaffGridView.Name = "EmployeeStaffGridView";
            EmployeeStaffGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            EmployeeStaffGridView.RowHeadersVisible = false;
            EmployeeStaffGridView.RowHeadersWidth = 51;
            EmployeeStaffGridView.Size = new Size(1081, 1071);
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
            Edit.Description = "Edit";
            Edit.HeaderText = "Edit";
            Edit.Image = Properties.Resources.pencil1;
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.False;
            // 
            // Delete
            // 
            Delete.Description = "Delete";
            Delete.HeaderText = "Delete";
            Delete.Image = Properties.Resources.trash_21;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Resizable = DataGridViewTriState.False;
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
            Size = new Size(1384, 1956);
            Load += Employee_Load;
            cuiPanel6.ResumeLayout(false);
            cuiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EmployeeStaffGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel6;
        private CuoreUI.Controls.cuiLabel DashboardHeader;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private DataGridView dataGridView1;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private DataGridView EmployeeStaffGridView;
        private CuoreUI.Controls.cuiButton AddBtn;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn EmployeePosition;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}
