namespace inventorymanagement
{
    partial class Form1
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
            panelside = new Panel();
            btnproduct = new Button();
            btninventory = new Button();
            btndashboard = new Button();
            panelheader = new Panel();
            mainpanel = new Panel();
            panelside.SuspendLayout();
            SuspendLayout();
            // 
            // panelside
            // 
            panelside.BackColor = Color.LightSkyBlue;
            panelside.Controls.Add(btnproduct);
            panelside.Controls.Add(btninventory);
            panelside.Controls.Add(btndashboard);
            panelside.Dock = DockStyle.Left;
            panelside.Location = new Point(0, 39);
            panelside.Name = "panelside";
            panelside.Size = new Size(164, 411);
            panelside.TabIndex = 0;
            // 
            // btnproduct
            // 
            btnproduct.FlatAppearance.BorderSize = 0;
            btnproduct.FlatStyle = FlatStyle.Flat;
            btnproduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnproduct.Image = Properties.Resources.producticon;
            btnproduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnproduct.Location = new Point(3, 168);
            btnproduct.Name = "btnproduct";
            btnproduct.Size = new Size(197, 40);
            btnproduct.TabIndex = 2;
            btnproduct.Text = "Product";
            btnproduct.UseVisualStyleBackColor = true;
            btnproduct.Click += btnproduct_Click;
            // 
            // btninventory
            // 
            btninventory.FlatAppearance.BorderSize = 0;
            btninventory.FlatStyle = FlatStyle.Flat;
            btninventory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btninventory.Image = Properties.Resources.inventoryicon;
            btninventory.ImageAlign = ContentAlignment.MiddleLeft;
            btninventory.Location = new Point(3, 122);
            btninventory.Name = "btninventory";
            btninventory.Size = new Size(197, 40);
            btninventory.TabIndex = 1;
            btninventory.Text = "Inventory";
            btninventory.UseVisualStyleBackColor = true;
            btninventory.Click += btninventory_Click;
            // 
            // btndashboard
            // 
            btndashboard.FlatAppearance.BorderSize = 0;
            btndashboard.FlatStyle = FlatStyle.Flat;
            btndashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndashboard.Image = Properties.Resources.dashboardicon;
            btndashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btndashboard.Location = new Point(3, 80);
            btndashboard.Name = "btndashboard";
            btndashboard.Size = new Size(197, 36);
            btndashboard.TabIndex = 0;
            btndashboard.Text = "Dashboard";
            btndashboard.UseVisualStyleBackColor = true;
            btndashboard.Click += btndashboard_Click;
            // 
            // panelheader
            // 
            panelheader.BackColor = Color.LightSkyBlue;
            panelheader.Dock = DockStyle.Top;
            panelheader.Location = new Point(0, 0);
            panelheader.Name = "panelheader";
            panelheader.Size = new Size(800, 39);
            panelheader.TabIndex = 1;
            // 
            // mainpanel
            // 
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(164, 39);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(636, 411);
            mainpanel.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(mainpanel);
            Controls.Add(panelside);
            Controls.Add(panelheader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panelside.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelside;
        private Panel panelheader;
        private Button btndashboard;
        private Panel mainpanel;
        private Button btninventory;
        private Button btnproduct;
    }
}
