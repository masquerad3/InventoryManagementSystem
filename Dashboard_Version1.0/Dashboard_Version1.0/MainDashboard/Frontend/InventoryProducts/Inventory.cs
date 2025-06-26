using MainDashboard.Backend.Logics.Inventory.Reload;
using MainDashboard.Backend.Queries.ProductsCrud;
using MainDashboard.Frontend;   // calls the deletion window

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainDashboard
{
    public partial class Inventory : UserControl
    {
        private AddItemForm addItemForm = null!; // Declare the AddItemForm field as null
        private DeletionTemplate deletionTemplate = null!;
        private FilterInventory filterInventoryForm = null!; // Declare the FilterInventory field as null

        public Inventory()
        {
            InitializeComponent();

            //editGridViewColumns();

            // load the data to the table
            ReloadProducts.LoadProductsData(InventoryGridView);

        }

        private void editGridViewColumns()
        {
            // Safely configure columns here — will not be overwritten
            View.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            View.Width = 50;
            View.Resizable = DataGridViewTriState.False;

            Edit.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Edit.Width = 50;
            Edit.Resizable = DataGridViewTriState.False;

            Delete.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Delete.Width = 65;
            Delete.Resizable = DataGridViewTriState.False;

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var addItemForm = new AddItemForm("Add", InventoryGridView);
            addItemForm.Show();

        }

        private void InventoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Only process if it's a valid row
            if (e.RowIndex < 0) return;

            // Only process clicks on image columns
            if (!(InventoryGridView.Columns[e.ColumnIndex] is DataGridViewImageColumn)) return;

            string clickedColumnName = InventoryGridView.Columns[e.ColumnIndex].Name;
            DataGridViewRow selectedRow = InventoryGridView.Rows[e.RowIndex];
            string productName = selectedRow.Cells["ProductName"].Value?.ToString()?.Trim() ?? "";

            var productRead = new ProductRead();
            int? productId = productRead.GetProductIDByName(productName);

            if (clickedColumnName == "View")
            {
                //view full details of the product
                if (productId != null)
                {
                    var addItemForm = new AddItemForm("View", productId.Value, InventoryGridView);
                    addItemForm.Show();

                }
                else
                {
                    MessageBox.Show("Product not found.");
                }

            }
            else if (clickedColumnName == "Edit")
            {
                if (productId != null)
                {
                    var addItemForm = new AddItemForm("Edit", InventoryGridView, productId.Value);
                    addItemForm.Show();

                }
                else
                {
                    MessageBox.Show("Product not found.");
                }

            }
            else if (clickedColumnName == "Delete")
            {
                if (productId != null)
                {
                    var confirmForm = new DeletionTemplate(
                        "Product",
                        productId.Value,
                        productName,
                        InventoryGridView
                    );
                    confirmForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Product not found.");
                }
            }

        }   //end of data cell rid view cell content click event



        //filterInventoryForm.ShowDialog(); // Show the FilterInventory form as a dialog

    }
}
