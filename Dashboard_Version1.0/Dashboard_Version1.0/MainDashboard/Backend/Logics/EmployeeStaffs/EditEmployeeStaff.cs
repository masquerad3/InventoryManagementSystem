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

            if (empBday == null || empBday > DateTime.Now)
            {
                errorMessage += "Date of birth must be valid and not in the future.\n";
                isValidInput = false;
            }

            if (string.IsNullOrWhiteSpace(empAddress))
            {
                errorMessage += "Address cannot be empty.\n";
                isValidInput = false;
            }

            /*
            // Check for duplicate email
            var staffReader = new StaffCrud();
            var allStaff = staffReader.GetAllStaff();
            

            bool isDuplicate = allStaff.Any(s =>
                string.Equals(s.StaffEmail.Trim(), empEmail.Trim(), StringComparison.OrdinalIgnoreCase)
            );

            if (isDuplicate)
            {
                errorMessage += "An employee with the same email already exists.\n";
                isValidInput = false;
            }
            */

            // END OF VALIDATIONS

            // Show validation errors
            if (!isValidInput)
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            /*

            // DO SOMETHING SIMILAR BUT FOR EMPLOYEE / STAFF

            // --- If all validations passed, proceed to update/edit the product ---
            bool editSuccess = ProductEdit.EditProduct(
                productName,
                manufacturer,
                model,
                categoryName,
                supplierID,
                parsedQty,
                condition,
                parsedPrice,
                dateDelivered,
                warrantyDate,
                parsedWeight,
                description
            );

            if (editSuccess)
            {
                MessageBox.Show("Product edited successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // --- Reload DataGridView ---
                if (targetDataGridView != null)
                {
                    ReloadProducts.LoadProductsData(targetDataGridView);
                }

                return true;
            }
            else
            {
                MessageBox.Show("Failed to edit product. See error log.", "Database Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            */

            return false;

        }

    }

}
