using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

/*

CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY(1,1),

    -- CORE PRODUCT INFO
    ProductName NVARCHAR(100) NOT NULL,
    Manufacturer NVARCHAR(100) NOT NULL,
    Model NVARCHAR(50) NOT NULL,

    -- FOREIGN KEYS
    CategoryID INT NOT NULL,    -- FK to Category table
    BatchOrdersID INT NOT NULL,        -- FK to BatchOrders table
    SupplierID INT NOT NULL,    -- FK to Supplier table

    -- INVENTORY
    ProductQuantity INT NOT NULL;
    -- ENUM VALUES:
    -- 'New', 'Sealed', 'Unsealed', 'Damaged', 'Good', 'Refurbish'
    ProductCondition NVARCHAR(25) NOT NULL,

    -- PRICING & DELIVERY
    ProductPrice DECIMAL(10, 2) NOT NULL,
    DateDelivered DATETIME NULL DEFAULT GETDATE(),

    -- WARRANTY
    ProductWarranty NVARCHAR(50) NOT NULL,

    -- OPTIONAL INFO
    PackageWeight DECIMAL(10, 2) NULL,
    ProductDescription NVARCHAR(500) NULL,

    -- FOREIGN KEY REFERENCES
    FOREIGN KEY (CategoryID) REFERENCES Category(CategoryID),   -- FK reference
    FOREIGN KEY (BatchOrdersID) REFERENCES BatchOrders(BatchOrdersID),              -- FK reference
    FOREIGN KEY (SupplierID) REFERENCES Supplier(SupplierID),   -- FK reference
);

// query without FK referencing
CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY(1,1),

    -- CORE PRODUCT INFO
    ProductName NVARCHAR(100) NOT NULL,
    Manufacturer NVARCHAR(100) NOT NULL,
    Model NVARCHAR(50) NOT NULL,

    -- FK columns as plain INTs (no references yet)
    CategoryID INT NOT NULL,
    BatchOrdersID INT NOT NULL,
    SupplierID INT NOT NULL,

    -- INVENTORY
    ProductQuantity NVARCHAR(25) NOT NULL,
    ProductCondition NVARCHAR(25) NOT NULL,  -- ENUM suggestion: New, Sealed, etc.

    -- PRICING & DELIVERY
    ProductPrice DECIMAL(10, 2) NOT NULL,
    DateDelivered DATETIME NULL DEFAULT GETDATE(),

    -- WARRANTY
    ProductWarranty NVARCHAR(50) NOT NULL,

    -- OPTIONAL INFO
    PackageWeight DECIMAL(10, 2) NULL,
    ProductDescription NVARCHAR(500) NULL
);

// query altering of table adding FK
-- Category FK
ALTER TABLE Products
ADD FOREIGN KEY (CategoryID) REFERENCES Category(CategoryID);

-- BatchOrders FK
ALTER TABLE Products
ADD FOREIGN KEY (BatchOrdersID) REFERENCES BatchOrders(BatchOrdersID);

-- Supplier FK
ALTER TABLE Products
ADD FOREIGN KEY (SupplierID) REFERENCES Supplier(SupplierID);

*/

namespace MainDashboard.Backend.Queries.InventoryCrud
{
    //constructor
    public class Product
    {
        public int ProductID { get; set; }

        // CORE PRODUCT INFO
        public string ProductName { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }

        // FK IDs
        public int CategoryID { get; set; }
        public int BatchOrdersID { get; set; }
        public int SupplierID { get; set; }

        // FK Names
        public string CategoryName { get; set; }
        public string BatchName { get; set; }
        public string SupplierName { get; set; }

        // INVENTORY
        public int ProductQuantity { get; set; }  // updated to INT
        public string ProductCondition { get; set; }

        // PRICING & DELIVERY
        public decimal ProductPrice { get; set; }
        public DateTime DateDelivered { get; set; }

        // WARRANTY
        public string ProductWarranty { get; set; }

        // OPTIONAL
        public decimal? PackageWeight { get; set; }
        public string? ProductDescription { get; set; }

        // Constructor WITH FK names
        public Product(
            int productID, string productName, string manufacturer, string model,
            int categoryID, string categoryName,
            int batchOrdersID, string batchName,
            int supplierID, string supplierName,
            int productQuantity, string productCondition,
            decimal productPrice, DateTime dateDelivered,
            string productWarranty, decimal? packageWeight = null, string? productDescription = null)
        {
            ProductID = productID;
            ProductName = productName;
            Manufacturer = manufacturer;
            Model = model;
            CategoryID = categoryID;
            CategoryName = categoryName;
            BatchOrdersID = batchOrdersID;
            BatchName = batchName;
            SupplierID = supplierID;
            SupplierName = supplierName;
            ProductQuantity = productQuantity;
            ProductCondition = productCondition;
            ProductPrice = productPrice;
            DateDelivered = dateDelivered;
            ProductWarranty = productWarranty;
            PackageWeight = packageWeight;
            ProductDescription = productDescription;
        }
    }

    // constructor for essential product info for inventory displaying
    public class ProductEssential
    {
        public string ProductName { get; set; }    // itemname
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int ProductQuantity { get; set; }   // quantity
        public string ProductCondition { get; set; } // condition
        public decimal ProductPrice { get; set; }  // price

        public ProductEssential(
            string productName,
            int categoryID, string categoryName,
            int productQuantity, string productCondition, decimal productPrice)
        {
            ProductName = productName;
            CategoryID = categoryID;
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
                        p.ProductID,
                        p.ProductName,
                        p.Manufacturer,
                        p.Model,
                        p.CategoryID,
                        c.CategoryName,
                        p.BatchOrdersID,
                        b.BatchName,
                        p.SupplierID,
                        s.SupplierName,
                        p.ProductQuantity,
                        p.ProductCondition,
                        p.ProductPrice,
                        p.DateDelivered,
                        p.ProductWarranty,
                        p.PackageWeight,
                        p.ProductDescription
                    FROM Products p
                    INNER JOIN Category c ON p.CategoryID = c.CategoryID
                    INNER JOIN BatchOrders b ON p.BatchOrdersID = b.BatchOrdersID
                    INNER JOIN Supplier s ON p.SupplierID = s.SupplierID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var product = new Product(
                                reader.GetInt32(0),                         // ProductID
                                reader.GetString(1),                        // ProductName
                                reader.GetString(2),                        // Manufacturer
                                reader.GetString(3),                        // Model
                                reader.GetInt32(4),                         // CategoryID
                                reader.GetString(5),                        // CategoryName
                                reader.GetInt32(6),                         // BatchOrdersID
                                reader.GetString(7),                        // BatchName
                                reader.GetInt32(8),                         // SupplierID
                                reader.GetString(9),                        // SupplierName
                                reader.GetInt32(10),                        // ProductQuantity (INT now)
                                reader.GetString(11),                       // ProductCondition
                                reader.GetDecimal(12),                      // ProductPrice
                                reader.GetDateTime(13),                     // DateDelivered
                                reader.GetString(14),                       // ProductWarranty
                                reader.IsDBNull(15) ? null : reader.GetDecimal(15),     // PackageWeight
                                reader.IsDBNull(16) ? null : reader.GetString(16)       // ProductDescription
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
                    p.ProductName,
                    p.CategoryID,
                    c.CategoryName,
                    p.ProductQuantity,
                    p.ProductCondition,
                    p.ProductPrice
                FROM Products p
                INNER JOIN Category c ON p.CategoryID = c.CategoryID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var product = new ProductEssential(
                                reader.GetString(0), // ProductName
                                reader.GetInt32(1),  // CategoryID
                                reader.GetString(2), // CategoryName
                                reader.GetInt32(3),  // ProductQuantity
                                reader.GetString(4), // ProductCondition
                                reader.GetDecimal(5) // ProductPrice
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
                p.ProductID,
                p.ProductName,
                p.Manufacturer,
                p.Model,
                p.CategoryID,
                c.CategoryName,
                p.BatchOrdersID,
                b.BatchName,
                p.SupplierID,
                s.SupplierName,
                p.ProductQuantity,
                p.ProductCondition,
                p.ProductPrice,
                p.DateDelivered,
                p.ProductWarranty,
                p.PackageWeight,
                p.ProductDescription
            FROM Products p
            INNER JOIN Category c ON p.CategoryID = c.CategoryID
            INNER JOIN BatchOrders b ON p.BatchOrdersID = b.BatchOrdersID
            INNER JOIN Supplier s ON p.SupplierID = s.SupplierID
            WHERE p.ProductName = @ProductName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", productName);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Product(
                                reader.GetInt32(0),                         // ProductID
                                reader.GetString(1),                        // ProductName
                                reader.GetString(2),                        // Manufacturer
                                reader.GetString(3),                        // Model
                                reader.GetInt32(4),                         // CategoryID
                                reader.GetString(5),                        // CategoryName
                                reader.GetInt32(6),                         // BatchOrdersID
                                reader.GetString(7),                        // BatchName
                                reader.GetInt32(8),                         // SupplierID
                                reader.GetString(9),                        // SupplierName
                                reader.GetInt32(10),                        // ProductQuantity
                                reader.GetString(11),                       // ProductCondition
                                reader.GetDecimal(12),                      // ProductPrice
                                reader.GetDateTime(13),                     // DateDelivered
                                reader.GetString(14),                       // ProductWarranty
                                reader.IsDBNull(15) ? null : reader.GetDecimal(15),     // PackageWeight
                                reader.IsDBNull(16) ? null : reader.GetString(16)      // ProductDescription
                            );
                        }
                    }
                }
            }

            return null; // return null if no matching product was found
        }

    }


}
