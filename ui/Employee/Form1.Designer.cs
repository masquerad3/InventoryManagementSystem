namespace EmployeeDragDrop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridView1 = new DataGridView();
            EmployeeName = new DataGridViewTextBoxColumn();
            EmployeeID = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Action = new DataGridViewTextBoxColumn();
            btnAddEmployee = new CuoreUI.Controls.cuiButton();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            cuiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(16, 16);
            label1.Name = "label1";
            label1.Size = new Size(125, 32);
            label1.TabIndex = 1;
            label1.Text = "Employee";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { EmployeeName, EmployeeID, Position, Status, Action });
            dataGridView1.Location = new Point(16, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RightToLeft = RightToLeft.No;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(816, 325);
            dataGridView1.TabIndex = 0;
            // 
            // EmployeeName
            // 
            EmployeeName.HeaderText = "Employee Name";
            EmployeeName.Name = "EmployeeName";
            EmployeeName.ReadOnly = true;
            EmployeeName.Resizable = DataGridViewTriState.False;
            // 
            // EmployeeID
            // 
            EmployeeID.HeaderText = "Employee ID";
            EmployeeID.Name = "EmployeeID";
            EmployeeID.ReadOnly = true;
            // 
            // Position
            // 
            Position.HeaderText = "Position";
            Position.Name = "Position";
            Position.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // Action
            // 
            Action.HeaderText = "Action";
            Action.Name = "Action";
            Action.ReadOnly = true;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.Transparent;
            btnAddEmployee.CheckButton = false;
            btnAddEmployee.Checked = false;
            btnAddEmployee.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnAddEmployee.CheckedForeColor = Color.White;
            btnAddEmployee.CheckedImageTint = Color.White;
            btnAddEmployee.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnAddEmployee.Content = "Add Employee";
            btnAddEmployee.DialogResult = DialogResult.None;
            btnAddEmployee.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnAddEmployee.ForeColor = Color.Black;
            btnAddEmployee.HoverBackground = Color.DodgerBlue;
            btnAddEmployee.HoveredImageTint = Color.White;
            btnAddEmployee.HoverForeColor = Color.Black;
            btnAddEmployee.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnAddEmployee.Image = null;
            btnAddEmployee.ImageAutoCenter = true;
            btnAddEmployee.ImageExpand = new Point(0, 0);
            btnAddEmployee.ImageOffset = new Point(0, 0);
            btnAddEmployee.Location = new Point(683, 33);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.NormalBackground = Color.DeepSkyBlue;
            btnAddEmployee.NormalForeColor = Color.Black;
            btnAddEmployee.NormalImageTint = Color.White;
            btnAddEmployee.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnAddEmployee.OutlineThickness = 1F;
            btnAddEmployee.PressedBackground = Color.WhiteSmoke;
            btnAddEmployee.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnAddEmployee.PressedImageTint = Color.White;
            btnAddEmployee.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnAddEmployee.Rounding = new Padding(8);
            btnAddEmployee.Size = new Size(149, 32);
            btnAddEmployee.TabIndex = 3;
            btnAddEmployee.TextAlignment = StringAlignment.Center;
            btnAddEmployee.TextOffset = new Point(0, 0);
            btnAddEmployee.Click += btnAddEmployee_Click_1;
            // 
            // cuiPanel1
            // 
            cuiPanel1.Controls.Add(dataGridView1);
            cuiPanel1.Controls.Add(label1);
            cuiPanel1.Controls.Add(btnAddEmployee);
            cuiPanel1.Location = new Point(12, 64);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.SkyBlue;
            cuiPanel1.PanelOutlineColor = Color.SteelBlue;
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(858, 422);
            cuiPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(892, 525);
            Controls.Add(cuiPanel1);
            Name = "Form1";
            Text = "Employee";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private CuoreUI.Controls.cuiButton btnAddEmployee;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn EmployeeID;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Action;
    }
}
