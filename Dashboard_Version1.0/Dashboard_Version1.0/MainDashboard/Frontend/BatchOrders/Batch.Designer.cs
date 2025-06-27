namespace MainDashboard
{
    partial class Batch
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
            BatchOrdersGridView = new DataGridView();
            BatchOrderName = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            BatchOrderStatus = new DataGridViewTextBoxColumn();
            DateRequested = new DataGridViewTextBoxColumn();
            DateReceived = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            cuiPanel6 = new CuoreUI.Controls.cuiPanel();
            DashboardHeader = new CuoreUI.Controls.cuiLabel();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            AddBtn = new CuoreUI.Controls.cuiButton();
            ((System.ComponentModel.ISupportInitialize)BatchOrdersGridView).BeginInit();
            cuiPanel6.SuspendLayout();
            cuiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // BatchOrdersGridView
            // 
            BatchOrdersGridView.AllowUserToAddRows = false;
            BatchOrdersGridView.AllowUserToDeleteRows = false;
            BatchOrdersGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BatchOrdersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BatchOrdersGridView.BackgroundColor = SystemColors.ControlLight;
            BatchOrdersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BatchOrdersGridView.Columns.AddRange(new DataGridViewColumn[] { BatchOrderName, ProductName, BatchOrderStatus, DateRequested, DateReceived, Edit, Delete });
            BatchOrdersGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            BatchOrdersGridView.Location = new Point(30, 18);
            BatchOrdersGridView.Margin = new Padding(3, 4, 3, 4);
            BatchOrdersGridView.Name = "BatchOrdersGridView";
            BatchOrdersGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            BatchOrdersGridView.RowHeadersVisible = false;
            BatchOrdersGridView.RowHeadersWidth = 51;
            BatchOrdersGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BatchOrdersGridView.Size = new Size(1086, 980);
            BatchOrdersGridView.TabIndex = 0;
            BatchOrdersGridView.CellContentClick += BatchOrdersGridView_CellContentClick;
            // 
            // BatchOrderName
            // 
            BatchOrderName.HeaderText = "Batch Name";
            BatchOrderName.MinimumWidth = 6;
            BatchOrderName.Name = "BatchOrderName";
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Product Name";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            // 
            // BatchOrderStatus
            // 
            BatchOrderStatus.HeaderText = "Order Status";
            BatchOrderStatus.MinimumWidth = 6;
            BatchOrderStatus.Name = "BatchOrderStatus";
            // 
            // DateRequested
            // 
            DateRequested.HeaderText = "Date Requested";
            DateRequested.MinimumWidth = 6;
            DateRequested.Name = "DateRequested";
            // 
            // DateReceived
            // 
            DateReceived.HeaderText = "Date Received";
            DateReceived.MinimumWidth = 6;
            DateReceived.Name = "DateReceived";
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.Image = Properties.Resources.pencil1;
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Image = Properties.Resources.trash_21;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            // 
            // cuiPanel6
            // 
            cuiPanel6.Controls.Add(DashboardHeader);
            cuiPanel6.Controls.Add(AddBtn);
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
            // DashboardHeader
            // 
            DashboardHeader.BackColor = Color.Transparent;
            DashboardHeader.Content = "Batch\\ Orders";
            DashboardHeader.Font = new Font("Leelawadee UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardHeader.HorizontalAlignment = StringAlignment.Near;
            DashboardHeader.Location = new Point(25, 4);
            DashboardHeader.Margin = new Padding(5, 4, 5, 4);
            DashboardHeader.Name = "DashboardHeader";
            DashboardHeader.Size = new Size(280, 72);
            DashboardHeader.TabIndex = 1;
            DashboardHeader.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiPanel1
            // 
            cuiPanel1.Controls.Add(cuiLabel1);
            cuiPanel1.Controls.Add(BatchOrdersGridView);
            cuiPanel1.Location = new Point(34, 133);
            cuiPanel1.Margin = new Padding(3, 4, 3, 4);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.FromArgb(224, 224, 224);
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(1143, 1200);
            cuiPanel1.TabIndex = 11;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = "Showing";
            cuiLabel1.Font = new Font("Leelawadee UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel1.HorizontalAlignment = StringAlignment.Near;
            cuiLabel1.Location = new Point(42, 1115);
            cuiLabel1.Margin = new Padding(5, 4, 5, 4);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(65, 32);
            cuiLabel1.TabIndex = 16;
            cuiLabel1.VerticalAlignment = StringAlignment.Center;
            // 
            // AddBtn
            // 
            AddBtn.AutoScroll = true;
            AddBtn.BackColor = Color.Transparent;
            AddBtn.CheckButton = false;
            AddBtn.Checked = false;
            AddBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            AddBtn.CheckedForeColor = Color.White;
            AddBtn.CheckedImageTint = Color.White;
            AddBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            AddBtn.Content = "Add Batch";
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
            AddBtn.ImageOffset = new Point(-12, 0);
            AddBtn.Location = new Point(1002, 4);
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
            // Batch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.AliceBlue;
            Controls.Add(cuiPanel1);
            Controls.Add(cuiPanel6);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Batch";
            Size = new Size(1211, 1467);
            ((System.ComponentModel.ISupportInitialize)BatchOrdersGridView).EndInit();
            cuiPanel6.ResumeLayout(false);
            cuiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel6;
        private CuoreUI.Controls.cuiLabel DashboardHeader;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiButton AddBtn;
        private DataGridView BatchOrdersGridView;
        private DataGridViewTextBoxColumn BatchOrderName;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn BatchOrderStatus;
        private DataGridViewTextBoxColumn DateRequested;
        private DataGridViewTextBoxColumn DateReceived;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}
