using MainDashboard.Backend.Logics.Inventory.Reload;
using MainDashboard.Backend.Queries.ProductsCrud;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainDashboard.Backend.Logics.Products.Edit
{
    public class EditProduct
    {

        public static bool HandleEditProduct(
            string productName,
            string manufacturer,
            string model,
            string categoryName,
            string supplierID,
            string quantityText,
            string condition,
            string priceText,
            DateTime dateDelivered,
            DateTime warrantyDate,
            string weightText,
            string description,
            DataGridView targetDataGridView
            )
        {
            //validate the values if empty or if its not a string
            bool isValidInput = true;
            string errorMessage = "";

            // --- String validations ---
            if (string.IsNullOrWhiteSpace(productName))
            {
                errorMessage += "Product Name cannot be empty.\n";
                isValidInput = false;
            }

            if (string.IsNullOrWhiteSpace(manufacturer))
            {
                errorMessage += "Manufacturer cannot be empty.\n";
                isValidInput = false;
            }

            if (string.IsNullOrWhiteSpace(model))
            {
                errorMessage += "Model cannot be empty.\n";
                isValidInput = false;
            }

            if (string.IsNullOrWhiteSpace(categoryName))
            {
                errorMessage += "Category must be selected.\n";
                isValidInput = false;
            }

            if (string.IsNullOrWhiteSpace(quantityText))
            {
                errorMessage += "Quantity cannot be empty.\n";
                isValidInput = false;
            }

            if (string.IsNullOrWhiteSpace(condition))
            {
                errorMessage += "Product condition is required.\n";
                isValidInput = false;
            }

            if (string.IsNullOrWhiteSpace(priceText))
            {
                errorMessage += "Price cannot be empty.\n";
                isValidInput = false;
            }

            // --- Check for duplicate product name ---
            var reader = new ProductRead();
            var allProducts = reader.ReadAllProducts();

            bool isDuplicate = allProducts.Any(p =>
                string.Equals(p.ProductName.Trim(), productName.Trim(), StringComparison.OrdinalIgnoreCase)
            );

            if (isDuplicate)
            {
                errorMessage += "A product with the same name already exists.\n";
                isValidInput = false;
            }

            // --- Decimal parsing ---
            if (!int.TryParse(quantityText, out int parsedQty) || parsedQty <= 0)
            {
                errorMessage += !int.TryParse(quantityText, out _)
                    ? "Invalid quantity entered. Enter a whole number.\n"
                    : "Quantity must be greater than zero.\n";
                isValidInput = false;
            }

            if (!decimal.TryParse(priceText, out decimal parsedPrice))
            {
                errorMessage += "Invalid price entered. Enter a number.\n";
                isValidInput = false;
            }
            else if (parsedPrice < 0)
            {
                errorMessage += "Price cannot be negative.\n";
                isValidInput = false;
            }

            decimal? parsedWeight = null;

            if (!string.IsNullOrWhiteSpace(weightText))
            {
                if (!decimal.TryParse(weightText, out decimal weightValue))
                {
                    errorMessage += "Weight must be a valid decimal number.\n";
                    isValidInput = false;
                }
                else if (weightValue < 0)
                {
                    errorMessage += "Weight cannot be negative.\n";
                    isValidInput = false;
                }
                else
                {
                    parsedWeight = weightValue; // Only assign if valid
                }
            }
            // END OF VALIDATIONS

            // --- Show error if invalid ---
            if (!isValidInput)
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

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

        }
    }
}
