using MainDashboard.Backend.Queries.StaffCrud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainDashboard.Backend.Logics.EmployeeStaffs.Add
{
    public class EditEmployeeStaff
    {
        public static bool HandleEditEmployeeStaff(
            int staffId,          // Added staffId parameter
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

            // Check for duplicate email (excluding the current staff)
            var staffCrud = new StaffCrud();
            int? existingStaffId = staffCrud.GetStaffIdByEmail(empEmail);
            if (existingStaffId.HasValue && existingStaffId.Value != staffId)
            {
                errorMessage += "An employee with the same email already exists.\n";
                isValidInput = false;
            }

            // END OF VALIDATIONS

            if (!isValidInput)
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // If all validations passed, proceed to update the staff record
            try
            {
                // Create staff object with updated information
                Staff updatedStaff = new Staff(
                    staffName: empName,
                    staffPosition: empPosition,
                    staffEmail: empEmail,
                    staffPassword: empPassword,
                    staffDateOfBirth: empBday,
                    staffAddress: empAddress
                );

                // Update staff record using the passed staffId parameter
                bool updateSuccess = staffCrud.UpdateStaff(staffId, updatedStaff);

                if (updateSuccess)
                {
                    MessageBox.Show("Employee information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Failed to update employee information.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }

}
