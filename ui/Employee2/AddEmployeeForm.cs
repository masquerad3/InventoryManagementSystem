using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeDragDrop
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

    
        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            // You can handle selection changes here if needed
        }

   
        private void BtnSave_Click(object sender, EventArgs e)
        {
            string name = txtEmployeeName.Text;
            string id = txtEmployeeID.Text;
            string position = cmbPosition.SelectedItem?.ToString();

            // Example validation
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(id) || cmbPosition.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Close modal and return to main form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Properties to access from main form
        public string EmployeeName => txtEmployeeName.Text;
        public string EmployeeID => txtEmployeeID.Text;
        public string Position => cmbPosition.SelectedItem?.ToString();
    }
}
