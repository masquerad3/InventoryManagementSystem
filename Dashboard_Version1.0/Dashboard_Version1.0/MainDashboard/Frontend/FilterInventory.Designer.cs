
namespace MainDashboard
{
    partial class FilterInventory
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
            FilterHeader = new CuoreUI.Controls.cuiLabel();
            FilterLabel = new CuoreUI.Controls.cuiLabel();
            ComputerDropdown = new CuoreUI.Controls.cuiComboBox();
            ComputerTypeLabel = new CuoreUI.Controls.cuiLabel();
            BrandLabel = new CuoreUI.Controls.cuiLabel();
            BrandDropdown = new CuoreUI.Controls.cuiComboBox();
            InventoryFilterBtn = new CuoreUI.Controls.cuiButton();
            FilterCancelBtn = new CuoreUI.Controls.cuiButton();
            SuspendLayout();
            // 
            // FilterHeader
            // 
            FilterHeader.Content = "Filter";
            FilterHeader.Font = new Font("Leelawadee UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FilterHeader.HorizontalAlignment = StringAlignment.Near;
            FilterHeader.Location = new Point(13, 21);
            FilterHeader.Margin = new Padding(4, 3, 4, 3);
            FilterHeader.Name = "FilterHeader";
            FilterHeader.Size = new Size(67, 28);
            FilterHeader.TabIndex = 0;
            FilterHeader.VerticalAlignment = StringAlignment.Center;
            // 
            // FilterLabel
            // 
            FilterLabel.Content = "Select\\ item\\ categories:";
            FilterLabel.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FilterLabel.HorizontalAlignment = StringAlignment.Near;
            FilterLabel.Location = new Point(13, 55);
            FilterLabel.Margin = new Padding(4, 3, 4, 3);
            FilterLabel.Name = "FilterLabel";
            FilterLabel.Size = new Size(222, 28);
            FilterLabel.TabIndex = 1;
            FilterLabel.VerticalAlignment = StringAlignment.Center;
            // 
            // ComputerDropdown
            // 
            ComputerDropdown.BackgroundColor = Color.FromArgb(255, 255, 255);
            ComputerDropdown.ButtonCursor = Cursors.Arrow;
            ComputerDropdown.ButtonHoverBackground = Color.FromArgb(224, 224, 224);
            ComputerDropdown.ButtonHoverOutline = Color.Empty;
            ComputerDropdown.ButtonNormalBackground = Color.White;
            ComputerDropdown.ButtonNormalOutline = Color.Empty;
            ComputerDropdown.ButtonPressedBackground = Color.Silver;
            ComputerDropdown.ButtonPressedOutline = Color.Empty;
            ComputerDropdown.DropDownBackgroundColor = Color.White;
            ComputerDropdown.DropDownOutlineColor = Color.FromArgb(30, 255, 255, 255);
            ComputerDropdown.ExpandArrowColor = Color.Gray;
            ComputerDropdown.ForeColor = Color.Gray;
            ComputerDropdown.Location = new Point(13, 130);
            ComputerDropdown.Margin = new Padding(4, 3, 4, 3);
            ComputerDropdown.Name = "ComputerDropdown";
            ComputerDropdown.NoSelectionDropdownText = "Empty";
            ComputerDropdown.NoSelectionText = "Select Type";
            ComputerDropdown.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            ComputerDropdown.OutlineThickness = 1F;
            ComputerDropdown.Rounding = 8;
            ComputerDropdown.Size = new Size(317, 38);
            ComputerDropdown.TabIndex = 2;
            // 
            // ComputerTypeLabel
            // 
            ComputerTypeLabel.BackColor = Color.Transparent;
            ComputerTypeLabel.Content = "Computer\\ Type:";
            ComputerTypeLabel.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ComputerTypeLabel.HorizontalAlignment = StringAlignment.Near;
            ComputerTypeLabel.Location = new Point(13, 102);
            ComputerTypeLabel.Margin = new Padding(4, 3, 4, 3);
            ComputerTypeLabel.Name = "ComputerTypeLabel";
            ComputerTypeLabel.Size = new Size(222, 28);
            ComputerTypeLabel.TabIndex = 3;
            ComputerTypeLabel.VerticalAlignment = StringAlignment.Center;
            // 
            // BrandLabel
            // 
            BrandLabel.BackColor = Color.Transparent;
            BrandLabel.Content = "Brand";
            BrandLabel.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BrandLabel.HorizontalAlignment = StringAlignment.Near;
            BrandLabel.Location = new Point(13, 182);
            BrandLabel.Margin = new Padding(4, 3, 4, 3);
            BrandLabel.Name = "BrandLabel";
            BrandLabel.Size = new Size(222, 28);
            BrandLabel.TabIndex = 4;
            BrandLabel.VerticalAlignment = StringAlignment.Center;
            // 
            // BrandDropdown
            // 
            BrandDropdown.BackgroundColor = Color.FromArgb(255, 255, 255);
            BrandDropdown.ButtonCursor = Cursors.Arrow;
            BrandDropdown.ButtonHoverBackground = Color.FromArgb(224, 224, 224);
            BrandDropdown.ButtonHoverOutline = Color.Empty;
            BrandDropdown.ButtonNormalBackground = Color.White;
            BrandDropdown.ButtonNormalOutline = Color.Empty;
            BrandDropdown.ButtonPressedBackground = Color.Silver;
            BrandDropdown.ButtonPressedOutline = Color.Empty;
            BrandDropdown.DropDownBackgroundColor = Color.White;
            BrandDropdown.DropDownOutlineColor = Color.FromArgb(30, 255, 255, 255);
            BrandDropdown.ExpandArrowColor = Color.Gray;
            BrandDropdown.ForeColor = Color.Gray;
            BrandDropdown.Items = new string[]
    {
    "Apple",
    "Lenovo",
    "MSI",
    "Acer",
    "Dell",
    "TUF",
    "Asus",
    "HP",
    "Microsoft",
    "Samsung"
    };
            BrandDropdown.Location = new Point(13, 206);
            BrandDropdown.Margin = new Padding(4, 3, 4, 3);
            BrandDropdown.Name = "BrandDropdown";
            BrandDropdown.NoSelectionDropdownText = "Empty";
            BrandDropdown.NoSelectionText = "Select Brand";
            BrandDropdown.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            BrandDropdown.OutlineThickness = 1F;
            BrandDropdown.Rounding = 8;
            BrandDropdown.Size = new Size(317, 38);
            BrandDropdown.TabIndex = 5;
            BrandDropdown.SelectedIndexChanged += cuiComboBox2_SelectedIndexChanged;
            // 
            // InventoryFilterBtn
            // 
            InventoryFilterBtn.CheckButton = false;
            InventoryFilterBtn.Checked = false;
            InventoryFilterBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            InventoryFilterBtn.CheckedForeColor = Color.White;
            InventoryFilterBtn.CheckedImageTint = Color.White;
            InventoryFilterBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            InventoryFilterBtn.Content = "Apply";
            InventoryFilterBtn.DialogResult = DialogResult.None;
            InventoryFilterBtn.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InventoryFilterBtn.ForeColor = Color.White;
            InventoryFilterBtn.HoverBackground = Color.White;
            InventoryFilterBtn.HoveredImageTint = Color.White;
            InventoryFilterBtn.HoverForeColor = Color.Black;
            InventoryFilterBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            InventoryFilterBtn.Image = null;
            InventoryFilterBtn.ImageAutoCenter = true;
            InventoryFilterBtn.ImageExpand = new Point(0, 0);
            InventoryFilterBtn.ImageOffset = new Point(0, 0);
            InventoryFilterBtn.Location = new Point(178, 338);
            InventoryFilterBtn.Name = "InventoryFilterBtn";
            InventoryFilterBtn.NormalBackground = Color.SteelBlue;
            InventoryFilterBtn.NormalForeColor = Color.White;
            InventoryFilterBtn.NormalImageTint = Color.White;
            InventoryFilterBtn.NormalOutline = Color.Transparent;
            InventoryFilterBtn.OutlineThickness = 1F;
            InventoryFilterBtn.PressedBackground = Color.FromArgb(49, 93, 130);
            InventoryFilterBtn.PressedForeColor = Color.White;
            InventoryFilterBtn.PressedImageTint = Color.White;
            InventoryFilterBtn.PressedOutline = Color.FromArgb(33, 64, 89);
            InventoryFilterBtn.Rounding = new Padding(8);
            InventoryFilterBtn.Size = new Size(153, 45);
            InventoryFilterBtn.TabIndex = 6;
            InventoryFilterBtn.TextAlignment = StringAlignment.Center;
            InventoryFilterBtn.TextOffset = new Point(0, 0);
            InventoryFilterBtn.Click += InventoryFilterBtn_Click;
            // 
            // FilterCancelBtn
            // 
            FilterCancelBtn.CheckButton = false;
            FilterCancelBtn.Checked = false;
            FilterCancelBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            FilterCancelBtn.CheckedForeColor = Color.White;
            FilterCancelBtn.CheckedImageTint = Color.White;
            FilterCancelBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            FilterCancelBtn.Content = "Cancel";
            FilterCancelBtn.DialogResult = DialogResult.None;
            FilterCancelBtn.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FilterCancelBtn.ForeColor = Color.Black;
            FilterCancelBtn.HoverBackground = Color.White;
            FilterCancelBtn.HoveredImageTint = Color.White;
            FilterCancelBtn.HoverForeColor = Color.Black;
            FilterCancelBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            FilterCancelBtn.Image = null;
            FilterCancelBtn.ImageAutoCenter = true;
            FilterCancelBtn.ImageExpand = new Point(0, 0);
            FilterCancelBtn.ImageOffset = new Point(0, 0);
            FilterCancelBtn.Location = new Point(13, 338);
            FilterCancelBtn.Name = "FilterCancelBtn";
            FilterCancelBtn.NormalBackground = Color.Transparent;
            FilterCancelBtn.NormalForeColor = Color.Black;
            FilterCancelBtn.NormalImageTint = Color.White;
            FilterCancelBtn.NormalOutline = Color.Black;
            FilterCancelBtn.OutlineThickness = 2F;
            FilterCancelBtn.PressedBackground = Color.WhiteSmoke;
            FilterCancelBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            FilterCancelBtn.PressedImageTint = Color.White;
            FilterCancelBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            FilterCancelBtn.Rounding = new Padding(8);
            FilterCancelBtn.Size = new Size(153, 45);
            FilterCancelBtn.TabIndex = 7;
            FilterCancelBtn.TextAlignment = StringAlignment.Center;
            FilterCancelBtn.TextOffset = new Point(0, 0);
            FilterCancelBtn.Click += FilterCancelBtn_Click;
            // 
            // FilterInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(343, 400);
            Controls.Add(FilterCancelBtn);
            Controls.Add(InventoryFilterBtn);
            Controls.Add(BrandDropdown);
            Controls.Add(BrandLabel);
            Controls.Add(ComputerTypeLabel);
            Controls.Add(ComputerDropdown);
            Controls.Add(FilterLabel);
            Controls.Add(FilterHeader);
            Font = new Font("Leelawadee UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FilterInventory";
            Text = "Filter";
            ResumeLayout(false);
        }


        #endregion

        private CuoreUI.Controls.cuiLabel FilterHeader;
        private CuoreUI.Controls.cuiLabel FilterLabel;
        private CuoreUI.Controls.cuiComboBox ComputerDropdown;
        private CuoreUI.Controls.cuiLabel ComputerTypeLabel;
        private CuoreUI.Controls.cuiLabel BrandLabel;
        private CuoreUI.Controls.cuiComboBox BrandDropdown;
        private CuoreUI.Controls.cuiButton InventoryFilterBtn;
        private CuoreUI.Controls.cuiButton FilterCancelBtn;
    }
}