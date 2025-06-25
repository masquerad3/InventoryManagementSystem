using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

/*

CREATE TABLE Staff (
    StaffID INT IDENTITY(1,1) PRIMARY KEY,
    StaffName NVARCHAR(100) NOT NULL,
    --removed staff position/roles
    --add admin edit, employee view
    StaffPosition NVARCHAR(50) NOT NULL,
    StaffEmail NVARCHAR(50) NOT NULL,
    --removed password
    StaffDateOfBirth DATE NULL,
    StaffAddress NVARCHAR(200) NULL
);

*/

namespace MainDashboard.Backend.Queries.StaffCrud
{
    // constructor here with and without ID
    public class Staff
    {
        // PROPERTIES
        public int StaffID { get; set; }
        public string StaffName { get; set; }
        public string StaffPosition { get; set; } // e.g., "Admin", "Employee"
        public string StaffEmail { get; set; }
        // This shouldn't be stored in the Staff table - it goes in Auth table
        // NOTE: We're keeping this property just for parameter passing
        public string StaffPassword { get; set; }
        public DateTime? StaffDateOfBirth { get; set; }
        public string? StaffAddress { get; set; }

        // Constructor WITHOUT ID (for INSERT operations)
        public Staff(string staffName, string staffPosition, string staffEmail, string staffPassword = null, DateTime? staffDateOfBirth = null, string? staffAddress = null)
        {
            StaffName = staffName;
            StaffPosition = staffPosition;
            StaffEmail = staffEmail;
            StaffPassword = staffPassword;
            StaffDateOfBirth = staffDateOfBirth;
            StaffAddress = staffAddress;
        }

        // Constructor WITH ID (for SELECT/UPDATE operations)
        public Staff(int staffID, string staffName, string staffPosition, string staffEmail, string staffPassword = null, DateTime? staffDateOfBirth = null, string? staffAddress = null)
            : this(staffName, staffPosition, staffEmail, staffPassword, staffDateOfBirth, staffAddress)
        {
            StaffID = staffID;
        }
    }
    public class StaffCrud : DatabaseConnection
    {
        // Add a new staff member and return the new StaffID
        public int AddStaff(Staff staff)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand(
                        "INSERT INTO Staff (StaffName, StaffPosition, StaffEmail, StaffDateOfBirth, StaffAddress) " +
                        "OUTPUT INSERTED.StaffID " +
                        "VALUES (@Name, @Position, @Email, @DOB, @Address)", conn);

                    cmd.Parameters.AddWithValue("@Name", staff.StaffName);
                    cmd.Parameters.AddWithValue("@Position", staff.StaffPosition);
                    cmd.Parameters.AddWithValue("@Email", staff.StaffEmail);
                    cmd.Parameters.AddWithValue("@DOB", (object?)staff.StaffDateOfBirth ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Address", (object?)staff.StaffAddress ?? DBNull.Value);

                    return (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding staff: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Return -1 to indicate failure
                return -1;
            }
        }
        // Check if an email is already in use
        public bool IsEmailInUse(string email)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT COUNT(*) FROM Staff WHERE StaffEmail = @Email", conn);
                cmd.Parameters.AddWithValue("@Email", email);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        // Get staff ID by email (for login)
        public int? GetStaffIdByEmail(string email)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT StaffID FROM Staff WHERE StaffEmail = @Email", conn);
                cmd.Parameters.AddWithValue("@Email", email);

                var result = cmd.ExecuteScalar();
                return result != null ? (int?)result : null;
            }
        }
        public Staff GetStaffById(int staffId)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "SELECT StaffID, StaffName, StaffPosition, StaffEmail, StaffDateOfBirth, StaffAddress " +
                    "FROM Staff WHERE StaffID = @StaffID", conn);
                cmd.Parameters.AddWithValue("@StaffID", staffId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Staff(
                            reader.GetInt32(0),                                 // StaffID
                            reader.GetString(1),                                // StaffName
                            reader.GetString(2),                                // StaffPosition
                            reader.GetString(3),                                // StaffEmail
                            null,                                               // StaffPassword (not stored in table)
                            reader.IsDBNull(4) ? null : reader.GetDateTime(4),  // StaffDateOfBirth
                            reader.IsDBNull(5) ? null : reader.GetString(5)     // StaffAddress
                        );
                    }
                    return null;
                }
            }
        }
    }

    public class StaffRead : DatabaseConnection
    {
        //read all
        public List<Staff> GetAllStaff()
>>>>>>> Stashed changes
        {
            var staffList = new List<Staff>();

            using (var conn = GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "SELECT StaffID, StaffName, StaffPosition, StaffEmail, StaffDateOfBirth, StaffAddress " +
                    "FROM Staff", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        staffList.Add(new Staff(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            null,
                            reader.IsDBNull(4) ? null : reader.GetDateTime(4),
                            reader.IsDBNull(5) ? null : reader.GetString(5)
                        ));
                    }
                }
            }

            return staffList;
        }


    }

    //basic read all


    public abstract class DatabaseConnection
    {
        // Centralized connection string
        //protected readonly string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=InventoryManagementSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        // samuels string
        protected readonly string connectionString = @"Data Source=DESKTOP-K3DB62P\SQLEXPRESS01;Initial Catalog=IMS;Integrated Security=True;Trust Server Certificate=True";
        
        // Shared method to open a new connection
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
