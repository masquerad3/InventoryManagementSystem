using System;
using System.Windows.Forms;

namespace EmployeeDragDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Define the columns manually
            dataGridView1.Rows.Add("Samuel Muralidharan", "Emp005", "Inventory Manager", "Available");
            dataGridView1.Rows.Add("Steven Masangcay", "Emp004", "Warehouse Supervisor", "Available");
            dataGridView1.Rows.Add("Mireyla Coronado", "Emp003", "Inventory Analyst", "Available");
            dataGridView1.Rows.Add("Maverick Ko", "Emp002", "Stock Clerk", "Suspended");
            dataGridView1.Rows.Add("Ahron Embudo", "Emp001", "Data Entry Clerk", "Available");
            dataGridView1.Rows.Add("Claire Ulgasan", "Emp006", "Quality Control Inspector", "On Leave");
        }

        private void btnAddEmployee_Click_1(object sender, EventArgs e)
        {
            var addForm = new AddEmployeeForm();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                string name = addForm.EmployeeName;
                string id = addForm.EmployeeID;
                string position = addForm.Position;

                // Add new row to DataGridView
                dataGridView1.Rows.Add(name, id, position, "Available");

                // feedback
                MessageBox.Show("Employee added successfully!", "Success");
            }
        }
    
        private void btnFilterEmployee_Click_1(object sender, EventArgs e)
        {
            FilterEmployeeForm filterForm = new FilterEmployeeForm();

            if (filterForm.ShowDialog() == DialogResult.OK)
            {
                string statusFilter = filterForm.SelectedStatus;
                List<string> positionFilters = filterForm.SelectedPositions;

                // Example: Loop over DataGridView and hide rows that don't match
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    string status = row.Cells[3].Value?.ToString();     // Status column
                    string position = row.Cells[2].Value?.ToString();   // Position column

                    bool matchesStatus = (statusFilter == "All" || status == statusFilter);
                    bool matchesPosition = (positionFilters.Count == 0 || positionFilters.Contains(position));

                    row.Visible = matchesStatus && matchesPosition;
                }
            }
        }
    }
}
