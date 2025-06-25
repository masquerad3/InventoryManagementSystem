using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

/*

CREATE TABLE Supplier (
    SupplierID INT IDENTITY(1,1) PRIMARY KEY,
    SupplierName NVARCHAR(100) NOT NULL,
    SupplierAddress NVARCHAR(200) NULL,
    SupplierContact NVARCHAR(20) NULL,
    SupplierEmail NVARCHAR(100) NULL,
);

*/

namespace MainDashboard.Backend.Queries.SupplierCrud
{
    // constructor here with and without ID
    public class Supplier
    {
        // PROPERTIES
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string? SupplierAddress { get; set; }
        public string? SupplierContact { get; set; }
        public string? SupplierEmail { get; set; }

        // Constructor WITHOUT ID (for INSERT operations)
        public Supplier(string supplierName, string? supplierAddress = null, string? supplierContact = null, string? supplierEmail = null)
        {
            SupplierName = supplierName;
            SupplierAddress = supplierAddress;
            SupplierContact = supplierContact;
            SupplierEmail = supplierEmail;
        }

        // Constructor WITH ID (for SELECT/UPDATE operations)
        public Supplier(int supplierID, string supplierName, string? supplierAddress = null, string? supplierContact = null, string? supplierEmail = null)
            : this(supplierName, supplierAddress, supplierContact, supplierEmail)
        {
            SupplierID = supplierID;
        }
    }

    public abstract class DatabaseConnection
    {
        // Centralized connection string
        // samuels string
        protected readonly string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=InventoryManagementSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        // Shared method to open a new connection
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }

    //basic read all
}
