
using MainDashboard.Backend.Logics.BatchOrders.Reload;
using MainDashboard.Backend.Queries.BatchOrdersCrud;
using MainDashboard.Backend.Queries.ProductsCrud;
using MainDashboard.Frontend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatchOrderForm = MainDashboard.Frontend.BatchOrders.BatchOrder;

namespace MainDashboard
{
    public partial class Batch : UserControl
    {

        public Batch()
        {
            InitializeComponent();

            // load the data to the table
            ReloadBatchOrders.LoadBatchOrdersData(BatchOrdersGridView);
        }

        private void BatchOrdersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Only process if it's a valid row
            if (e.RowIndex < 0) return;

            // Only process clicks on image columns
            if (!(BatchOrdersGridView.Columns[e.ColumnIndex] is DataGridViewImageColumn)) return;

            string clickedColumnName = BatchOrdersGridView.Columns[e.ColumnIndex].Name;
            DataGridViewRow selectedRow = BatchOrdersGridView.Rows[e.RowIndex];
            string batchOrderName = selectedRow.Cells["BatchOrderName"].Value?.ToString()?.Trim() ?? "";

            var batchOrderRead = new ReadBatchOrders();
            int batchOrderId = batchOrderRead.GetBatchOrderIdByName(batchOrderName);

            if (clickedColumnName == "Edit")
            {
                if (batchOrderId != -1)
                {
                    var batchOrderForm = new BatchOrderForm("Edit", BatchOrdersGridView, batchOrderId);
                    batchOrderForm.Show();
                }
                else
                {
                    MessageBox.Show("Batch order not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (clickedColumnName == "Delete")
            {
                if (batchOrderId != -1)
                {
                    var confirmForm = new DeletionTemplate(
                        "BatchOrder",
                        batchOrderId,
                        batchOrderName,
                        BatchOrdersGridView
                    );
                    confirmForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Product not found.");
                }

            }
            else
            {
                MessageBox.Show("Batch Order not found.");
            }

        }
        //end of data cell rid view cell content click event

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var batchOrderForm = new BatchOrderForm("Add", BatchOrdersGridView);
            batchOrderForm.Show();

        }

    }
}
