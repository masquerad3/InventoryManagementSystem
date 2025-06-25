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
    StaffPassword NVARCHAR(50) NOT NULL,
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
        public string StaffPassword { get; set; }
        public DateTime? StaffDateOfBirth { get; set; }
        public string? StaffAddress { get; set; }

        // Constructor WITHOUT ID (for INSERT operations)
        public Staff(string staffName, string staffPosition, string staffEmail, string staffPassword, DateTime? staffDateOfBirth = null, string? staffAddress = null)
        {
            StaffName = staffName;
            StaffPosition = staffPosition;
            StaffEmail = staffEmail;
            StaffPassword = staffPassword;
            StaffDateOfBirth = staffDateOfBirth;
            StaffAddress = staffAddress;
        }

        // Constructor WITH ID (for SELECT/UPDATE operations)
        public Staff(int staffID, string staffName, string staffPosition, string staffEmail, string staffPassword, DateTime? staffDateOfBirth = null, string? staffAddress = null)
            : this(staffName, staffPosition, staffEmail, staffPassword, staffDateOfBirth, staffAddress)
        {
            StaffID = staffID;
        }
    }

    public abstract class DatabaseConnection
    {
        // Centralized connection string
        // samuels string
        protected readonly string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=InventoryManagementSystem;Integrated Security=True;Trust Server Certificate=True";

        // Shared method to open a new connection
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }

    //basic read all

}
