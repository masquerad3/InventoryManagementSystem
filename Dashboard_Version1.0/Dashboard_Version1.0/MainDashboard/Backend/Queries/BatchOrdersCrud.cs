using System;
using System.Collections.Generic;
using System.Linq; // Added for .Select() and .Any()
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient; // Ensure this is the correct namespace for SqlConnection

using MainDashboard.Backend.Logics.BatchOrders.ModelOfGridItem; // Ensure this points to your single GridItem definition

/*

--previously named Batch / batches but is too vague
--UPDATED

CREATE TABLE BatchOrders (
    BatchOrderID INT IDENTITY(1,1) PRIMARY KEY,
    BatchName NVARCHAR(25) NOT NULL,
    BatchOrderStatus VARCHAR(50) DEFAULT 'Pending', --Pending, Approved, Denied
    BatchDescription NVARCHAR(100) NULL,
    BatchDateRequested DATETIME DEFAULT GETDATE(),
    BatchDateReceived DATETIME NULL
);

--added product quantity
CREATE TABLE BatchOrderProducts (
    BatchOrderID INT NOT NULL,
    ProductName NVARCHAR(75) NOT NULL,
    ProductQuantity INT NOT NULL, -- Confirmed this is the column name
    PRIMARY KEY (BatchOrderID, ProductName),
    FOREIGN KEY (BatchOrderID) REFERENCES BatchOrders(BatchOrderID)
);

*/

namespace MainDashboard.Backend.Queries.BatchOrdersCrud
{
    // constructor here with and without ID
    public class BatchOrder
    {
        public int BatchOrderID { get; set; }
        public string BatchName { get; set; }
        public string BatchOrderStatus { get; set; } = "Pending"; // Default value
        public string? BatchDescription { get; set; }
        public DateTime BatchDateRequested { get; set; } = DateTime.Now; // Default GETDATE()
        public DateTime? BatchDateReceived { get; set; }

        // Constructor without ID (for insertion)
        public BatchOrder(string batchName, string? batchDescription = null)
        {
            BatchName = batchName;
            BatchDescription = batchDescription;
        }

        // Constructor with ID (for reading from DB)
        public BatchOrder(int batchOrderId, string batchName, string batchOrderStatus, string? batchDescription, DateTime batchDateRequested, DateTime? batchDateReceived)
        {
            BatchOrderID = batchOrderId;
            BatchName = batchName;
            BatchOrderStatus = batchOrderStatus;
            BatchDescription = batchDescription;
            BatchDateRequested = batchDateRequested;
            BatchDateReceived = batchDateReceived;
        }
    }

    //constructor for viewing
    public class BatchOrderSummary
    {
        public int BatchOrdersID { get; set; }
        public string BatchName { get; set; }
        public string BatchOrderStatus { get; set; }
        public string BatchDescription { get; set; } // Added BatchDescription property
        public DateTime BatchDateRequested { get; set; }
        public DateTime? BatchDateReceived { get; set; }

        // NEW: List of product + quantity
        public List<BatchOrderProduct> Products { get; set; } = new List<BatchOrderProduct>();

        public BatchOrderSummary() { }

        // UPDATED: Constructor signature to match properties and remove redundant productQuality
        public BatchOrderSummary(
            int batchOrdersID,
            string batchName,
            string batchOrderStatus,
            string batchDescription, // UPDATED: Added BatchDescription
            DateTime batchDateRequested,
            DateTime? batchDateReceived,
            List<BatchOrderProduct> products) // UPDATED: Corrected parameter for products
        {
            BatchOrdersID = batchOrdersID;
            BatchName = batchName;
            BatchOrderStatus = batchOrderStatus;
            BatchDescription = batchDescription; // UPDATED: Assigned BatchDescription
            BatchDateRequested = batchDateRequested;
            BatchDateReceived = batchDateReceived;
            Products = products;
        }
    }

    public class BatchOrderProduct
    {
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }

        public BatchOrderProduct(string productName, int productQuantity)
        {
            ProductName = productName;
            ProductQuantity = productQuantity;
        }

    }

    public abstract class DatabaseConnection
    {
        // Centralized connection string
        // samuels string
        protected readonly string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=InventoryManagementSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        //protected readonly string connectionString = @"Data Source=DESKTOP-K3DB62P\SQLEXPRESS01;Initial Catalog=IMS;Integrated Security=True;Trust Server Certificate=True";
        // Shared method to open a new connection
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }

    // CRUD STARTS HERE

    //basic read all
    public class ReadBatchOrders : DatabaseConnection
    {
        //read all for reloading of datas in gridview
        public List<BatchOrderSummary> ReadAllBatchOrders()
        {
            var results = new List<BatchOrderSummary>();

            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    // UPDATED: Added BatchDescription to the SELECT query
                    string query = @"SELECT BatchOrderID, BatchName, BatchOrderStatus, BatchDescription, BatchDateRequested, BatchDateReceived
                                     FROM BatchOrders";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int batchId = reader.GetInt32(0);
                            string batchName = reader.GetString(1);
                            string status = reader.GetString(2);
                            string batchDescription = reader.IsDBNull(3) ? string.Empty : reader.GetString(3); // UPDATED: Read BatchDescription
                            DateTime dateRequested = reader.GetDateTime(4); // UPDATED: Index changed
                            DateTime? dateReceived = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5); // UPDATED: Index changed

                            // UPDATED: Get products with quantities for this batch order
                            List<BatchOrderProduct> products = GetProductsWithQuantitiesByBatchOrderId(batchId);

                            // UPDATED: Use constructor correctly with all parameters
                            results.Add(new BatchOrderSummary(
                                batchId,
                                batchName,
                                status,
                                batchDescription, // UPDATED: Pass BatchDescription
                                dateRequested,
                                dateReceived,
                                products // UPDATED: Pass List<BatchOrderProduct>
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading batch orders:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return results;
        }

        public List<string> GetProductNamesByBatchOrderId(int batchOrderId)
        {
            List<string> productNames = new List<string>();

            try
            {
                using (SqlConnection connection = GetConnection()) // Uses the GetConnection() method
                {
                    // SIMPLIFIED QUERY: Directly selecting ProductName from BatchOrderProducts
                    // This assumes BatchOrderProducts table has a ProductName column.
                    string query = @"
                        SELECT ProductName
                        FROM BatchOrderProducts
                        WHERE BatchOrderID = @BatchOrderID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BatchOrderID", batchOrderId);

                        connection.Open(); // Open the connection
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Assuming ProductName is a string column in BatchOrderProducts
                                if (reader["ProductName"] != DBNull.Value)
                                {
                                    productNames.Add(reader["ProductName"].ToString());
                                }
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine($"SQL Error in GetProductNamesByBatchOrderId: {ex.Message}");
                MessageBox.Show($"A database error occurred while retrieving product names: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"General Error in GetProductNamesByBatchOrderId: {ex.Message}");
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return productNames;
        }

        // UPDATED: Renamed method and changed return type to List<BatchOrderProduct>
        public List<BatchOrderProduct> GetProductsWithQuantitiesByBatchOrderId(int batchOrderId)
        {
            var products = new List<BatchOrderProduct>();

            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    // UPDATED: Select ProductName AND ProductQuantity
                    string query = @"SELECT ProductName, ProductQuantity FROM BatchOrderProducts WHERE BatchOrderID = @BatchOrderID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BatchOrderID", batchOrderId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string productName = reader.GetString(0);
                                int productQuantity = reader.GetInt32(1); // UPDATED: Read ProductQuantity
                                products.Add(new BatchOrderProduct(productName, productQuantity)); // UPDATED: Create BatchOrderProduct object
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product names and quantities:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return products;
        }

        // Returns BatchName and BatchDescription by BatchOrderID
        public (string BatchName, string? BatchDescription)? GetBatchOrderById(int batchOrderId)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string query = "SELECT BatchName, BatchDescription FROM BatchOrders WHERE BatchOrderID = @BatchOrderID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BatchOrderID", batchOrderId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string name = reader.GetString(0);
                                string? description = reader.IsDBNull(1) ? null : reader.GetString(1);
                                return (name, description);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching batch order details:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        // Returns a list of selected product names for a given BatchOrderID
        // NOTE: This method now only gets product names. If you need quantities, use GetProductsWithQuantitiesByBatchOrderId.
        public List<string> GetProductsByBatchOrderId(int batchOrderId)
        {
            var selectedProducts = new List<string>();

            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string query = "SELECT ProductName FROM BatchOrderProducts WHERE BatchOrderID = @BatchOrderID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BatchOrderID", batchOrderId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                selectedProducts.Add(reader.GetString(0));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching selected products:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return selectedProducts;
        }

        public int GetBatchOrderIdByName(string batchOrderName)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();

                    string selectQuery = "SELECT BatchOrderID FROM BatchOrders WHERE BatchName = @BatchName";

                    using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@BatchName", batchOrderName);

                        object result = cmd.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving Batch Order ID:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public bool IsBatchDateReceivedNull(int batchOrderId)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT CASE
                            WHEN BatchDateReceived IS NULL THEN 1
                            ELSE 0
                        END
                        FROM BatchOrders
                        WHERE BatchOrderID = @BatchOrderID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BatchOrderID", batchOrderId);

                        object result = cmd.ExecuteScalar();
                        return Convert.ToInt32(result) == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking BatchDateReceived:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // default to false if error
            }
        }

    }
    // end of read

    // creation / add here
    public class CreateBatchOrders : DatabaseConnection
    {
        public bool InsertBatchOrder(string batchOrderName, string batchOrderDescription)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();

                    string insertQuery = @"
                    INSERT INTO BatchOrders (BatchName, BatchDescription)
                    VALUES (@BatchName, @BatchDescription);";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@BatchName", batchOrderName);
                        cmd.Parameters.AddWithValue("@BatchDescription",
                            string.IsNullOrWhiteSpace(batchOrderDescription) ? DBNull.Value : (object)batchOrderDescription);

                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting Batch Order:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool AddProductsToBatchOrder(int batchOrderId, List<MainDashboard.Backend.Logics.BatchOrders.ModelOfGridItem.GridItem> productsWithQuantities)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // UPDATED: Corrected column name to ProductQuantity in INSERT statement
                            string insertProductQuery = @"
                            INSERT INTO BatchOrderProducts (BatchOrderID, ProductName, ProductQuantity)
                            VALUES (@BatchOrderID, @ProductName, @ProductQuantity);";

                            foreach (MainDashboard.Backend.Logics.BatchOrders.ModelOfGridItem.GridItem product in productsWithQuantities) // Ensure fully qualified name or using statement
                            {
                                SqlCommand cmd = new SqlCommand(insertProductQuery, conn, transaction);
                                cmd.Parameters.AddWithValue("@BatchOrderID", batchOrderId);
                                cmd.Parameters.AddWithValue("@ProductName", product.ItemName);
                                cmd.Parameters.AddWithValue("@ProductQuantity", product.Quantity); // Parameter name matches @ProductQuantity
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Error inserting batch products:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            // Log the exception details here if you have a logging mechanism
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Log the exception details here if you have a logging mechanism
                return false;
            }
        }

    }
    // end of creation

    // edit / update
    public class UpdateBatchOrders : DatabaseConnection
    {
        public bool UpdateBatchOrder(
            int batchOrderId,
            string batchOrderName,
            string batchOrderDescription)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();

                    string updateQuery = @"
                        UPDATE BatchOrders
                        SET BatchName = @BatchName,
                            BatchDescription = @BatchDescription
                        WHERE BatchOrderID = @BatchOrderID;";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@BatchOrderID", batchOrderId);
                        cmd.Parameters.AddWithValue("@BatchName", batchOrderName);
                        cmd.Parameters.AddWithValue("@BatchDescription",
                            string.IsNullOrWhiteSpace(batchOrderDescription) ? DBNull.Value : (object)batchOrderDescription);

                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating Batch Order:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateBatchOrderProducts(int batchOrderId, List<MainDashboard.Backend.Logics.BatchOrders.ModelOfGridItem.GridItem> productsWithQuantities) // Parameter type already updated
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // 1. Delete all existing products for this BatchOrderID
                            string deleteQuery = "DELETE FROM BatchOrderProducts WHERE BatchOrderID = @BatchOrderID;";
                            SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn, transaction);
                            deleteCmd.Parameters.AddWithValue("@BatchOrderID", batchOrderId);
                            deleteCmd.ExecuteNonQuery();

                            // 2. Insert the new/updated list of products with their quantities
                            // UPDATED: Confirmed column name is ProductQuantity
                            string insertQuery = @"
                            INSERT INTO BatchOrderProducts (BatchOrderID, ProductName, ProductQuantity)
                            VALUES (@BatchOrderID, @ProductName, @ProductQuantity);";

                            foreach (MainDashboard.Backend.Logics.BatchOrders.ModelOfGridItem.GridItem product in productsWithQuantities) // Ensure fully qualified name or using statement
                            {
                                SqlCommand insertCmd = new SqlCommand(insertQuery, conn, transaction);
                                insertCmd.Parameters.AddWithValue("@BatchOrderID", batchOrderId);
                                insertCmd.Parameters.AddWithValue("@ProductName", product.ItemName);
                                insertCmd.Parameters.AddWithValue("@ProductQuantity", product.Quantity); // Parameter name matches @ProductQuantity
                                insertCmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Error updating batch products:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            // Log the exception details here if you have a logging mechanism
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Log the exception details here if you have a logging mechanism
                return false;
            }
        }

        public bool UpdateBatchOrderIsReceived(int batchOrderId, DateTime batchDateReceived)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();

                    string query = @"
                        UPDATE BatchOrders
                        SET BatchDateReceived = @BatchDateReceived
                        WHERE BatchOrderID = @BatchOrderID;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BatchOrderID", batchOrderId);
                        cmd.Parameters.AddWithValue("@BatchDateReceived", batchDateReceived);

                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating batch order date received:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool NullifyBatchDateReceived(int batchOrderId)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();

                    string query = @"
                        UPDATE BatchOrders
                        SET BatchDateReceived = NULL
                        WHERE BatchOrderID = @BatchOrderID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BatchOrderID", batchOrderId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error setting BatchDateReceived to NULL:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }

    // end of edit / update

    // deletion
    public class BatchOrderDelete : DatabaseConnection
    {
        public bool DeleteBatchOrderAndProducts(int batchOrderId)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Delete products first
                            try
                            {
                                string deleteProductsQuery = "DELETE FROM BatchOrderProducts WHERE BatchOrderID = @BatchOrderID";
                                SqlCommand deleteProductsCmd = new SqlCommand(deleteProductsQuery, conn, transaction);
                                deleteProductsCmd.Parameters.AddWithValue("@BatchOrderID", batchOrderId);
                                deleteProductsCmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error deleting related products:\n" + ex.Message, "Deletion of Order Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                transaction.Rollback();
                                return false;
                            }

                            // Then delete the batch order
                            try
                            {
                                string deleteBatchQuery = "DELETE FROM BatchOrders WHERE BatchOrderID = @BatchOrderID";
                                SqlCommand deleteBatchCmd = new SqlCommand(deleteBatchQuery, conn, transaction);
                                deleteBatchCmd.Parameters.AddWithValue("@BatchOrderID", batchOrderId);
                                deleteBatchCmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error deleting batch order:\n" + ex.Message, "Delete Batch Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                transaction.Rollback();
                                return false;
                            }

                            // Commit if both operations succeeded
                            transaction.Commit();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Error deleting batch order:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the database:\n" + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
    // end of deletion

}