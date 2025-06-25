using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

/*

--previously named Batch / batches but is too vague
CREATE TABLE BatchOrders (
    BatchOrdersID INT IDENTITY(1,1) PRIMARY KEY,
    BatchName NVARCHAR(25) NOT NULL,
    BatchOrderStatus VARCHAR(50) DEFAULT 'Pending', --Pending, Approved, Denied
    BatchDescription NVARCHAR(100) NULL,
    BatchDateRequested DATETIME DEFAULT GETDATE(),
    BatchDateReceived DATETIME NULL DEFAULT GETDATE()
);

CREATE TABLE BatchOrderProducts (
    BatchOrdersID INT NOT NULL,      -- changed from VARCHAR(4) to INT
    ProductID INT NOT NULL,
    PRIMARY KEY (BatchOrdersID, ProductID),
    FOREIGN KEY (BatchOrdersID) REFERENCES BatchOrders(BatchOrdersID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

//table creation with no FK
-- Create BatchOrders table (with IDENTITY PK)
CREATE TABLE BatchOrders (
    BatchOrdersID INT IDENTITY(1,1) PRIMARY KEY,
    BatchName NVARCHAR(25) NOT NULL,
    BatchOrderStatus VARCHAR(50) DEFAULT 'Pending',
    BatchDescription NVARCHAR(100) NULL,
    BatchDateRequested DATETIME DEFAULT GETDATE(),
    BatchDateReceived DATETIME NULL DEFAULT GETDATE()
);

-- Create BatchOrderProducts junction table WITHOUT foreign keys
CREATE TABLE BatchOrderProducts (
    BatchOrdersID INT NOT NULL,
    ProductID INT NOT NULL,
    PRIMARY KEY (BatchOrdersID, ProductID)
);

//altering of table adding of FK
-- Add FK from BatchOrderProducts → BatchOrders
ALTER TABLE BatchOrderProducts
ADD FOREIGN KEY (BatchOrdersID) REFERENCES BatchOrders(BatchOrdersID);

-- Add FK from BatchOrderProducts → Products
ALTER TABLE BatchOrderProducts
ADD FOREIGN KEY (ProductID) REFERENCES Products(ProductID);

*/

namespace MainDashboard.Backend.Queries.BatchOrdersCrud
{
    // constructor here with and without ID
    public class BatchOrder
    {
        public string BatchOrdersID { get; set; }
        public string BatchName { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string BatchOrderStatus { get; set; }
        public string? BatchDescription { get; set; }
        public DateTime BatchDateRequested { get; set; }
        public DateTime? BatchDateReceived { get; set; } // <- now nullable

        // Constructor WITHOUT ID (for INSERT)
        public BatchOrder(
            string batchName,
            int productID,
            string productName,
            string batchOrderStatus = "Processed",
            string? batchDescription = null,
            DateTime? batchDateRequested = null,
            DateTime? batchDateReceived = null)
        {
            BatchName = batchName;
            ProductID = productID;
            ProductName = productName;
            BatchOrderStatus = batchOrderStatus;
            BatchDescription = batchDescription;
            BatchDateRequested = batchDateRequested ?? DateTime.Now;
            BatchDateReceived = batchDateReceived; // can remain null
        }

        // Constructor WITH ID (for SELECT/UPDATE)
        public BatchOrder(
            string batchOrdersID,
            string batchName,
            int productID,
            string productName,
            string batchOrderStatus = "Processed",
            string? batchDescription = null,
            DateTime? batchDateRequested = null,
            DateTime? batchDateReceived = null)
            : this(batchName, productID, productName, batchOrderStatus, batchDescription, batchDateRequested, batchDateReceived)
        {
            BatchOrdersID = batchOrdersID;
        }
    }

    //constructor for viewing
    public class BatchOrderSummary
    {
        public int BatchOrdersID { get; set; }
        public string BatchName { get; set; }
        public string ProductNames { get; set; } // Comma-separated list
        public string BatchOrderStatus { get; set; }
        public DateTime BatchDateRequested { get; set; }
        public DateTime? BatchDateReceived { get; set; }

        public BatchOrderSummary(
            int batchOrdersID,
            string batchName,
            string productNames,
            string batchOrderStatus,
            DateTime batchDateRequested,
            DateTime? batchDateReceived)
        {
            BatchOrdersID = batchOrdersID;
            BatchName = batchName;
            ProductNames = productNames;
            BatchOrderStatus = batchOrderStatus;
            BatchDateRequested = batchDateRequested;
            BatchDateReceived = batchDateReceived;
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

    // CRUD STARTS HERE

    //basic read all
    public class BatchOrdersRead : DatabaseConnection
    {
        public List<BatchOrder> ReadAllBatchOrders()
        {
            var batchOrders = new List<BatchOrder>();

            using (SqlConnection connection = GetConnection())
            {
                string query = @"
                SELECT 
                    bo.BatchOrdersID,
                    bo.BatchName,
                    bp.ProductID,
                    p.ProductName,
                    bo.BatchOrderStatus,
                    bo.BatchDescription,
                    bo.BatchDateRequested,
                    bo.BatchDateReceived
                FROM BatchOrders bo
                INNER JOIN BatchOrderProducts bp ON bo.BatchOrdersID = bp.BatchOrdersID
                INNER JOIN Products p ON bp.ProductID = p.ProductID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string batchId = reader.GetString(0);
                            string batchName = reader.GetString(1);
                            int productId = reader.GetInt32(2);
                            string productName = reader.GetString(3);
                            string batchStatus = reader.GetString(4);
                            string? batchDesc = reader.IsDBNull(5) ? null : reader.GetString(6);
                            DateTime requested = reader.GetDateTime(6);
                            DateTime received = reader.GetDateTime(7);

                            batchOrders.Add(new BatchOrder(
                                batchId, batchName, productId, productName,
                                batchStatus,
                                batchDesc, requested, received
                            ));
                        }
                    }
                }
            }

            return batchOrders;
        }   // end of read all batch orders

        //read summary for viewing
        public List<BatchOrderSummary> ReadBatchOrderSummaries()
        {
            var summaries = new List<BatchOrderSummary>();

            using (SqlConnection connection = GetConnection())
            {
                string query = @"
            SELECT 
                bo.BatchOrdersID,
                bo.BatchName,
                STRING_AGG(p.ProductName, ', ') AS ProductNames,
                bo.BatchOrderStatus,
                bo.BatchDateRequested,
                bo.BatchDateReceived
            FROM BatchOrders bo
            INNER JOIN BatchOrderProducts bop ON bo.BatchOrdersID = bop.BatchOrdersID
            INNER JOIN Products p ON bop.ProductID = p.ProductID
            GROUP BY 
                bo.BatchOrdersID,
                bo.BatchName,
                bo.BatchOrderStatus,
                bo.BatchDateRequested,
                bo.BatchDateReceived";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            summaries.Add(new BatchOrderSummary(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3),
                                reader.GetDateTime(4),
                                reader.IsDBNull(5) ? null : reader.GetDateTime(5)
                            ));
                        }
                    }
                }
            }

            return summaries;
        }

    }

}
