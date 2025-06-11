namespace New_Inventory_System
{
    partial class Inventory
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
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.InventoryMain = new System.Windows.Forms.Label();
            this.cuiTextBox1 = new CuoreUI.Controls.cuiTextBox();
            this.cuiPanel10 = new CuoreUI.Controls.cuiPanel();
            this.cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            this.NameUser = new CuoreUI.Controls.cuiLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogoutButton = new CuoreUI.Controls.cuiButton();
            this.EmployeButton = new CuoreUI.Controls.cuiButton();
            this.BatchButton = new CuoreUI.Controls.cuiButton();
            this.ProductAlertButton = new CuoreUI.Controls.cuiButton();
            this.InventoryButton = new CuoreUI.Controls.cuiButton();
            this.DashbordButton = new CuoreUI.Controls.cuiButton();
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.cuiTextBox2 = new CuoreUI.Controls.cuiTextBox();
            this.Filtertxt = new CuoreUI.Controls.cuiButton();
            this.AddItemTxt = new CuoreUI.Controls.cuiButton();
            this.cuiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cuiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // InventoryMain
            // 
            this.InventoryMain.AutoSize = true;
            this.InventoryMain.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryMain.Location = new System.Drawing.Point(210, 26);
            this.InventoryMain.Name = "InventoryMain";
            this.InventoryMain.Size = new System.Drawing.Size(103, 26);
            this.InventoryMain.TabIndex = 13;
            this.InventoryMain.Text = "Inventory";
            // 
            // cuiTextBox1
            // 
            this.cuiTextBox1.BackgroundColor = System.Drawing.Color.White;
            this.cuiTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiTextBox1.Content = "Search...";
            this.cuiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cuiTextBox1.FocusBackgroundColor = System.Drawing.Color.White;
            this.cuiTextBox1.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiTextBox1.FocusImageTint = System.Drawing.Color.White;
            this.cuiTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.cuiTextBox1.Image = null;
            this.cuiTextBox1.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiTextBox1.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiTextBox1.Location = new System.Drawing.Point(740, 21);
            this.cuiTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.cuiTextBox1.Multiline = false;
            this.cuiTextBox1.Name = "cuiTextBox1";
            this.cuiTextBox1.NormalImageTint = System.Drawing.Color.White;
            this.cuiTextBox1.Padding = new System.Windows.Forms.Padding(18, 13, 18, 0);
            this.cuiTextBox1.PasswordChar = false;
            this.cuiTextBox1.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.cuiTextBox1.PlaceholderText = "";
            this.cuiTextBox1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiTextBox1.Size = new System.Drawing.Size(266, 45);
            this.cuiTextBox1.TabIndex = 14;
            this.cuiTextBox1.TextOffset = new System.Drawing.Size(0, 0);
            this.cuiTextBox1.UnderlinedStyle = true;
            // 
            // cuiPanel10
            // 
            this.cuiPanel10.Location = new System.Drawing.Point(11, 56);
            this.cuiPanel10.Name = "cuiPanel10";
            this.cuiPanel10.OutlineThickness = 1F;
            this.cuiPanel10.PanelColor = System.Drawing.Color.White;
            this.cuiPanel10.PanelOutlineColor = System.Drawing.Color.Black;
            this.cuiPanel10.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanel10.Size = new System.Drawing.Size(780, 557);
            this.cuiPanel10.TabIndex = 5;
            // 
            // cuiPanel2
            // 
            this.cuiPanel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cuiPanel2.Controls.Add(this.AddItemTxt);
            this.cuiPanel2.Controls.Add(this.Filtertxt);
            this.cuiPanel2.Controls.Add(this.cuiTextBox2);
            this.cuiPanel2.Controls.Add(this.cuiPanel10);
            this.cuiPanel2.Location = new System.Drawing.Point(204, 73);
            this.cuiPanel2.Name = "cuiPanel2";
            this.cuiPanel2.OutlineThickness = 1F;
            this.cuiPanel2.PanelColor = System.Drawing.Color.LightSkyBlue;
            this.cuiPanel2.PanelOutlineColor = System.Drawing.Color.Black;
            this.cuiPanel2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanel2.Size = new System.Drawing.Size(802, 633);
            this.cuiPanel2.TabIndex = 8;
            // 
            // NameUser
            // 
            this.NameUser.BackColor = System.Drawing.Color.Transparent;
            this.NameUser.Content = "Kikombi";
            this.NameUser.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameUser.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.NameUser.Location = new System.Drawing.Point(31, 129);
            this.NameUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameUser.Name = "NameUser";
            this.NameUser.Size = new System.Drawing.Size(127, 23);
            this.NameUser.TabIndex = 7;
            this.NameUser.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(41, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 90);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LogoutButton
            // 
            this.LogoutButton.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.LogoutButton.BackColor = System.Drawing.Color.Transparent;
            this.LogoutButton.CheckButton = false;
            this.LogoutButton.Checked = false;
            this.LogoutButton.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.LogoutButton.CheckedForeColor = System.Drawing.Color.White;
            this.LogoutButton.CheckedImageTint = System.Drawing.Color.White;
            this.LogoutButton.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.LogoutButton.Content = "Log Out";
            this.LogoutButton.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.LogoutButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.Black;
            this.LogoutButton.HoverBackground = System.Drawing.Color.White;
            this.LogoutButton.HoveredImageTint = System.Drawing.Color.White;
            this.LogoutButton.HoverForeColor = System.Drawing.Color.Black;
            this.LogoutButton.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LogoutButton.Image = null;
            this.LogoutButton.ImageAutoCenter = true;
            this.LogoutButton.ImageExpand = new System.Drawing.Point(0, 0);
            this.LogoutButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.LogoutButton.Location = new System.Drawing.Point(12, 655);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.NormalBackground = System.Drawing.Color.White;
            this.LogoutButton.NormalForeColor = System.Drawing.Color.Black;
            this.LogoutButton.NormalImageTint = System.Drawing.Color.White;
            this.LogoutButton.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LogoutButton.OutlineThickness = 1F;
            this.LogoutButton.PressedBackground = System.Drawing.Color.Transparent;
            this.LogoutButton.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.LogoutButton.PressedImageTint = System.Drawing.Color.White;
            this.LogoutButton.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LogoutButton.Rounding = new System.Windows.Forms.Padding(15);
            this.LogoutButton.Size = new System.Drawing.Size(156, 51);
            this.LogoutButton.TabIndex = 5;
            this.LogoutButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.LogoutButton.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // EmployeButton
            // 
            this.EmployeButton.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.EmployeButton.BackColor = System.Drawing.Color.Transparent;
            this.EmployeButton.CheckButton = false;
            this.EmployeButton.Checked = false;
            this.EmployeButton.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.EmployeButton.CheckedForeColor = System.Drawing.Color.White;
            this.EmployeButton.CheckedImageTint = System.Drawing.Color.White;
            this.EmployeButton.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.EmployeButton.Content = "Employees";
            this.EmployeButton.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.EmployeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EmployeButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeButton.ForeColor = System.Drawing.Color.Black;
            this.EmployeButton.HoverBackground = System.Drawing.Color.White;
            this.EmployeButton.HoveredImageTint = System.Drawing.Color.White;
            this.EmployeButton.HoverForeColor = System.Drawing.Color.Black;
            this.EmployeButton.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.EmployeButton.Image = null;
            this.EmployeButton.ImageAutoCenter = true;
            this.EmployeButton.ImageExpand = new System.Drawing.Point(0, 0);
            this.EmployeButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.EmployeButton.Location = new System.Drawing.Point(12, 459);
            this.EmployeButton.Name = "EmployeButton";
            this.EmployeButton.NormalBackground = System.Drawing.Color.White;
            this.EmployeButton.NormalForeColor = System.Drawing.Color.Black;
            this.EmployeButton.NormalImageTint = System.Drawing.Color.White;
            this.EmployeButton.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.EmployeButton.OutlineThickness = 1F;
            this.EmployeButton.PressedBackground = System.Drawing.Color.Transparent;
            this.EmployeButton.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.EmployeButton.PressedImageTint = System.Drawing.Color.White;
            this.EmployeButton.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.EmployeButton.Rounding = new System.Windows.Forms.Padding(15);
            this.EmployeButton.Size = new System.Drawing.Size(156, 51);
            this.EmployeButton.TabIndex = 4;
            this.EmployeButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.EmployeButton.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // BatchButton
            // 
            this.BatchButton.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BatchButton.BackColor = System.Drawing.Color.Transparent;
            this.BatchButton.CheckButton = false;
            this.BatchButton.Checked = false;
            this.BatchButton.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.BatchButton.CheckedForeColor = System.Drawing.Color.White;
            this.BatchButton.CheckedImageTint = System.Drawing.Color.White;
            this.BatchButton.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.BatchButton.Content = "Batch";
            this.BatchButton.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.BatchButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BatchButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatchButton.ForeColor = System.Drawing.Color.Black;
            this.BatchButton.HoverBackground = System.Drawing.Color.White;
            this.BatchButton.HoveredImageTint = System.Drawing.Color.White;
            this.BatchButton.HoverForeColor = System.Drawing.Color.Black;
            this.BatchButton.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BatchButton.Image = null;
            this.BatchButton.ImageAutoCenter = true;
            this.BatchButton.ImageExpand = new System.Drawing.Point(0, 0);
            this.BatchButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.BatchButton.Location = new System.Drawing.Point(12, 392);
            this.BatchButton.Name = "BatchButton";
            this.BatchButton.NormalBackground = System.Drawing.Color.White;
            this.BatchButton.NormalForeColor = System.Drawing.Color.Black;
            this.BatchButton.NormalImageTint = System.Drawing.Color.White;
            this.BatchButton.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BatchButton.OutlineThickness = 1F;
            this.BatchButton.PressedBackground = System.Drawing.Color.Transparent;
            this.BatchButton.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BatchButton.PressedImageTint = System.Drawing.Color.White;
            this.BatchButton.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BatchButton.Rounding = new System.Windows.Forms.Padding(15);
            this.BatchButton.Size = new System.Drawing.Size(156, 51);
            this.BatchButton.TabIndex = 3;
            this.BatchButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BatchButton.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // ProductAlertButton
            // 
            this.ProductAlertButton.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ProductAlertButton.BackColor = System.Drawing.Color.Transparent;
            this.ProductAlertButton.CheckButton = false;
            this.ProductAlertButton.Checked = false;
            this.ProductAlertButton.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.ProductAlertButton.CheckedForeColor = System.Drawing.Color.White;
            this.ProductAlertButton.CheckedImageTint = System.Drawing.Color.White;
            this.ProductAlertButton.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.ProductAlertButton.Content = "Product Alert";
            this.ProductAlertButton.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ProductAlertButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ProductAlertButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductAlertButton.ForeColor = System.Drawing.Color.Black;
            this.ProductAlertButton.HoverBackground = System.Drawing.Color.White;
            this.ProductAlertButton.HoveredImageTint = System.Drawing.Color.White;
            this.ProductAlertButton.HoverForeColor = System.Drawing.Color.Black;
            this.ProductAlertButton.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ProductAlertButton.Image = null;
            this.ProductAlertButton.ImageAutoCenter = true;
            this.ProductAlertButton.ImageExpand = new System.Drawing.Point(0, 0);
            this.ProductAlertButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.ProductAlertButton.Location = new System.Drawing.Point(12, 325);
            this.ProductAlertButton.Name = "ProductAlertButton";
            this.ProductAlertButton.NormalBackground = System.Drawing.Color.White;
            this.ProductAlertButton.NormalForeColor = System.Drawing.Color.Black;
            this.ProductAlertButton.NormalImageTint = System.Drawing.Color.White;
            this.ProductAlertButton.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ProductAlertButton.OutlineThickness = 1F;
            this.ProductAlertButton.PressedBackground = System.Drawing.Color.Transparent;
            this.ProductAlertButton.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ProductAlertButton.PressedImageTint = System.Drawing.Color.White;
            this.ProductAlertButton.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ProductAlertButton.Rounding = new System.Windows.Forms.Padding(15);
            this.ProductAlertButton.Size = new System.Drawing.Size(156, 51);
            this.ProductAlertButton.TabIndex = 2;
            this.ProductAlertButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ProductAlertButton.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // InventoryButton
            // 
            this.InventoryButton.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.InventoryButton.BackColor = System.Drawing.Color.Transparent;
            this.InventoryButton.CheckButton = false;
            this.InventoryButton.Checked = false;
            this.InventoryButton.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.InventoryButton.CheckedForeColor = System.Drawing.Color.White;
            this.InventoryButton.CheckedImageTint = System.Drawing.Color.White;
            this.InventoryButton.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.InventoryButton.Content = "Inventory";
            this.InventoryButton.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.InventoryButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.InventoryButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryButton.ForeColor = System.Drawing.Color.Black;
            this.InventoryButton.HoverBackground = System.Drawing.Color.White;
            this.InventoryButton.HoveredImageTint = System.Drawing.Color.White;
            this.InventoryButton.HoverForeColor = System.Drawing.Color.Black;
            this.InventoryButton.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.InventoryButton.Image = null;
            this.InventoryButton.ImageAutoCenter = true;
            this.InventoryButton.ImageExpand = new System.Drawing.Point(0, 0);
            this.InventoryButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.InventoryButton.Location = new System.Drawing.Point(12, 257);
            this.InventoryButton.Name = "InventoryButton";
            this.InventoryButton.NormalBackground = System.Drawing.Color.White;
            this.InventoryButton.NormalForeColor = System.Drawing.Color.Black;
            this.InventoryButton.NormalImageTint = System.Drawing.Color.White;
            this.InventoryButton.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.InventoryButton.OutlineThickness = 1F;
            this.InventoryButton.PressedBackground = System.Drawing.Color.Transparent;
            this.InventoryButton.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.InventoryButton.PressedImageTint = System.Drawing.Color.White;
            this.InventoryButton.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.InventoryButton.Rounding = new System.Windows.Forms.Padding(15);
            this.InventoryButton.Size = new System.Drawing.Size(156, 51);
            this.InventoryButton.TabIndex = 1;
            this.InventoryButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.InventoryButton.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // DashbordButton
            // 
            this.DashbordButton.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.DashbordButton.BackColor = System.Drawing.Color.Transparent;
            this.DashbordButton.CheckButton = false;
            this.DashbordButton.Checked = false;
            this.DashbordButton.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.DashbordButton.CheckedForeColor = System.Drawing.Color.White;
            this.DashbordButton.CheckedImageTint = System.Drawing.Color.White;
            this.DashbordButton.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.DashbordButton.Content = "Dashboard";
            this.DashbordButton.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.DashbordButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DashbordButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashbordButton.ForeColor = System.Drawing.Color.Black;
            this.DashbordButton.HoverBackground = System.Drawing.Color.White;
            this.DashbordButton.HoveredImageTint = System.Drawing.Color.White;
            this.DashbordButton.HoverForeColor = System.Drawing.Color.Black;
            this.DashbordButton.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DashbordButton.Image = null;
            this.DashbordButton.ImageAutoCenter = true;
            this.DashbordButton.ImageExpand = new System.Drawing.Point(0, 0);
            this.DashbordButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.DashbordButton.Location = new System.Drawing.Point(12, 189);
            this.DashbordButton.Name = "DashbordButton";
            this.DashbordButton.NormalBackground = System.Drawing.Color.White;
            this.DashbordButton.NormalForeColor = System.Drawing.Color.Black;
            this.DashbordButton.NormalImageTint = System.Drawing.Color.White;
            this.DashbordButton.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DashbordButton.OutlineThickness = 1F;
            this.DashbordButton.PressedBackground = System.Drawing.Color.Transparent;
            this.DashbordButton.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.DashbordButton.PressedImageTint = System.Drawing.Color.White;
            this.DashbordButton.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DashbordButton.Rounding = new System.Windows.Forms.Padding(15);
            this.DashbordButton.Size = new System.Drawing.Size(156, 51);
            this.DashbordButton.TabIndex = 0;
            this.DashbordButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.DashbordButton.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.Controls.Add(this.NameUser);
            this.cuiPanel1.Controls.Add(this.pictureBox1);
            this.cuiPanel1.Controls.Add(this.LogoutButton);
            this.cuiPanel1.Controls.Add(this.EmployeButton);
            this.cuiPanel1.Controls.Add(this.BatchButton);
            this.cuiPanel1.Controls.Add(this.ProductAlertButton);
            this.cuiPanel1.Controls.Add(this.InventoryButton);
            this.cuiPanel1.Controls.Add(this.DashbordButton);
            this.cuiPanel1.Location = new System.Drawing.Point(0, 0);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.SteelBlue;
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.SteelBlue;
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiPanel1.Size = new System.Drawing.Size(180, 732);
            this.cuiPanel1.TabIndex = 7;
            // 
            // cuiTextBox2
            // 
            this.cuiTextBox2.BackgroundColor = System.Drawing.Color.White;
            this.cuiTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiTextBox2.Content = "Search...";
            this.cuiTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cuiTextBox2.FocusBackgroundColor = System.Drawing.Color.White;
            this.cuiTextBox2.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiTextBox2.FocusImageTint = System.Drawing.Color.White;
            this.cuiTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiTextBox2.ForeColor = System.Drawing.Color.Gray;
            this.cuiTextBox2.Image = null;
            this.cuiTextBox2.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiTextBox2.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiTextBox2.Location = new System.Drawing.Point(15, 13);
            this.cuiTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.cuiTextBox2.Multiline = false;
            this.cuiTextBox2.Name = "cuiTextBox2";
            this.cuiTextBox2.NormalImageTint = System.Drawing.Color.White;
            this.cuiTextBox2.Padding = new System.Windows.Forms.Padding(18, 7, 18, 0);
            this.cuiTextBox2.PasswordChar = false;
            this.cuiTextBox2.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.cuiTextBox2.PlaceholderText = "";
            this.cuiTextBox2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiTextBox2.Size = new System.Drawing.Size(266, 32);
            this.cuiTextBox2.TabIndex = 15;
            this.cuiTextBox2.TextOffset = new System.Drawing.Size(0, 0);
            this.cuiTextBox2.UnderlinedStyle = true;
            // 
            // Filtertxt
            // 
            this.Filtertxt.CheckButton = false;
            this.Filtertxt.Checked = false;
            this.Filtertxt.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.Filtertxt.CheckedForeColor = System.Drawing.Color.White;
            this.Filtertxt.CheckedImageTint = System.Drawing.Color.White;
            this.Filtertxt.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.Filtertxt.Content = "Filter";
            this.Filtertxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Filtertxt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Filtertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Filtertxt.ForeColor = System.Drawing.Color.Black;
            this.Filtertxt.HoverBackground = System.Drawing.Color.White;
            this.Filtertxt.HoveredImageTint = System.Drawing.Color.White;
            this.Filtertxt.HoverForeColor = System.Drawing.Color.Black;
            this.Filtertxt.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Filtertxt.Image = null;
            this.Filtertxt.ImageAutoCenter = true;
            this.Filtertxt.ImageExpand = new System.Drawing.Point(0, 0);
            this.Filtertxt.ImageOffset = new System.Drawing.Point(0, 0);
            this.Filtertxt.Location = new System.Drawing.Point(673, 13);
            this.Filtertxt.Name = "Filtertxt";
            this.Filtertxt.NormalBackground = System.Drawing.Color.White;
            this.Filtertxt.NormalForeColor = System.Drawing.Color.Black;
            this.Filtertxt.NormalImageTint = System.Drawing.Color.White;
            this.Filtertxt.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Filtertxt.OutlineThickness = 1F;
            this.Filtertxt.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.Filtertxt.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Filtertxt.PressedImageTint = System.Drawing.Color.White;
            this.Filtertxt.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Filtertxt.Rounding = new System.Windows.Forms.Padding(8);
            this.Filtertxt.Size = new System.Drawing.Size(115, 37);
            this.Filtertxt.TabIndex = 16;
            this.Filtertxt.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Filtertxt.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // AddItemTxt
            // 
            this.AddItemTxt.CheckButton = false;
            this.AddItemTxt.Checked = false;
            this.AddItemTxt.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.AddItemTxt.CheckedForeColor = System.Drawing.Color.White;
            this.AddItemTxt.CheckedImageTint = System.Drawing.Color.White;
            this.AddItemTxt.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.AddItemTxt.Content = "Add Item";
            this.AddItemTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddItemTxt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddItemTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.AddItemTxt.ForeColor = System.Drawing.Color.Black;
            this.AddItemTxt.HoverBackground = System.Drawing.Color.White;
            this.AddItemTxt.HoveredImageTint = System.Drawing.Color.White;
            this.AddItemTxt.HoverForeColor = System.Drawing.Color.Black;
            this.AddItemTxt.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AddItemTxt.Image = null;
            this.AddItemTxt.ImageAutoCenter = true;
            this.AddItemTxt.ImageExpand = new System.Drawing.Point(0, 0);
            this.AddItemTxt.ImageOffset = new System.Drawing.Point(0, 0);
            this.AddItemTxt.Location = new System.Drawing.Point(552, 13);
            this.AddItemTxt.Name = "AddItemTxt";
            this.AddItemTxt.NormalBackground = System.Drawing.Color.White;
            this.AddItemTxt.NormalForeColor = System.Drawing.Color.Black;
            this.AddItemTxt.NormalImageTint = System.Drawing.Color.White;
            this.AddItemTxt.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AddItemTxt.OutlineThickness = 1F;
            this.AddItemTxt.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.AddItemTxt.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.AddItemTxt.PressedImageTint = System.Drawing.Color.White;
            this.AddItemTxt.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AddItemTxt.Rounding = new System.Windows.Forms.Padding(8);
            this.AddItemTxt.Size = new System.Drawing.Size(115, 37);
            this.AddItemTxt.TabIndex = 17;
            this.AddItemTxt.TextAlignment = System.Drawing.StringAlignment.Center;
            this.AddItemTxt.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InventoryMain);
            this.Controls.Add(this.cuiTextBox1);
            this.Controls.Add(this.cuiPanel2);
            this.Controls.Add(this.cuiPanel1);
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(1031, 725);
            this.cuiPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cuiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label InventoryMain;
        private CuoreUI.Controls.cuiTextBox cuiTextBox1;
        private CuoreUI.Controls.cuiPanel cuiPanel10;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiLabel NameUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CuoreUI.Controls.cuiButton LogoutButton;
        private CuoreUI.Controls.cuiButton EmployeButton;
        private CuoreUI.Controls.cuiButton BatchButton;
        private CuoreUI.Controls.cuiButton ProductAlertButton;
        private CuoreUI.Controls.cuiButton InventoryButton;
        private CuoreUI.Controls.cuiButton DashbordButton;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiButton Filtertxt;
        private CuoreUI.Controls.cuiTextBox cuiTextBox2;
        private CuoreUI.Controls.cuiButton AddItemTxt;
    }
}
