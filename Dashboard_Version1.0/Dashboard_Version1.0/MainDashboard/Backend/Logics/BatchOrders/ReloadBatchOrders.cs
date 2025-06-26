using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MainDashboard.Backend.Queries.BatchOrdersCrud;

namespace MainDashboard.Backend.Logics.BatchOrders.Reload
{
    public class ReloadBatchOrders
    {
        // method to load unarchived inventory data into the DataGridView
        public static void LoadBatchOrdersData(DataGridView dataGridView)
        {
            if (dataGridView == null)
            {
                MessageBox.Show("Error: BatchOrderGridView is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridView.Rows.Clear();

            var read = new ReadBatchOrders();
            var batches = read.ReadAllBatchOrders();

            foreach (var b in batches)
            {
                var productNamesList = read.GetProductNamesByBatchOrderId(b.BatchOrdersID);

                // Format: comma-separated, newline after every 2 items
                StringBuilder formatted = new StringBuilder();
                for (int i = 0; i < productNamesList.Count; i++)
                {
                    formatted.Append(productNamesList[i]);

                    if (i < productNamesList.Count - 1)
                        formatted.Append(", ");

                    if ((i + 1) % 2 == 0 && i < productNamesList.Count - 1)
                        formatted.AppendLine();  // insert newline after every 2 items
                }


                // Add row with multiline product names
                dataGridView.Rows.Add(
                    b.BatchName,
                    formatted.ToString(),
                    b.BatchOrderStatus,
                    b.BatchDateRequested.ToShortDateString(),
                    // logic for date received
                    b.BatchDateReceived?.ToShortDateString() ?? "Not Yet Received",
                    null,
                    null
                );
            }

        }

    }

}
