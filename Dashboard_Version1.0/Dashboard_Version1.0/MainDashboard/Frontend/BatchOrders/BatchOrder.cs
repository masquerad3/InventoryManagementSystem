using CuoreUI;
using MainDashboard.Backend.Logics.BatchOrders.Create;
using MainDashboard.Backend.Logics.BatchOrders.Reload;
using MainDashboard.Backend.Logics.BatchOrders.Updating;
using MainDashboard.Backend.Queries.BatchOrdersCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
// Removed unused usings for a cleaner file
// using Microsoft.VisualBasic.Devices;
// using System.Data;
// using System.Diagnostics;
// using System.Diagnostics.Metrics;
// using System.Drawing;
// using System.Reflection;
// using System.Reflection.PortableExecutable;
// using System.Security.Claims;
// using System.Text;
// using System.Threading.Tasks;
// using static CuoreUI.DeviceInfo;
// using static CuoreUI.Drawing.EasingFunctions;

// Importantly, add this using statement for your custom GridItem model
using MainDashboard.Backend.Logics.BatchOrders.ModelOfGridItem;


namespace MainDashboard.Frontend.BatchOrders
{
    public partial class BatchOrder : Form
    {
        private string value;
        private DataGridView _targetDataGridView;
        private int? batchOrderId;

        // REMOVED THE INNER CLASS DEFINITION for GridItem here.
        // It should be defined only in MainDashboard.Backend.Logics.BatchOrders.ModelOfGridItem.GridItem

        // A list to hold the data that will be bound to the DataGridView
        // Using BindingList for automatic UI updates when items are added/removed
        // Explicitly use the fully qualified name for GridItem to avoid ambiguity
        private BindingList<MainDashboard.Backend.Logics.BatchOrders.ModelOfGridItem.GridItem> _gridData;
        private List<MainDashboard.Backend.Logics.BatchOrders.ModelOfGridItem.GridItem> selectedProductsWithQuantities;

        // Hardcoded items for the CheckedListBox
        private List<string> _hardcodedChecklistItems = new List<string>
        {
            "Lcd Monitor",
            "Opisina Chair",
            "Electric Drill",
            "Wifi Router",
            "Desk Lamp",
            "Filing Cabinet",
            "Software Suite",
            "Cctv Camera",
            "External Hdd",
            "Power Drill",
            "Wireless Keyboard",
            "Air Conditioner",
            "Projector",
            "Industrial Fan",
            "Smart Tv",
            "Printer Scanner",
            "Safety Helmet",
            "Network Switch",
            "Solar Panel",
            "Voltage Regulator",
            "Barcode Scanner",
            "Ups Battery",
            "Conference Phone",
            "Welding Machine",
            "Tablet",
            "Computer"
        };

        //CONSTRUCTOR FOR ADD * ADDING/CREATING NEW ORDER BATCHES OF PRODUCTS
        public BatchOrder(string value, DataGridView dgv)
        {
            InitializeComponent();
            InitializeChecklistAndGridView();

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
            InitializeChecklistAndGridView();

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

            // --- UPDATED LOGIC FOR LOADING PRODUCTS AND QUANTITIES ---

            // Get products with quantities from DB using the appropriate method
            // This method should return List<BatchOrderProduct>
            var productsWithQuantitiesFromDb = reader.GetProductsWithQuantitiesByBatchOrderId(batchOrderId.Value);

            // --- Populate ProductCheckList ---
            // 1. Clear the checklist's current items
            ProductCheckList.Items.Clear();

            // 2. Re-populate checklist with all hardcoded items, initially unchecked
            foreach (string item in _hardcodedChecklistItems)
            {
                ProductCheckList.Items.Add(item, false);
            }

            // --- Populate _gridData AND check items in ProductCheckList ---
            _gridData.Clear(); // Clear existing data in the DataGridView's source

            foreach (var dbProduct in productsWithQuantitiesFromDb) // Iterate through BatchOrderProduct objects
            {
                // Add to _gridData (for DataGridView)
                // Create a new GridItem from the BatchOrderProduct data
                _gridData.Add(new MainDashboard.Backend.Logics.BatchOrders.ModelOfGridItem.GridItem
                {
                    ItemName = dbProduct.ProductName,
                    Quantity = dbProduct.ProductQuantity
                });

                // Find the item in the ProductCheckList and check it
                int index = ProductCheckList.Items.IndexOf(dbProduct.ProductName);
                if (index != -1)
                {
                    ProductCheckList.SetItemChecked(index, true);
                }
            }
            // --- END OF UPDATED LOGIC ---
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string batchOrderName = BONameTextBox.Content.Trim();
            string batchOrderDescription = OrderDescriptionTextBox.Content.Trim();

            // Get the product and quantity data directly from the DataGridView's bound source
            // _gridData already contains the GridItem objects (ItemName and Quantity)
            // This line is correct as selectedProductsWithQuantities is correctly typed above
            selectedProductsWithQuantities = _gridData.ToList();

            if (this.value == "Add")
            {
                bool createSuccess = CreateBatchOrder.HandleBatchOrderCreation(
                    batchOrderName,
                    batchOrderDescription,
                    selectedProductsWithQuantities, // This is now correctly typed
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
                    selectedProductsWithQuantities, // This is now correctly typed
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

        // stuffs for checklist and gridview
        private void InitializeChecklistAndGridView()
        {
            // --- ProductCheckList Setup ---
            // Populate ProductCheckList
            foreach (string item in _hardcodedChecklistItems)
            {
                ProductCheckList.Items.Add(item);
            }
            // Attach event handler for ProductCheckList item checking
            ProductCheckList.ItemCheck += ProductCheckList_ItemCheck;

            // --- ProductQuantityGridview Setup ---
            ProductQuantityGridview.AutoGenerateColumns = false; // We'll define columns manually

            // Column 0: Item Name
            DataGridViewTextBoxColumn itemNameColumn = new DataGridViewTextBoxColumn();
            itemNameColumn.DataPropertyName = "ItemName"; // Matches property name in GridItem
            itemNameColumn.HeaderText = "Product";
            itemNameColumn.ReadOnly = true; // User cant change the item name directly 
            itemNameColumn.Width = 150;
            ProductQuantityGridview.Columns.Add(itemNameColumn);

            // Column 1: Quantity
            DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn();
            quantityColumn.DataPropertyName = "Quantity"; // Matches property name in GridItem
            quantityColumn.HeaderText = "Quantity";
            quantityColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Align numbers to the right
            quantityColumn.Width = 80;
            ProductQuantityGridview.Columns.Add(quantityColumn);

            // Initialize the BindingList and bind it to the DataGridView
            // Explicitly use the fully qualified name for GridItem
            _gridData = new BindingList<MainDashboard.Backend.Logics.BatchOrders.ModelOfGridItem.GridItem>();
            ProductQuantityGridview.DataSource = _gridData;

            // Attach event handler for DataGridView cell validation
            ProductQuantityGridview.CellValidating += ProductQuantityGridview_CellValidating;
            ProductQuantityGridview.CellEndEdit += ProductQuantityGridview_CellEndEdit; // To clear error text after successful edit
        }

        private void ProductCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string itemName = ProductCheckList.Items[e.Index].ToString();

            if (e.NewValue == CheckState.Checked)
            {
                // Item was checked, add it to the DataGridView's data source
                // Only add if not already present (prevents duplicates on rapid clicks)
                if (!_gridData.Any(item => item.ItemName == itemName))
                {
                    // Explicitly use the fully qualified name for GridItem
                    _gridData.Add(new MainDashboard.Backend.Logics.BatchOrders.ModelOfGridItem.GridItem { ItemName = itemName, Quantity = 1 }); // Default quantity is 1
                }
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                // Item was unchecked, remove it from the DataGridView's data source
                var itemToRemove = _gridData.FirstOrDefault(item => item.ItemName == itemName);
                if (itemToRemove != null)
                {
                    _gridData.Remove(itemToRemove);
                }
            }
        }

        private void ProductQuantityGridview_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Ensure we are validating the "Quantity" column (index 1 or by DataPropertyName)
            if (ProductQuantityGridview.Columns[e.ColumnIndex].DataPropertyName == "Quantity")
            {
                int newQuantity;
                // Try to parse the new value as an integer and check if it's non-negative
                if (!int.TryParse(e.FormattedValue.ToString(), out newQuantity) || newQuantity < 0)
                {
                    e.Cancel = true; // Prevent the cell from losing focus
                    ProductQuantityGridview.Rows[e.RowIndex].ErrorText = "Please enter a valid non-negative integer for quantity.";
                }
                else
                {
                    // Value is valid, clear any existing error text
                    ProductQuantityGridview.Rows[e.RowIndex].ErrorText = string.Empty;
                }
            }
        }

        private void ProductQuantityGridview_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Clear any error text when editing ends (e.g., after successful validation)
            ProductQuantityGridview.Rows[e.RowIndex].ErrorText = string.Empty;
        }

        // Example: Get final selected items and quantities (you might call this from a "Submit" button)
        private void btnProcessSelection_Click(object sender, EventArgs e) // Assuming you have a button named btnProcessSelection
        {
            // Explicitly use the fully qualified name for GridItem
            List<MainDashboard.Backend.Logics.BatchOrders.ModelOfGridItem.GridItem> selectedItemsWithQuantities = _gridData.ToList();

            if (selectedItemsWithQuantities.Any())
            {
                string result = "Selected Items and Quantities:\n";
                foreach (var item in selectedItemsWithQuantities)
                {
                    result += $"{item.ItemName}: {item.Quantity}\n";
                }
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("No items selected in the grid.");
            }
        }

    }
}