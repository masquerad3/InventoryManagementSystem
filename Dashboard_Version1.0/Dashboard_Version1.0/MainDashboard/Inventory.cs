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


        //filterInventoryForm.ShowDialog(); // Show the FilterInventory form as a dialog

    }
}
