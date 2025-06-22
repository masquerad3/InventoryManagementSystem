namespace MainDashboard
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            DashboardPanel = new CuoreUI.Controls.cuiPanel();
            LogoutBtn = new CuoreUI.Controls.cuiButton();
            EmployeeBtn = new CuoreUI.Controls.cuiButton();
            BatchBtn = new CuoreUI.Controls.cuiButton();
            ProductAlertBtn = new CuoreUI.Controls.cuiButton();
            InventoryBtn = new CuoreUI.Controls.cuiButton();
            DashboardBtn = new CuoreUI.Controls.cuiButton();
            ProfileLabel = new CuoreUI.Controls.cuiLabel();
            ProfilePicture = new CuoreUI.Controls.cuiPictureBox();
            ProfileName = new CuoreUI.Controls.cuiLabel();
            dashboardContent1 = new DashboardContent();
            inventory1 = new Inventory();
            DashboardPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(706, 536);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(706, 536);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // DashboardPanel
            // 
            DashboardPanel.BackColor = Color.Transparent;
            DashboardPanel.Controls.Add(LogoutBtn);
            DashboardPanel.Controls.Add(EmployeeBtn);
            DashboardPanel.Controls.Add(BatchBtn);
            DashboardPanel.Controls.Add(ProductAlertBtn);
            DashboardPanel.Controls.Add(InventoryBtn);
            DashboardPanel.Controls.Add(DashboardBtn);
            DashboardPanel.Controls.Add(ProfileLabel);
            DashboardPanel.Controls.Add(ProfilePicture);
            DashboardPanel.Controls.Add(ProfileName);
            DashboardPanel.Dock = DockStyle.Left;
            DashboardPanel.Location = new Point(0, 0);
            DashboardPanel.Name = "DashboardPanel";
            DashboardPanel.OutlineThickness = 1F;
            DashboardPanel.PanelColor = Color.LightSkyBlue;
            DashboardPanel.PanelOutlineColor = Color.Transparent;
            DashboardPanel.Rounding = new Padding(8, 0, 0, 8);
            DashboardPanel.Size = new Size(224, 681);
            DashboardPanel.TabIndex = 0;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.Transparent;
            LogoutBtn.CheckButton = false;
            LogoutBtn.Checked = false;
            LogoutBtn.CheckedBackground = Color.Transparent;
            LogoutBtn.CheckedForeColor = Color.Transparent;
            LogoutBtn.CheckedImageTint = Color.Transparent;
            LogoutBtn.CheckedOutline = Color.Transparent;
            LogoutBtn.Content = "Logout";
            LogoutBtn.DialogResult = DialogResult.None;
            LogoutBtn.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoutBtn.ForeColor = SystemColors.ControlText;
            LogoutBtn.HoverBackground = Color.Transparent;
            LogoutBtn.HoveredImageTint = Color.Black;
            LogoutBtn.HoverForeColor = Color.Black;
            LogoutBtn.HoverOutline = Color.Transparent;
            LogoutBtn.Image = (Image)resources.GetObject("LogoutBtn.Image");
            LogoutBtn.ImageAutoCenter = true;
            LogoutBtn.ImageExpand = new Point(0, 0);
            LogoutBtn.ImageOffset = new Point(-60, 0);
            LogoutBtn.Location = new Point(0, 636);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.NormalBackground = Color.Transparent;
            LogoutBtn.NormalForeColor = SystemColors.ControlText;
            LogoutBtn.NormalImageTint = Color.Black;
            LogoutBtn.NormalOutline = Color.Transparent;
            LogoutBtn.OutlineThickness = 1F;
            LogoutBtn.PressedBackground = Color.Transparent;
            LogoutBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            LogoutBtn.PressedImageTint = Color.Transparent;
            LogoutBtn.PressedOutline = Color.Transparent;
            LogoutBtn.Rounding = new Padding(8);
            LogoutBtn.Size = new Size(224, 45);
            LogoutBtn.TabIndex = 6;
            LogoutBtn.TextAlignment = StringAlignment.Near;
            LogoutBtn.TextOffset = new Point(35, 0);
            // 
            // EmployeeBtn
            // 
            EmployeeBtn.BackColor = Color.Transparent;
            EmployeeBtn.CheckButton = false;
            EmployeeBtn.Checked = false;
            EmployeeBtn.CheckedBackground = Color.Transparent;
            EmployeeBtn.CheckedForeColor = Color.Transparent;
            EmployeeBtn.CheckedImageTint = Color.Transparent;
            EmployeeBtn.CheckedOutline = Color.Transparent;
            EmployeeBtn.Content = "Employees";
            EmployeeBtn.DialogResult = DialogResult.None;
            EmployeeBtn.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmployeeBtn.ForeColor = SystemColors.ControlText;
            EmployeeBtn.HoverBackground = Color.Transparent;
            EmployeeBtn.HoveredImageTint = SystemColors.ControlText;
            EmployeeBtn.HoverForeColor = SystemColors.ControlText;
            EmployeeBtn.HoverOutline = Color.Transparent;
            EmployeeBtn.Image = (Image)resources.GetObject("EmployeeBtn.Image");
            EmployeeBtn.ImageAutoCenter = true;
            EmployeeBtn.ImageExpand = new Point(0, 0);
            EmployeeBtn.ImageOffset = new Point(-27, 0);
            EmployeeBtn.Location = new Point(0, 298);
            EmployeeBtn.Name = "EmployeeBtn";
            EmployeeBtn.NormalBackground = Color.Transparent;
            EmployeeBtn.NormalForeColor = SystemColors.ControlText;
            EmployeeBtn.NormalImageTint = Color.Black;
            EmployeeBtn.NormalOutline = Color.Transparent;
            EmployeeBtn.OutlineThickness = 1F;
            EmployeeBtn.PressedBackground = Color.Transparent;
            EmployeeBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            EmployeeBtn.PressedImageTint = Color.Transparent;
            EmployeeBtn.PressedOutline = Color.Transparent;
            EmployeeBtn.Rounding = new Padding(8);
            EmployeeBtn.Size = new Size(224, 45);
            EmployeeBtn.TabIndex = 4;
            EmployeeBtn.TextAlignment = StringAlignment.Near;
            EmployeeBtn.TextOffset = new Point(50, 0);
            // 
            // BatchBtn
            // 
            BatchBtn.BackColor = Color.Transparent;
            BatchBtn.CheckButton = false;
            BatchBtn.Checked = false;
            BatchBtn.CheckedBackground = Color.Transparent;
            BatchBtn.CheckedForeColor = Color.Transparent;
            BatchBtn.CheckedImageTint = Color.Transparent;
            BatchBtn.CheckedOutline = Color.Transparent;
            BatchBtn.Content = "Batch";
            BatchBtn.DialogResult = DialogResult.None;
            BatchBtn.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BatchBtn.ForeColor = SystemColors.ControlText;
            BatchBtn.HoverBackground = Color.Transparent;
            BatchBtn.HoveredImageTint = SystemColors.ControlText;
            BatchBtn.HoverForeColor = SystemColors.ControlText;
            BatchBtn.HoverOutline = Color.Transparent;
            BatchBtn.Image = (Image)resources.GetObject("BatchBtn.Image");
            BatchBtn.ImageAutoCenter = true;
            BatchBtn.ImageExpand = new Point(0, 0);
            BatchBtn.ImageOffset = new Point(-47, 0);
            BatchBtn.Location = new Point(0, 247);
            BatchBtn.Name = "BatchBtn";
            BatchBtn.NormalBackground = Color.Transparent;
            BatchBtn.NormalForeColor = SystemColors.ControlText;
            BatchBtn.NormalImageTint = Color.Black;
            BatchBtn.NormalOutline = Color.Transparent;
            BatchBtn.OutlineThickness = 1F;
            BatchBtn.PressedBackground = Color.Transparent;
            BatchBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            BatchBtn.PressedImageTint = Color.Transparent;
            BatchBtn.PressedOutline = Color.Transparent;
            BatchBtn.Rounding = new Padding(8);
            BatchBtn.Size = new Size(224, 45);
            BatchBtn.TabIndex = 4;
            BatchBtn.TextAlignment = StringAlignment.Near;
            BatchBtn.TextOffset = new Point(50, 0);
            // 
            // ProductAlertBtn
            // 
            ProductAlertBtn.BackColor = Color.Transparent;
            ProductAlertBtn.CheckButton = false;
            ProductAlertBtn.Checked = false;
            ProductAlertBtn.CheckedBackground = Color.Transparent;
            ProductAlertBtn.CheckedForeColor = Color.Transparent;
            ProductAlertBtn.CheckedImageTint = Color.Transparent;
            ProductAlertBtn.CheckedOutline = Color.Transparent;
            ProductAlertBtn.Content = "Product Alert";
            ProductAlertBtn.DialogResult = DialogResult.None;
            ProductAlertBtn.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductAlertBtn.ForeColor = SystemColors.ControlText;
            ProductAlertBtn.HoverBackground = Color.Transparent;
            ProductAlertBtn.HoveredImageTint = SystemColors.ControlText;
            ProductAlertBtn.HoverForeColor = SystemColors.ControlText;
            ProductAlertBtn.HoverOutline = Color.Transparent;
            ProductAlertBtn.Image = (Image)resources.GetObject("ProductAlertBtn.Image");
            ProductAlertBtn.ImageAutoCenter = true;
            ProductAlertBtn.ImageExpand = new Point(0, 0);
            ProductAlertBtn.ImageOffset = new Point(-20, 0);
            ProductAlertBtn.Location = new Point(0, 196);
            ProductAlertBtn.Name = "ProductAlertBtn";
            ProductAlertBtn.NormalBackground = Color.Transparent;
            ProductAlertBtn.NormalForeColor = SystemColors.ControlText;
            ProductAlertBtn.NormalImageTint = Color.Black;
            ProductAlertBtn.NormalOutline = Color.Transparent;
            ProductAlertBtn.OutlineThickness = 1F;
            ProductAlertBtn.PressedBackground = Color.Transparent;
            ProductAlertBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            ProductAlertBtn.PressedImageTint = Color.Transparent;
            ProductAlertBtn.PressedOutline = Color.Transparent;
            ProductAlertBtn.Rounding = new Padding(8);
            ProductAlertBtn.Size = new Size(224, 45);
            ProductAlertBtn.TabIndex = 5;
            ProductAlertBtn.TextAlignment = StringAlignment.Near;
            ProductAlertBtn.TextOffset = new Point(50, 0);
            ProductAlertBtn.Click += ProductAlertBtn_Click;
            // 
            // InventoryBtn
            // 
            InventoryBtn.BackColor = Color.Transparent;
            InventoryBtn.CheckButton = false;
            InventoryBtn.Checked = false;
            InventoryBtn.CheckedBackground = Color.Transparent;
            InventoryBtn.CheckedForeColor = Color.Transparent;
            InventoryBtn.CheckedImageTint = Color.Transparent;
            InventoryBtn.CheckedOutline = Color.Transparent;
            InventoryBtn.Content = "Inventory";
            InventoryBtn.DialogResult = DialogResult.None;
            InventoryBtn.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InventoryBtn.ForeColor = SystemColors.ControlText;
            InventoryBtn.HoverBackground = Color.Transparent;
            InventoryBtn.HoveredImageTint = SystemColors.ControlText;
            InventoryBtn.HoverForeColor = SystemColors.ControlText;
            InventoryBtn.HoverOutline = Color.Transparent;
            InventoryBtn.Image = (Image)resources.GetObject("InventoryBtn.Image");
            InventoryBtn.ImageAutoCenter = true;
            InventoryBtn.ImageExpand = new Point(0, 0);
            InventoryBtn.ImageOffset = new Point(-33, 0);
            InventoryBtn.Location = new Point(0, 145);
            InventoryBtn.Name = "InventoryBtn";
            InventoryBtn.NormalBackground = Color.Transparent;
            InventoryBtn.NormalForeColor = SystemColors.ControlText;
            InventoryBtn.NormalImageTint = Color.Black;
            InventoryBtn.NormalOutline = Color.Transparent;
            InventoryBtn.OutlineThickness = 1F;
            InventoryBtn.PressedBackground = Color.Transparent;
            InventoryBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            InventoryBtn.PressedImageTint = Color.Transparent;
            InventoryBtn.PressedOutline = Color.Transparent;
            InventoryBtn.Rounding = new Padding(8);
            InventoryBtn.Size = new Size(224, 45);
            InventoryBtn.TabIndex = 3;
            InventoryBtn.TextAlignment = StringAlignment.Near;
            InventoryBtn.TextOffset = new Point(50, 0);
            InventoryBtn.Click += InventoryBtn_Click;
            // 
            // DashboardBtn
            // 
            DashboardBtn.BackColor = Color.Transparent;
            DashboardBtn.CheckButton = false;
            DashboardBtn.Checked = false;
            DashboardBtn.CheckedBackground = Color.Transparent;
            DashboardBtn.CheckedForeColor = Color.Transparent;
            DashboardBtn.CheckedImageTint = Color.Transparent;
            DashboardBtn.CheckedOutline = Color.Transparent;
            DashboardBtn.Content = "Dashboard";
            DashboardBtn.DialogResult = DialogResult.None;
            DashboardBtn.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardBtn.ForeColor = SystemColors.ControlText;
            DashboardBtn.HoverBackground = Color.Transparent;
            DashboardBtn.HoveredImageTint = SystemColors.ControlText;
            DashboardBtn.HoverForeColor = SystemColors.ControlText;
            DashboardBtn.HoverOutline = Color.Transparent;
            DashboardBtn.Image = (Image)resources.GetObject("DashboardBtn.Image");
            DashboardBtn.ImageAutoCenter = true;
            DashboardBtn.ImageExpand = new Point(0, 0);
            DashboardBtn.ImageOffset = new Point(-30, 0);
            DashboardBtn.Location = new Point(0, 94);
            DashboardBtn.Name = "DashboardBtn";
            DashboardBtn.NormalBackground = Color.Transparent;
            DashboardBtn.NormalForeColor = SystemColors.ControlText;
            DashboardBtn.NormalImageTint = Color.Black;
            DashboardBtn.NormalOutline = Color.Transparent;
            DashboardBtn.OutlineThickness = 1F;
            DashboardBtn.PressedBackground = Color.Transparent;
            DashboardBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            DashboardBtn.PressedImageTint = Color.Transparent;
            DashboardBtn.PressedOutline = Color.Transparent;
            DashboardBtn.Rounding = new Padding(8);
            DashboardBtn.Size = new Size(224, 45);
            DashboardBtn.TabIndex = 3;
            DashboardBtn.TextAlignment = StringAlignment.Near;
            DashboardBtn.TextOffset = new Point(50, 0);
            DashboardBtn.Click += DashboardBtn_Click;
            // 
            // ProfileLabel
            // 
            ProfileLabel.BackColor = Color.Transparent;
            ProfileLabel.Content = "Employee";
            ProfileLabel.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProfileLabel.ForeColor = SystemColors.ControlText;
            ProfileLabel.HorizontalAlignment = StringAlignment.Near;
            ProfileLabel.Location = new Point(77, 37);
            ProfileLabel.Margin = new Padding(4, 3, 4, 3);
            ProfileLabel.Name = "ProfileLabel";
            ProfileLabel.RightToLeft = RightToLeft.No;
            ProfileLabel.Size = new Size(134, 24);
            ProfileLabel.TabIndex = 2;
            ProfileLabel.VerticalAlignment = StringAlignment.Near;
            // 
            // ProfilePicture
            // 
            ProfilePicture.BackgroundImage = Properties.Resources.Nilou;
            ProfilePicture.BackgroundImageLayout = ImageLayout.Stretch;
            ProfilePicture.Content = null;
            ProfilePicture.ImageTint = Color.White;
            ProfilePicture.Location = new Point(14, 20);
            ProfilePicture.Margin = new Padding(4, 3, 4, 3);
            ProfilePicture.Name = "ProfilePicture";
            ProfilePicture.OutlineThickness = 1F;
            ProfilePicture.PanelOutlineColor = Color.Empty;
            ProfilePicture.Rotation = 0;
            ProfilePicture.Rounding = new Padding(8);
            ProfilePicture.Size = new Size(55, 50);
            ProfilePicture.TabIndex = 0;
            ProfilePicture.Load += ProfilePicture_Load;
            // 
            // ProfileName
            // 
            ProfileName.BackColor = Color.Transparent;
            ProfileName.Content = "John\\ Doe";
            ProfileName.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProfileName.ForeColor = SystemColors.ControlText;
            ProfileName.HorizontalAlignment = StringAlignment.Near;
            ProfileName.Location = new Point(77, 20);
            ProfileName.Margin = new Padding(4, 3, 4, 3);
            ProfileName.Name = "ProfileName";
            ProfileName.RightToLeft = RightToLeft.No;
            ProfileName.Size = new Size(134, 24);
            ProfileName.TabIndex = 1;
            ProfileName.VerticalAlignment = StringAlignment.Near;
            // 
            // dashboardContent1
            // 
            dashboardContent1.AutoScroll = true;
            dashboardContent1.BackColor = Color.AliceBlue;
            dashboardContent1.Dock = DockStyle.Fill;
            dashboardContent1.Location = new Point(224, 0);
            dashboardContent1.Name = "dashboardContent1";
            dashboardContent1.Size = new Size(1060, 681);
            dashboardContent1.TabIndex = 4;
            // 
            // inventory1
            // 
            inventory1.BackColor = Color.AliceBlue;
            inventory1.Dock = DockStyle.Fill;
            inventory1.Location = new Point(224, 0);
            inventory1.Name = "inventory1";
            inventory1.Size = new Size(1060, 681);
            inventory1.TabIndex = 5;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1284, 681);
            Controls.Add(inventory1);
            Controls.Add(dashboardContent1);
            Controls.Add(DashboardPanel);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Dashboard";
            Text = "IMS - Dashboard";
            DashboardPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage1;
        private TabPage tabPage2;
        private CuoreUI.Controls.cuiPictureBox ProfilePicture;
        public CuoreUI.Controls.cuiPanel DashboardPanel;
        private CuoreUI.Controls.cuiLabel ProfileName;
        private CuoreUI.Controls.cuiLabel ProfileLabel;
        private CuoreUI.Controls.cuiButton DashboardBtn;
        private CuoreUI.Controls.cuiButton InventoryBtn;
        private CuoreUI.Controls.cuiButton EmployeeBtn;
        private CuoreUI.Controls.cuiButton BatchBtn;
        private CuoreUI.Controls.cuiButton ProductAlertBtn;
        private CuoreUI.Controls.cuiButton LogoutBtn;
        private DashboardContent dashboardContent1;
        private Inventory inventory1;
    }
}
