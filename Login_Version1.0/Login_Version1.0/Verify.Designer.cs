namespace Login_Version1._0
{
    partial class Verify
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
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            VerificationBox = new CuoreUI.Controls.cuiOTPasswordBox();
            cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            VerifyButton = new CuoreUI.Controls.cuiButton();
            SuspendLayout();
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = "Verify\\ Authentication\\ Code";
            cuiLabel1.Font = new Font("Arial", 20F, FontStyle.Bold);
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(427, 181);
            cuiLabel1.Margin = new Padding(4, 3, 4, 3);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(400, 50);
            cuiLabel1.TabIndex = 0;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel2
            // 
            cuiLabel2.BackColor = Color.Transparent;
            cuiLabel2.Content = "Enter\\ the\\ 6-Digit\\ code\\ sent\\ to\\ your\\ email";
            cuiLabel2.Font = new Font("Arial", 10F, FontStyle.Bold);
            cuiLabel2.HorizontalAlignment = StringAlignment.Center;
            cuiLabel2.Location = new Point(479, 223);
            cuiLabel2.Margin = new Padding(4, 3, 4, 3);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(300, 50);
            cuiLabel2.TabIndex = 1;
            cuiLabel2.VerticalAlignment = StringAlignment.Near;
            // 
            // VerificationBox
            // 
            VerificationBox.BackColor = Color.Transparent;
            VerificationBox.BoxAmount = 6;
            VerificationBox.Content = "";
            VerificationBox.FocusedBorderColor = Color.Black;
            VerificationBox.FocusedColor = Color.WhiteSmoke;
            VerificationBox.FocusedTextColor = Color.Black;
            VerificationBox.Font = new Font("Arial", 15F);
            VerificationBox.Location = new Point(281, 279);
            VerificationBox.Name = "VerificationBox";
            VerificationBox.OnlyDigit = false;
            VerificationBox.Rounding = 8;
            VerificationBox.Size = new Size(701, 111);
            VerificationBox.TabIndex = 2;
            VerificationBox.UnderlinedStyle = true;
            VerificationBox.UnfocusedBorderColor = Color.DimGray;
            VerificationBox.UnfocusedColor = Color.White;
            VerificationBox.UnfocusedTextColor = Color.Black;
            VerificationBox.FinishedTypingContent += VerificationBox_FinishedTypingContent;
            // 
            // cuiLabel3
            // 
            cuiLabel3.BackColor = Color.Transparent;
            cuiLabel3.Content = "Didn't\\ get\\ the\\ code\\?";
            cuiLabel3.Font = new Font("Arial", 12F);
            cuiLabel3.HorizontalAlignment = StringAlignment.Center;
            cuiLabel3.Location = new Point(491, 447);
            cuiLabel3.Margin = new Padding(4, 3, 4, 3);
            cuiLabel3.Name = "cuiLabel3";
            cuiLabel3.Size = new Size(155, 20);
            cuiLabel3.TabIndex = 3;
            cuiLabel3.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel4
            // 
            cuiLabel4.BackColor = Color.Transparent;
            cuiLabel4.Content = "resend\\ here";
            cuiLabel4.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Underline);
            cuiLabel4.HorizontalAlignment = StringAlignment.Center;
            cuiLabel4.Location = new Point(640, 445);
            cuiLabel4.Margin = new Padding(4, 3, 4, 3);
            cuiLabel4.Name = "cuiLabel4";
            cuiLabel4.Size = new Size(110, 22);
            cuiLabel4.TabIndex = 4;
            cuiLabel4.VerticalAlignment = StringAlignment.Near;
            // 
            // VerifyButton
            // 
            VerifyButton.BackColor = Color.Transparent;
            VerifyButton.CheckButton = false;
            VerifyButton.Checked = false;
            VerifyButton.CheckedBackground = Color.FromArgb(255, 106, 0);
            VerifyButton.CheckedForeColor = Color.White;
            VerifyButton.CheckedImageTint = Color.White;
            VerifyButton.CheckedOutline = Color.FromArgb(255, 106, 0);
            VerifyButton.Content = "Verify";
            VerifyButton.DialogResult = DialogResult.None;
            VerifyButton.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            VerifyButton.ForeColor = Color.White;
            VerifyButton.HoverBackground = Color.White;
            VerifyButton.HoveredImageTint = Color.White;
            VerifyButton.HoverForeColor = Color.Black;
            VerifyButton.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            VerifyButton.Image = null;
            VerifyButton.ImageAutoCenter = true;
            VerifyButton.ImageExpand = new Point(0, 0);
            VerifyButton.ImageOffset = new Point(0, 0);
            VerifyButton.Location = new Point(557, 523);
            VerifyButton.Name = "VerifyButton";
            VerifyButton.NormalBackground = Color.Black;
            VerifyButton.NormalForeColor = Color.White;
            VerifyButton.NormalImageTint = Color.Transparent;
            VerifyButton.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            VerifyButton.OutlineThickness = 1F;
            VerifyButton.PressedBackground = Color.Black;
            VerifyButton.PressedForeColor = Color.White;
            VerifyButton.PressedImageTint = Color.Transparent;
            VerifyButton.PressedOutline = Color.Transparent;
            VerifyButton.Rounding = new Padding(8);
            VerifyButton.Size = new Size(153, 45);
            VerifyButton.TabIndex = 5;
            VerifyButton.TextAlignment = StringAlignment.Center;
            VerifyButton.TextOffset = new Point(0, 0);
            // 
            // Verify
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(174, 198, 207);
            ClientSize = new Size(1264, 681);
            Controls.Add(VerifyButton);
            Controls.Add(cuiLabel4);
            Controls.Add(cuiLabel3);
            Controls.Add(VerificationBox);
            Controls.Add(cuiLabel2);
            Controls.Add(cuiLabel1);
            Name = "Verify";
            Text = "Inventory Management System: Verify";
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiOTPasswordBox VerificationBox;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiButton VerifyButton;
    }
}