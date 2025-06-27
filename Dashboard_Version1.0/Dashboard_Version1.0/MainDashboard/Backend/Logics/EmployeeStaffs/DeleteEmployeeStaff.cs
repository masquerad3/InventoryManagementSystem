using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace MainDashboard.Backend.Queries.StaffCrud
{
    
    public class StaffDelete : DatabaseConnectionForDeletion
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

    public class AuthDelete : DatabaseConnectionForDeletion
    {
        public bool DeleteAuthByStaffID(int staffId)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM Auth WHERE StaffID = @StaffID";

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
                MessageBox.Show($"Error deleting Auth credentials: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }

    public abstract class DatabaseConnectionForDeletion
    {
        // Centralized connection string
        protected readonly string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=InventoryManagementSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        // samuels string
        //protected readonly string connectionString = @"Data Source=DESKTOP-K3DB62P\SQLEXPRESS01;Initial Catalog=IMS;Integrated Security=True;Trust Server Certificate=True";

        // Shared method to open a new connection
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}