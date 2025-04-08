using MyPointOfSale.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MyPointOfSale.DataAccessSQLServer
{
    public class ProductDao : ConnectionToSQLServer
    {
        public IReadOnlyList<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            using (SqlConnection connection = ConnectionString)
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = 
                        @"SELECT ProductId, Categories.Name, Description, Price, ITBIS 
                          FROM Products 
                          LEFT JOIN Categories ON Products.CategoryId = categories.CategoryId";
                    command.CommandType = System.Data.CommandType.Text;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product();
                            product.Id = reader.GetInt32(0);
                            product.Category = new ProductCategory()
                            {
                                Category = reader.GetString(1)
                            };
                            product.Description = reader.GetString(2);
                            product.Price = reader.GetDecimal(3);
                            product.ITBIS = reader.GetDecimal(4);
                            products.Add(product);
                            //products.Add(new Product()
                            //{
                            //    Id = reader.GetInt32(0),
                            //    Category = new ProductCategory()
                            //    {
                            //        Category = reader.GetString(1)
                            //    },
                            //    Description = reader.GetString(2),
                            //    Price = reader.GetDecimal(3),
                            //    ITBIS = reader.GetFloat(4)
                            //});
                        }
                    }
                }
            }

            return products;
        }
    }
}
