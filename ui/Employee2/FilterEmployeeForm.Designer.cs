namespace EmployeeDragDrop
{
    partial class FilterEmployeeForm
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
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            chkMaterial = new CheckBox();
            chkStock = new CheckBox();
            chkQC = new CheckBox();
            cmbStatus = new ComboBox();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            BtnApplyFilter = new CuoreUI.Controls.cuiButton();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            cuiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // cuiPanel1
            // 
            cuiPanel1.Controls.Add(chkMaterial);
            cuiPanel1.Controls.Add(chkStock);
            cuiPanel1.Controls.Add(chkQC);
            cuiPanel1.Controls.Add(cmbStatus);
            cuiPanel1.Controls.Add(cuiButton1);
            cuiPanel1.Controls.Add(BtnApplyFilter);
            cuiPanel1.Controls.Add(label2);
            cuiPanel1.Controls.Add(label3);
            cuiPanel1.Controls.Add(label1);
            cuiPanel1.Location = new Point(162, 60);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.SkyBlue;
            cuiPanel1.PanelOutlineColor = Color.SteelBlue;
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(292, 295);
            cuiPanel1.TabIndex = 1;
            // 
            // chkMaterial
            // 
            chkMaterial.AutoSize = true;
            chkMaterial.BackColor = Color.Transparent;
            chkMaterial.Font = new Font("Segoe UI", 9F);
            chkMaterial.Location = new Point(22, 195);
            chkMaterial.Name = "chkMaterial";
            chkMaterial.Size = new Size(140, 19);
            chkMaterial.TabIndex = 13;
            chkMaterial.Text = "Material Handle Clerk";
            chkMaterial.UseVisualStyleBackColor = false;
            // 
            // chkStock
            // 
            chkStock.AutoSize = true;
            chkStock.BackColor = Color.Transparent;
            chkStock.Location = new Point(22, 170);
            chkStock.Name = "chkStock";
            chkStock.Size = new Size(85, 19);
            chkStock.TabIndex = 12;
            chkStock.Text = "Stock Clerk";
            chkStock.UseVisualStyleBackColor = false;
            // 
            // chkQC
            // 
            chkQC.AutoSize = true;
            chkQC.BackColor = Color.Transparent;
            chkQC.Location = new Point(22, 145);
            chkQC.Name = "chkQC";
            chkQC.Size = new Size(159, 19);
            chkQC.TabIndex = 11;
            chkQC.Text = "Quality Control Inspector";
            chkQC.UseVisualStyleBackColor = false;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(16, 80);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(177, 23);
            cmbStatus.TabIndex = 10;
            // 
            // cuiButton1
            // 
            cuiButton1.BackColor = Color.Transparent;
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton1.CheckedForeColor = Color.White;
            cuiButton1.CheckedImageTint = Color.White;
            cuiButton1.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton1.Content = "Cancel";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButton1.ForeColor = Color.Black;
            cuiButton1.HoverBackground = Color.White;
            cuiButton1.HoveredImageTint = Color.White;
            cuiButton1.HoverForeColor = Color.Black;
            cuiButton1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton1.Image = null;
            cuiButton1.ImageAutoCenter = true;
            cuiButton1.ImageExpand = new Point(0, 0);
            cuiButton1.ImageOffset = new Point(0, 0);
            cuiButton1.Location = new Point(16, 235);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.White;
            cuiButton1.NormalForeColor = Color.Black;
            cuiButton1.NormalImageTint = Color.White;
            cuiButton1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.OutlineThickness = 1F;
            cuiButton1.PressedBackground = Color.WhiteSmoke;
            cuiButton1.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedImageTint = Color.White;
            cuiButton1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.Rounding = new Padding(8);
            cuiButton1.Size = new Size(127, 35);
            cuiButton1.TabIndex = 9;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextOffset = new Point(0, 0);
            // 
            // BtnApplyFilter
            // 
            BtnApplyFilter.BackColor = Color.Transparent;
            BtnApplyFilter.CheckButton = false;
            BtnApplyFilter.Checked = false;
            BtnApplyFilter.CheckedBackground = Color.FromArgb(255, 106, 0);
            BtnApplyFilter.CheckedForeColor = Color.White;
            BtnApplyFilter.CheckedImageTint = Color.White;
            BtnApplyFilter.CheckedOutline = Color.FromArgb(255, 106, 0);
            BtnApplyFilter.Content = "Apply";
            BtnApplyFilter.DialogResult = DialogResult.None;
            BtnApplyFilter.Font = new Font("Microsoft Sans Serif", 9.75F);
            BtnApplyFilter.ForeColor = Color.Black;
            BtnApplyFilter.HoverBackground = Color.White;
            BtnApplyFilter.HoveredImageTint = Color.White;
            BtnApplyFilter.HoverForeColor = Color.Black;
            BtnApplyFilter.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            BtnApplyFilter.Image = null;
            BtnApplyFilter.ImageAutoCenter = true;
            BtnApplyFilter.ImageExpand = new Point(0, 0);
            BtnApplyFilter.ImageOffset = new Point(0, 0);
            BtnApplyFilter.Location = new Point(149, 235);
            BtnApplyFilter.Name = "BtnApplyFilter";
            BtnApplyFilter.NormalBackground = Color.ForestGreen;
            BtnApplyFilter.NormalForeColor = Color.Black;
            BtnApplyFilter.NormalImageTint = Color.White;
            BtnApplyFilter.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            BtnApplyFilter.OutlineThickness = 1F;
            BtnApplyFilter.PressedBackground = Color.WhiteSmoke;
            BtnApplyFilter.PressedForeColor = Color.FromArgb(32, 32, 32);
            BtnApplyFilter.PressedImageTint = Color.White;
            BtnApplyFilter.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            BtnApplyFilter.Rounding = new Padding(8);
            BtnApplyFilter.Size = new Size(127, 35);
            BtnApplyFilter.TabIndex = 8;
            BtnApplyFilter.TextAlignment = StringAlignment.Center;
            BtnApplyFilter.TextOffset = new Point(0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 121);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 3;
            label2.Text = "Position";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 56);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 2;
            label3.Text = "Status";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 0;
            label1.Text = "Filter";
            // 
            // FilterEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 478);
            Controls.Add(cuiPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FilterEmployeeForm";
            Text = "FilterEmployee";
            Load += FilterEmployeeForm_Load;
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiButton BtnApplyFilter;
        private Label label2;
        private Label label3;
        private Label label1;
        private CheckBox chkQC;
        private ComboBox cmbStatus;
        private CheckBox chkMaterial;
        private CheckBox chkStock;
    }
}