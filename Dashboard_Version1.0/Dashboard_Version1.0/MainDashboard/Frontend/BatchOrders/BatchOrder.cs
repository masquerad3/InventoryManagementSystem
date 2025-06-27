
using MainDashboard.Backend.Logics.BatchOrders.Reload;
using MainDashboard.Backend.Logics.BatchOrders.Create;
using MainDashboard.Backend.Logics.BatchOrders.Updating;
using MainDashboard.Backend.Queries.BatchOrdersCrud;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainDashboard.Frontend.BatchOrders
{
    public partial class BatchOrder : Form
    {
        private string value;
        private DataGridView _targetDataGridView;
        private int? batchOrderId;

        //CONSTRUCTOR FOR ADD * ADDING/CREATING NEW ORDER BATCHES OF PRODUCTS
        public BatchOrder(string value, DataGridView dgv)
        {
            InitializeComponent();

            this.value = value;
            // Store the passed DataGridView instance
            _targetDataGridView = dgv;

            // checks the value
            if (this.value == "Add")
            {
                //replaces the dashboard title and button with "Add Item"
                AddEditBatchOrderLabel.Content = "Order New Batch of Products";
                SaveBtn.Content = "Order";

                //hides the two update button
                NotReceivedBtn.Visible = false;
                IsReceivedBtn.Visible = false;
            }
            else
            {
                // for checking
                AddEditBatchOrderLabel.Content = "ERROR ORDERING DO NOT PROCEED";
                SaveBtn.Visible = false;
            }
        }
        // end of constructor for add

        //CONSTRUCTOR FOR EDIT * EDITING ORDER BATCHES OF PRODUCTS
        public BatchOrder(string value, DataGridView dgv, int batchOrderId)
        {
            InitializeComponent();

            this.value = value;
            // Store the passed DataGridView instance
            _targetDataGridView = dgv;
            this.batchOrderId = batchOrderId;

            if (this.value == "Edit")
            {
                //replaces the dashboard title and button with "Add Item"
                AddEditBatchOrderLabel.Content = "Update Order";
                SaveBtn.Content = "Update Order";

                //unhides the two update button
                NotReceivedBtn.Visible = true;
                IsReceivedBtn.Visible = true;
            }
            else
            {
                // for checking
                AddEditBatchOrderLabel.Content = "ERROR UPDATING ORDER DO NOT PROCEED";
                SaveBtn.Visible = false;
            }

            LoadBatchOrderDetails();
        }
        // end of constructor for edit

        private void LoadBatchOrderDetails()
        {
            if (!batchOrderId.HasValue) return;

            var reader = new ReadBatchOrders();
            var order = reader.GetBatchOrderById(batchOrderId.Value);

            if (order == null)
            {
                MessageBox.Show("Batch Order record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            // Fill the form
            BONameTextBox.Content = order.Value.BatchName;
            OrderDescriptionTextBox.Content = order.Value.BatchDescription;

            // Get selected products from DB
            var selectedProducts = new ReadBatchOrders().GetProductsByBatchOrderId(batchOrderId.Value);

            // Temporarily store existing checklist items
            var allItems = new List<string>();
            foreach (var item in ProductCheckList.Items)
            {
                allItems.Add(item.ToString());
            }

            // Clear the checklist
            ProductCheckList.Items.Clear();

            // Step 1: Add selected products first (checked)
            foreach (var product in selectedProducts)
            {
                ProductCheckList.Items.Add(product, true);
            }

            // Step 2: Add remaining products (unchecked), skipping already added
            foreach (var product in allItems)
            {
                if (!selectedProducts.Contains(product))
                {
                    ProductCheckList.Items.Add(product, false);
                }
            }

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string batchOrderName = BONameTextBox.Content.Trim();
            string batchOrderDescription = OrderDescriptionTextBox.Content.Trim();

            // Get selected items as list of strings
            List<string> selectedProducts = new List<string>();

            foreach (var item in ProductCheckList.CheckedItems)
            {
                if (item != null)
                {
                    selectedProducts.Add(item!.ToString().Trim());
                }
            }

            if (this.value == "Add")
            {
                bool createSuccess = CreateBatchOrder.HandleBatchOrderCreation(
                    batchOrderName,
                    batchOrderDescription,
                    selectedProducts,
                    _targetDataGridView
                );

                if (createSuccess)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cannot Create Order: Unknown Error.", "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (this.value == "Edit")
            {
                bool updatingSuccess = UpdateBatchOrder.HandleBatchOrderUpdating(
                    batchOrderId.Value,
                    batchOrderName,
                    batchOrderDescription,
                    selectedProducts,
                    _targetDataGridView
                );

                if (updatingSuccess)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cannot Update Order: Unknown Error.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void IsReceivedBtn_Click(object sender, EventArgs e)
        {
            DateTime batchDateReceived = DateTime.Now;

            //update query
            bool isReceivedSuccess = UpdateBatchOrder.HandleBatchOrderUpdatingIsReceived(
                    batchOrderId.Value,
                    batchDateReceived,
                    _targetDataGridView
                );

            if (isReceivedSuccess)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Cannot Update that order has been received: Unknown Error.", "Updating Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NotReceivedBtn_Click(object sender, EventArgs e)
        {
            var reader = new ReadBatchOrders();
            bool isDateReceivedNull = reader.IsBatchDateReceivedNull(batchOrderId.Value);

            // checks if its not null
            if (!isDateReceivedNull)
            {
                DialogResult confirmResult = MessageBox.Show(
                     "Are you sure you want to mark this order as not yet received when it's already marked as received?",
                     "Order Confirmation",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Warning
                 );

                if (confirmResult == DialogResult.Yes)
                {
                    // Call the update method to set BatchDateReceived to NULL
                    var updateHandler = new UpdateBatchOrders();
                    bool success = updateHandler.NullifyBatchDateReceived(batchOrderId.Value);

                    if (success)
                    {
                        MessageBox.Show("Order has been successfully marked as not yet received.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ReloadBatchOrders.LoadBatchOrdersData(_targetDataGridView);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update the order. Please try again.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // User clicked No, do nothing or close
                    return;
                }

            }
            else if (isDateReceivedNull)
            {
                MessageBox.Show("Order already marked as not yet received.", "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Cannot Update that order is not yet received: Unknown Error.", "Updating Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
