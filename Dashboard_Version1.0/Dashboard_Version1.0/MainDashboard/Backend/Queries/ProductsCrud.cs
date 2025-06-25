using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

/*

CREATE TABLE Products (
    -- CORE PRODUCT INFO
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    ProductName NVARCHAR(100) NOT NULL,
    Manufacturer NVARCHAR(100) NOT NULL,
    Model NVARCHAR(50) NOT NULL,

    -- removed FK
    CategoryName NVARCHAR(50) NOT NULL,
    SupplierID NVARCHAR(50) NULL,

    -- INVENTORY
    ProductQuantity NVARCHAR(25) NOT NULL,
    ProductCondition NVARCHAR(25) NOT NULL,  -- ENUM suggestion: New, Sealed, etc.

    -- PRICING & DELIVERY
    ProductPrice DECIMAL(10, 2) NOT NULL,
    DateDelivered DATETIME NULL DEFAULT GETDATE(),
    ProductWarranty NVARCHAR(50) NOT NULL,

    -- OPTIONAL INFO
    PackageWeight DECIMAL(10, 2) NULL,
    ProductDescription NVARCHAR(500) NULL
);

*/

namespace MainDashboard.Backend.Queries.ProductsCrud
{
    //constructor
    public class Product
    {
        public int ProductID { get; set; }

        // CORE PRODUCT INFO
        public string ProductName { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }

        // Simplified foreign details
        public string CategoryName { get; set; }
        public string? SupplierID { get; set; } // Now string and nullable

        // INVENTORY
        public string ProductQuantity { get; set; }
        public string ProductCondition { get; set; }

        // PRICING & DELIVERY
        public decimal ProductPrice { get; set; }
        public DateTime? DateDelivered { get; set; } // NULLable

        // WARRANTY
        public string ProductWarranty { get; set; }

        // OPTIONAL INFO
        public decimal? PackageWeight { get; set; }
        public string? ProductDescription { get; set; }

        // Constructor
        public Product(
            int productID,
            string productName,
            string manufacturer,
            string model,
            string categoryName,
            string? supplierID,
            string productQuantity,
            string productCondition,
            decimal productPrice,
            DateTime? dateDelivered,
            string productWarranty,
            decimal? packageWeight = null,
            string? productDescription = null)
        {
            ProductID = productID;
            ProductName = productName;
            Manufacturer = manufacturer;
            Model = model;
            CategoryName = categoryName;
            SupplierID = supplierID;
            ProductQuantity = productQuantity;
            ProductCondition = productCondition;
            ProductPrice = productPrice;
            DateDelivered = dateDelivered;
            ProductWarranty = productWarranty;
            PackageWeight = packageWeight;
            ProductDescription = productDescription;
        }
    }

    //constructor for displaying in gridview
    public class ProductEssential
    {
        public string ProductName { get; set; }       // item name
        public string CategoryName { get; set; }      // category name
        public string ProductQuantity { get; set; }   // quantity (as string)
        public string ProductCondition { get; set; }  // condition (e.g., "New", "Damaged")
        public decimal ProductPrice { get; set; }     // price

        public ProductEssential(
            string productName,
            string categoryName,
            string productQuantity,
            string productCondition,
            decimal productPrice)
        {
            ProductName = productName;
            CategoryName = categoryName;
            ProductQuantity = productQuantity;
            ProductCondition = productCondition;
            ProductPrice = productPrice;
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

    public class ProductRead : DatabaseConnection
    {
        public List<Product> ReadAllProducts()
        {
            var productList = new List<Product>();

            using (SqlConnection connection = GetConnection())
            {
                string query = @"
                SELECT 
                    ProductID,
                    ProductName,
                    Manufacturer,
                    Model,
                    CategoryName,
                    SupplierID,
                    ProductQuantity,
                    ProductCondition,
                    ProductPrice,
                    DateDelivered,
                    ProductWarranty,
                    PackageWeight,
                    ProductDescription
                FROM Products";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var product = new Product(
                                productID: reader.GetInt32(0),
                                productName: reader.GetString(1),
                                manufacturer: reader.GetString(2),
                                model: reader.GetString(3),
                                categoryName: reader.GetString(4),
                                supplierID: reader.IsDBNull(5) ? null : reader.GetString(5),
                                productQuantity: reader.GetString(6),
                                productCondition: reader.GetString(7),
                                productPrice: reader.GetDecimal(8),
                                dateDelivered: reader.IsDBNull(9) ? null : reader.GetDateTime(9),
                                productWarranty: reader.GetString(10),
                                packageWeight: reader.IsDBNull(11) ? null : reader.GetDecimal(11),
                                productDescription: reader.IsDBNull(12) ? null : reader.GetString(12)
                            );

                            productList.Add(product);
                        }
                    }
                }
            }

            return productList;
        }

        //read for inventory gridview
        public List<ProductEssential> GetProductSummaries()
        {
            var list = new List<ProductEssential>();

            using (SqlConnection connection = GetConnection())
            {
                string query = @"
                    SELECT 
                        ProductName,
                        CategoryName,
                        ProductQuantity,
                        ProductCondition,
                        ProductPrice
                    FROM Products";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var product = new ProductEssential(
                                productName: reader.GetString(0),
                                categoryName: reader.GetString(1),
                                productQuantity: reader.GetString(2),
                                productCondition: reader.GetString(3),
                                productPrice: reader.GetDecimal(4)
                            );

                            list.Add(product);
                        }
                    }
                }
            }

            return list;
        }   //end of read for display

        // read for getting product details to update
        public Product? GetProductByName(string productName)
        {
            using (SqlConnection connection = GetConnection())
            {
                string query = @"
                    SELECT 
                        ProductID,
                        ProductName,
                        Manufacturer,
                        Model,
                        CategoryName,
                        SupplierID,
                        ProductQuantity,
                        ProductCondition,
                        ProductPrice,
                        DateDelivered,
                        ProductWarranty,
                        PackageWeight,
                        ProductDescription
                    FROM Products
                    WHERE ProductName = @ProductName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", productName);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Product(
                                productID: reader.GetInt32(0),
                                productName: reader.GetString(1),
                                manufacturer: reader.GetString(2),
                                model: reader.GetString(3),
                                categoryName: reader.GetString(4),
                                supplierID: reader.IsDBNull(5) ? null : reader.GetString(5),
                                productQuantity: reader.GetString(6),
                                productCondition: reader.GetString(7),
                                productPrice: reader.GetDecimal(8),
                                dateDelivered: reader.IsDBNull(9) ? null : reader.GetDateTime(9),
                                productWarranty: reader.GetString(10),
                                packageWeight: reader.IsDBNull(11) ? null : reader.GetDecimal(11),
                                productDescription: reader.IsDBNull(12) ? null : reader.GetString(12)
                            );
                        }
                    }
                }
            }

            return null;
        }

    }

    public class ProductAdd : DatabaseConnection
    {
        public static bool AddProductToDatabase(
            string productName,
            string manufacturer,
            string model,
            string categoryName,
            string? supplierID,
            int quantity,
            string condition,
            decimal price,
            DateTime dateDelivered,
            DateTime warrantyDate,
            decimal? weight,
            string? description
            )
        {
            string query = @"
                INSERT INTO Products (
                    ProductName, Manufacturer, Model,
                    CategoryName, SupplierID,
                    ProductQuantity, ProductCondition,
                    ProductPrice, DateDelivered, ProductWarranty,
                    PackageWeight, ProductDescription
                )
                VALUES (
                    @ProductName, @Manufacturer, @Model,
                    @CategoryName, @SupplierID,
                    @ProductQuantity, @ProductCondition,
                    @ProductPrice, @DateDelivered, @ProductWarranty,
                    @PackageWeight, @ProductDescription
                );
            ";

            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=InventoryManagementSystem;Integrated Security=True;Trust Server Certificate=True"))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ProductName", productName);
                cmd.Parameters.AddWithValue("@Manufacturer", manufacturer);
                cmd.Parameters.AddWithValue("@Model", model);
                cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                cmd.Parameters.AddWithValue("@SupplierID", string.IsNullOrWhiteSpace(supplierID) ? DBNull.Value : supplierID);
                cmd.Parameters.AddWithValue("@ProductQuantity", quantity);
                cmd.Parameters.AddWithValue("@ProductCondition", condition);
                cmd.Parameters.AddWithValue("@ProductPrice", price);
                cmd.Parameters.AddWithValue("@DateDelivered", dateDelivered);
                cmd.Parameters.AddWithValue("@ProductWarranty", warrantyDate.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@PackageWeight", weight.HasValue ? weight : DBNull.Value);
                cmd.Parameters.AddWithValue("@ProductDescription", string.IsNullOrWhiteSpace(description) ? DBNull.Value : description);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database Error:\n{ex.Message}", "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }

}