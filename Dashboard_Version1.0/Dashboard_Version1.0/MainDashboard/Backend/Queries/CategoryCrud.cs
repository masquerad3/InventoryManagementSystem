using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

/*

CREATE TABLE Category (
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName NVARCHAR(50) NOT NULL,
    CategoryDescription NVARCHAR(200) NULL
);

*/

namespace MainDashboard.Backend.Queries.CategoryCrud
{
    // constructor here with and without ID
    public class Category
    {
        // PROPERTIES
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string? CategoryDescription { get; set; }

        // Constructor WITHOUT ID (for INSERT operations)
        public Category(string categoryName, string? categoryDescription = null)
        {
            CategoryName = categoryName;
            CategoryDescription = categoryDescription;
        }

        // Constructor WITH ID (for SELECT/UPDATE operations)
        public Category(int categoryID, string categoryName, string? categoryDescription = null)
        {
            CategoryID = categoryID;
            CategoryName = categoryName;
            CategoryDescription = categoryDescription;
        }
    }

    public abstract class DatabaseConnection
    {
        // Centralized connection string
        // samuels string
        //protected readonly string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=InventoryManagementSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        protected readonly string connectionString = @"Data Source=DESKTOP-K3DB62P\SQLEXPRESS01;Initial Catalog=IMS;Integrated Security=True;Trust Server Certificate=True";
        // Shared method to open a new connection
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }

    // CRUD STARTS HERE

    //basic read all
    public class CategoryRead : DatabaseConnection
    {
        public List<Category> ReadAllCategories()
        {
            var categoryList = new List<Category>();

            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT CategoryID, CategoryName, CategoryDescription FROM Category";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            string? description = reader.IsDBNull(2) ? null : reader.GetString(2);

                            var category = new Category(id, name, description);
                            categoryList.Add(category);
                        }
                    }
                }
            }

            return categoryList;
        }
    }
}
