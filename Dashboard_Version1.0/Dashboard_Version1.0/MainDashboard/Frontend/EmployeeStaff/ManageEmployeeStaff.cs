using MainDashboard.Backend.Logics.EmployeeStaffs.Add;
using MainDashboard.Backend.Logics.Products.Add;
using MainDashboard.Backend.Logics.Products.Edit;
using MainDashboard.Backend.Queries.CategoryCrud;
using MainDashboard.Backend.Queries.ProductsCrud;
using MainDashboard.Backend.Queries.StaffCrud;
using MainDashboard.Backend.Queries.SupplierCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainDashboard.Frontend.EmployeeStaff
{
    public partial class ManageEmployeeStaff : Form
    {
        private string value;
        private DataGridView _targetDataGridView;
        private int? empId;
        private string? password;

        // constructor for ADD
        public ManageEmployeeStaff(string value, DataGridView dgv)
        {
            InitializeComponent();

            this.value = value;
            // Store the passed DataGridView instance
            _targetDataGridView = dgv;

            // checks the value
            if (this.value == "Add")
            {
                //replaces the dashboard title and button with "Add Item"
                EmpHeader.Content = "Create New Employee Account";
                SubLabel.Content = "Please fill in the necessary informations";
                SaveBtn.Content = "Create";
            }
            else
            {
                // for checking
                EmpHeader.Content = "Error Employee Creation";
                SubLabel.Visible = false;
                SaveBtn.Visible = false;
                CancelBtn.Content = "Close";
            }

        }

        //constructor for EDIT
        public ManageEmployeeStaff(string value, DataGridView dgv, int? empId, string password)
        {
            InitializeComponent();

            this.value = value;
            _targetDataGridView = dgv;
            this.empId = empId;
            this.password = password;

            // checks the value
            if (this.value == "Edit")
            {
                if (this.password == "admin")
                {
                    EmpHeader.Content = "Update an Employee's Account";
                    SubLabel.Content = "Please fill in the necessary informations";

                }
                else if (this.password == "chose employees password")
                {
                    EmpHeader.Content = "Update your Account Credentials";
                    SubLabel.Content = "Please fill in the necessary informations";
                }

                SaveBtn.Content = "Update";

            }
            else
            {
                // for checking
                EmpHeader.Content = "Error Employee Update/Edit Creation";
                SubLabel.Visible = false;
                SaveBtn.Visible = false;
                CancelBtn.Content = "Close";
            }

            LoadEmployeeDetails();

        }

        // loads details for editing an employee
        private void LoadEmployeeDetails()
        {
            if (!empId.HasValue) return;

            // Get the staff details
            Staff? employee = new StaffCrud().GetStaffById(empId.Value);

            if (employee == null)
            {
                MessageBox.Show("Employee credentials not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            // --- Assign values to widgets ---
            EmpNameTextBox.Content = employee.StaffName?.Trim();
            EmpPositionCB.SelectedItem = employee.StaffPosition?.Trim();
            EmailTextBox.Content = employee.StaffEmail?.Trim();
            PasswordTextBox.Content = employee.StaffPassword?.Trim();

            DOBPicker.Value = employee.StaffDateOfBirth ?? DateTime.Now;
            AddressTextBox.Content = employee.StaffAddress?.Trim() ?? "";
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //widgets here
            string empName = EmpNameTextBox.Content.Trim();
            string empPosition = EmpPositionCB.SelectedItem.Trim();
            string empEmail = EmailTextBox.Content.Trim();
            string empPassword = PasswordTextBox.Content.Trim();

            DateTime empBday = DOBPicker.Value;
            string empAddress = AddressTextBox.Content.Trim();

            if (SaveBtn.Content == "Create")  // Changed from "Add Product" to "Create"
            {
                bool addSuccess = AddEmployeeStaff.HandleAddEmployeeStaff(
                    empName,
                    empPosition,
                    empEmail,
                    empPassword,
                    empBday,
                    empAddress,
                    _targetDataGridView
                );

                if (addSuccess)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Employee Account Creation: Unknown Error.", "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (SaveBtn.Content == "Update")  // Changed from "Edit Product" to "Update"
            {
                bool editSuccess = EditEmployeeStaff.HandleEditEmployeeStaff(
                    empId.Value,        // Pass the staffId
                    empName,
                    empPosition,
                    empEmail,
                    empPassword,
                    empBday,
                    empAddress,
                    _targetDataGridView
                );

                if (editSuccess)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Employee Updating of Account: Unknown Error.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
