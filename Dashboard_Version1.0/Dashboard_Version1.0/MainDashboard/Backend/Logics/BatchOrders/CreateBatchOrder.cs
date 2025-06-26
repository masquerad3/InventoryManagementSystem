
using MainDashboard.Backend.Queries.BatchOrdersCrud;
using MainDashboard.Backend.Logics.BatchOrders.Reload;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainDashboard.Backend.Logics.BatchOrders.Create
{
    public class CreateBatchOrder
    {

        public static bool HandleBatchOrderCreation(
                string batchOrderName,
                string batchOrderDescription,
                List<string> selectedProducts,
                DataGridView targetDataGridView
            )
        {
            bool isValidInput = true;
            string errorMessage = "";

            // --- Batch Name validation ---
            if (string.IsNullOrWhiteSpace(batchOrderName))
            {
                errorMessage += "Batch Order Name cannot be empty.\n";
                isValidInput = false;
            }

            // --- Optional: Batch Description validation ---
            // You can leave this out if null/empty is acceptable.

            // --- Selected Products validation ---
            if (selectedProducts == null || selectedProducts.Count == 0)
            {
                errorMessage += "Please select at least one product for to proceed with the order.\n";
                isValidInput = false;
            }

            // Show validation message if any failed
            if (!isValidInput)
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // END OF VALIDATIONS

            // initalize date variables 
            DateTime batchDateRequested = DateTime.Now;

            // --- If all validations passed, proceed to insert the product ---

            bool insertSuccess = false;

            // 1. Insert the batch order (BatchName & BatchDescription)
            CreateBatchOrders createHandler = new CreateBatchOrders();
            bool isBatchInserted = createHandler.InsertBatchOrder(batchOrderName, batchOrderDescription);

            if (isBatchInserted)
            {
                // 2. Get the BatchOrderID using the name
                ReadBatchOrders readHandler = new ReadBatchOrders();
                int batchOrderId = readHandler.GetBatchOrderIdByName(batchOrderName);

                if (batchOrderId != -1)
                {
                    // 3. Insert the related products into BatchOrderProducts
                    insertSuccess = createHandler.AddProductsToBatchOrder(batchOrderId, selectedProducts);
                }
                else
                {
                    MessageBox.Show("Failed to retrieve the batch order ID.", "Batch Linking Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Failed to insert batch order.", "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // --- Result feedback ---
            if (insertSuccess)
            {
                MessageBox.Show("Batch ordered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // --- Reload DataGridView ---
                if (targetDataGridView != null)
                {
                    ReloadBatchOrders.LoadBatchOrdersData(targetDataGridView);
                }

                return true;
            }
            else
            {
                MessageBox.Show("Failed to order new batch of product/s. See error log.", "Database Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
    }
}
