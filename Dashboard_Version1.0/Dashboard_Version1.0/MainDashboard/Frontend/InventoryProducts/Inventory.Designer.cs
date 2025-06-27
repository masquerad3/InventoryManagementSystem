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
            InventoryGridView = new DataGridView();
            ProductName = new DataGridViewTextBoxColumn();
            ItemCategory = new DataGridViewTextBoxColumn();
            ItemQuantity = new DataGridViewTextBoxColumn();
            ItemCondition = new DataGridViewTextBoxColumn();
            ItemPrice = new DataGridViewTextBoxColumn();
            View = new DataGridViewImageColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            cuiPanel6 = new CuoreUI.Controls.cuiPanel();
            InventoryHeader = new CuoreUI.Controls.cuiLabel();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            AddBtn = new CuoreUI.Controls.cuiButton();
            ((System.ComponentModel.ISupportInitialize)InventoryGridView).BeginInit();
            cuiPanel6.SuspendLayout();
            cuiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // InventoryGridView
            // 
            InventoryGridView.AllowUserToAddRows = false;
            InventoryGridView.AllowUserToDeleteRows = false;
            InventoryGridView.AllowUserToOrderColumns = true;
            InventoryGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            InventoryGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            InventoryGridView.BackgroundColor = SystemColors.ControlLight;
            InventoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InventoryGridView.Columns.AddRange(new DataGridViewColumn[] { ProductName, ItemCategory, ItemQuantity, ItemCondition, ItemPrice, View, Edit, Delete });
            InventoryGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            InventoryGridView.Location = new Point(28, 24);
            InventoryGridView.Margin = new Padding(3, 4, 3, 4);
            InventoryGridView.Name = "InventoryGridView";
            InventoryGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            InventoryGridView.RowHeadersVisible = false;
            InventoryGridView.RowHeadersWidth = 51;
            InventoryGridView.RowTemplate.Height = 30;
            InventoryGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            InventoryGridView.Size = new Size(1086, 980);
            InventoryGridView.TabIndex = 29;
            InventoryGridView.CellContentClick += InventoryGridView_CellContentClick;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Product Name";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = resources.GetObject("dataGridViewCellStyle1.NullValue");
            View.DefaultCellStyle = dataGridViewCellStyle1;
            View.Description = "View";
            View.HeaderText = "View";
            View.Image = Properties.Resources.eye1;
            View.MinimumWidth = 6;
            View.Name = "View";
            View.Resizable = DataGridViewTriState.False;
            // 
            // Edit
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = resources.GetObject("dataGridViewCellStyle2.NullValue");
            Edit.DefaultCellStyle = dataGridViewCellStyle2;
            Edit.Description = "Edit";
            Edit.HeaderText = "Edit";
            Edit.Image = Properties.Resources.pencil1;
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.False;
            // 
            // Delete
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = resources.GetObject("dataGridViewCellStyle3.NullValue");
            Delete.DefaultCellStyle = dataGridViewCellStyle3;
            Delete.Description = "Delete";
            Delete.HeaderText = "Delete";
            Delete.Image = Properties.Resources.trash_21;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Resizable = DataGridViewTriState.False;
            // 
            // cuiPanel6
            // 
            cuiPanel6.Controls.Add(AddBtn);
            cuiPanel6.Controls.Add(InventoryHeader);
            cuiPanel6.Dock = DockStyle.Top;
            cuiPanel6.Location = new Point(0, 0);
            cuiPanel6.Margin = new Padding(3, 4, 3, 4);
            cuiPanel6.Name = "cuiPanel6";
            cuiPanel6.OutlineThickness = 1F;
            cuiPanel6.PanelColor = Color.AliceBlue;
            cuiPanel6.PanelOutlineColor = Color.Transparent;
            cuiPanel6.Rounding = new Padding(8);
            cuiPanel6.Size = new Size(1211, 81);
            cuiPanel6.TabIndex = 9;
            // 
            // InventoryHeader
            // 
            InventoryHeader.BackColor = Color.Transparent;
            InventoryHeader.Content = "Inventory";
            InventoryHeader.Font = new Font("Leelawadee UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InventoryHeader.HorizontalAlignment = StringAlignment.Near;
            InventoryHeader.Location = new Point(25, 4);
            InventoryHeader.Margin = new Padding(5, 4, 5, 4);
            InventoryHeader.Name = "InventoryHeader";
            InventoryHeader.Size = new Size(280, 72);
            InventoryHeader.TabIndex = 1;
            InventoryHeader.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiPanel1
            // 
            cuiPanel1.Controls.Add(InventoryGridView);
            cuiPanel1.Location = new Point(28, 133);
            cuiPanel1.Margin = new Padding(3, 4, 3, 4);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.FromArgb(224, 224, 224);
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(1143, 1200);
            cuiPanel1.TabIndex = 10;
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
            AddBtn.Location = new Point(967, 4);
            AddBtn.Margin = new Padding(3, 4, 3, 4);
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
            AddBtn.Size = new Size(175, 60);
            AddBtn.TabIndex = 14;
            AddBtn.TextAlignment = StringAlignment.Center;
            AddBtn.TextOffset = new Point(0, 0);
            AddBtn.Click += AddBtn_Click;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.AliceBlue;
            Controls.Add(cuiPanel1);
            Controls.Add(cuiPanel6);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Inventory";
            Size = new Size(1211, 1467);
            ((System.ComponentModel.ISupportInitialize)InventoryGridView).EndInit();
            cuiPanel6.ResumeLayout(false);
            cuiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel6;
        private CuoreUI.Controls.cuiLabel InventoryHeader;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private DataGridView InventoryGridView;
        private CuoreUI.Controls.cuiButton AddBtn;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ItemCategory;
        private DataGridViewTextBoxColumn ItemQuantity;
        private DataGridViewTextBoxColumn ItemCondition;
        private DataGridViewTextBoxColumn ItemPrice;
        private DataGridViewImageColumn View;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}
