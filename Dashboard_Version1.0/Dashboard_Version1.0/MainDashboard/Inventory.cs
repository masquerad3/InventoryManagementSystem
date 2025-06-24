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
            LoadSampleData();
            addItemForm = new AddItemForm(); // Initialize the AddItemForm to ensure it is not null
            filterInventoryForm = new FilterInventory(); // Initialize the FilterInventory to ensure it is not null
        }

        private void LoadSampleData()
        {
            DataTable inventoryTable = new DataTable("Inventory");
            inventoryTable.Columns.Add("ItemID", typeof(int));
            inventoryTable.Columns.Add("ItemName", typeof(string));
            inventoryTable.Columns.Add("Category", typeof(string));
            inventoryTable.Columns.Add("Quantity", typeof(int));
            inventoryTable.Columns.Add("Price", typeof(decimal));

            inventoryTable.Rows.Add(1, "Dell XPS 13", "Laptop", 5, 999.99m);
            inventoryTable.Rows.Add(2, "HP Pavilion", "Laptop", 3, 799.99m);
            inventoryTable.Rows.Add(3, "MacBook Air", "Laptop", 4, 1299.99m);
            inventoryTable.Rows.Add(4, "Logitech Mouse", "Peripheral", 10, 29.99m);
            inventoryTable.Rows.Add(5, "Dell Keyboard", "Peripheral", 8, 49.99m);
            inventoryTable.Rows.Add(6, "USB-C Hub", "Peripheral", 15, 39.99m);

            dataGridView1.DataSource = inventoryTable;
        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            addItemForm.ShowDialog(); // Show the AddItemForm as a dialog
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            filterInventoryForm.ShowDialog(); // Show the FilterInventory form as a dialog
        }
    }
}
