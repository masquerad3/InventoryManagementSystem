namespace MainDashboard.Frontend
{
    partial class DeletionTemplate
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
            components = new System.ComponentModel.Container();
            DeleteHeaderLabel = new CuoreUI.Controls.cuiLabel();
            DeleteSubHeaderLabel = new CuoreUI.Controls.cuiLabel();
            imageList1 = new ImageList(components);
            VariableIDLabel = new CuoreUI.Controls.cuiLabel();
            VariableNameLabel = new CuoreUI.Controls.cuiLabel();
            VariableIDContentHolder = new CuoreUI.Controls.cuiLabel();
            VariableNameContentHolder = new CuoreUI.Controls.cuiLabel();
            CancelBtn = new CuoreUI.Controls.cuiButton();
            ConfirmBtn = new CuoreUI.Controls.cuiButton();
            SuspendLayout();
            // 
            // DeleteHeaderLabel
            // 
            DeleteHeaderLabel.Content = "Delete\\ <variable>";
            DeleteHeaderLabel.Font = new Font("Leelawadee UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteHeaderLabel.HorizontalAlignment = StringAlignment.Near;
            DeleteHeaderLabel.Location = new Point(24, 25);
            DeleteHeaderLabel.Margin = new Padding(5, 4, 5, 4);
            DeleteHeaderLabel.Name = "DeleteHeaderLabel";
            DeleteHeaderLabel.Size = new Size(517, 44);
            DeleteHeaderLabel.TabIndex = 2;
            DeleteHeaderLabel.VerticalAlignment = StringAlignment.Center;
            // 
            // DeleteSubHeaderLabel
            // 
            DeleteSubHeaderLabel.BackColor = Color.Transparent;
            DeleteSubHeaderLabel.Content = "Click\\ Confirm\\ to\\ proceed\\ with\\ deletion";
            DeleteSubHeaderLabel.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteSubHeaderLabel.HorizontalAlignment = StringAlignment.Near;
            DeleteSubHeaderLabel.Location = new Point(24, 67);
            DeleteSubHeaderLabel.Margin = new Padding(5, 4, 5, 4);
            DeleteSubHeaderLabel.Name = "DeleteSubHeaderLabel";
            DeleteSubHeaderLabel.Size = new Size(517, 28);
            DeleteSubHeaderLabel.TabIndex = 45;
            DeleteSubHeaderLabel.VerticalAlignment = StringAlignment.Center;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // VariableIDLabel
            // 
            VariableIDLabel.Content = "Variable\\ ID\\ :";
            VariableIDLabel.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VariableIDLabel.HorizontalAlignment = StringAlignment.Near;
            VariableIDLabel.Location = new Point(24, 131);
            VariableIDLabel.Margin = new Padding(5, 4, 5, 4);
            VariableIDLabel.Name = "VariableIDLabel";
            VariableIDLabel.Size = new Size(209, 44);
            VariableIDLabel.TabIndex = 46;
            VariableIDLabel.VerticalAlignment = StringAlignment.Center;
            // 
            // VariableNameLabel
            // 
            VariableNameLabel.Content = "Variable\\ Name\\ :";
            VariableNameLabel.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VariableNameLabel.HorizontalAlignment = StringAlignment.Near;
            VariableNameLabel.Location = new Point(24, 193);
            VariableNameLabel.Margin = new Padding(5, 4, 5, 4);
            VariableNameLabel.Name = "VariableNameLabel";
            VariableNameLabel.Size = new Size(209, 44);
            VariableNameLabel.TabIndex = 47;
            VariableNameLabel.VerticalAlignment = StringAlignment.Center;
            // 
            // VariableIDContentHolder
            // 
            VariableIDContentHolder.Content = "<VARIABLE\\ ID>";
            VariableIDContentHolder.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VariableIDContentHolder.HorizontalAlignment = StringAlignment.Near;
            VariableIDContentHolder.Location = new Point(198, 131);
            VariableIDContentHolder.Margin = new Padding(5, 4, 5, 4);
            VariableIDContentHolder.Name = "VariableIDContentHolder";
            VariableIDContentHolder.Size = new Size(343, 44);
            VariableIDContentHolder.TabIndex = 48;
            VariableIDContentHolder.VerticalAlignment = StringAlignment.Center;
            // 
            // VariableNameContentHolder
            // 
            VariableNameContentHolder.Content = "<VARIABLE\\ NAME>";
            VariableNameContentHolder.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VariableNameContentHolder.HorizontalAlignment = StringAlignment.Near;
            VariableNameContentHolder.Location = new Point(198, 193);
            VariableNameContentHolder.Margin = new Padding(5, 4, 5, 4);
            VariableNameContentHolder.Name = "VariableNameContentHolder";
            VariableNameContentHolder.Size = new Size(343, 44);
            VariableNameContentHolder.TabIndex = 49;
            VariableNameContentHolder.VerticalAlignment = StringAlignment.Center;
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
            CancelBtn.Location = new Point(58, 279);
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
            CancelBtn.TabIndex = 50;
            CancelBtn.TextAlignment = StringAlignment.Center;
            CancelBtn.TextOffset = new Point(0, 0);
            CancelBtn.Click += CancelBtn_Click;
            // 
            // ConfirmBtn
            // 
            ConfirmBtn.CheckButton = false;
            ConfirmBtn.Checked = false;
            ConfirmBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            ConfirmBtn.CheckedForeColor = Color.White;
            ConfirmBtn.CheckedImageTint = Color.White;
            ConfirmBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            ConfirmBtn.Content = "Confirm";
            ConfirmBtn.DialogResult = DialogResult.None;
            ConfirmBtn.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConfirmBtn.ForeColor = Color.White;
            ConfirmBtn.HoverBackground = Color.FromArgb(49, 93, 130);
            ConfirmBtn.HoveredImageTint = Color.White;
            ConfirmBtn.HoverForeColor = Color.WhiteSmoke;
            ConfirmBtn.HoverOutline = Color.FromArgb(33, 64, 89);
            ConfirmBtn.Image = Properties.Resources.trash_2;
            ConfirmBtn.ImageAutoCenter = true;
            ConfirmBtn.ImageExpand = new Point(0, 0);
            ConfirmBtn.ImageOffset = new Point(-10, 0);
            ConfirmBtn.Location = new Point(275, 279);
            ConfirmBtn.Margin = new Padding(3, 4, 3, 4);
            ConfirmBtn.Name = "ConfirmBtn";
            ConfirmBtn.NormalBackground = Color.SteelBlue;
            ConfirmBtn.NormalForeColor = Color.White;
            ConfirmBtn.NormalImageTint = Color.White;
            ConfirmBtn.NormalOutline = Color.Transparent;
            ConfirmBtn.OutlineThickness = 1F;
            ConfirmBtn.PressedBackground = Color.FromArgb(49, 93, 130);
            ConfirmBtn.PressedForeColor = Color.White;
            ConfirmBtn.PressedImageTint = Color.White;
            ConfirmBtn.PressedOutline = Color.FromArgb(33, 64, 89);
            ConfirmBtn.Rounding = new Padding(8);
            ConfirmBtn.Size = new Size(175, 60);
            ConfirmBtn.TabIndex = 51;
            ConfirmBtn.TextAlignment = StringAlignment.Center;
            ConfirmBtn.TextOffset = new Point(0, 0);
            ConfirmBtn.Click += ConfirmBtn_Click;
            // 
            // DeletionTemplate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(572, 381);
            Controls.Add(ConfirmBtn);
            Controls.Add(CancelBtn);
            Controls.Add(VariableNameContentHolder);
            Controls.Add(VariableIDContentHolder);
            Controls.Add(VariableNameLabel);
            Controls.Add(VariableIDLabel);
            Controls.Add(DeleteSubHeaderLabel);
            Controls.Add(DeleteHeaderLabel);
            Name = "DeletionTemplate";
            Text = "Deletion Window";
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiLabel DeleteHeaderLabel;
        private CuoreUI.Controls.cuiLabel DeleteSubHeaderLabel;
        private ImageList imageList1;
        private CuoreUI.Controls.cuiLabel VariableIDLabel;
        private CuoreUI.Controls.cuiLabel VariableNameLabel;
        private CuoreUI.Controls.cuiLabel VariableIDContentHolder;
        private CuoreUI.Controls.cuiLabel VariableNameContentHolder;
        private CuoreUI.Controls.cuiButton CancelBtn;
        private CuoreUI.Controls.cuiButton ConfirmBtn;
    }
}