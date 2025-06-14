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
            this.sidebartimer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Menubutton = new System.Windows.Forms.PictureBox();
            this.cuiButton1 = new CuoreUI.Controls.cuiButton();
            this.cuiButton2 = new CuoreUI.Controls.cuiButton();
            this.cuiButton3 = new CuoreUI.Controls.cuiButton();
            this.cuiButton4 = new CuoreUI.Controls.cuiButton();
            this.cuiButton5 = new CuoreUI.Controls.cuiButton();
            this.cuiButton6 = new CuoreUI.Controls.cuiButton();
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
            this.sidebar.Controls.Add(this.cuiButton1);
            this.sidebar.Controls.Add(this.cuiButton2);
            this.sidebar.Controls.Add(this.cuiButton3);
            this.sidebar.Controls.Add(this.cuiButton4);
            this.sidebar.Controls.Add(this.cuiButton5);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.cuiButton6);
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
            // sidebartimer
            // 
            this.sidebartimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 91);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 448);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 51);
            this.panel3.TabIndex = 6;
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
            // cuiButton1
            // 
            this.cuiButton1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.cuiButton1.CheckButton = false;
            this.cuiButton1.Checked = false;
            this.cuiButton1.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton1.CheckedForeColor = System.Drawing.Color.Black;
            this.cuiButton1.CheckedImageTint = System.Drawing.Color.Black;
            this.cuiButton1.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton1.Content = "Dashboard";
            this.cuiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiButton1.ForeColor = System.Drawing.Color.White;
            this.cuiButton1.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton1.HoveredImageTint = System.Drawing.Color.Transparent;
            this.cuiButton1.HoverForeColor = System.Drawing.Color.Black;
            this.cuiButton1.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton1.Image = global::InventoreSys.Properties.Resources.dashboard;
            this.cuiButton1.ImageAutoCenter = false;
            this.cuiButton1.ImageExpand = new System.Drawing.Point(5, 5);
            this.cuiButton1.ImageOffset = new System.Drawing.Point(18, 0);
            this.cuiButton1.Location = new System.Drawing.Point(3, 188);
            this.cuiButton1.Name = "cuiButton1";
            this.cuiButton1.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton1.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton1.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton1.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton1.OutlineThickness = 1F;
            this.cuiButton1.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton1.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton1.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton1.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton1.Size = new System.Drawing.Size(138, 46);
            this.cuiButton1.TabIndex = 1;
            this.cuiButton1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton1.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // cuiButton2
            // 
            this.cuiButton2.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.cuiButton2.CheckButton = false;
            this.cuiButton2.Checked = false;
            this.cuiButton2.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton2.CheckedForeColor = System.Drawing.Color.Black;
            this.cuiButton2.CheckedImageTint = System.Drawing.Color.Black;
            this.cuiButton2.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton2.Content = "Inventory";
            this.cuiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiButton2.ForeColor = System.Drawing.Color.White;
            this.cuiButton2.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton2.HoveredImageTint = System.Drawing.Color.Transparent;
            this.cuiButton2.HoverForeColor = System.Drawing.Color.Black;
            this.cuiButton2.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton2.Image = global::InventoreSys.Properties.Resources.shipping;
            this.cuiButton2.ImageAutoCenter = false;
            this.cuiButton2.ImageExpand = new System.Drawing.Point(5, 5);
            this.cuiButton2.ImageOffset = new System.Drawing.Point(18, 0);
            this.cuiButton2.Location = new System.Drawing.Point(3, 240);
            this.cuiButton2.Name = "cuiButton2";
            this.cuiButton2.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton2.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton2.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton2.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton2.OutlineThickness = 1F;
            this.cuiButton2.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton2.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton2.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton2.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton2.Size = new System.Drawing.Size(138, 46);
            this.cuiButton2.TabIndex = 2;
            this.cuiButton2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton2.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // cuiButton3
            // 
            this.cuiButton3.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.cuiButton3.CheckButton = false;
            this.cuiButton3.Checked = false;
            this.cuiButton3.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton3.CheckedForeColor = System.Drawing.Color.Black;
            this.cuiButton3.CheckedImageTint = System.Drawing.Color.Black;
            this.cuiButton3.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton3.Content = "Product Alert";
            this.cuiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiButton3.ForeColor = System.Drawing.Color.White;
            this.cuiButton3.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton3.HoveredImageTint = System.Drawing.Color.Transparent;
            this.cuiButton3.HoverForeColor = System.Drawing.Color.Black;
            this.cuiButton3.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton3.Image = global::InventoreSys.Properties.Resources.warning;
            this.cuiButton3.ImageAutoCenter = false;
            this.cuiButton3.ImageExpand = new System.Drawing.Point(5, 5);
            this.cuiButton3.ImageOffset = new System.Drawing.Point(18, 0);
            this.cuiButton3.Location = new System.Drawing.Point(3, 292);
            this.cuiButton3.Name = "cuiButton3";
            this.cuiButton3.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton3.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton3.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton3.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton3.OutlineThickness = 1F;
            this.cuiButton3.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton3.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton3.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton3.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton3.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton3.Size = new System.Drawing.Size(138, 46);
            this.cuiButton3.TabIndex = 3;
            this.cuiButton3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton3.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // cuiButton4
            // 
            this.cuiButton4.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.cuiButton4.CheckButton = false;
            this.cuiButton4.Checked = false;
            this.cuiButton4.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton4.CheckedForeColor = System.Drawing.Color.Black;
            this.cuiButton4.CheckedImageTint = System.Drawing.Color.Black;
            this.cuiButton4.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton4.Content = "Batch";
            this.cuiButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiButton4.ForeColor = System.Drawing.Color.White;
            this.cuiButton4.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton4.HoveredImageTint = System.Drawing.Color.Transparent;
            this.cuiButton4.HoverForeColor = System.Drawing.Color.Black;
            this.cuiButton4.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton4.Image = global::InventoreSys.Properties.Resources.stack_overflow;
            this.cuiButton4.ImageAutoCenter = false;
            this.cuiButton4.ImageExpand = new System.Drawing.Point(5, 5);
            this.cuiButton4.ImageOffset = new System.Drawing.Point(18, 0);
            this.cuiButton4.Location = new System.Drawing.Point(3, 344);
            this.cuiButton4.Name = "cuiButton4";
            this.cuiButton4.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton4.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton4.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton4.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton4.OutlineThickness = 1F;
            this.cuiButton4.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton4.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton4.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton4.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton4.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton4.Size = new System.Drawing.Size(138, 46);
            this.cuiButton4.TabIndex = 4;
            this.cuiButton4.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton4.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // cuiButton5
            // 
            this.cuiButton5.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.cuiButton5.CheckButton = false;
            this.cuiButton5.Checked = false;
            this.cuiButton5.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton5.CheckedForeColor = System.Drawing.Color.Black;
            this.cuiButton5.CheckedImageTint = System.Drawing.Color.Black;
            this.cuiButton5.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton5.Content = "Employees";
            this.cuiButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiButton5.ForeColor = System.Drawing.Color.White;
            this.cuiButton5.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton5.HoveredImageTint = System.Drawing.Color.Transparent;
            this.cuiButton5.HoverForeColor = System.Drawing.Color.Black;
            this.cuiButton5.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton5.Image = global::InventoreSys.Properties.Resources.teamwork;
            this.cuiButton5.ImageAutoCenter = false;
            this.cuiButton5.ImageExpand = new System.Drawing.Point(5, 5);
            this.cuiButton5.ImageOffset = new System.Drawing.Point(18, 0);
            this.cuiButton5.Location = new System.Drawing.Point(3, 396);
            this.cuiButton5.Name = "cuiButton5";
            this.cuiButton5.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton5.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton5.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton5.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton5.OutlineThickness = 1F;
            this.cuiButton5.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton5.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton5.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton5.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton5.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton5.Size = new System.Drawing.Size(138, 46);
            this.cuiButton5.TabIndex = 5;
            this.cuiButton5.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton5.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // cuiButton6
            // 
            this.cuiButton6.CheckButton = false;
            this.cuiButton6.Checked = false;
            this.cuiButton6.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton6.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton6.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton6.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton6.Content = "Log out";
            this.cuiButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiButton6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cuiButton6.HoverBackground = System.Drawing.Color.White;
            this.cuiButton6.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton6.HoverForeColor = System.Drawing.Color.Black;
            this.cuiButton6.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton6.Image = global::InventoreSys.Properties.Resources.logout;
            this.cuiButton6.ImageAutoCenter = false;
            this.cuiButton6.ImageExpand = new System.Drawing.Point(5, 5);
            this.cuiButton6.ImageOffset = new System.Drawing.Point(20, 0);
            this.cuiButton6.Location = new System.Drawing.Point(3, 505);
            this.cuiButton6.Name = "cuiButton6";
            this.cuiButton6.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton6.NormalForeColor = System.Drawing.Color.WhiteSmoke;
            this.cuiButton6.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton6.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton6.OutlineThickness = 1F;
            this.cuiButton6.PressedBackground = System.Drawing.Color.Transparent;
            this.cuiButton6.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton6.PressedImageTint = System.Drawing.Color.Transparent;
            this.cuiButton6.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton6.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton6.Size = new System.Drawing.Size(153, 45);
            this.cuiButton6.TabIndex = 1;
            this.cuiButton6.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton6.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
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
        private CuoreUI.Controls.cuiButton cuiButton1;
        private System.Windows.Forms.Panel panel2;
        private CuoreUI.Controls.cuiButton cuiButton2;
        private CuoreUI.Controls.cuiButton cuiButton3;
        private CuoreUI.Controls.cuiButton cuiButton4;
        private CuoreUI.Controls.cuiButton cuiButton5;
        private System.Windows.Forms.Panel panel3;
        private CuoreUI.Controls.cuiButton cuiButton6;
    }
}

