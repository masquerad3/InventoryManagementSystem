using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MainDashboard.Backend.Queries.ProductsCrud;

namespace MainDashboard.Backend.Logics.Inventory.Reload
{
    public class ReloadProducts
    {
        public static void LoadProductsData(DataGridView dataGridView)
        {
            // Clear existing rows before loading new data to prevent duplicates
            dataGridView.Rows.Clear();

            ProductRead read = new ProductRead();
            List<ProductEssential> products = read.GetProductSummaries();

            foreach (var item in products)
            {
                int rowIndex = dataGridView.Rows.Add(); // Add a blank row and get its index

                dataGridView.Rows[rowIndex].Cells[0].Value = item.ProductName;         // Column 0: Product Name
                dataGridView.Rows[rowIndex].Cells[1].Value = item.CategoryName;        // Column 1: Category Name
                dataGridView.Rows[rowIndex].Cells[2].Value = item.ProductQuantity;     // Column 2: Quantity
                dataGridView.Rows[rowIndex].Cells[3].Value = item.ProductCondition;    // Column 3: Condition
                dataGridView.Rows[rowIndex].Cells[4].Value = item.ProductPrice.ToString("N2"); // Column 4: Price
            }
        }


    }

}
