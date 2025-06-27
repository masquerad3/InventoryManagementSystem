namespace MainDashboard.Frontend.EmployeeStaff
{
    partial class ManageEmployeeStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEmployeeStaff));
            EmpHeader = new CuoreUI.Controls.cuiLabel();
            SubLabel = new CuoreUI.Controls.cuiLabel();
            EmpNameLabel = new CuoreUI.Controls.cuiLabel();
            EmpNameTextBox = new CuoreUI.Controls.cuiTextBox();
            EmpPositionLabel = new CuoreUI.Controls.cuiLabel();
            EmpPositionCB = new CuoreUI.Controls.cuiComboBox();
            EmailLabel = new CuoreUI.Controls.cuiLabel();
            EmailTextBox = new CuoreUI.Controls.cuiTextBox();
            PasswordLabel = new CuoreUI.Controls.cuiLabel();
            PasswordTextBox = new CuoreUI.Controls.cuiTextBox();
            DOBLabel = new CuoreUI.Controls.cuiLabel();
            DOBPicker = new CuoreUI.Controls.cuiCalendarDatePicker();
            AddressLabel = new CuoreUI.Controls.cuiLabel();
            AddressTextBox = new CuoreUI.Controls.cuiTextBox();
            CancelBtn = new CuoreUI.Controls.cuiButton();
            SaveBtn = new CuoreUI.Controls.cuiButton();
            SuspendLayout();
            // 
            // EmpHeader
            // 
            EmpHeader.Content = "Employee\\ Information";
            EmpHeader.Font = new Font("Leelawadee UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmpHeader.HorizontalAlignment = StringAlignment.Near;
            EmpHeader.Location = new Point(32, 36);
            EmpHeader.Margin = new Padding(5, 4, 5, 4);
            EmpHeader.Name = "EmpHeader";
            EmpHeader.Size = new Size(617, 44);
            EmpHeader.TabIndex = 1;
            EmpHeader.VerticalAlignment = StringAlignment.Center;
            EmpHeader.Load += EmpHeader_Load;
            // 
            // SubLabel
            // 
            SubLabel.BackColor = Color.Transparent;
            SubLabel.Content = "Update\\ your\\ Information";
            SubLabel.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubLabel.HorizontalAlignment = StringAlignment.Near;
            SubLabel.Location = new Point(32, 77);
            SubLabel.Margin = new Padding(5, 4, 5, 4);
            SubLabel.Name = "SubLabel";
            SubLabel.Size = new Size(563, 28);
            SubLabel.TabIndex = 40;
            SubLabel.VerticalAlignment = StringAlignment.Center;
            // 
            // EmpNameLabel
            // 
            EmpNameLabel.Content = "Employee\\ Name\\ :";
            EmpNameLabel.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpNameLabel.HorizontalAlignment = StringAlignment.Near;
            EmpNameLabel.Location = new Point(32, 123);
            EmpNameLabel.Margin = new Padding(5, 4, 5, 4);
            EmpNameLabel.Name = "EmpNameLabel";
            EmpNameLabel.Size = new Size(280, 44);
            EmpNameLabel.TabIndex = 40;
            EmpNameLabel.VerticalAlignment = StringAlignment.Center;
            // 
            // EmpNameTextBox
            // 
            EmpNameTextBox.BackgroundColor = Color.White;
            EmpNameTextBox.Content = "";
            EmpNameTextBox.FocusBackgroundColor = Color.White;
            EmpNameTextBox.FocusImageTint = Color.White;
            EmpNameTextBox.FocusOutlineColor = Color.FromArgb(64, 64, 64);
            EmpNameTextBox.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpNameTextBox.ForeColor = Color.Gray;
            EmpNameTextBox.Image = null;
            EmpNameTextBox.ImageExpand = new Point(0, 0);
            EmpNameTextBox.ImageOffset = new Point(0, 0);
            EmpNameTextBox.Location = new Point(32, 165);
            EmpNameTextBox.Margin = new Padding(5, 5, 5, 5);
            EmpNameTextBox.Multiline = false;
            EmpNameTextBox.Name = "EmpNameTextBox";
            EmpNameTextBox.NormalImageTint = Color.White;
            EmpNameTextBox.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            EmpNameTextBox.Padding = new Padding(18, 19, 18, 0);
            EmpNameTextBox.PasswordChar = false;
            EmpNameTextBox.PlaceholderColor = SystemColors.WindowText;
            EmpNameTextBox.PlaceholderText = "";
            EmpNameTextBox.Rounding = new Padding(8);
            EmpNameTextBox.Size = new Size(255, 56);
            EmpNameTextBox.TabIndex = 41;
            EmpNameTextBox.TextOffset = new Size(0, 0);
            EmpNameTextBox.UnderlinedStyle = true;
            // 
            // EmpPositionLabel
            // 
            EmpPositionLabel.Content = "Position";
            EmpPositionLabel.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpPositionLabel.HorizontalAlignment = StringAlignment.Near;
            EmpPositionLabel.Location = new Point(369, 123);
            EmpPositionLabel.Margin = new Padding(5, 4, 5, 4);
            EmpPositionLabel.Name = "EmpPositionLabel";
            EmpPositionLabel.Size = new Size(280, 44);
            EmpPositionLabel.TabIndex = 42;
            EmpPositionLabel.VerticalAlignment = StringAlignment.Center;
            // 
            // EmpPositionCB
            // 
            EmpPositionCB.BackgroundColor = Color.FromArgb(255, 255, 255);
            EmpPositionCB.ButtonCursor = Cursors.Arrow;
            EmpPositionCB.ButtonHoverBackground = Color.FromArgb(192, 255, 106, 0);
            EmpPositionCB.ButtonHoverOutline = Color.Empty;
            EmpPositionCB.ButtonNormalBackground = Color.FromArgb(255, 106, 0);
            EmpPositionCB.ButtonNormalOutline = Color.Empty;
            EmpPositionCB.ButtonPressedBackground = Color.FromArgb(255, 106, 0);
            EmpPositionCB.ButtonPressedOutline = Color.Empty;
            EmpPositionCB.DropDownBackgroundColor = Color.White;
            EmpPositionCB.DropDownOutlineColor = Color.FromArgb(30, 255, 255, 255);
            EmpPositionCB.ExpandArrowColor = Color.Gray;
            EmpPositionCB.ForeColor = Color.Gray;
            EmpPositionCB.Items = new string[]
    {
    "Admin",
    "Regular",
    "Intern"
    };
            EmpPositionCB.Location = new Point(369, 164);
            EmpPositionCB.Margin = new Padding(5, 4, 5, 4);
            EmpPositionCB.Name = "EmpPositionCB";
            EmpPositionCB.NoSelectionDropdownText = "Empty";
            EmpPositionCB.NoSelectionText = "Position";
            EmpPositionCB.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            EmpPositionCB.OutlineThickness = 1F;
            EmpPositionCB.Rounding = 8;
            EmpPositionCB.Size = new Size(255, 57);
            EmpPositionCB.TabIndex = 43;
            // 
            // EmailLabel
            // 
            EmailLabel.Content = "Email\\ :";
            EmailLabel.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailLabel.HorizontalAlignment = StringAlignment.Near;
            EmailLabel.Location = new Point(32, 263);
            EmailLabel.Margin = new Padding(5, 4, 5, 4);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(280, 44);
            EmailLabel.TabIndex = 44;
            EmailLabel.VerticalAlignment = StringAlignment.Center;
            // 
            // EmailTextBox
            // 
            EmailTextBox.BackgroundColor = Color.White;
            EmailTextBox.Content = "";
            EmailTextBox.FocusBackgroundColor = Color.White;
            EmailTextBox.FocusImageTint = Color.White;
            EmailTextBox.FocusOutlineColor = Color.FromArgb(64, 64, 64);
            EmailTextBox.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailTextBox.ForeColor = Color.Gray;
            EmailTextBox.Image = null;
            EmailTextBox.ImageExpand = new Point(0, 0);
            EmailTextBox.ImageOffset = new Point(0, 0);
            EmailTextBox.Location = new Point(32, 305);
            EmailTextBox.Margin = new Padding(5, 5, 5, 5);
            EmailTextBox.Multiline = false;
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.NormalImageTint = Color.White;
            EmailTextBox.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            EmailTextBox.Padding = new Padding(18, 19, 18, 0);
            EmailTextBox.PasswordChar = false;
            EmailTextBox.PlaceholderColor = SystemColors.WindowText;
            EmailTextBox.PlaceholderText = "";
            EmailTextBox.Rounding = new Padding(8);
            EmailTextBox.Size = new Size(255, 56);
            EmailTextBox.TabIndex = 45;
            EmailTextBox.TextOffset = new Size(0, 0);
            EmailTextBox.UnderlinedStyle = true;
            // 
            // PasswordLabel
            // 
            PasswordLabel.Content = "Password\\ :";
            PasswordLabel.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordLabel.HorizontalAlignment = StringAlignment.Near;
            PasswordLabel.Location = new Point(32, 381);
            PasswordLabel.Margin = new Padding(5, 4, 5, 4);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(280, 44);
            PasswordLabel.TabIndex = 46;
            PasswordLabel.VerticalAlignment = StringAlignment.Center;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackgroundColor = Color.White;
            PasswordTextBox.Content = "";
            PasswordTextBox.FocusBackgroundColor = Color.White;
            PasswordTextBox.FocusImageTint = Color.White;
            PasswordTextBox.FocusOutlineColor = Color.FromArgb(64, 64, 64);
            PasswordTextBox.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTextBox.ForeColor = Color.Gray;
            PasswordTextBox.Image = null;
            PasswordTextBox.ImageExpand = new Point(0, 0);
            PasswordTextBox.ImageOffset = new Point(0, 0);
            PasswordTextBox.Location = new Point(32, 425);
            PasswordTextBox.Margin = new Padding(5, 5, 5, 5);
            PasswordTextBox.Multiline = false;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.NormalImageTint = Color.White;
            PasswordTextBox.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            PasswordTextBox.Padding = new Padding(18, 19, 18, 0);
            PasswordTextBox.PasswordChar = false;
            PasswordTextBox.PlaceholderColor = SystemColors.WindowText;
            PasswordTextBox.PlaceholderText = "";
            PasswordTextBox.Rounding = new Padding(8);
            PasswordTextBox.Size = new Size(255, 56);
            PasswordTextBox.TabIndex = 47;
            PasswordTextBox.TextOffset = new Size(0, 0);
            PasswordTextBox.UnderlinedStyle = true;
            // 
            // DOBLabel
            // 
            DOBLabel.Content = "Date\\ of\\ Birth\\ :";
            DOBLabel.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DOBLabel.HorizontalAlignment = StringAlignment.Near;
            DOBLabel.Location = new Point(369, 263);
            DOBLabel.Margin = new Padding(5, 4, 5, 4);
            DOBLabel.Name = "DOBLabel";
            DOBLabel.Size = new Size(280, 44);
            DOBLabel.TabIndex = 48;
            DOBLabel.VerticalAlignment = StringAlignment.Center;
            // 
            // DOBPicker
            // 
            DOBPicker.BackColor = Color.Transparent;
            DOBPicker.EnableThemeChangeButton = true;
            DOBPicker.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DOBPicker.ForeColor = Color.Gray;
            DOBPicker.HoverBackground = Color.FromArgb(50, 128, 128, 128);
            DOBPicker.HoverOutline = Color.FromArgb(180, 128, 128, 128);
            DOBPicker.Icon = (Image)resources.GetObject("DOBPicker.Icon");
            DOBPicker.IconTint = Color.Gray;
            DOBPicker.Location = new Point(369, 305);
            DOBPicker.Margin = new Padding(5, 4, 5, 4);
            DOBPicker.Name = "DOBPicker";
            DOBPicker.NormalBackground = Color.White;
            DOBPicker.NormalOutline = Color.FromArgb(150, 128, 128, 128);
            DOBPicker.OutlineThickness = 1.5F;
            DOBPicker.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.Bottom;
            DOBPicker.PressedBackground = Color.FromArgb(80, 128, 128, 128);
            DOBPicker.PressedOutline = Color.FromArgb(210, 128, 128, 128);
            DOBPicker.Rounding = 8;
            DOBPicker.ShowIcon = true;
            DOBPicker.Size = new Size(255, 56);
            DOBPicker.TabIndex = 40;
            DOBPicker.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            DOBPicker.Value = new DateTime(2025, 6, 24, 0, 0, 0, 0);
            // 
            // AddressLabel
            // 
            AddressLabel.Content = "Address\\ :";
            AddressLabel.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddressLabel.HorizontalAlignment = StringAlignment.Near;
            AddressLabel.Location = new Point(32, 527);
            AddressLabel.Margin = new Padding(5, 4, 5, 4);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(280, 44);
            AddressLabel.TabIndex = 49;
            AddressLabel.VerticalAlignment = StringAlignment.Center;
            // 
            // AddressTextBox
            // 
            AddressTextBox.BackgroundColor = Color.White;
            AddressTextBox.Content = "";
            AddressTextBox.FocusBackgroundColor = Color.White;
            AddressTextBox.FocusImageTint = Color.White;
            AddressTextBox.FocusOutlineColor = Color.FromArgb(64, 64, 64);
            AddressTextBox.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddressTextBox.ForeColor = Color.Gray;
            AddressTextBox.Image = null;
            AddressTextBox.ImageExpand = new Point(0, 0);
            AddressTextBox.ImageOffset = new Point(0, 0);
            AddressTextBox.Location = new Point(32, 569);
            AddressTextBox.Margin = new Padding(5, 5, 5, 5);
            AddressTextBox.Multiline = false;
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.NormalImageTint = Color.White;
            AddressTextBox.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            AddressTextBox.Padding = new Padding(18, 19, 18, 0);
            AddressTextBox.PasswordChar = false;
            AddressTextBox.PlaceholderColor = SystemColors.WindowText;
            AddressTextBox.PlaceholderText = "";
            AddressTextBox.Rounding = new Padding(8);
            AddressTextBox.Size = new Size(592, 56);
            AddressTextBox.TabIndex = 50;
            AddressTextBox.TextOffset = new Size(0, 0);
            AddressTextBox.UnderlinedStyle = true;
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
            CancelBtn.Location = new Point(137, 691);
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
            CancelBtn.Click += CancelBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.CheckButton = false;
            SaveBtn.Checked = false;
            SaveBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            SaveBtn.CheckedForeColor = Color.White;
            SaveBtn.CheckedImageTint = Color.White;
            SaveBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            SaveBtn.Content = "Add";
            SaveBtn.DialogResult = DialogResult.None;
            SaveBtn.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveBtn.ForeColor = Color.White;
            SaveBtn.HoverBackground = Color.FromArgb(49, 93, 130);
            SaveBtn.HoveredImageTint = Color.White;
            SaveBtn.HoverForeColor = Color.WhiteSmoke;
            SaveBtn.HoverOutline = Color.FromArgb(33, 64, 89);
            SaveBtn.Image = Properties.Resources.plus;
            SaveBtn.ImageAutoCenter = true;
            SaveBtn.ImageExpand = new Point(0, 0);
            SaveBtn.ImageOffset = new Point(-10, 0);
            SaveBtn.Location = new Point(369, 691);
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
            SaveBtn.Click += SaveBtn_Click;
            // 
            // ManageEmployeeStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(686, 823);
            Controls.Add(SaveBtn);
            Controls.Add(CancelBtn);
            Controls.Add(AddressTextBox);
            Controls.Add(AddressLabel);
            Controls.Add(DOBPicker);
            Controls.Add(DOBLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(EmailTextBox);
            Controls.Add(EmailLabel);
            Controls.Add(EmpPositionCB);
            Controls.Add(EmpPositionLabel);
            Controls.Add(EmpNameTextBox);
            Controls.Add(EmpNameLabel);
            Controls.Add(SubLabel);
            Controls.Add(EmpHeader);
            Name = "ManageEmployeeStaff";
            Text = "ManageEmployeeStaff";
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiLabel EmpHeader;
        private CuoreUI.Controls.cuiLabel SubLabel;
        private CuoreUI.Controls.cuiLabel EmpNameLabel;
        private CuoreUI.Controls.cuiTextBox EmpNameTextBox;
        private CuoreUI.Controls.cuiLabel EmpPositionLabel;
        private CuoreUI.Controls.cuiComboBox EmpPositionCB;
        private CuoreUI.Controls.cuiLabel EmailLabel;
        private CuoreUI.Controls.cuiTextBox EmailTextBox;
        private CuoreUI.Controls.cuiLabel PasswordLabel;
        private CuoreUI.Controls.cuiTextBox PasswordTextBox;
        private CuoreUI.Controls.cuiLabel DOBLabel;
        private CuoreUI.Controls.cuiCalendarDatePicker DOBPicker;
        private CuoreUI.Controls.cuiLabel AddressLabel;
        private CuoreUI.Controls.cuiTextBox AddressTextBox;
        private CuoreUI.Controls.cuiButton CancelBtn;
        private CuoreUI.Controls.cuiButton SaveBtn;
    }
}