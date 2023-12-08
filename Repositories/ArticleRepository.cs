using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Web;

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

        public string GetArticle(string url)
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
                                return reader[reader.GetOrdinal("image_url")] as string;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }

            return null;
        }
    }
}