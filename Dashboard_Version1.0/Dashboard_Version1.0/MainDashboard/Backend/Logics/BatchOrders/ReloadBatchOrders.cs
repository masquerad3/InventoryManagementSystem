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
            dataGridView.Rows.Clear();

            var read = new BatchOrdersRead();
            var batches = read.ReadBatchOrderSummaries();

            foreach (var b in batches)
            {
                dataGridView.Rows.Add(
                    b.BatchOrdersID,
                    b.BatchName,
                    b.ProductNames, // this is the comma-separated list of product names
                    b.BatchOrderStatus,
                    b.BatchDateRequested.ToShortDateString(),
                    b.BatchDateReceived?.ToShortDateString() ?? "N/A"
                );
            }

        }

    }

}
