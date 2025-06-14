namespace InventoreSys
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Menubutton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DashboardBtn = new CuoreUI.Controls.cuiButton();
            this.formInventory = new CuoreUI.Controls.cuiButton();
            this.formProductAlert = new CuoreUI.Controls.cuiButton();
            this.formBatch = new CuoreUI.Controls.cuiButton();
            this.formEmployees = new CuoreUI.Controls.cuiButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LogoutButton = new CuoreUI.Controls.cuiButton();
            this.sidebartimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menubutton)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.SteelBlue;
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.DashboardBtn);
            this.sidebar.Controls.Add(this.formInventory);
            this.sidebar.Controls.Add(this.formProductAlert);
            this.sidebar.Controls.Add(this.formBatch);
            this.sidebar.Controls.Add(this.formEmployees);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.LogoutButton);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(156, 573);
            this.sidebar.MinimumSize = new System.Drawing.Size(46, 573);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(156, 573);
            this.sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Menubutton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 82);
            this.panel1.TabIndex = 0;
            // 
            // Menubutton
            // 
            this.Menubutton.Image = global::InventoreSys.Properties.Resources.menu_burger__1_;
            this.Menubutton.Location = new System.Drawing.Point(6, 23);
            this.Menubutton.Name = "Menubutton";
            this.Menubutton.Size = new System.Drawing.Size(30, 33);
            this.Menubutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Menubutton.TabIndex = 0;
            this.Menubutton.TabStop = false;
            this.Menubutton.Click += new System.EventHandler(this.Menubutton_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 91);
            this.panel2.TabIndex = 1;
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.DashboardBtn.CheckButton = false;
            this.DashboardBtn.Checked = false;
            this.DashboardBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.DashboardBtn.CheckedForeColor = System.Drawing.Color.Black;
            this.DashboardBtn.CheckedImageTint = System.Drawing.Color.Black;
            this.DashboardBtn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.DashboardBtn.Content = "Dashboard";
            this.DashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashboardBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DashboardBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardBtn.ForeColor = System.Drawing.Color.White;
            this.DashboardBtn.HoverBackground = System.Drawing.Color.Transparent;
            this.DashboardBtn.HoveredImageTint = System.Drawing.Color.Transparent;
            this.DashboardBtn.HoverForeColor = System.Drawing.Color.Black;
            this.DashboardBtn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DashboardBtn.Image = global::InventoreSys.Properties.Resources.dashboard;
            this.DashboardBtn.ImageAutoCenter = false;
            this.DashboardBtn.ImageExpand = new System.Drawing.Point(5, 5);
            this.DashboardBtn.ImageOffset = new System.Drawing.Point(18, 0);
            this.DashboardBtn.Location = new System.Drawing.Point(3, 188);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.NormalBackground = System.Drawing.Color.Transparent;
            this.DashboardBtn.NormalForeColor = System.Drawing.Color.White;
            this.DashboardBtn.NormalImageTint = System.Drawing.Color.White;
            this.DashboardBtn.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DashboardBtn.OutlineThickness = 1F;
            this.DashboardBtn.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.DashboardBtn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.DashboardBtn.PressedImageTint = System.Drawing.Color.White;
            this.DashboardBtn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DashboardBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.DashboardBtn.Size = new System.Drawing.Size(138, 46);
            this.DashboardBtn.TabIndex = 1;
            this.DashboardBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.DashboardBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.DashboardBtn.Click += new System.EventHandler(this.cuiButton1_Click);
            // 
            // formInventory
            // 
            this.formInventory.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.formInventory.CheckButton = false;
            this.formInventory.Checked = false;
            this.formInventory.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.formInventory.CheckedForeColor = System.Drawing.Color.Black;
            this.formInventory.CheckedImageTint = System.Drawing.Color.Black;
            this.formInventory.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.formInventory.Content = "Inventory";
            this.formInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.formInventory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.formInventory.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formInventory.ForeColor = System.Drawing.Color.White;
            this.formInventory.HoverBackground = System.Drawing.Color.Transparent;
            this.formInventory.HoveredImageTint = System.Drawing.Color.Transparent;
            this.formInventory.HoverForeColor = System.Drawing.Color.Black;
            this.formInventory.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.formInventory.Image = global::InventoreSys.Properties.Resources.shipping;
            this.formInventory.ImageAutoCenter = false;
            this.formInventory.ImageExpand = new System.Drawing.Point(5, 5);
            this.formInventory.ImageOffset = new System.Drawing.Point(18, 0);
            this.formInventory.Location = new System.Drawing.Point(3, 240);
            this.formInventory.Name = "formInventory";
            this.formInventory.NormalBackground = System.Drawing.Color.Transparent;
            this.formInventory.NormalForeColor = System.Drawing.Color.White;
            this.formInventory.NormalImageTint = System.Drawing.Color.White;
            this.formInventory.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.formInventory.OutlineThickness = 1F;
            this.formInventory.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.formInventory.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.formInventory.PressedImageTint = System.Drawing.Color.White;
            this.formInventory.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.formInventory.Rounding = new System.Windows.Forms.Padding(8);
            this.formInventory.Size = new System.Drawing.Size(138, 46);
            this.formInventory.TabIndex = 2;
            this.formInventory.TextAlignment = System.Drawing.StringAlignment.Center;
            this.formInventory.TextOffset = new System.Drawing.Point(0, 0);
            this.formInventory.Click += new System.EventHandler(this.cuiButton2_Click);
            // 
            // formProductAlert
            // 
            this.formProductAlert.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.formProductAlert.CheckButton = false;
            this.formProductAlert.Checked = false;
            this.formProductAlert.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.formProductAlert.CheckedForeColor = System.Drawing.Color.Black;
            this.formProductAlert.CheckedImageTint = System.Drawing.Color.Black;
            this.formProductAlert.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.formProductAlert.Content = "Product Alert";
            this.formProductAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.formProductAlert.DialogResult = System.Windows.Forms.DialogResult.None;
            this.formProductAlert.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formProductAlert.ForeColor = System.Drawing.Color.White;
            this.formProductAlert.HoverBackground = System.Drawing.Color.Transparent;
            this.formProductAlert.HoveredImageTint = System.Drawing.Color.Transparent;
            this.formProductAlert.HoverForeColor = System.Drawing.Color.Black;
            this.formProductAlert.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.formProductAlert.Image = global::InventoreSys.Properties.Resources.warning;
            this.formProductAlert.ImageAutoCenter = false;
            this.formProductAlert.ImageExpand = new System.Drawing.Point(5, 5);
            this.formProductAlert.ImageOffset = new System.Drawing.Point(18, 0);
            this.formProductAlert.Location = new System.Drawing.Point(3, 292);
            this.formProductAlert.Name = "formProductAlert";
            this.formProductAlert.NormalBackground = System.Drawing.Color.Transparent;
            this.formProductAlert.NormalForeColor = System.Drawing.Color.White;
            this.formProductAlert.NormalImageTint = System.Drawing.Color.White;
            this.formProductAlert.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.formProductAlert.OutlineThickness = 1F;
            this.formProductAlert.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.formProductAlert.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.formProductAlert.PressedImageTint = System.Drawing.Color.White;
            this.formProductAlert.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.formProductAlert.Rounding = new System.Windows.Forms.Padding(8);
            this.formProductAlert.Size = new System.Drawing.Size(138, 46);
            this.formProductAlert.TabIndex = 3;
            this.formProductAlert.TextAlignment = System.Drawing.StringAlignment.Center;
            this.formProductAlert.TextOffset = new System.Drawing.Point(0, 0);
            this.formProductAlert.Click += new System.EventHandler(this.cuiButton3_Click);
            // 
            // formBatch
            // 
            this.formBatch.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.formBatch.CheckButton = false;
            this.formBatch.Checked = false;
            this.formBatch.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.formBatch.CheckedForeColor = System.Drawing.Color.Black;
            this.formBatch.CheckedImageTint = System.Drawing.Color.Black;
            this.formBatch.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.formBatch.Content = "Batch";
            this.formBatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.formBatch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.formBatch.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formBatch.ForeColor = System.Drawing.Color.White;
            this.formBatch.HoverBackground = System.Drawing.Color.Transparent;
            this.formBatch.HoveredImageTint = System.Drawing.Color.Transparent;
            this.formBatch.HoverForeColor = System.Drawing.Color.Black;
            this.formBatch.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.formBatch.Image = global::InventoreSys.Properties.Resources.stack_overflow;
            this.formBatch.ImageAutoCenter = false;
            this.formBatch.ImageExpand = new System.Drawing.Point(5, 5);
            this.formBatch.ImageOffset = new System.Drawing.Point(18, 0);
            this.formBatch.Location = new System.Drawing.Point(3, 344);
            this.formBatch.Name = "formBatch";
            this.formBatch.NormalBackground = System.Drawing.Color.Transparent;
            this.formBatch.NormalForeColor = System.Drawing.Color.White;
            this.formBatch.NormalImageTint = System.Drawing.Color.White;
            this.formBatch.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.formBatch.OutlineThickness = 1F;
            this.formBatch.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.formBatch.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.formBatch.PressedImageTint = System.Drawing.Color.White;
            this.formBatch.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.formBatch.Rounding = new System.Windows.Forms.Padding(8);
            this.formBatch.Size = new System.Drawing.Size(138, 46);
            this.formBatch.TabIndex = 4;
            this.formBatch.TextAlignment = System.Drawing.StringAlignment.Center;
            this.formBatch.TextOffset = new System.Drawing.Point(0, 0);
            this.formBatch.Click += new System.EventHandler(this.cuiButton4_Click);
            // 
            // formEmployees
            // 
            this.formEmployees.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.formEmployees.CheckButton = false;
            this.formEmployees.Checked = false;
            this.formEmployees.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.formEmployees.CheckedForeColor = System.Drawing.Color.Black;
            this.formEmployees.CheckedImageTint = System.Drawing.Color.Black;
            this.formEmployees.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.formEmployees.Content = "Employees";
            this.formEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.formEmployees.DialogResult = System.Windows.Forms.DialogResult.None;
            this.formEmployees.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formEmployees.ForeColor = System.Drawing.Color.White;
            this.formEmployees.HoverBackground = System.Drawing.Color.Transparent;
            this.formEmployees.HoveredImageTint = System.Drawing.Color.Transparent;
            this.formEmployees.HoverForeColor = System.Drawing.Color.Black;
            this.formEmployees.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.formEmployees.Image = global::InventoreSys.Properties.Resources.teamwork;
            this.formEmployees.ImageAutoCenter = false;
            this.formEmployees.ImageExpand = new System.Drawing.Point(5, 5);
            this.formEmployees.ImageOffset = new System.Drawing.Point(18, 0);
            this.formEmployees.Location = new System.Drawing.Point(3, 396);
            this.formEmployees.Name = "formEmployees";
            this.formEmployees.NormalBackground = System.Drawing.Color.Transparent;
            this.formEmployees.NormalForeColor = System.Drawing.Color.White;
            this.formEmployees.NormalImageTint = System.Drawing.Color.White;
            this.formEmployees.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.formEmployees.OutlineThickness = 1F;
            this.formEmployees.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.formEmployees.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.formEmployees.PressedImageTint = System.Drawing.Color.White;
            this.formEmployees.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.formEmployees.Rounding = new System.Windows.Forms.Padding(8);
            this.formEmployees.Size = new System.Drawing.Size(138, 46);
            this.formEmployees.TabIndex = 5;
            this.formEmployees.TextAlignment = System.Drawing.StringAlignment.Center;
            this.formEmployees.TextOffset = new System.Drawing.Point(0, 0);
            this.formEmployees.Click += new System.EventHandler(this.cuiButton5_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 448);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 51);
            this.panel3.TabIndex = 6;
            // 
            // LogoutButton
            // 
            this.LogoutButton.CheckButton = false;
            this.LogoutButton.Checked = false;
            this.LogoutButton.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.LogoutButton.CheckedForeColor = System.Drawing.Color.White;
            this.LogoutButton.CheckedImageTint = System.Drawing.Color.White;
            this.LogoutButton.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.LogoutButton.Content = "Log out";
            this.LogoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LogoutButton.HoverBackground = System.Drawing.Color.White;
            this.LogoutButton.HoveredImageTint = System.Drawing.Color.White;
            this.LogoutButton.HoverForeColor = System.Drawing.Color.Black;
            this.LogoutButton.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LogoutButton.Image = global::InventoreSys.Properties.Resources.logout;
            this.LogoutButton.ImageAutoCenter = false;
            this.LogoutButton.ImageExpand = new System.Drawing.Point(5, 5);
            this.LogoutButton.ImageOffset = new System.Drawing.Point(20, 0);
            this.LogoutButton.Location = new System.Drawing.Point(3, 505);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.NormalBackground = System.Drawing.Color.Transparent;
            this.LogoutButton.NormalForeColor = System.Drawing.Color.WhiteSmoke;
            this.LogoutButton.NormalImageTint = System.Drawing.Color.White;
            this.LogoutButton.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LogoutButton.OutlineThickness = 1F;
            this.LogoutButton.PressedBackground = System.Drawing.Color.Transparent;
            this.LogoutButton.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.LogoutButton.PressedImageTint = System.Drawing.Color.Transparent;
            this.LogoutButton.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LogoutButton.Rounding = new System.Windows.Forms.Padding(8);
            this.LogoutButton.Size = new System.Drawing.Size(153, 45);
            this.LogoutButton.TabIndex = 1;
            this.LogoutButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.LogoutButton.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // sidebartimer
            // 
            this.sidebartimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Menubutton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Menubutton;
        private System.Windows.Forms.Timer sidebartimer;
        private CuoreUI.Controls.cuiButton DashboardBtn;
        private System.Windows.Forms.Panel panel2;
        private CuoreUI.Controls.cuiButton formInventory;
        private CuoreUI.Controls.cuiButton formProductAlert;
        private CuoreUI.Controls.cuiButton formBatch;
        private CuoreUI.Controls.cuiButton formEmployees;
        private System.Windows.Forms.Panel panel3;
        private CuoreUI.Controls.cuiButton LogoutButton;
    }
}

