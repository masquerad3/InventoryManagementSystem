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
    public partial class FilterInventory : Form
    {
        public FilterInventory()
        {
            InitializeComponent();
        }

       
        private void FilterInventory_Load(object sender, EventArgs e)
        {
            // Initialize the filter options if needed
            // For example, you can populate a ComboBox with categories
            // comboBoxCategory.Items.AddRange(new string[] { "Laptop", "Peripheral", "Accessories" });
        }

        // This method is called when the selected index of the ComboBox changes yet there is no implementation yet.
        private void cuiComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Basic implementation for handling ComboBox changes
            // You can customize this based on your specific requirements
            if (sender is ComboBox comboBox && comboBox.SelectedItem != null)
            {
                // Do something with the selected item
                Console.WriteLine($"Selected: {comboBox.SelectedItem}");
            }
        }

        private void InventoryFilterBtn_Click(object sender, EventArgs e)
        {
            // Implement the filtering logic here
            // For example, you can filter the DataGridView based on the selected category
            string selectedCategory = BrandDropdown.SelectedItem.ToString();
            // Assuming dataGridView1 is the DataGridView containing inventory items
            // You would filter the data source of dataGridView1 based on selectedCategory
            MessageBox.Show($"Filtering inventory by category: {selectedCategory}", "Filter", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FilterCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the filter form
        }

    }
}
