using System.Data.SqlClient;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace AutoMobileLibrary.DataAccess
{
    public class BaseDAL
    {
        public StockDataProvider DataProvider { get; set; } = null;
        public SqlConnection connection = null;
        //-----------------------------------------------------------------------------------------------------------------------
        public BaseDAL()
        {
            var connectionString = GetConnectionString();
            DataProvider = new StockDataProvider(connectionString);
        }


        public string GetConnectionString()
        {
            string connectionString;
            //IConfiguration config = new ConfigurationBuilder()
            //                        .SetBasePath(Directory.GetCurrentDirectory())
            //                        .AddJsonFile("appsettings.json", true,true)
            //                        .Build();
            //connectionString = config["ConnectionString:MyStockDB"];
            connectionString = "Data Source=HOANGLONG\\HOANGLONG;Initial Catalog=MyStock;User ID=sa;Password=12345";
            return connectionString;
        }
        public void CloseConnection() {
            if (connection != null)
            {
                DataProvider.CloseConnection(connection);
            }
        }
    }
    
}