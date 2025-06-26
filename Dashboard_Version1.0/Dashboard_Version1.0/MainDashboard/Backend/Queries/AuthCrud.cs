using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

/*

CREATE TABLE Auth (
    AuthID INT IDENTITY(1,1) PRIMARY KEY,
    StaffID INT NOT NULL,  -- FK to Staff table
    PasswordHash NVARCHAR(255) NOT NULL, -- store hashed passwords, not plain text
    FOREIGN KEY (StaffID) REFERENCES Staff(StaffID)
);

*/

namespace MainDashboard.Backend.Queries.AuthCrud
{
    // Change from internal to public to allow access from Login_Version1.0 project
    public class AuthCrud : DatabaseConnection
    {
        // Register: Add a new user with hashed password
        public bool Register(int staffId, string password)
        {
            string passwordHash = ComputeSha256Hash(password);

            using (var conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    var cmd = new SqlCommand(
                        "INSERT INTO Auth (StaffID, PasswordHash) VALUES (@StaffID, @PasswordHash)", conn);
                    cmd.Parameters.AddWithValue("@StaffID", staffId);
                    cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Registration error: {ex.Message}", "Database Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        // Login: Verify user credentials
        public bool Verify(int staffId, string password)
        {
            string passwordHash = ComputeSha256Hash(password);

            using (var conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    var cmd = new SqlCommand(
                        "SELECT COUNT(*) FROM Auth WHERE StaffID = @StaffID AND PasswordHash = @PasswordHash", conn);
                    cmd.Parameters.AddWithValue("@StaffID", staffId);
                    cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Verification error: {ex.Message}", "Database Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        // Hashing helper
        private static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }
    }

    public abstract class DatabaseConnection
    {
        // Centralized connection string
        //remos string
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
