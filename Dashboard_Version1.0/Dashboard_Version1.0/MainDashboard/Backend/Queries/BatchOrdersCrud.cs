using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

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

CREATE TABLE BatchOrderProducts (
    BatchOrderID INT NOT NULL,
    ProductName NVARCHAR(75) NOT NULL,
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
        public DateTime BatchDateRequested { get; set; }
        public DateTime? BatchDateReceived { get; set; }

        // NEW: store list of product names
        public List<string> ProductNamesList { get; set; } = new List<string>();

        // Automatically joins the list into a multiline string
        public string ProductNames => string.Join(Environment.NewLine, ProductNamesList);

        // Optional: keep the constructor, or remove it if not needed
        public BatchOrderSummary(
            int batchOrdersID,
            string batchName,
            string productNames,  // Can be removed if you're using the list only
            string batchOrderStatus,
            DateTime batchDateRequested,
            DateTime? batchDateReceived)
        {
            BatchOrdersID = batchOrdersID;
            BatchName = batchName;
            BatchOrderStatus = batchOrderStatus;
            BatchDateRequested = batchDateRequested;
            BatchDateReceived = batchDateReceived;

            // Split string if needed
            ProductNamesList = productNames.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        public BatchOrderSummary() { } // For list initialization
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
                    string query = @"SELECT BatchOrderID, BatchName, BatchOrderStatus, BatchDateRequested, BatchDateReceived 
                             FROM BatchOrders";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int batchId = reader.GetInt32(0);
                            string batchName = reader.GetString(1);
                            string status = reader.GetString(2);
                            DateTime dateRequested = reader.GetDateTime(3);
                            DateTime? dateReceived = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4);

                            // Get products for this batch order
                            List<string> productList = GetProductNamesByBatchOrderId(batchId);
                            string productNames = string.Join("\n", productList);  // Multiline format

                            // Use constructor correctly
                            results.Add(new BatchOrderSummary(
                                batchId,
                                batchName,
                                productNames,
                                status,
                                dateRequested,
                                dateReceived
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
            var products = new List<string>();

            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT ProductName FROM BatchOrderProducts WHERE BatchOrderID = @BatchOrderID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BatchOrderID", batchOrderId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                products.Add(reader.GetString(0));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product names:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        public bool AddProductsToBatchOrder(int batchOrderId, List<string> selectedProducts)
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
                            string insertProductQuery = @"
                            INSERT INTO BatchOrderProducts (BatchOrderID, ProductName)
                            VALUES (@BatchOrderID, @ProductName);";

                            foreach (string product in selectedProducts)
                            {
                                SqlCommand cmd = new SqlCommand(insertProductQuery, conn, transaction);
                                cmd.Parameters.AddWithValue("@BatchOrderID", batchOrderId);
                                cmd.Parameters.AddWithValue("@ProductName", product);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Error inserting batch products:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public bool UpdateBatchOrderProducts(int batchOrderId, List<string> selectedProducts)
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
                            // 1. Delete existing products for this batch
                            string deleteQuery = "DELETE FROM BatchOrderProducts WHERE BatchOrderID = @BatchOrderID";
                            SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn, transaction);
                            deleteCmd.Parameters.AddWithValue("@BatchOrderID", batchOrderId);
                            deleteCmd.ExecuteNonQuery();

                            // 2. Insert new selected products
                            string insertQuery = @"
                                INSERT INTO BatchOrderProducts (BatchOrderID, ProductName)
                                VALUES (@BatchOrderID, @ProductName);";

                            foreach (string product in selectedProducts)
                            {
                                SqlCommand insertCmd = new SqlCommand(insertQuery, conn, transaction);
                                insertCmd.Parameters.AddWithValue("@BatchOrderID", batchOrderId);
                                insertCmd.Parameters.AddWithValue("@ProductName", product);
                                insertCmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Error updating batch products:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                MessageBox.Show("Error deleting related products:\n" + ex.Message, "Delete Products Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
