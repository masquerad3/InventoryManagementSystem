using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MainDashboard.Backend.Logics.EmployeeStaffs.Reload
{
    public class ReloadEmployeeStaffs
    {
        // method to load unarchived inventory data into the DataGridView
        public static void LoadEmployeeStaffData(DataGridView dataGridView)
        {
            // Clear existing rows before loading new data to prevent duplicates
            dataGridView.Rows.Clear();

            /*
            
            // DO SOMETHING SIMILAR BUT FOR EMPLOYEE / STAFF
            
            var readAll = new CategoryRead();
            List<Queries.CategoryCrud.Category> categories = readAll.ReadAllCategories();

            foreach (var item in categories)
            {
                dataGridView.Rows.Add(
                    item.EmployeeName,
                    item.EmployeePosition,
                    item.EmployeeEmail
                );
            }

            */

        }

    }

}
