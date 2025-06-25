namespace MainDashboard.Frontend.BatchOrders
{
    partial class BatchOrder
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
            AddEditBatchOrderLabel = new CuoreUI.Controls.cuiLabel();
            SubLabel = new CuoreUI.Controls.cuiLabel();
            BONameLabel = new CuoreUI.Controls.cuiLabel();
            BONameTextBox = new CuoreUI.Controls.cuiTextBox();
            ProductListLabel = new CuoreUI.Controls.cuiLabel();
            checkedListBox1 = new CheckedListBox();
            DescriptionLabel = new CuoreUI.Controls.cuiLabel();
            cuiTextBox1 = new CuoreUI.Controls.cuiTextBox();
            SaveBtn = new CuoreUI.Controls.cuiButton();
            CancelBtn = new CuoreUI.Controls.cuiButton();
            Received = new CuoreUI.Controls.cuiButton();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            SuspendLayout();
            // 
            // AddEditBatchOrderLabel
            // 
            AddEditBatchOrderLabel.Content = "Order\\ New\\ Batch\\ of\\ Products";
            AddEditBatchOrderLabel.Font = new Font("Leelawadee UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddEditBatchOrderLabel.HorizontalAlignment = StringAlignment.Near;
            AddEditBatchOrderLabel.Location = new Point(26, 25);
            AddEditBatchOrderLabel.Margin = new Padding(5, 4, 5, 4);
            AddEditBatchOrderLabel.Name = "AddEditBatchOrderLabel";
            AddEditBatchOrderLabel.Size = new Size(349, 44);
            AddEditBatchOrderLabel.TabIndex = 1;
            AddEditBatchOrderLabel.VerticalAlignment = StringAlignment.Center;
            // 
            // SubLabel
            // 
            SubLabel.BackColor = Color.Transparent;
            SubLabel.Content = "Check\\ the\\ lists\\ of\\ products\\ you'd\\ like\\ to\\ order";
            SubLabel.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubLabel.HorizontalAlignment = StringAlignment.Near;
            SubLabel.Location = new Point(26, 67);
            SubLabel.Margin = new Padding(5, 4, 5, 4);
            SubLabel.Name = "SubLabel";
            SubLabel.Size = new Size(369, 28);
            SubLabel.TabIndex = 34;
            SubLabel.VerticalAlignment = StringAlignment.Center;
            // 
            // BONameLabel
            // 
            BONameLabel.Content = "Batch\\ Order\\ Name\\ :";
            BONameLabel.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BONameLabel.HorizontalAlignment = StringAlignment.Near;
            BONameLabel.Location = new Point(26, 114);
            BONameLabel.Margin = new Padding(5, 4, 5, 4);
            BONameLabel.Name = "BONameLabel";
            BONameLabel.Size = new Size(280, 44);
            BONameLabel.TabIndex = 40;
            BONameLabel.VerticalAlignment = StringAlignment.Center;
            // 
            // BONameTextBox
            // 
            BONameTextBox.BackgroundColor = Color.White;
            BONameTextBox.Content = "";
            BONameTextBox.FocusBackgroundColor = Color.White;
            BONameTextBox.FocusImageTint = Color.White;
            BONameTextBox.FocusOutlineColor = Color.FromArgb(64, 64, 64);
            BONameTextBox.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BONameTextBox.ForeColor = Color.Gray;
            BONameTextBox.Image = null;
            BONameTextBox.ImageExpand = new Point(0, 0);
            BONameTextBox.ImageOffset = new Point(0, 0);
            BONameTextBox.Location = new Point(26, 151);
            BONameTextBox.Margin = new Padding(5);
            BONameTextBox.Multiline = false;
            BONameTextBox.Name = "BONameTextBox";
            BONameTextBox.NormalImageTint = Color.White;
            BONameTextBox.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            BONameTextBox.Padding = new Padding(18, 19, 18, 0);
            BONameTextBox.PasswordChar = false;
            BONameTextBox.PlaceholderColor = SystemColors.WindowText;
            BONameTextBox.PlaceholderText = "";
            BONameTextBox.Rounding = new Padding(8);
            BONameTextBox.Size = new Size(255, 56);
            BONameTextBox.TabIndex = 40;
            BONameTextBox.TextOffset = new Size(0, 0);
            BONameTextBox.UnderlinedStyle = true;
            // 
            // ProductListLabel
            // 
            ProductListLabel.Content = "List\\ of\\ Products\\ :";
            ProductListLabel.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductListLabel.HorizontalAlignment = StringAlignment.Near;
            ProductListLabel.Location = new Point(26, 231);
            ProductListLabel.Margin = new Padding(5, 4, 5, 4);
            ProductListLabel.Name = "ProductListLabel";
            ProductListLabel.Size = new Size(280, 44);
            ProductListLabel.TabIndex = 40;
            ProductListLabel.VerticalAlignment = StringAlignment.Center;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Lcd Monitor", "Opisina Chair", "Electric Drill", "Wifi Router", "Desk Lamp", "Filing Cabinet", "Software Suite", "Cctv Camera", "External Hdd", "Power Drill", "Wireless Keyboard", "Air Conditioner", "Projector", "Industrial Fan", "Smart Tv", "Printer Scanner", "Safety Helmet", "Network Switch", "Solar Panel", "Voltage Regulator", "Barcode Scanner", "Ups Battery", "Conference Phone", "Welding Machine", "Tablet", "Computer" });
            checkedListBox1.Location = new Point(26, 282);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(150, 114);
            checkedListBox1.TabIndex = 41;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.BackColor = Color.Transparent;
            DescriptionLabel.Content = "Description";
            DescriptionLabel.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DescriptionLabel.HorizontalAlignment = StringAlignment.Near;
            DescriptionLabel.Location = new Point(26, 432);
            DescriptionLabel.Margin = new Padding(5, 4, 5, 4);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(280, 44);
            DescriptionLabel.TabIndex = 42;
            DescriptionLabel.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiTextBox1
            // 
            cuiTextBox1.BackgroundColor = Color.White;
            cuiTextBox1.Content = "";
            cuiTextBox1.FocusBackgroundColor = Color.White;
            cuiTextBox1.FocusImageTint = Color.White;
            cuiTextBox1.FocusOutlineColor = Color.FromArgb(64, 64, 64);
            cuiTextBox1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox1.ForeColor = Color.Gray;
            cuiTextBox1.Image = null;
            cuiTextBox1.ImageExpand = new Point(0, 0);
            cuiTextBox1.ImageOffset = new Point(0, 0);
            cuiTextBox1.Location = new Point(26, 494);
            cuiTextBox1.Margin = new Padding(5);
            cuiTextBox1.Multiline = false;
            cuiTextBox1.Name = "cuiTextBox1";
            cuiTextBox1.NormalImageTint = Color.White;
            cuiTextBox1.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            cuiTextBox1.Padding = new Padding(18, 121, 18, 0);
            cuiTextBox1.PasswordChar = false;
            cuiTextBox1.PlaceholderColor = SystemColors.WindowText;
            cuiTextBox1.PlaceholderText = "";
            cuiTextBox1.Rounding = new Padding(8);
            cuiTextBox1.Size = new Size(595, 261);
            cuiTextBox1.TabIndex = 40;
            cuiTextBox1.TextOffset = new Size(0, 0);
            cuiTextBox1.UnderlinedStyle = true;
            // 
            // SaveBtn
            // 
            SaveBtn.CheckButton = false;
            SaveBtn.Checked = false;
            SaveBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            SaveBtn.CheckedForeColor = Color.White;
            SaveBtn.CheckedImageTint = Color.White;
            SaveBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            SaveBtn.Content = "Order";
            SaveBtn.DialogResult = DialogResult.None;
            SaveBtn.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveBtn.ForeColor = Color.White;
            SaveBtn.HoverBackground = Color.FromArgb(49, 93, 130);
            SaveBtn.HoveredImageTint = Color.White;
            SaveBtn.HoverForeColor = Color.WhiteSmoke;
            SaveBtn.HoverOutline = Color.FromArgb(33, 64, 89);
            SaveBtn.Image = Properties.Resources.truck;
            SaveBtn.ImageAutoCenter = true;
            SaveBtn.ImageExpand = new Point(0, 0);
            SaveBtn.ImageOffset = new Point(-10, 0);
            SaveBtn.Location = new Point(383, 806);
            SaveBtn.Margin = new Padding(3, 4, 3, 4);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.NormalBackground = Color.SteelBlue;
            SaveBtn.NormalForeColor = Color.White;
            SaveBtn.NormalImageTint = Color.White;
            SaveBtn.NormalOutline = Color.Transparent;
            SaveBtn.OutlineThickness = 1F;
            SaveBtn.PressedBackground = Color.FromArgb(49, 93, 130);
            SaveBtn.PressedForeColor = Color.White;
            SaveBtn.PressedImageTint = Color.White;
            SaveBtn.PressedOutline = Color.FromArgb(33, 64, 89);
            SaveBtn.Rounding = new Padding(8);
            SaveBtn.Size = new Size(175, 60);
            SaveBtn.TabIndex = 40;
            SaveBtn.TextAlignment = StringAlignment.Center;
            SaveBtn.TextOffset = new Point(0, 0);
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.Transparent;
            CancelBtn.CheckButton = false;
            CancelBtn.Checked = false;
            CancelBtn.CheckedBackground = Color.White;
            CancelBtn.CheckedForeColor = Color.White;
            CancelBtn.CheckedImageTint = Color.White;
            CancelBtn.CheckedOutline = Color.White;
            CancelBtn.Content = "Cancel";
            CancelBtn.DialogResult = DialogResult.None;
            CancelBtn.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelBtn.ForeColor = Color.Black;
            CancelBtn.HoverBackground = Color.Transparent;
            CancelBtn.HoveredImageTint = Color.White;
            CancelBtn.HoverForeColor = Color.SteelBlue;
            CancelBtn.HoverOutline = Color.SteelBlue;
            CancelBtn.Image = Properties.Resources.x;
            CancelBtn.ImageAutoCenter = true;
            CancelBtn.ImageExpand = new Point(0, 0);
            CancelBtn.ImageOffset = new Point(-10, 0);
            CancelBtn.Location = new Point(106, 806);
            CancelBtn.Margin = new Padding(3, 4, 3, 4);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.NormalBackground = Color.Transparent;
            CancelBtn.NormalForeColor = Color.Black;
            CancelBtn.NormalImageTint = Color.White;
            CancelBtn.NormalOutline = Color.Black;
            CancelBtn.OutlineThickness = 2F;
            CancelBtn.PressedBackground = Color.WhiteSmoke;
            CancelBtn.PressedForeColor = Color.SteelBlue;
            CancelBtn.PressedImageTint = Color.Transparent;
            CancelBtn.PressedOutline = Color.FromArgb(33, 64, 89);
            CancelBtn.Rounding = new Padding(8);
            CancelBtn.Size = new Size(175, 60);
            CancelBtn.TabIndex = 40;
            CancelBtn.TextAlignment = StringAlignment.Center;
            CancelBtn.TextOffset = new Point(0, 0);
            // 
            // Received
            // 
            Received.CheckButton = false;
            Received.Checked = false;
            Received.CheckedBackground = Color.FromArgb(255, 106, 0);
            Received.CheckedForeColor = Color.White;
            Received.CheckedImageTint = Color.White;
            Received.CheckedOutline = Color.FromArgb(255, 106, 0);
            Received.Content = "Received";
            Received.DialogResult = DialogResult.None;
            Received.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Received.ForeColor = Color.White;
            Received.HoverBackground = Color.FromArgb(49, 93, 130);
            Received.HoveredImageTint = Color.White;
            Received.HoverForeColor = Color.WhiteSmoke;
            Received.HoverOutline = Color.FromArgb(33, 64, 89);
            Received.Image = Properties.Resources.package_check;
            Received.ImageAutoCenter = true;
            Received.ImageExpand = new Point(0, 0);
            Received.ImageOffset = new Point(-10, 0);
            Received.Location = new Point(383, 932);
            Received.Margin = new Padding(3, 4, 3, 4);
            Received.Name = "Received";
            Received.NormalBackground = Color.SteelBlue;
            Received.NormalForeColor = Color.White;
            Received.NormalImageTint = Color.White;
            Received.NormalOutline = Color.Transparent;
            Received.OutlineThickness = 1F;
            Received.PressedBackground = Color.FromArgb(49, 93, 130);
            Received.PressedForeColor = Color.White;
            Received.PressedImageTint = Color.White;
            Received.PressedOutline = Color.FromArgb(33, 64, 89);
            Received.Rounding = new Padding(8);
            Received.Size = new Size(175, 60);
            Received.TabIndex = 43;
            Received.TextAlignment = StringAlignment.Center;
            Received.TextOffset = new Point(0, 0);
            // 
            // cuiButton1
            // 
            cuiButton1.BackColor = Color.Transparent;
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.White;
            cuiButton1.CheckedForeColor = Color.White;
            cuiButton1.CheckedImageTint = Color.White;
            cuiButton1.CheckedOutline = Color.White;
            cuiButton1.Content = "Not Yet Received";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiButton1.ForeColor = Color.Black;
            cuiButton1.HoverBackground = Color.Transparent;
            cuiButton1.HoveredImageTint = Color.White;
            cuiButton1.HoverForeColor = Color.SteelBlue;
            cuiButton1.HoverOutline = Color.SteelBlue;
            cuiButton1.Image = Properties.Resources.package_x;
            cuiButton1.ImageAutoCenter = true;
            cuiButton1.ImageExpand = new Point(0, 0);
            cuiButton1.ImageOffset = new Point(-10, 0);
            cuiButton1.Location = new Point(73, 932);
            cuiButton1.Margin = new Padding(3, 4, 3, 4);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.Transparent;
            cuiButton1.NormalForeColor = Color.Black;
            cuiButton1.NormalImageTint = Color.White;
            cuiButton1.NormalOutline = Color.Black;
            cuiButton1.OutlineThickness = 2F;
            cuiButton1.PressedBackground = Color.WhiteSmoke;
            cuiButton1.PressedForeColor = Color.SteelBlue;
            cuiButton1.PressedImageTint = Color.Transparent;
            cuiButton1.PressedOutline = Color.FromArgb(33, 64, 89);
            cuiButton1.Rounding = new Padding(8);
            cuiButton1.Size = new Size(269, 60);
            cuiButton1.TabIndex = 44;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextOffset = new Point(0, 0);
            // 
            // BatchOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(686, 1200);
            Controls.Add(cuiButton1);
            Controls.Add(Received);
            Controls.Add(CancelBtn);
            Controls.Add(SaveBtn);
            Controls.Add(cuiTextBox1);
            Controls.Add(DescriptionLabel);
            Controls.Add(checkedListBox1);
            Controls.Add(ProductListLabel);
            Controls.Add(BONameTextBox);
            Controls.Add(BONameLabel);
            Controls.Add(SubLabel);
            Controls.Add(AddEditBatchOrderLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "BatchOrder";
            Text = "Batch Orders";
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiLabel AddEditBatchOrderLabel;
        private CuoreUI.Controls.cuiLabel SubLabel;
        private CuoreUI.Controls.cuiLabel BONameLabel;
        private CuoreUI.Controls.cuiTextBox BONameTextBox;
        private CuoreUI.Controls.cuiLabel ProductListLabel;
        private CheckedListBox checkedListBox1;
        private CuoreUI.Controls.cuiLabel DescriptionLabel;
        private CuoreUI.Controls.cuiTextBox cuiTextBox1;
        private CuoreUI.Controls.cuiButton SaveBtn;
        private CuoreUI.Controls.cuiButton CancelBtn;
        private CuoreUI.Controls.cuiButton Received;
        private CuoreUI.Controls.cuiButton cuiButton1;
    }
}