
using MainDashboard.Backend.Queries.BatchOrdersCrud;
using MainDashboard.Backend.Logics.BatchOrders.Reload;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainDashboard.Backend.Logics.BatchOrders.Updating
{
    public class UpdateBatchOrder
    {
        public static bool HandleBatchOrderUpdating(
                int batchOrderId,
                string batchOrderName,
                string batchOrderDescription,
                List<MainDashboard.Backend.Logics.BatchOrders.ModelOfGridItem.GridItem> selectedProductsWithQuantities,
                DataGridView targetDataGridView
            )
        {
            bool isValidInput = true;
            string errorMessage = "";

            // Validations
            if (string.IsNullOrWhiteSpace(batchOrderName))
            {
                errorMessage += "Batch Order Name cannot be empty.\n";
                isValidInput = false;
            }

            // UPDATED: Validation for selectedProductsWithQuantities
            if (selectedProductsWithQuantities == null || selectedProductsWithQuantities.Count == 0)
            {
                errorMessage += "Please select at least one product for the order.\n";
                isValidInput = false;
            }
            // Optional: Add validation to ensure all quantities are positive
            else if (selectedProductsWithQuantities.Any(item => item.Quantity <= 0))
            {
                errorMessage += "All selected product quantities must be greater than zero.\n";
                isValidInput = false;
            }

            if (!isValidInput)
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // end of validations

            // --- Call update logic ---
            var updateHandler1 = new UpdateBatchOrders();
            bool updateSuccess1 = updateHandler1.UpdateBatchOrder(batchOrderId, batchOrderName, batchOrderDescription);

            var updateHandler2 = new UpdateBatchOrders();
            // UPDATED: Now passing the List<GridItem> to UpdateBatchOrderProducts
            bool updateSuccess2 = updateHandler2.UpdateBatchOrderProducts(batchOrderId, selectedProductsWithQuantities);

            if (updateSuccess1 && updateSuccess2)
            {
                MessageBox.Show("Batch order updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (targetDataGridView != null)
                {
                    ReloadBatchOrders.LoadBatchOrdersData(targetDataGridView);
                }

                return true;
            }
            else
            {
                MessageBox.Show("Failed to update batch order.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool HandleBatchOrderUpdatingIsReceived(
               int batchOrderId,
               DateTime batchDateReceived,
               DataGridView targetDataGridView
           )
        {
            // --- Call update logic ---
            var updateHandler1 = new UpdateBatchOrders();
            bool isReceivedSuccess = updateHandler1.UpdateBatchOrderIsReceived(batchOrderId, batchDateReceived);

            var updateHandler2 = new UpdateBatchOrders();
            bool isMarkedReceived = updateHandler2.MarkBatchOrderAsReceived(batchOrderId);

            if (isReceivedSuccess && isMarkedReceived)
            {
                MessageBox.Show("Batch order marked as received successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (targetDataGridView != null)
                {
                    ReloadBatchOrders.LoadBatchOrdersData(targetDataGridView);
                }

                return true;
            }
            else
            {
                MessageBox.Show("Failure to Update that order is now received.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
