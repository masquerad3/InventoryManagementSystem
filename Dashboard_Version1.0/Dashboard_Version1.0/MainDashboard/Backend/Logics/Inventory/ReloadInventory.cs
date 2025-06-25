using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MainDashboard.Backend.Queries.InventoryCrud;

namespace MainDashboard.Backend.Logics.Inventory.Reload
{
    public class ReloadInventory
    {
        public static void LoadProductsData(DataGridView dataGridView)
        {
            // Clear existing rows before loading new data to prevent duplicates
            dataGridView.Rows.Clear();

            ProductRead read = new ProductRead();
            List<ProductEssential> products = read.GetProductSummaries();

            foreach (var item in products)
            {
                dataGridView.Rows.Add(
                    item.ProductName,         // item name
                    item.CategoryID,          // category ID
                    item.CategoryName,        // category name
                    item.ProductQuantity,     // quantity
                    item.ProductCondition,    // condition
                    item.ProductPrice.ToString("N2") // price
                );
            }
        }


    }

}
