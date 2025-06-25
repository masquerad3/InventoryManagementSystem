using MainDashboard.Backend.Logics.Inventory.Reload;
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
        private FilterInventory filterInventoryForm = null!; // Declare the FilterInventory field as null

        public Inventory()
        {
            InitializeComponent();

            // load the data to the table
            ReloadProducts.LoadProductsData(InventoryGridView);

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (addItemForm == null || addItemForm.IsDisposed) // Check if it's already open  
            {
                addItemForm = new AddItemForm("Add", InventoryGridView);
                addItemForm.ShowDialog();
                addItemForm.Focus();
            }
            else
            {
                addItemForm.Focus(); // Bring existing form to front 
            }

        }
       // private void FilterBtn_Click(object sender, EventArgs e)
       // {
        //    filterInventoryForm.ShowDialog();
        //}

        private void InventoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataTable dt = (DataTable)InventoryGridView.DataSource;
                int itemId = (int)dt.Rows[e.RowIndex]["ItemID"]; // Assuming ItemID exists
                if (e.ColumnIndex == InventoryGridView.Columns["View"].Index)
                {
                    MessageBox.Show($"Viewing item {dt.Rows[e.RowIndex]["ItemName"]}.", "View Item");
                    // Implement view logic
                }
                else if (e.ColumnIndex == InventoryGridView.Columns["Edit"].Index)
                {
                    MessageBox.Show($"Editing item {dt.Rows[e.RowIndex]["ItemName"]}.", "Edit Item");
                    // Implement edit logic
                }
                else if (e.ColumnIndex == InventoryGridView.Columns["Delete"].Index)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        
                    }
                }
            }
        }
    }
}
