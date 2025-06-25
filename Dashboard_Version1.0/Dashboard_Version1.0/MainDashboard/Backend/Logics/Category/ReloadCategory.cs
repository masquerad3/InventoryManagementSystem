using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MainDashboard.Backend.Queries.CategoryCrud;

namespace MainDashboard.Backend.Logics.Category.Reload
{
    public class ReloadBatchOrders
    {
        // method to load unarchived inventory data into the DataGridView
        public static void LoadInventoryData(DataGridView dataGridView)
        {
            // Clear existing rows before loading new data to prevent duplicates
            dataGridView.Rows.Clear();

            var readAll = new CategoryRead();
            List<Queries.CategoryCrud.Category> categories = readAll.ReadAllCategories();

            foreach (var item in categories)
            {
                dataGridView.Rows.Add(
                    item.CategoryID,
                    item.CategoryName,
                    item.CategoryDescription
                );
            }
        }

    }

}
