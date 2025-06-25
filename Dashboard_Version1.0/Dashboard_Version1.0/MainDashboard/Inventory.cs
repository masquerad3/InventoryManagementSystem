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
        private AddItemForm addItemForm; // Declare the AddItemForm field
        private FilterInventory filterInventoryForm; // Declare the FilterInventory field

        public Inventory()
        {
            InitializeComponent();
            addItemForm = new AddItemForm(); // Initialize the AddItemForm to ensure it is not null
            filterInventoryForm = new FilterInventory(); // Initialize the FilterInventory to ensure it is not null

            // load the data to the table
            ReloadInventory.LoadProductsData(InventoryGridView);

        }

        //addItemForm.ShowDialog(); // Show the AddItemForm as a dialog
        //filterInventoryForm.ShowDialog(); // Show the FilterInventory form as a dialog

    }
}
