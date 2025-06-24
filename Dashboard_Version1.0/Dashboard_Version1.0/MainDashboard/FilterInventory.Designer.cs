
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
            cuiComboBox1 = new CuoreUI.Controls.cuiComboBox();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            cuiComboBox2 = new CuoreUI.Controls.cuiComboBox();
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
            // cuiComboBox1
            // 
            cuiComboBox1.BackgroundColor = Color.FromArgb(255, 255, 255);
            cuiComboBox1.ButtonCursor = Cursors.Arrow;
            cuiComboBox1.ButtonHoverBackground = Color.FromArgb(192, 255, 106, 0);
            cuiComboBox1.ButtonHoverOutline = Color.Empty;
            cuiComboBox1.ButtonNormalBackground = Color.FromArgb(255, 106, 0);
            cuiComboBox1.ButtonNormalOutline = Color.Empty;
            cuiComboBox1.ButtonPressedBackground = Color.FromArgb(255, 106, 0);
            cuiComboBox1.ButtonPressedOutline = Color.Empty;
            cuiComboBox1.DropDownBackgroundColor = Color.White;
            cuiComboBox1.DropDownOutlineColor = Color.FromArgb(30, 255, 255, 255);
            cuiComboBox1.ExpandArrowColor = Color.Gray;
            cuiComboBox1.ForeColor = Color.Gray;
            cuiComboBox1.Location = new Point(13, 127);
            cuiComboBox1.Margin = new Padding(4, 3, 4, 3);
            cuiComboBox1.Name = "cuiComboBox1";
            cuiComboBox1.NoSelectionDropdownText = "Empty";
            cuiComboBox1.NoSelectionText = "Select Type";
            cuiComboBox1.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiComboBox1.OutlineThickness = 1F;
            cuiComboBox1.Rounding = 8;
            cuiComboBox1.Size = new Size(317, 38);
            cuiComboBox1.TabIndex = 2;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = "Computer\\ Type:";
            cuiLabel1.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel1.HorizontalAlignment = StringAlignment.Near;
            cuiLabel1.Location = new Point(13, 102);
            cuiLabel1.Margin = new Padding(4, 3, 4, 3);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(222, 28);
            cuiLabel1.TabIndex = 3;
            cuiLabel1.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabel2
            // 
            cuiLabel2.BackColor = Color.Transparent;
            cuiLabel2.Content = "Brand";
            cuiLabel2.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel2.HorizontalAlignment = StringAlignment.Near;
            cuiLabel2.Location = new Point(13, 182);
            cuiLabel2.Margin = new Padding(4, 3, 4, 3);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(222, 28);
            cuiLabel2.TabIndex = 4;
            cuiLabel2.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiComboBox2
            // 
            cuiComboBox2.BackgroundColor = Color.FromArgb(255, 255, 255);
            cuiComboBox2.ButtonCursor = Cursors.Arrow;
            cuiComboBox2.ButtonHoverBackground = Color.FromArgb(192, 255, 106, 0);
            cuiComboBox2.ButtonHoverOutline = Color.Empty;
            cuiComboBox2.ButtonNormalBackground = Color.FromArgb(255, 106, 0);
            cuiComboBox2.ButtonNormalOutline = Color.Empty;
            cuiComboBox2.ButtonPressedBackground = Color.FromArgb(255, 106, 0);
            cuiComboBox2.ButtonPressedOutline = Color.Empty;
            cuiComboBox2.DropDownBackgroundColor = Color.White;
            cuiComboBox2.DropDownOutlineColor = Color.FromArgb(30, 255, 255, 255);
            cuiComboBox2.ExpandArrowColor = Color.Gray;
            cuiComboBox2.ForeColor = Color.Gray;
            cuiComboBox2.Items = new string[]
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
            cuiComboBox2.Location = new Point(13, 206);
            cuiComboBox2.Margin = new Padding(4, 3, 4, 3);
            cuiComboBox2.Name = "cuiComboBox2";
            cuiComboBox2.NoSelectionDropdownText = "Empty";
            cuiComboBox2.NoSelectionText = "Select Brand";
            cuiComboBox2.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiComboBox2.OutlineThickness = 1F;
            cuiComboBox2.Rounding = 8;
            cuiComboBox2.Size = new Size(317, 38);
            cuiComboBox2.TabIndex = 5;
            cuiComboBox2.SelectedIndexChanged += this.cuiComboBox2_SelectedIndexChanged;
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
            InventoryFilterBtn.Click += this.InventoryFilterBtn_Click;
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
            FilterCancelBtn.Click += this.FilterCancelBtn_Click;
            // 
            // FilterInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(343, 400);
            Controls.Add(FilterCancelBtn);
            Controls.Add(InventoryFilterBtn);
            Controls.Add(cuiComboBox2);
            Controls.Add(cuiLabel2);
            Controls.Add(cuiLabel1);
            Controls.Add(cuiComboBox1);
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
        private CuoreUI.Controls.cuiComboBox cuiComboBox1;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiComboBox cuiComboBox2;
        private CuoreUI.Controls.cuiButton InventoryFilterBtn;
        private CuoreUI.Controls.cuiButton FilterCancelBtn;
    }
}