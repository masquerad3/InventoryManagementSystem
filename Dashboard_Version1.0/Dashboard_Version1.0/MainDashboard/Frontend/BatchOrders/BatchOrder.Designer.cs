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
            ProductCheckList = new CheckedListBox();
            DescriptionLabel = new CuoreUI.Controls.cuiLabel();
            OrderDescriptionTextBox = new CuoreUI.Controls.cuiTextBox();
            SaveBtn = new CuoreUI.Controls.cuiButton();
            CancelBtn = new CuoreUI.Controls.cuiButton();
            IsReceivedBtn = new CuoreUI.Controls.cuiButton();
            NotReceivedBtn = new CuoreUI.Controls.cuiButton();
            ProductQuantityLabel = new CuoreUI.Controls.cuiLabel();
            ProductQuantityGridview = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ProductQuantityGridview).BeginInit();
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
            AddEditBatchOrderLabel.Size = new Size(470, 44);
            AddEditBatchOrderLabel.TabIndex = 1;
            AddEditBatchOrderLabel.VerticalAlignment = StringAlignment.Center;
            // 
            // SubLabel
            // 
            SubLabel.BackColor = Color.Transparent;
            SubLabel.Content = "Check\\ the\\ lists\\ of\\ products\\ you'd\\ like\\ to\\ order\\ and\\ update\\ their\\ quantity";
            SubLabel.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubLabel.HorizontalAlignment = StringAlignment.Near;
            SubLabel.Location = new Point(26, 67);
            SubLabel.Margin = new Padding(5, 4, 5, 4);
            SubLabel.Name = "SubLabel";
            SubLabel.Size = new Size(608, 28);
            SubLabel.TabIndex = 34;
            SubLabel.VerticalAlignment = StringAlignment.Center;
            // 
            // BONameLabel
            // 
            BONameLabel.Content = "Batch\\ Order\\ Name\\ :";
            BONameLabel.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BONameLabel.HorizontalAlignment = StringAlignment.Near;
            BONameLabel.Location = new Point(39, 103);
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
            BONameTextBox.Location = new Point(39, 141);
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
            ProductListLabel.Location = new Point(39, 216);
            ProductListLabel.Margin = new Padding(5, 4, 5, 4);
            ProductListLabel.Name = "ProductListLabel";
            ProductListLabel.Size = new Size(150, 44);
            ProductListLabel.TabIndex = 40;
            ProductListLabel.VerticalAlignment = StringAlignment.Center;
            // 
            // ProductCheckList
            // 
            ProductCheckList.FormattingEnabled = true;
            ProductCheckList.Location = new Point(39, 257);
            ProductCheckList.Name = "ProductCheckList";
            ProductCheckList.Size = new Size(150, 114);
            ProductCheckList.TabIndex = 41;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.BackColor = Color.Transparent;
            DescriptionLabel.Content = "Description";
            DescriptionLabel.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DescriptionLabel.HorizontalAlignment = StringAlignment.Near;
            DescriptionLabel.Location = new Point(39, 501);
            DescriptionLabel.Margin = new Padding(5, 4, 5, 4);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(280, 44);
            DescriptionLabel.TabIndex = 42;
            DescriptionLabel.VerticalAlignment = StringAlignment.Center;
            // 
            // OrderDescriptionTextBox
            // 
            OrderDescriptionTextBox.BackgroundColor = Color.White;
            OrderDescriptionTextBox.Content = "";
            OrderDescriptionTextBox.FocusBackgroundColor = Color.White;
            OrderDescriptionTextBox.FocusImageTint = Color.White;
            OrderDescriptionTextBox.FocusOutlineColor = Color.FromArgb(64, 64, 64);
            OrderDescriptionTextBox.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OrderDescriptionTextBox.ForeColor = Color.Gray;
            OrderDescriptionTextBox.Image = null;
            OrderDescriptionTextBox.ImageExpand = new Point(0, 0);
            OrderDescriptionTextBox.ImageOffset = new Point(0, 0);
            OrderDescriptionTextBox.Location = new Point(39, 545);
            OrderDescriptionTextBox.Margin = new Padding(5);
            OrderDescriptionTextBox.Multiline = false;
            OrderDescriptionTextBox.Name = "OrderDescriptionTextBox";
            OrderDescriptionTextBox.NormalImageTint = Color.White;
            OrderDescriptionTextBox.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            OrderDescriptionTextBox.Padding = new Padding(18, 121, 18, 0);
            OrderDescriptionTextBox.PasswordChar = false;
            OrderDescriptionTextBox.PlaceholderColor = SystemColors.WindowText;
            OrderDescriptionTextBox.PlaceholderText = "";
            OrderDescriptionTextBox.Rounding = new Padding(8);
            OrderDescriptionTextBox.Size = new Size(595, 261);
            OrderDescriptionTextBox.TabIndex = 40;
            OrderDescriptionTextBox.TextOffset = new Size(0, 0);
            OrderDescriptionTextBox.UnderlinedStyle = true;
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
            SaveBtn.Location = new Point(366, 839);
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
            SaveBtn.Size = new Size(255, 60);
            SaveBtn.TabIndex = 40;
            SaveBtn.TextAlignment = StringAlignment.Center;
            SaveBtn.TextOffset = new Point(0, 0);
            SaveBtn.Click += SaveBtn_Click;
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
            CancelBtn.Location = new Point(50, 839);
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
            CancelBtn.Size = new Size(269, 60);
            CancelBtn.TabIndex = 40;
            CancelBtn.TextAlignment = StringAlignment.Center;
            CancelBtn.TextOffset = new Point(0, 0);
            CancelBtn.Click += CancelBtn_Click;
            // 
            // IsReceivedBtn
            // 
            IsReceivedBtn.CheckButton = false;
            IsReceivedBtn.Checked = false;
            IsReceivedBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            IsReceivedBtn.CheckedForeColor = Color.White;
            IsReceivedBtn.CheckedImageTint = Color.White;
            IsReceivedBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            IsReceivedBtn.Content = "Received";
            IsReceivedBtn.DialogResult = DialogResult.None;
            IsReceivedBtn.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IsReceivedBtn.ForeColor = Color.White;
            IsReceivedBtn.HoverBackground = Color.FromArgb(49, 93, 130);
            IsReceivedBtn.HoveredImageTint = Color.White;
            IsReceivedBtn.HoverForeColor = Color.WhiteSmoke;
            IsReceivedBtn.HoverOutline = Color.FromArgb(33, 64, 89);
            IsReceivedBtn.Image = Properties.Resources.package_check;
            IsReceivedBtn.ImageAutoCenter = true;
            IsReceivedBtn.ImageExpand = new Point(0, 0);
            IsReceivedBtn.ImageOffset = new Point(-10, 0);
            IsReceivedBtn.Location = new Point(366, 931);
            IsReceivedBtn.Margin = new Padding(3, 4, 3, 4);
            IsReceivedBtn.Name = "IsReceivedBtn";
            IsReceivedBtn.NormalBackground = Color.SteelBlue;
            IsReceivedBtn.NormalForeColor = Color.White;
            IsReceivedBtn.NormalImageTint = Color.White;
            IsReceivedBtn.NormalOutline = Color.Transparent;
            IsReceivedBtn.OutlineThickness = 1F;
            IsReceivedBtn.PressedBackground = Color.FromArgb(49, 93, 130);
            IsReceivedBtn.PressedForeColor = Color.White;
            IsReceivedBtn.PressedImageTint = Color.White;
            IsReceivedBtn.PressedOutline = Color.FromArgb(33, 64, 89);
            IsReceivedBtn.Rounding = new Padding(8);
            IsReceivedBtn.Size = new Size(255, 60);
            IsReceivedBtn.TabIndex = 43;
            IsReceivedBtn.TextAlignment = StringAlignment.Center;
            IsReceivedBtn.TextOffset = new Point(0, 0);
            IsReceivedBtn.Click += IsReceivedBtn_Click;
            // 
            // NotReceivedBtn
            // 
            NotReceivedBtn.BackColor = Color.Transparent;
            NotReceivedBtn.CheckButton = false;
            NotReceivedBtn.Checked = false;
            NotReceivedBtn.CheckedBackground = Color.White;
            NotReceivedBtn.CheckedForeColor = Color.White;
            NotReceivedBtn.CheckedImageTint = Color.White;
            NotReceivedBtn.CheckedOutline = Color.White;
            NotReceivedBtn.Content = "Not Yet Received";
            NotReceivedBtn.DialogResult = DialogResult.None;
            NotReceivedBtn.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NotReceivedBtn.ForeColor = Color.Black;
            NotReceivedBtn.HoverBackground = Color.Transparent;
            NotReceivedBtn.HoveredImageTint = Color.White;
            NotReceivedBtn.HoverForeColor = Color.SteelBlue;
            NotReceivedBtn.HoverOutline = Color.SteelBlue;
            NotReceivedBtn.Image = Properties.Resources.package_x;
            NotReceivedBtn.ImageAutoCenter = true;
            NotReceivedBtn.ImageExpand = new Point(0, 0);
            NotReceivedBtn.ImageOffset = new Point(-10, 0);
            NotReceivedBtn.Location = new Point(50, 931);
            NotReceivedBtn.Margin = new Padding(3, 4, 3, 4);
            NotReceivedBtn.Name = "NotReceivedBtn";
            NotReceivedBtn.NormalBackground = Color.Transparent;
            NotReceivedBtn.NormalForeColor = Color.Black;
            NotReceivedBtn.NormalImageTint = Color.White;
            NotReceivedBtn.NormalOutline = Color.Black;
            NotReceivedBtn.OutlineThickness = 2F;
            NotReceivedBtn.PressedBackground = Color.WhiteSmoke;
            NotReceivedBtn.PressedForeColor = Color.SteelBlue;
            NotReceivedBtn.PressedImageTint = Color.Transparent;
            NotReceivedBtn.PressedOutline = Color.FromArgb(33, 64, 89);
            NotReceivedBtn.Rounding = new Padding(8);
            NotReceivedBtn.Size = new Size(269, 60);
            NotReceivedBtn.TabIndex = 44;
            NotReceivedBtn.TextAlignment = StringAlignment.Center;
            NotReceivedBtn.TextOffset = new Point(0, 0);
            NotReceivedBtn.Click += NotReceivedBtn_Click;
            // 
            // ProductQuantityLabel
            // 
            ProductQuantityLabel.Content = "Input\\ Product\\ Quantity\\ :";
            ProductQuantityLabel.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductQuantityLabel.HorizontalAlignment = StringAlignment.Near;
            ProductQuantityLabel.Location = new Point(212, 216);
            ProductQuantityLabel.Margin = new Padding(5, 4, 5, 4);
            ProductQuantityLabel.Name = "ProductQuantityLabel";
            ProductQuantityLabel.Size = new Size(284, 44);
            ProductQuantityLabel.TabIndex = 46;
            ProductQuantityLabel.VerticalAlignment = StringAlignment.Center;
            // 
            // ProductQuantityGridview
            // 
            ProductQuantityGridview.AllowUserToAddRows = false;
            ProductQuantityGridview.AllowUserToDeleteRows = false;
            ProductQuantityGridview.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ProductQuantityGridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductQuantityGridview.BackgroundColor = Color.White;
            ProductQuantityGridview.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            ProductQuantityGridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductQuantityGridview.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            ProductQuantityGridview.ImeMode = ImeMode.Off;
            ProductQuantityGridview.Location = new Point(212, 257);
            ProductQuantityGridview.Name = "ProductQuantityGridview";
            ProductQuantityGridview.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ProductQuantityGridview.RowHeadersVisible = false;
            ProductQuantityGridview.RowHeadersWidth = 51;
            ProductQuantityGridview.Size = new Size(422, 231);
            ProductQuantityGridview.TabIndex = 47;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Product";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // BatchOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(686, 1041);
            Controls.Add(ProductQuantityGridview);
            Controls.Add(ProductQuantityLabel);
            Controls.Add(NotReceivedBtn);
            Controls.Add(IsReceivedBtn);
            Controls.Add(CancelBtn);
            Controls.Add(SaveBtn);
            Controls.Add(OrderDescriptionTextBox);
            Controls.Add(DescriptionLabel);
            Controls.Add(ProductCheckList);
            Controls.Add(ProductListLabel);
            Controls.Add(BONameTextBox);
            Controls.Add(BONameLabel);
            Controls.Add(SubLabel);
            Controls.Add(AddEditBatchOrderLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "BatchOrder";
            Text = "Batch Orders";
            ((System.ComponentModel.ISupportInitialize)ProductQuantityGridview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiLabel AddEditBatchOrderLabel;
        private CuoreUI.Controls.cuiLabel SubLabel;
        private CuoreUI.Controls.cuiLabel BONameLabel;
        private CuoreUI.Controls.cuiTextBox BONameTextBox;
        private CuoreUI.Controls.cuiLabel ProductListLabel;
        private CheckedListBox ProductCheckList;
        private CuoreUI.Controls.cuiLabel DescriptionLabel;
        private CuoreUI.Controls.cuiTextBox OrderDescriptionTextBox;
        private CuoreUI.Controls.cuiButton SaveBtn;
        private CuoreUI.Controls.cuiButton CancelBtn;
        private CuoreUI.Controls.cuiButton IsReceivedBtn;
        private CuoreUI.Controls.cuiButton NotReceivedBtn;
        private CuoreUI.Controls.cuiLabel ProductQuantityLabel;
        private DataGridView ProductQuantityGridview;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}