using MainDashboard.Backend.Logics.Inventory.Reload;
using MainDashboard.Backend.Queries.ProductsCrud;
using MainDashboard.Frontend.EmployeeStaff;
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
    public partial class Employee : UserControl
    {
        private ManageEmployeeStaff manageEmployeeStaff = null;

        public Employee()
        {
            InitializeComponent();

            /*

            // CALL READ HERE

            ReloadProducts.LoadProductsData(InventoryGridView);

            */

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            // UPDATE THIS
            var addEmployeeForm = new ManageEmployeeStaff("Add", EmployeeStaffGridView);
            addEmployeeForm.Show();

        }

        private void EmployeeStaffGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Only process if it's a valid row
            if (e.RowIndex < 0) return;

            // Only process clicks on image columns
            if (!(EmployeeStaffGridView.Columns[e.ColumnIndex] is DataGridViewImageColumn)) return;

            string clickedColumnName = EmployeeStaffGridView.Columns[e.ColumnIndex].Name;
            DataGridViewRow selectedRow = EmployeeStaffGridView.Rows[e.RowIndex];
            string employeeName = selectedRow.Cells["EmployeeName"].Value?.ToString()?.Trim() ?? "";

            /*
            
            // DO SOMETHING SIMILAR
            
            var productRead = new ProductRead();
            int? productId = productRead.GetProductIDByName(employeeName );
            
            //

            if (clickedColumnName == "Edit")
            {
                if (productId != null)
                {
                    var editEmployeeForm = new ManageEmployeeStaff("Edit", EmployeeStaffGridView, empId.Value, "admin");
                    editEmployeeForm.Show();

                }
                else
                {
                    MessageBox.Show("Employee not found.");
                }

            }
            else if (clickedColumnName == "Delete")
            {
                if (productId != null)
                {
                    // Confirmation message box with item ID and name
                    DialogResult confirmResult = MessageBox.Show(
                        $"Are you sure you want to delete this account?\n\n   Employee ID : {empId}\n   Employee Name : {productName}",
                        "Confirm Deletion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (confirmResult == DialogResult.Yes)
                    {
                        /*
                        
                        DO SOMETHING SIMILAR BUT FOR EMPLOYEE STAFF

                        ProductDelete deleteHandler = new ProductDelete();
                        bool deletingProductSuccess = deleteHandler.DeleteProductByID(productId);

                        if (deletingProductSuccess)
                        {
                            MessageBox.Show("Successfully deleted the item.", "Deletion Window", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // --- Reload DataGridView ---
                            if (EmployeeStaffGridView != null)
                            {
                                ReloadProducts.LoadProductsData(EmployeeStaffGridView);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the item. Check Error Logs.", "Deletion Window", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        

        

    
                else
                {
                    MessageBox.Show("Employee not found.");
                }



            }
            */

        }


    }
}
