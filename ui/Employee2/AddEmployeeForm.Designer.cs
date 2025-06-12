namespace EmployeeDragDrop
{
    partial class AddEmployeeForm
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
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            cmbPosition = new ComboBox();
            BtnSave = new CuoreUI.Controls.cuiButton();
            label4 = new Label();
            txtEmployeeID = new CuoreUI.Controls.cuiTextBox();
            txtEmployeeName = new CuoreUI.Controls.cuiTextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            cuiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // cuiPanel1
            // 
            cuiPanel1.Controls.Add(cuiButton1);
            cuiPanel1.Controls.Add(cmbPosition);
            cuiPanel1.Controls.Add(BtnSave);
            cuiPanel1.Controls.Add(label4);
            cuiPanel1.Controls.Add(txtEmployeeID);
            cuiPanel1.Controls.Add(txtEmployeeName);
            cuiPanel1.Controls.Add(label2);
            cuiPanel1.Controls.Add(label3);
            cuiPanel1.Controls.Add(label1);
            cuiPanel1.Location = new Point(158, 36);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.SkyBlue;
            cuiPanel1.PanelOutlineColor = Color.SteelBlue;
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(292, 342);
            cuiPanel1.TabIndex = 0;
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
            cuiButton1.Location = new Point(14, 283);
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
            // cmbPosition
            // 
            cmbPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Items.AddRange(new object[] { "Quality Control Inspector", "Stock Clerk", "Material Handler" });
            cmbPosition.Location = new Point(19, 226);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(185, 23);
            cmbPosition.TabIndex = 1;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.Transparent;
            BtnSave.CheckButton = false;
            BtnSave.Checked = false;
            BtnSave.CheckedBackground = Color.FromArgb(255, 106, 0);
            BtnSave.CheckedForeColor = Color.White;
            BtnSave.CheckedImageTint = Color.White;
            BtnSave.CheckedOutline = Color.FromArgb(255, 106, 0);
            BtnSave.Content = "Save";
            BtnSave.DialogResult = DialogResult.None;
            BtnSave.Font = new Font("Microsoft Sans Serif", 9.75F);
            BtnSave.ForeColor = Color.Black;
            BtnSave.HoverBackground = Color.White;
            BtnSave.HoveredImageTint = Color.White;
            BtnSave.HoverForeColor = Color.Black;
            BtnSave.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            BtnSave.Image = null;
            BtnSave.ImageAutoCenter = true;
            BtnSave.ImageExpand = new Point(0, 0);
            BtnSave.ImageOffset = new Point(0, 0);
            BtnSave.Location = new Point(147, 283);
            BtnSave.Name = "BtnSave";
            BtnSave.NormalBackground = Color.Green;
            BtnSave.NormalForeColor = Color.Black;
            BtnSave.NormalImageTint = Color.White;
            BtnSave.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            BtnSave.OutlineThickness = 1F;
            BtnSave.PressedBackground = Color.WhiteSmoke;
            BtnSave.PressedForeColor = Color.FromArgb(32, 32, 32);
            BtnSave.PressedImageTint = Color.White;
            BtnSave.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            BtnSave.Rounding = new Padding(8);
            BtnSave.Size = new Size(127, 35);
            BtnSave.TabIndex = 8;
            BtnSave.TextAlignment = StringAlignment.Center;
            BtnSave.TextOffset = new Point(0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 202);
            label4.Name = "label4";
            label4.Size = new Size(65, 21);
            label4.TabIndex = 6;
            label4.Text = "Position";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.BackColor = Color.Transparent;
            txtEmployeeID.BackgroundColor = Color.White;
            txtEmployeeID.BorderColor = Color.FromArgb(128, 128, 128, 128);
            txtEmployeeID.Content = "";
            txtEmployeeID.FocusBackgroundColor = Color.White;
            txtEmployeeID.FocusBorderColor = Color.FromArgb(255, 106, 0);
            txtEmployeeID.FocusImageTint = Color.White;
            txtEmployeeID.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmployeeID.ForeColor = Color.Gray;
            txtEmployeeID.Image = null;
            txtEmployeeID.ImageExpand = new Point(0, 0);
            txtEmployeeID.ImageOffset = new Point(0, 0);
            txtEmployeeID.Location = new Point(14, 160);
            txtEmployeeID.Margin = new Padding(4);
            txtEmployeeID.Multiline = false;
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.NormalImageTint = Color.White;
            txtEmployeeID.Padding = new Padding(15, 4, 15, 0);
            txtEmployeeID.PasswordChar = false;
            txtEmployeeID.PlaceholderColor = SystemColors.WindowText;
            txtEmployeeID.PlaceholderText = "";
            txtEmployeeID.Rounding = new Padding(8);
            txtEmployeeID.Size = new Size(190, 23);
            txtEmployeeID.TabIndex = 5;
            txtEmployeeID.TextOffset = new Size(0, 0);
            txtEmployeeID.UnderlinedStyle = true;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.BackColor = Color.Transparent;
            txtEmployeeName.BackgroundColor = Color.White;
            txtEmployeeName.BorderColor = Color.FromArgb(128, 128, 128, 128);
            txtEmployeeName.Content = "";
            txtEmployeeName.FocusBackgroundColor = Color.White;
            txtEmployeeName.FocusBorderColor = Color.FromArgb(255, 106, 0);
            txtEmployeeName.FocusImageTint = Color.White;
            txtEmployeeName.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmployeeName.ForeColor = Color.Gray;
            txtEmployeeName.Image = null;
            txtEmployeeName.ImageExpand = new Point(0, 0);
            txtEmployeeName.ImageOffset = new Point(0, 0);
            txtEmployeeName.Location = new Point(14, 97);
            txtEmployeeName.Margin = new Padding(4);
            txtEmployeeName.Multiline = false;
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.NormalImageTint = Color.White;
            txtEmployeeName.Padding = new Padding(15, 4, 15, 0);
            txtEmployeeName.PasswordChar = false;
            txtEmployeeName.PlaceholderColor = SystemColors.WindowText;
            txtEmployeeName.PlaceholderText = "";
            txtEmployeeName.Rounding = new Padding(8);
            txtEmployeeName.Size = new Size(190, 23);
            txtEmployeeName.TabIndex = 4;
            txtEmployeeName.TextOffset = new Size(0, 0);
            txtEmployeeName.UnderlinedStyle = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 135);
            label2.Name = "label2";
            label2.Size = new Size(97, 21);
            label2.TabIndex = 3;
            label2.Text = "Employee ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 72);
            label3.Name = "label3";
            label3.Size = new Size(124, 21);
            label3.TabIndex = 2;
            label3.Text = "Employee Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 0;
            label1.Text = "Add Employee";
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 482);
            ControlBox = false;
            Controls.Add(cuiPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddEmployeeForm";
            Text = "AddEmployeeForm";
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private Label label1;
        private CuoreUI.Controls.cuiTextBox txtEmployeeID;
        private CuoreUI.Controls.cuiTextBox txtEmployeeName;
        private Label label2;
        private Label label3;
        private CuoreUI.Controls.cuiButton BtnSave;
        private Label label4;
        private ComboBox cmbPosition;
        private CuoreUI.Controls.cuiButton cuiButton1;
    }
}