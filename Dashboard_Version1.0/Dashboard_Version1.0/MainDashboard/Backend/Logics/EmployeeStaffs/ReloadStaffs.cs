using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainDashboard.Backend.Queries.StaffCrud;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace MainDashboard.Backend.Logics.EmployeeStaffs.Reload
{
    public class ReloadEmployeeStaffs
    {
        public static void LoadEmployeeStaffData(DataGridView dataGridView)
        {

            if (dataGridView == null)
            {
                MessageBox.Show("Error: EmployeeGridView is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Clear existing rows before loading new data to prevent duplicates
            dataGridView.Rows.Clear();

            var staffList = new StaffRead().GetAllStaff();
            foreach (var staff in staffList)
            {
                dataGridView.Rows.Add(
                    //staff.StaffID,
                    staff.StaffName,
                    staff.StaffPosition,
                    staff.StaffEmail,
                    //staff.StaffDateOfBirth?.ToShortDateString() ?? "",
                    //staff.StaffAddress ?? "",
                    null,
                    null
                );
            }
        }
    }
}