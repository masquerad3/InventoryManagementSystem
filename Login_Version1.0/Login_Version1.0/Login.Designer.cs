using MainDashboard;

namespace Login_Version1._0
{
    partial class Login
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
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            SignInButton = new CuoreUI.Controls.cuiLabel();
            cuiLabel5 = new CuoreUI.Controls.cuiLabel();
            cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            cuiTextBox2 = new CuoreUI.Controls.cuiTextBox();
            EmailLabel = new CuoreUI.Controls.cuiTextBox();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            cuiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // cuiPanel1
            // 
            cuiPanel1.Controls.Add(SignInButton);
            cuiPanel1.Controls.Add(cuiLabel5);
            cuiPanel1.Controls.Add(cuiLabel4);
            cuiPanel1.Controls.Add(cuiLabel3);
            cuiPanel1.Controls.Add(cuiButton1);
            cuiPanel1.Controls.Add(cuiTextBox2);
            cuiPanel1.Controls.Add(EmailLabel);
            cuiPanel1.Location = new Point(691, 41);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.WhiteSmoke;
            cuiPanel1.PanelOutlineColor = Color.FromArgb(22, 22, 22);
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(550, 630);
            cuiPanel1.TabIndex = 0;
            // 
            // SignInButton
            // 
            SignInButton.BackColor = Color.Transparent;
            SignInButton.Content = "Sign\\ up\\ here";
            SignInButton.Cursor = Cursors.Hand;
            SignInButton.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Underline);
            SignInButton.HorizontalAlignment = StringAlignment.Center;
            SignInButton.Location = new Point(180, 430);
            SignInButton.Margin = new Padding(4, 3, 4, 3);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(200, 20);
            SignInButton.TabIndex = 4;
            SignInButton.VerticalAlignment = StringAlignment.Near;
            SignInButton.MouseClick += SignInButton_MouseClick;
            // 
            // cuiLabel5
            // 
            cuiLabel5.BackColor = Color.Transparent;
            cuiLabel5.Content = "Don't\\ have\\ an\\ account\\ yet\\?";
            cuiLabel5.HorizontalAlignment = StringAlignment.Center;
            cuiLabel5.Location = new Point(180, 400);
            cuiLabel5.Margin = new Padding(4, 3, 4, 3);
            cuiLabel5.Name = "cuiLabel5";
            cuiLabel5.Size = new Size(200, 30);
            cuiLabel5.TabIndex = 3;
            cuiLabel5.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel4
            // 
            cuiLabel4.BackColor = Color.Transparent;
            cuiLabel4.Content = "Welcome\\ to\\ Inventory\\ Management\\ System";
            cuiLabel4.Font = new Font("Arial", 10F);
            cuiLabel4.HorizontalAlignment = StringAlignment.Center;
            cuiLabel4.Location = new Point(129, 180);
            cuiLabel4.Margin = new Padding(4, 3, 4, 3);
            cuiLabel4.Name = "cuiLabel4";
            cuiLabel4.Size = new Size(300, 30);
            cuiLabel4.TabIndex = 0;
            cuiLabel4.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel3
            // 
            cuiLabel3.BackColor = Color.Transparent;
            cuiLabel3.Content = "Hi\\ User!";
            cuiLabel3.Font = new Font("Arial", 20F, FontStyle.Bold);
            cuiLabel3.HorizontalAlignment = StringAlignment.Center;
            cuiLabel3.Location = new Point(129, 150);
            cuiLabel3.Margin = new Padding(4, 3, 4, 3);
            cuiLabel3.Name = "cuiLabel3";
            cuiLabel3.Size = new Size(300, 50);
            cuiLabel3.TabIndex = 0;
            cuiLabel3.VerticalAlignment = StringAlignment.Near;
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
            cuiButton1.Content = "Login";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            cuiButton1.ForeColor = Color.White;
            cuiButton1.HoverBackground = Color.White;
            cuiButton1.HoveredImageTint = Color.White;
            cuiButton1.HoverForeColor = Color.Black;
            cuiButton1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton1.Image = null;
            cuiButton1.ImageAutoCenter = true;
            cuiButton1.ImageExpand = new Point(0, 0);
            cuiButton1.ImageOffset = new Point(0, 0);
            cuiButton1.Location = new Point(48, 514);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.Black;
            cuiButton1.NormalForeColor = Color.White;
            cuiButton1.NormalImageTint = Color.White;
            cuiButton1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.OutlineThickness = 1F;
            cuiButton1.PressedBackground = Color.WhiteSmoke;
            cuiButton1.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedImageTint = Color.White;
            cuiButton1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.Rounding = new Padding(8);
            cuiButton1.Size = new Size(466, 45);
            cuiButton1.TabIndex = 2;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextOffset = new Point(0, 0);
            cuiButton1.Click += cuiButton1_Click;
            // 
            // cuiTextBox2
            // 
            cuiTextBox2.BackColor = Color.Transparent;
            cuiTextBox2.BackgroundColor = Color.White;
            cuiTextBox2.Content = "";
            cuiTextBox2.FocusBackgroundColor = Color.White;
            cuiTextBox2.FocusImageTint = Color.White;
            cuiTextBox2.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            cuiTextBox2.Font = new Font("Arial", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox2.ForeColor = Color.Gray;
            cuiTextBox2.Image = null;
            cuiTextBox2.ImageExpand = new Point(0, 0);
            cuiTextBox2.ImageOffset = new Point(0, 0);
            cuiTextBox2.Location = new Point(48, 306);
            cuiTextBox2.Margin = new Padding(4);
            cuiTextBox2.Multiline = false;
            cuiTextBox2.Name = "cuiTextBox2";
            cuiTextBox2.NormalImageTint = Color.White;
            cuiTextBox2.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            cuiTextBox2.Padding = new Padding(15, 15, 15, 0);
            cuiTextBox2.PasswordChar = true;
            cuiTextBox2.PlaceholderColor = Color.Gray;
            cuiTextBox2.PlaceholderText = "Password";
            cuiTextBox2.Rounding = new Padding(8);
            cuiTextBox2.Size = new Size(466, 45);
            cuiTextBox2.TabIndex = 1;
            cuiTextBox2.TextOffset = new Size(0, 0);
            cuiTextBox2.UnderlinedStyle = true;
            // 
            // EmailLabel
            // 
            EmailLabel.BackColor = Color.Transparent;
            EmailLabel.BackgroundColor = Color.White;
            EmailLabel.Content = "";
            EmailLabel.FocusBackgroundColor = Color.White;
            EmailLabel.FocusImageTint = Color.White;
            EmailLabel.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            EmailLabel.Font = new Font("Arial", 9.5F);
            EmailLabel.ForeColor = Color.Gray;
            EmailLabel.Image = null;
            EmailLabel.ImageExpand = new Point(0, 0);
            EmailLabel.ImageOffset = new Point(0, 0);
            EmailLabel.Location = new Point(48, 239);
            EmailLabel.Margin = new Padding(4);
            EmailLabel.Multiline = false;
            EmailLabel.Name = "EmailLabel";
            EmailLabel.NormalImageTint = Color.White;
            EmailLabel.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            EmailLabel.Padding = new Padding(15, 15, 15, 0);
            EmailLabel.PasswordChar = false;
            EmailLabel.PlaceholderColor = Color.Gray;
            EmailLabel.PlaceholderText = "Email";
            EmailLabel.Rounding = new Padding(8);
            EmailLabel.Size = new Size(466, 45);
            EmailLabel.TabIndex = 0;
            EmailLabel.TextOffset = new Size(0, 0);
            EmailLabel.UnderlinedStyle = true;
            // 
            // cuiLabel1
            // 
            cuiLabel1.Content = "Inventory\\ Management\\ System";
            cuiLabel1.Font = new Font("Arial", 36F, FontStyle.Bold);
            cuiLabel1.HorizontalAlignment = StringAlignment.Near;
            cuiLabel1.Location = new Point(88, 41);
            cuiLabel1.Margin = new Padding(4, 3, 3, 3);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(400, 200);
            cuiLabel1.TabIndex = 1;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel2
            // 
            cuiLabel2.Content = "Manage\\ your\\ products\\ easily\\ and\\ efficiently!";
            cuiLabel2.Font = new Font("Arial", 10F, FontStyle.Bold);
            cuiLabel2.HorizontalAlignment = StringAlignment.Near;
            cuiLabel2.Location = new Point(88, 230);
            cuiLabel2.Margin = new Padding(4, 3, 4, 3);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(300, 54);
            cuiLabel2.TabIndex = 2;
            cuiLabel2.VerticalAlignment = StringAlignment.Near;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(174, 198, 207);
            ClientSize = new Size(1280, 720);
            Controls.Add(cuiLabel2);
            Controls.Add(cuiLabel1);
            Controls.Add(cuiPanel1);
            Name = "Login";
            Text = "Login";
            Load += Form1_Load;
            cuiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialization code here
        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiTextBox cuiTextBox2;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiLabel cuiLabel5;
        private CuoreUI.Controls.cuiLabel SignInButton;
        public CuoreUI.Controls.cuiTextBox EmailLabel;
    }
}
