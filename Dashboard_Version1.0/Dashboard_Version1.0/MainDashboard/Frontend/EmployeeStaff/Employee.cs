using MainDashboard.Backend.Logics.EmployeeStaffs.Reload;
using MainDashboard.Backend.Logics.Inventory.Reload;
using MainDashboard.Backend.Queries.ProductsCrud;
using MainDashboard.Backend.Queries.StaffCrud;
using MainDashboard.Frontend.EmployeeStaff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MainDashboard
{
    public partial class Employee : UserControl
    {
        private ManageEmployeeStaff manageEmployeeStaff = null;

        public Employee()
        {
            InitializeComponent();
            ReloadEmployeeStaffs.LoadEmployeeStaffData(EmployeeStaffGridView);
            this.Load += Employee_Load;
        }

        // Add this method to match the one referenced in Designer.cs
        private void Employee_Load(object sender, EventArgs e)
        {
            ReloadEmployeeStaffs.LoadEmployeeStaffData(EmployeeStaffGridView);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            // UPDATE THIS
            var addEmployeeForm = new ManageEmployeeStaff("Add", EmployeeStaffGridView);
            addEmployeeForm.Show();

        }

        private void EmployeeStaffGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Only process if it's a valid row
            if (e.RowIndex < 0) return;

            // Only process clicks on image columns
            if (!(EmployeeStaffGridView.Columns[e.ColumnIndex] is DataGridViewImageColumn)) return;

            string clickedColumnName = EmployeeStaffGridView.Columns[e.ColumnIndex].Name;
            DataGridViewRow selectedRow = EmployeeStaffGridView.Rows[e.RowIndex];

            // Get staff ID and name from the selected row
            string staffName = selectedRow.Cells["EmployeeName"].Value?.ToString()?.Trim() ?? "";

            var staffReader = new StaffCrud();
            int? staffId = staffReader.GetStaffIDByName("John Doe");

            if (clickedColumnName == "Edit")
            {
                var editEmployeeForm = new ManageEmployeeStaff("Edit", EmployeeStaffGridView, staffId, "admin");
                editEmployeeForm.Show();
            }
            else if (clickedColumnName == "Delete")
            {
                // Confirmation message box with staff ID and name
                DialogResult confirmResult = MessageBox.Show(
                    $"Are you sure you want to delete this account?\n\n   Employee ID: {staffId}\n   Employee Name: {staffName}",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmResult == DialogResult.Yes)
                {
                    var deleteHandler = new StaffDelete();
                    bool deletingStaffSuccess = deleteHandler.DeleteStaffByID(staffId.Value);

                    if (deletingStaffSuccess)
                    {
                        MessageBox.Show("Successfully deleted the employee.", "Deletion Window",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // --- Reload DataGridView with employee data ---
                        if (EmployeeStaffGridView != null)
                        {
                            ReloadEmployeeStaffs.LoadEmployeeStaffData(EmployeeStaffGridView);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the employee. Check Error Logs.",
                            "Deletion Window", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}