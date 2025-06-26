using CuoreUI.Controls;
using MainDashboard.Backend.Logics.BatchOrders.Reload;
using MainDashboard.Backend.Logics.Inventory.Reload;
using MainDashboard.Backend.Queries.BatchOrdersCrud;
using MainDashboard.Backend.Queries.ProductsCrud;
using MainDashboard.Frontend.BatchOrders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainDashboard.Frontend
{
    public partial class DeletionTemplate : Form
    {
        private string value;
        private DataGridView _targetDataGridView;

        private int? variableId;
        private string? variableName;

        //constructor for product
        public DeletionTemplate(
            string value,
            int variableId,
            string variableName,
            DataGridView dgv
            )
        {
            InitializeComponent();

            this.value = value;
            this.variableId = variableId;
            this.variableName = variableName;
            _targetDataGridView = dgv;

            if (value == "Product")
            {
                // Product-specific labeling
                DeleteHeaderLabel.Content = "Confirm Product Deletion";
                DeleteSubHeaderLabel.Content = "Are you sure you want to delete this product?";

                VariableIDLabel.Content = "Product ID:";
                VariableIDContentHolder.Content = variableId.ToString();

                VariableNameLabel.Content = "Product Name:";
                VariableNameContentHolder.Content = variableName;
            }
            else if (value == "BatchOrder")
            {
                // Batch order-specific labeling
                DeleteHeaderLabel.Content = "Confirm Batch Order Deletion";
                DeleteSubHeaderLabel.Content = "Are you sure you want to delete this batch order?";

                VariableIDLabel.Content = "Batch Order ID:";
                VariableIDContentHolder.Content = variableId.ToString();

                VariableNameLabel.Content = "Batch Order Name:";
                VariableNameContentHolder.Content = variableName;
            }
            else
            {
                // fallback display
                DeleteHeaderLabel.Content = "Deletion Error";
                DeleteSubHeaderLabel.Content = "Please click Cancel.";
                ConfirmBtn.Visible = false;
            }

        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (value == "Product")
            {
                ProductDelete deleteHandler = new ProductDelete();
                bool deletingProductSuccess = deleteHandler.DeleteProductByID(variableId.Value);

                if (deletingProductSuccess)
                {
                    MessageBox.Show("Successfully deleted the product.", "Deletion Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadProducts.LoadProductsData(_targetDataGridView);
                }
                else
                {
                    MessageBox.Show("Failed to delete the product. Check Error Logs.", "Deletion Window", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (value == "BatchOrder")
            {
                BatchOrderDelete deleteHandler = new BatchOrderDelete();
                bool deletingBatchOrderSuccess = deleteHandler.DeleteBatchOrderAndProducts(variableId.Value);

                if (deletingBatchOrderSuccess)
                {
                    MessageBox.Show("Successfully deleted the batch order.", "Deletion Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadBatchOrders.LoadBatchOrdersData(_targetDataGridView);
                }
                else
                {
                    MessageBox.Show("Failed to delete the batch order. Check Error Logs.", "Deletion Window", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
