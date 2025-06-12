namespace ProductAlert
{
    partial class PRODALERT
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
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.panelFilter = new CuoreUI.Controls.cuiPanel();
            this.btnCancel = new CuoreUI.Controls.cuiButton();
            this.btnRequestItem = new CuoreUI.Controls.cuiButton();
            this.flowLayoutPanelTags = new System.Windows.Forms.FlowLayoutPanel();
            this.cuiLabel6 = new CuoreUI.Controls.cuiLabel();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cuiLabel5 = new CuoreUI.Controls.cuiLabel();
            this.btnFilter = new CuoreUI.Controls.cuiButton();
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Messages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            this.cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiButton2 = new CuoreUI.Controls.cuiButton();
            this.cuiButton3 = new CuoreUI.Controls.cuiButton();
            this.cuiButton4 = new CuoreUI.Controls.cuiButton();
            this.cuiButton5 = new CuoreUI.Controls.cuiButton();
            this.cuiButton6 = new CuoreUI.Controls.cuiButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cuiPanel1.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.cuiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.Controls.Add(this.panelFilter);
            this.cuiPanel1.Controls.Add(this.btnFilter);
            this.cuiPanel1.Controls.Add(this.cuiLabel2);
            this.cuiPanel1.Controls.Add(this.cuiPanel2);
            this.cuiPanel1.Controls.Add(this.cuiLabel1);
            this.cuiPanel1.ForeColor = System.Drawing.Color.Black;
            this.cuiPanel1.Location = new System.Drawing.Point(135, 0);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.SkyBlue;
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanel1.Size = new System.Drawing.Size(695, 449);
            this.cuiPanel1.TabIndex = 0;
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.White;
            this.panelFilter.Controls.Add(this.btnCancel);
            this.panelFilter.Controls.Add(this.btnRequestItem);
            this.panelFilter.Controls.Add(this.flowLayoutPanelTags);
            this.panelFilter.Controls.Add(this.cuiLabel6);
            this.panelFilter.Controls.Add(this.cmbSupplier);
            this.panelFilter.Controls.Add(this.cmbCategory);
            this.panelFilter.Controls.Add(this.cuiLabel5);
            this.panelFilter.Location = new System.Drawing.Point(322, 12);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.OutlineThickness = 1F;
            this.panelFilter.PanelColor = System.Drawing.Color.White;
            this.panelFilter.PanelOutlineColor = System.Drawing.Color.White;
            this.panelFilter.Rounding = new System.Windows.Forms.Padding(8);
            this.panelFilter.Size = new System.Drawing.Size(251, 360);
            this.panelFilter.TabIndex = 4;
            this.panelFilter.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.CheckButton = false;
            this.btnCancel.Checked = false;
            this.btnCancel.CheckedBackground = System.Drawing.Color.Transparent;
            this.btnCancel.CheckedForeColor = System.Drawing.Color.White;
            this.btnCancel.CheckedImageTint = System.Drawing.Color.White;
            this.btnCancel.CheckedOutline = System.Drawing.Color.Black;
            this.btnCancel.Content = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.HoverBackground = System.Drawing.Color.White;
            this.btnCancel.HoveredImageTint = System.Drawing.Color.White;
            this.btnCancel.HoverForeColor = System.Drawing.Color.Black;
            this.btnCancel.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.Image = null;
            this.btnCancel.ImageAutoCenter = true;
            this.btnCancel.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnCancel.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnCancel.Location = new System.Drawing.Point(15, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormalBackground = System.Drawing.Color.White;
            this.btnCancel.NormalForeColor = System.Drawing.Color.Black;
            this.btnCancel.NormalImageTint = System.Drawing.Color.White;
            this.btnCancel.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.OutlineThickness = 1F;
            this.btnCancel.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnCancel.PressedImageTint = System.Drawing.Color.White;
            this.btnCancel.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.Rounding = new System.Windows.Forms.Padding(8);
            this.btnCancel.Size = new System.Drawing.Size(102, 22);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnCancel.TextOffset = new System.Drawing.Point(0, 0);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRequestItem
            // 
            this.btnRequestItem.BackColor = System.Drawing.Color.White;
            this.btnRequestItem.CheckButton = false;
            this.btnRequestItem.Checked = false;
            this.btnRequestItem.CheckedBackground = System.Drawing.Color.Transparent;
            this.btnRequestItem.CheckedForeColor = System.Drawing.Color.White;
            this.btnRequestItem.CheckedImageTint = System.Drawing.Color.White;
            this.btnRequestItem.CheckedOutline = System.Drawing.Color.Black;
            this.btnRequestItem.Content = "Request Item";
            this.btnRequestItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRequestItem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRequestItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnRequestItem.ForeColor = System.Drawing.Color.Black;
            this.btnRequestItem.HoverBackground = System.Drawing.Color.White;
            this.btnRequestItem.HoveredImageTint = System.Drawing.Color.White;
            this.btnRequestItem.HoverForeColor = System.Drawing.Color.Black;
            this.btnRequestItem.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRequestItem.Image = null;
            this.btnRequestItem.ImageAutoCenter = true;
            this.btnRequestItem.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnRequestItem.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnRequestItem.Location = new System.Drawing.Point(130, 326);
            this.btnRequestItem.Name = "btnRequestItem";
            this.btnRequestItem.NormalBackground = System.Drawing.Color.White;
            this.btnRequestItem.NormalForeColor = System.Drawing.Color.Black;
            this.btnRequestItem.NormalImageTint = System.Drawing.Color.White;
            this.btnRequestItem.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRequestItem.OutlineThickness = 1F;
            this.btnRequestItem.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.btnRequestItem.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnRequestItem.PressedImageTint = System.Drawing.Color.White;
            this.btnRequestItem.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRequestItem.Rounding = new System.Windows.Forms.Padding(8);
            this.btnRequestItem.Size = new System.Drawing.Size(102, 22);
            this.btnRequestItem.TabIndex = 17;
            this.btnRequestItem.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnRequestItem.TextOffset = new System.Drawing.Point(0, 0);
            this.btnRequestItem.Click += new System.EventHandler(this.btnRequestItem_Click);
            // 
            // flowLayoutPanelTags
            // 
            this.flowLayoutPanelTags.Location = new System.Drawing.Point(15, 78);
            this.flowLayoutPanelTags.Name = "flowLayoutPanelTags";
            this.flowLayoutPanelTags.Size = new System.Drawing.Size(217, 242);
            this.flowLayoutPanelTags.TabIndex = 16;
            // 
            // cuiLabel6
            // 
            this.cuiLabel6.BackColor = System.Drawing.Color.White;
            this.cuiLabel6.Content = "Please\\ select\\ items\\ to\\ proceed";
            this.cuiLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel6.ForeColor = System.Drawing.Color.Black;
            this.cuiLabel6.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel6.Location = new System.Drawing.Point(41, 60);
            this.cuiLabel6.Name = "cuiLabel6";
            this.cuiLabel6.Size = new System.Drawing.Size(175, 12);
            this.cuiLabel6.TabIndex = 15;
            this.cuiLabel6.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(133, 22);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(99, 21);
            this.cmbSupplier.TabIndex = 14;
            this.cmbSupplier.Text = "Select Supplier";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(15, 22);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(102, 21);
            this.cmbCategory.TabIndex = 13;
            this.cmbCategory.Text = "Select Category";
            // 
            // cuiLabel5
            // 
            this.cuiLabel5.BackColor = System.Drawing.Color.White;
            this.cuiLabel5.Content = "Batch\\ Request\\ Items";
            this.cuiLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel5.ForeColor = System.Drawing.Color.Black;
            this.cuiLabel5.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel5.Location = new System.Drawing.Point(0, 3);
            this.cuiLabel5.Name = "cuiLabel5";
            this.cuiLabel5.Size = new System.Drawing.Size(248, 13);
            this.cuiLabel5.TabIndex = 6;
            this.cuiLabel5.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.White;
            this.btnFilter.CheckButton = false;
            this.btnFilter.Checked = false;
            this.btnFilter.CheckedBackground = System.Drawing.Color.Transparent;
            this.btnFilter.CheckedForeColor = System.Drawing.Color.White;
            this.btnFilter.CheckedImageTint = System.Drawing.Color.White;
            this.btnFilter.CheckedOutline = System.Drawing.Color.Black;
            this.btnFilter.Content = "Filter";
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnFilter.ForeColor = System.Drawing.Color.Black;
            this.btnFilter.HoverBackground = System.Drawing.Color.White;
            this.btnFilter.HoveredImageTint = System.Drawing.Color.White;
            this.btnFilter.HoverForeColor = System.Drawing.Color.Black;
            this.btnFilter.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFilter.Image = null;
            this.btnFilter.ImageAutoCenter = true;
            this.btnFilter.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnFilter.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnFilter.Location = new System.Drawing.Point(579, 12);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.NormalBackground = System.Drawing.Color.White;
            this.btnFilter.NormalForeColor = System.Drawing.Color.Black;
            this.btnFilter.NormalImageTint = System.Drawing.Color.White;
            this.btnFilter.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFilter.OutlineThickness = 1F;
            this.btnFilter.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.btnFilter.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnFilter.PressedImageTint = System.Drawing.Color.White;
            this.btnFilter.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFilter.Rounding = new System.Windows.Forms.Padding(8);
            this.btnFilter.Size = new System.Drawing.Size(104, 25);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnFilter.TextOffset = new System.Drawing.Point(0, 0);
            this.btnFilter.Click += new System.EventHandler(this.cuiButton1_Click);
            // 
            // cuiLabel2
            // 
            this.cuiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel2.Content = "view\\ detailed\\ information";
            this.cuiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel2.ForeColor = System.Drawing.Color.Black;
            this.cuiLabel2.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel2.Location = new System.Drawing.Point(6, 23);
            this.cuiLabel2.Name = "cuiLabel2";
            this.cuiLabel2.Size = new System.Drawing.Size(153, 16);
            this.cuiLabel2.TabIndex = 2;
            this.cuiLabel2.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // cuiPanel2
            // 
            this.cuiPanel2.Controls.Add(this.dataGridView1);
            this.cuiPanel2.ForeColor = System.Drawing.Color.Black;
            this.cuiPanel2.Location = new System.Drawing.Point(18, 43);
            this.cuiPanel2.Name = "cuiPanel2";
            this.cuiPanel2.OutlineThickness = 1F;
            this.cuiPanel2.PanelColor = System.Drawing.Color.White;
            this.cuiPanel2.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiPanel2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanel2.Size = new System.Drawing.Size(665, 391);
            this.cuiPanel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Messages,
            this.Date,
            this.Action});
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(659, 385);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Messages
            // 
            this.Messages.HeaderText = "Messages";
            this.Messages.Name = "Messages";
            this.Messages.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel1.Content = "Product\\ Alert";
            this.cuiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.ForeColor = System.Drawing.Color.Black;
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel1.Location = new System.Drawing.Point(3, 3);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(143, 25);
            this.cuiLabel1.TabIndex = 0;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // cuiLabel3
            // 
            this.cuiLabel3.BackColor = System.Drawing.Color.White;
            this.cuiLabel3.Content = "Showing";
            this.cuiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel3.ForeColor = System.Drawing.Color.Black;
            this.cuiLabel3.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel3.Location = new System.Drawing.Point(144, 460);
            this.cuiLabel3.Name = "cuiLabel3";
            this.cuiLabel3.Size = new System.Drawing.Size(81, 16);
            this.cuiLabel3.TabIndex = 3;
            this.cuiLabel3.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // cuiLabel4
            // 
            this.cuiLabel4.BackColor = System.Drawing.Color.White;
            this.cuiLabel4.Content = "Showing\\ 1\\ out\\ of\\ 10\\ records";
            this.cuiLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel4.ForeColor = System.Drawing.Color.Black;
            this.cuiLabel4.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel4.Location = new System.Drawing.Point(430, 460);
            this.cuiLabel4.Name = "cuiLabel4";
            this.cuiLabel4.Size = new System.Drawing.Size(164, 16);
            this.cuiLabel4.TabIndex = 5;
            this.cuiLabel4.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // cuiPictureBox1
            // 
            this.cuiPictureBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.cuiPictureBox1.Content = null;
            this.cuiPictureBox1.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox1.Location = new System.Drawing.Point(29, 23);
            this.cuiPictureBox1.Name = "cuiPictureBox1";
            this.cuiPictureBox1.OutlineThickness = 1F;
            this.cuiPictureBox1.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox1.Rotation = 0;
            this.cuiPictureBox1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox1.Size = new System.Drawing.Size(78, 71);
            this.cuiPictureBox1.TabIndex = 6;
            // 
            // cuiButton2
            // 
            this.cuiButton2.CheckButton = false;
            this.cuiButton2.Checked = false;
            this.cuiButton2.CheckedBackground = System.Drawing.Color.Transparent;
            this.cuiButton2.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton2.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton2.CheckedOutline = System.Drawing.Color.Black;
            this.cuiButton2.Content = "DASHBOARD";
            this.cuiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton2.ForeColor = System.Drawing.Color.Black;
            this.cuiButton2.HoverBackground = System.Drawing.Color.White;
            this.cuiButton2.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton2.HoverForeColor = System.Drawing.Color.Black;
            this.cuiButton2.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton2.Image = null;
            this.cuiButton2.ImageAutoCenter = true;
            this.cuiButton2.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton2.Location = new System.Drawing.Point(12, 118);
            this.cuiButton2.Name = "cuiButton2";
            this.cuiButton2.NormalBackground = System.Drawing.Color.White;
            this.cuiButton2.NormalForeColor = System.Drawing.Color.Black;
            this.cuiButton2.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton2.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton2.OutlineThickness = 1F;
            this.cuiButton2.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton2.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton2.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton2.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton2.Size = new System.Drawing.Size(104, 25);
            this.cuiButton2.TabIndex = 7;
            this.cuiButton2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton2.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // cuiButton3
            // 
            this.cuiButton3.CheckButton = false;
            this.cuiButton3.Checked = false;
            this.cuiButton3.CheckedBackground = System.Drawing.Color.Transparent;
            this.cuiButton3.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton3.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton3.CheckedOutline = System.Drawing.Color.Black;
            this.cuiButton3.Content = "INVENTORY";
            this.cuiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton3.ForeColor = System.Drawing.Color.Black;
            this.cuiButton3.HoverBackground = System.Drawing.Color.White;
            this.cuiButton3.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton3.HoverForeColor = System.Drawing.Color.Black;
            this.cuiButton3.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton3.Image = null;
            this.cuiButton3.ImageAutoCenter = true;
            this.cuiButton3.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton3.Location = new System.Drawing.Point(12, 168);
            this.cuiButton3.Name = "cuiButton3";
            this.cuiButton3.NormalBackground = System.Drawing.Color.White;
            this.cuiButton3.NormalForeColor = System.Drawing.Color.Black;
            this.cuiButton3.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton3.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton3.OutlineThickness = 1F;
            this.cuiButton3.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton3.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton3.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton3.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton3.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton3.Size = new System.Drawing.Size(104, 25);
            this.cuiButton3.TabIndex = 8;
            this.cuiButton3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton3.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // cuiButton4
            // 
            this.cuiButton4.CheckButton = false;
            this.cuiButton4.Checked = false;
            this.cuiButton4.CheckedBackground = System.Drawing.Color.Transparent;
            this.cuiButton4.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton4.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton4.CheckedOutline = System.Drawing.Color.Black;
            this.cuiButton4.Content = "PRODUCT ALERT";
            this.cuiButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiButton4.ForeColor = System.Drawing.Color.Black;
            this.cuiButton4.HoverBackground = System.Drawing.Color.White;
            this.cuiButton4.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton4.HoverForeColor = System.Drawing.Color.Black;
            this.cuiButton4.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton4.Image = null;
            this.cuiButton4.ImageAutoCenter = true;
            this.cuiButton4.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton4.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton4.Location = new System.Drawing.Point(12, 220);
            this.cuiButton4.Name = "cuiButton4";
            this.cuiButton4.NormalBackground = System.Drawing.Color.White;
            this.cuiButton4.NormalForeColor = System.Drawing.Color.Black;
            this.cuiButton4.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton4.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton4.OutlineThickness = 1F;
            this.cuiButton4.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton4.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton4.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton4.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton4.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton4.Size = new System.Drawing.Size(104, 25);
            this.cuiButton4.TabIndex = 9;
            this.cuiButton4.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton4.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // cuiButton5
            // 
            this.cuiButton5.CheckButton = false;
            this.cuiButton5.Checked = false;
            this.cuiButton5.CheckedBackground = System.Drawing.Color.Transparent;
            this.cuiButton5.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton5.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton5.CheckedOutline = System.Drawing.Color.Black;
            this.cuiButton5.Content = "BATCH";
            this.cuiButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton5.ForeColor = System.Drawing.Color.Black;
            this.cuiButton5.HoverBackground = System.Drawing.Color.White;
            this.cuiButton5.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton5.HoverForeColor = System.Drawing.Color.Black;
            this.cuiButton5.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton5.Image = null;
            this.cuiButton5.ImageAutoCenter = true;
            this.cuiButton5.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton5.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton5.Location = new System.Drawing.Point(12, 268);
            this.cuiButton5.Name = "cuiButton5";
            this.cuiButton5.NormalBackground = System.Drawing.Color.White;
            this.cuiButton5.NormalForeColor = System.Drawing.Color.Black;
            this.cuiButton5.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton5.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton5.OutlineThickness = 1F;
            this.cuiButton5.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton5.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton5.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton5.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton5.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton5.Size = new System.Drawing.Size(104, 25);
            this.cuiButton5.TabIndex = 10;
            this.cuiButton5.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton5.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // cuiButton6
            // 
            this.cuiButton6.CheckButton = false;
            this.cuiButton6.Checked = false;
            this.cuiButton6.CheckedBackground = System.Drawing.Color.Transparent;
            this.cuiButton6.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton6.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton6.CheckedOutline = System.Drawing.Color.Black;
            this.cuiButton6.Content = "EMPLOYEES";
            this.cuiButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton6.ForeColor = System.Drawing.Color.Black;
            this.cuiButton6.HoverBackground = System.Drawing.Color.White;
            this.cuiButton6.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton6.HoverForeColor = System.Drawing.Color.Black;
            this.cuiButton6.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton6.Image = null;
            this.cuiButton6.ImageAutoCenter = true;
            this.cuiButton6.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton6.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton6.Location = new System.Drawing.Point(12, 322);
            this.cuiButton6.Name = "cuiButton6";
            this.cuiButton6.NormalBackground = System.Drawing.Color.White;
            this.cuiButton6.NormalForeColor = System.Drawing.Color.Black;
            this.cuiButton6.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton6.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton6.OutlineThickness = 1F;
            this.cuiButton6.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton6.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton6.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton6.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton6.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton6.Size = new System.Drawing.Size(104, 25);
            this.cuiButton6.TabIndex = 11;
            this.cuiButton6.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton6.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(231, 460);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(87, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "\"X\" numbers";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(719, 457);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(99, 21);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.Text = "out of \"X\" items";
            // 
            // PRODALERT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(830, 520);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cuiButton6);
            this.Controls.Add(this.cuiButton5);
            this.Controls.Add(this.cuiButton4);
            this.Controls.Add(this.cuiButton3);
            this.Controls.Add(this.cuiButton2);
            this.Controls.Add(this.cuiPictureBox1);
            this.Controls.Add(this.cuiLabel4);
            this.Controls.Add(this.cuiLabel3);
            this.Controls.Add(this.cuiPanel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "PRODALERT";
            this.Text = "Product Alert";
            this.cuiPanel1.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.cuiPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiButton btnFilter;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiButton cuiButton2;
        private CuoreUI.Controls.cuiButton cuiButton3;
        private CuoreUI.Controls.cuiButton cuiButton4;
        private CuoreUI.Controls.cuiButton cuiButton5;
        private CuoreUI.Controls.cuiButton cuiButton6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Messages;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewComboBoxColumn Action;
        private System.Windows.Forms.ComboBox comboBox2;
        private CuoreUI.Controls.cuiPanel panelFilter;
        private System.Windows.Forms.ComboBox cmbCategory;
        private CuoreUI.Controls.cuiLabel cuiLabel5;
        private CuoreUI.Controls.cuiLabel cuiLabel6;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private CuoreUI.Controls.cuiButton btnRequestItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTags;
        private CuoreUI.Controls.cuiButton btnCancel;
    }
}

