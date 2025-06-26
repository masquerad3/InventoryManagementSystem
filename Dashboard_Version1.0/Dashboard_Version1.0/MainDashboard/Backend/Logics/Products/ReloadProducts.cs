using MainDashboard.Backend.Queries.ProductsCrud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainDashboard.Backend.Logics.Inventory.Reload
{
    public class ReloadProducts
    {
        public static void LoadProductsData(DataGridView dataGridView)
        {
            if (dataGridView == null)
            {
                MessageBox.Show("Error: ProductsGridView is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Clear existing rows before loading new data to prevent duplicates
            dataGridView.Rows.Clear();

            ProductRead read = new ProductRead();
            List<ProductEssential> products = read.GetProductSummaries();

            foreach (var product in products)
            {
                dataGridView.Rows.Add(
                    product.ProductName,
                    product.CategoryName,
                    product.ProductQuantity,
                    product.ProductCondition,
                    product.ProductPrice.ToString("N2"),
                    null, // View image (already set in designer or event)
                    null, // Edit image
                    null  // Delete image
                );
            }
        }


    }

}
