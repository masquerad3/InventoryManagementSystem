using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace MainDashboard.Backend.Queries.StaffCrud
{
    public class StaffDelete : DatabaseConnection
    {
        public bool DeleteStaffByID(int staffId)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM Staff WHERE StaffID = @StaffID";

                    using (var command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@StaffID", staffId);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting staff: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}