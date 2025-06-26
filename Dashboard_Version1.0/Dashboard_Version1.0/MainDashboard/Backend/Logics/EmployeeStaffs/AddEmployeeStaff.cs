using MainDashboard.Backend.Queries.AuthCrud;
using MainDashboard.Backend.Queries.StaffCrud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainDashboard.Backend.Logics.EmployeeStaffs.Add
{
    public class AddEmployeeStaff
    {
        public static bool HandleAddEmployeeStaff(
            string empName,
            string empPosition,
            string empEmail,
            string empPassword,
            DateTime empBday,
            string empAddress,
            DataGridView targetDataGridView
            )
        {
            bool isValidInput = true;
            string errorMessage = "";

            // --- String validations ---
            if (string.IsNullOrWhiteSpace(empName))
            {
                errorMessage += "Employee name cannot be empty.\n";
                isValidInput = false;
            }

            if (string.IsNullOrWhiteSpace(empPosition))
            {
                errorMessage += "Employee position must be selected.\n";
                isValidInput = false;
            }

            if (string.IsNullOrWhiteSpace(empEmail))
            {
                errorMessage += "Email cannot be empty.\n";
                isValidInput = false;
            }
            else if (!empEmail.Contains("@") || !empEmail.Contains("."))
            {
                errorMessage += "Email format is invalid.\n";
                isValidInput = false;
            }

            if (string.IsNullOrWhiteSpace(empPassword))
            {
                errorMessage += "Password cannot be empty.\n";
                isValidInput = false;
            }
            else if (empPassword.Length < 6)
            {
                errorMessage += "Password must be at least 6 characters long.\n";
                isValidInput = false;
            }

            if (empBday > DateTime.Now)
            {
                errorMessage += "Date of birth cannot be in the future.\n";
                isValidInput = false;
            }

            if (string.IsNullOrWhiteSpace(empAddress))
            {
                errorMessage += "Address cannot be empty.\n";
                isValidInput = false;
            }

            // Check for duplicate email
            var staffCrud = new StaffCrud();
            int? existingStaffId = staffCrud.GetStaffIdByEmail(empEmail);
            if (existingStaffId.HasValue)
            {
                errorMessage += "An employee with the same email already exists.\n";
                isValidInput = false;
            }

            // Show validation errors
            if (!isValidInput)
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // If all validations passed, proceed to create the employee record
            try
            {
                // Check if email is already in use
                if (staffCrud.IsEmailInUse(empEmail))
                {
                    MessageBox.Show("This email is already registered. Please use a different email.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Create staff object with new information
                Staff newStaff = new Staff(
                    staffName: empName,
                    staffPosition: empPosition,
                    staffEmail: empEmail,
                    staffPassword: empPassword,
                    staffDateOfBirth: empBday,
                    staffAddress: empAddress
                );

                // Add staff record and get new ID
                int staffId = staffCrud.AddStaff(newStaff);

                if (staffId > 0)
                {
                    // Create auth record with hashed password
                    var authCrud = new AuthCrud();
                    bool authSuccess = authCrud.Register(staffId, empPassword);

                    if (authSuccess)
                    {
                        MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reload DataGridView if needed here
                        // Add code to reload your employee DataGridView

                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Failed to create authentication record.", "Database Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Failed to create employee record.", "Database Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating employee: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

    }

}
