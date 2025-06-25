namespace MainDashboard
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            cuiPanel6 = new CuoreUI.Controls.cuiPanel();
            InventoryHeader = new CuoreUI.Controls.cuiLabel();
            SearchBar = new CuoreUI.Controls.cuiTextBox();
            NotifIconBG = new CuoreUI.Controls.cuiGradientPanel();
            NotificationIcon = new CuoreUI.Controls.cuiPictureBox();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            FilterBtn = new CuoreUI.Controls.cuiButton();
            AddBtn = new CuoreUI.Controls.cuiButton();
            TableSearchBar = new CuoreUI.Controls.cuiTextBox();
            InventoryGridView = new DataGridView();
            ItemName = new DataGridViewTextBoxColumn();
            ItemCategory = new DataGridViewTextBoxColumn();
            ItemQuantity = new DataGridViewTextBoxColumn();
            ItemCondition = new DataGridViewTextBoxColumn();
            ItemPrice = new DataGridViewTextBoxColumn();
            View = new DataGridViewImageColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            cuiPanel6.SuspendLayout();
            NotifIconBG.SuspendLayout();
            cuiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InventoryGridView).BeginInit();
            SuspendLayout();
            // 
            // cuiPanel6
            // 
            cuiPanel6.Controls.Add(InventoryHeader);
            cuiPanel6.Controls.Add(SearchBar);
            cuiPanel6.Controls.Add(NotifIconBG);
            cuiPanel6.Dock = DockStyle.Top;
            cuiPanel6.Location = new Point(0, 0);
            cuiPanel6.Name = "cuiPanel6";
            cuiPanel6.OutlineThickness = 1F;
            cuiPanel6.PanelColor = Color.AliceBlue;
            cuiPanel6.PanelOutlineColor = Color.Transparent;
            cuiPanel6.Rounding = new Padding(8);
            cuiPanel6.Size = new Size(1060, 61);
            cuiPanel6.TabIndex = 9;
            // 
            // InventoryHeader
            // 
            InventoryHeader.BackColor = Color.Transparent;
            InventoryHeader.Content = "Inventory";
            InventoryHeader.Font = new Font("Leelawadee UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InventoryHeader.HorizontalAlignment = StringAlignment.Near;
            InventoryHeader.Location = new Point(22, 3);
            InventoryHeader.Margin = new Padding(4, 3, 4, 3);
            InventoryHeader.Name = "InventoryHeader";
            InventoryHeader.Size = new Size(245, 54);
            InventoryHeader.TabIndex = 1;
            InventoryHeader.VerticalAlignment = StringAlignment.Center;
            // 
            // SearchBar
            // 
            SearchBar.BackColor = Color.Transparent;
            SearchBar.BackgroundColor = Color.White;
            SearchBar.Content = "";
            SearchBar.FocusBackgroundColor = Color.White;
            SearchBar.FocusImageTint = Color.White;
            SearchBar.FocusOutlineColor = Color.DarkGray;
            SearchBar.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchBar.ForeColor = Color.Gray;
            SearchBar.Image = null;
            SearchBar.ImageExpand = new Point(5, 5);
            SearchBar.ImageOffset = new Point(0, 0);
            SearchBar.Location = new Point(600, 10);
            SearchBar.Margin = new Padding(4);
            SearchBar.Multiline = false;
            SearchBar.Name = "SearchBar";
            SearchBar.NormalImageTint = Color.Transparent;
            SearchBar.OutlineColor = Color.DarkGray;
            SearchBar.Padding = new Padding(18, 11, 18, 0);
            SearchBar.PasswordChar = false;
            SearchBar.PlaceholderColor = SystemColors.WindowText;
            SearchBar.PlaceholderText = "Search";
            SearchBar.Rounding = new Padding(8);
            SearchBar.Size = new Size(371, 40);
            SearchBar.TabIndex = 3;
            SearchBar.TextOffset = new Size(0, 0);
            SearchBar.UnderlinedStyle = true;
            // 
            // NotifIconBG
            // 
            NotifIconBG.Controls.Add(NotificationIcon);
            NotifIconBG.GradientAngle = 90F;
            NotifIconBG.Location = new Point(990, 10);
            NotifIconBG.Name = "NotifIconBG";
            NotifIconBG.OutlineThickness = 1F;
            NotifIconBG.PanelColor1 = Color.White;
            NotifIconBG.PanelColor2 = Color.LightGray;
            NotifIconBG.PanelOutlineColor1 = Color.FromArgb(224, 224, 224);
            NotifIconBG.PanelOutlineColor2 = Color.Silver;
            NotifIconBG.Rounding = new Padding(8);
            NotifIconBG.Size = new Size(35, 35);
            NotifIconBG.TabIndex = 12;
            // 
            // NotificationIcon
            // 
            NotificationIcon.BackColor = Color.Transparent;
            NotificationIcon.BackgroundImage = Properties.Resources.bell;
            NotificationIcon.BackgroundImageLayout = ImageLayout.Zoom;
            NotificationIcon.Content = null;
            NotificationIcon.ImageTint = Color.White;
            NotificationIcon.Location = new Point(4, 3);
            NotificationIcon.Margin = new Padding(4, 3, 4, 3);
            NotificationIcon.Name = "NotificationIcon";
            NotificationIcon.OutlineThickness = 1F;
            NotificationIcon.PanelOutlineColor = Color.Empty;
            NotificationIcon.Rotation = 0;
            NotificationIcon.Rounding = new Padding(8);
            NotificationIcon.Size = new Size(28, 28);
            NotificationIcon.TabIndex = 0;
            // 
            // cuiPanel1
            // 
            cuiPanel1.Controls.Add(FilterBtn);
            cuiPanel1.Controls.Add(AddBtn);
            cuiPanel1.Controls.Add(TableSearchBar);
            cuiPanel1.Controls.Add(InventoryGridView);
            cuiPanel1.Location = new Point(30, 100);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.FromArgb(224, 224, 224);
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(1000, 900);
            cuiPanel1.TabIndex = 10;
            // 
            // FilterBtn
            // 
            FilterBtn.AutoScroll = true;
            FilterBtn.BackColor = Color.Transparent;
            FilterBtn.CheckButton = false;
            FilterBtn.Checked = false;
            FilterBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            FilterBtn.CheckedForeColor = Color.White;
            FilterBtn.CheckedImageTint = Color.White;
            FilterBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            FilterBtn.Content = "Filter";
            FilterBtn.DialogResult = DialogResult.None;
            FilterBtn.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FilterBtn.ForeColor = Color.Black;
            FilterBtn.HoverBackground = Color.White;
            FilterBtn.HoveredImageTint = Color.White;
            FilterBtn.HoverForeColor = Color.Black;
            FilterBtn.HoverOutline = Color.Black;
            FilterBtn.Image = Properties.Resources.sliders_horizontal;
            FilterBtn.ImageAutoCenter = true;
            FilterBtn.ImageExpand = new Point(0, 0);
            FilterBtn.ImageOffset = new Point(-5, 0);
            FilterBtn.Location = new Point(870, 8);
            FilterBtn.Name = "FilterBtn";
            FilterBtn.NormalBackground = Color.White;
            FilterBtn.NormalForeColor = Color.Black;
            FilterBtn.NormalImageTint = Color.White;
            FilterBtn.NormalOutline = Color.Black;
            FilterBtn.OutlineThickness = 1F;
            FilterBtn.PressedBackground = Color.WhiteSmoke;
            FilterBtn.PressedForeColor = Color.Black;
            FilterBtn.PressedImageTint = Color.White;
            FilterBtn.PressedOutline = Color.Black;
            FilterBtn.Rounding = new Padding(8);
            FilterBtn.Size = new Size(105, 45);
            FilterBtn.TabIndex = 15;
            FilterBtn.TextAlignment = StringAlignment.Center;
            FilterBtn.TextOffset = new Point(0, 0);
            //FilterBtn.Click += FilterBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Transparent;
            AddBtn.CheckButton = false;
            AddBtn.Checked = false;
            AddBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            AddBtn.CheckedForeColor = Color.White;
            AddBtn.CheckedImageTint = Color.White;
            AddBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            AddBtn.Content = "Add Item";
            AddBtn.DialogResult = DialogResult.None;
            AddBtn.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.White;
            AddBtn.HoverBackground = Color.SteelBlue;
            AddBtn.HoveredImageTint = Color.White;
            AddBtn.HoverForeColor = Color.White;
            AddBtn.HoverOutline = Color.SteelBlue;
            AddBtn.Image = Properties.Resources.plus_circle;
            AddBtn.ImageAutoCenter = true;
            AddBtn.ImageExpand = new Point(3, 3);
            AddBtn.ImageOffset = new Point(-15, 0);
            AddBtn.Location = new Point(711, 8);
            AddBtn.Name = "AddBtn";
            AddBtn.NormalBackground = Color.SteelBlue;
            AddBtn.NormalForeColor = Color.White;
            AddBtn.NormalImageTint = Color.White;
            AddBtn.NormalOutline = Color.Transparent;
            AddBtn.OutlineThickness = 1F;
            AddBtn.PressedBackground = Color.FromArgb(49, 93, 130);
            AddBtn.PressedForeColor = Color.White;
            AddBtn.PressedImageTint = Color.White;
            AddBtn.PressedOutline = Color.FromArgb(33, 64, 89);
            AddBtn.Rounding = new Padding(8);
            AddBtn.Size = new Size(153, 45);
            AddBtn.TabIndex = 14;
            AddBtn.TextAlignment = StringAlignment.Center;
            AddBtn.TextOffset = new Point(0, 0);
            AddBtn.Click += AddBtn_Click;
            // 
            // TableSearchBar
            // 
            TableSearchBar.BackColor = Color.Transparent;
            TableSearchBar.BackgroundColor = Color.White;
            TableSearchBar.BorderStyle = BorderStyle.FixedSingle;
            TableSearchBar.Content = "";
            TableSearchBar.FocusBackgroundColor = Color.White;
            TableSearchBar.FocusImageTint = Color.White;
            TableSearchBar.FocusOutlineColor = Color.Transparent;
            TableSearchBar.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TableSearchBar.ForeColor = Color.Gray;
            TableSearchBar.Image = null;
            TableSearchBar.ImageExpand = new Point(0, 0);
            TableSearchBar.ImageOffset = new Point(0, 0);
            TableSearchBar.Location = new Point(25, 10);
            TableSearchBar.Margin = new Padding(4);
            TableSearchBar.Multiline = false;
            TableSearchBar.Name = "TableSearchBar";
            TableSearchBar.NormalImageTint = Color.Transparent;
            TableSearchBar.OutlineColor = Color.Transparent;
            TableSearchBar.Padding = new Padding(18, 11, 18, 0);
            TableSearchBar.PasswordChar = false;
            TableSearchBar.PlaceholderColor = SystemColors.WindowText;
            TableSearchBar.PlaceholderText = "Search";
            TableSearchBar.Rounding = new Padding(8);
            TableSearchBar.Size = new Size(371, 40);
            TableSearchBar.TabIndex = 13;
            TableSearchBar.TextOffset = new Size(0, 0);
            TableSearchBar.UnderlinedStyle = true;
            // 
            // InventoryGridView
            // 
            InventoryGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            InventoryGridView.BackgroundColor = SystemColors.ControlLight;
            InventoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InventoryGridView.Columns.AddRange(new DataGridViewColumn[] { ItemName, ItemCategory, ItemQuantity, ItemCondition, ItemPrice, View, Edit, Delete });
            InventoryGridView.Location = new Point(25, 60);
            InventoryGridView.Name = "InventoryGridView";
            InventoryGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            InventoryGridView.RowHeadersWidth = 51;
            InventoryGridView.RowTemplate.Height = 30;
            InventoryGridView.Size = new Size(950, 735);
            InventoryGridView.TabIndex = 0;
            // 
            // ItemName
            // 
            ItemName.HeaderText = "Item Name";
            ItemName.MinimumWidth = 6;
            ItemName.Name = "ItemName";
            // 
            // ItemCategory
            // 
            ItemCategory.HeaderText = "Category";
            ItemCategory.MinimumWidth = 6;
            ItemCategory.Name = "ItemCategory";
            // 
            // ItemQuantity
            // 
            ItemQuantity.HeaderText = "Quantity";
            ItemQuantity.MinimumWidth = 6;
            ItemQuantity.Name = "ItemQuantity";
            // 
            // ItemCondition
            // 
            ItemCondition.HeaderText = "Condition";
            ItemCondition.MinimumWidth = 6;
            ItemCondition.Name = "ItemCondition";
            // 
            // ItemPrice
            // 
            ItemPrice.HeaderText = "Price";
            ItemPrice.MinimumWidth = 6;
            ItemPrice.Name = "ItemPrice";
            // 
            // View
            // 
            View.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.NullValue = resources.GetObject("dataGridViewCellStyle1.NullValue");
            View.DefaultCellStyle = dataGridViewCellStyle1;
            View.Description = "View";
            View.HeaderText = "";
            View.Image = Properties.Resources.eye1;
            View.MinimumWidth = 6;
            View.Name = "View";
            View.Resizable = DataGridViewTriState.False;
            View.Width = 21;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.NullValue = resources.GetObject("dataGridViewCellStyle2.NullValue");
            Edit.DefaultCellStyle = dataGridViewCellStyle2;
            Edit.Description = "Edit";
            Edit.HeaderText = "";
            Edit.Image = Properties.Resources.pencil1;
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.True;
            Edit.Width = 21;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.NullValue = resources.GetObject("dataGridViewCellStyle3.NullValue");
            Delete.DefaultCellStyle = dataGridViewCellStyle3;
            Delete.Description = "Delete";
            Delete.HeaderText = "";
            Delete.Image = Properties.Resources.trash_21;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Resizable = DataGridViewTriState.True;
            Delete.Width = 21;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.AliceBlue;
            Controls.Add(cuiPanel1);
            Controls.Add(cuiPanel6);
            Name = "Inventory";
            Size = new Size(1060, 1100);
            cuiPanel6.ResumeLayout(false);
            NotifIconBG.ResumeLayout(false);
            cuiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)InventoryGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel6;
        private CuoreUI.Controls.cuiLabel InventoryHeader;
        private CuoreUI.Controls.cuiTextBox SearchBar;
        private CuoreUI.Controls.cuiGradientPanel NotifIconBG;
        private CuoreUI.Controls.cuiPictureBox NotificationIcon;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private DataGridView InventoryGridView;
        private CuoreUI.Controls.cuiTextBox TableSearchBar;
        private CuoreUI.Controls.cuiButton FilterBtn;
        private CuoreUI.Controls.cuiButton AddBtn;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn ItemCategory;
        private DataGridViewTextBoxColumn ItemQuantity;
        private DataGridViewTextBoxColumn ItemCondition;
        private DataGridViewTextBoxColumn ItemPrice;
        private DataGridViewImageColumn View;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}
