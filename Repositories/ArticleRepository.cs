using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Web;
using VinoteketTestWebApp.Models;

namespace VinoteketTestWebApp.Repositories
{
    public class ArticleRepository
    {
        public ArticleRepository() { }

        private SqlConnection Connection
        {
            get
            {
                return
                       new SqlConnection(
                           System.Configuration.ConfigurationManager.ConnectionStrings["DatabaseConnection"]
                               .ConnectionString);
            }
        }

        public Product GetArticle(string url)
        {

            string query = $@"
                SELECT [id]
                        ,[sku]
                        ,[name]
                        ,[description]
                        ,[image_url]
                        ,[price]
                        ,[url]
                    FROM [Article]
                    WHERE url = '{url}'
                ";

            try
            {
                using (var connection = Connection)
                {
                    connection.Open();
                    using (var sqlCommand = new SqlCommand(query, connection))
                    {
                        using (var reader = sqlCommand.ExecuteReader())
                        {
                            if (reader.HasRows && reader.Read())
                            {
                                Product product = new Product();
                                product.id = (int)reader["id"];
                                product.name = reader["name"].ToString();
                                product.sku = reader["sku"].ToString();
                                product.url = reader["url"].ToString();
                                product.description = reader["description"]?.ToString();
                                product.image_url = reader["image_url"].ToString();
                                product.price = (int)reader["price"];
                                return product;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }

            return null;
        }

        public List<Product> GetAllArticles()
        {

            string query = $@"
                SELECT [id]
                        ,[sku]
                        ,[name]
                        ,[description]
                        ,[image_url]
                        ,[price]
                        ,[url]
                    FROM [Article]
                ";

            List<Product> products = new List<Product>();

            try
            {
                using (var connection = Connection)
                {
                    connection.Open();
                    using (var sqlCommand = new SqlCommand(query, connection))
                    {
                        using (var reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Product product = new Product();
                                product.id = (int) reader["id"];
                                product.name = reader["name"].ToString();
                                product.sku = reader["sku"].ToString();
                                product.url = reader["url"].ToString();
                                product.description = reader["description"]?.ToString();
                                product.image_url = reader["image_url"].ToString();
                                product.price = (int) reader["price"];
                                products.Add(product);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }

            return products;
        }
    }
}