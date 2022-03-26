using System;
using System.Data;
using System.Data.SqlClient;

namespace AutoMobileLibrary.DataAccess
{
    public class StockDataProvider
    {
        private string ConnectionString { get; set; }
        
        public StockDataProvider (string connectionString)
        {
            ConnectionString = connectionString;
        }
        
        public void CloseConnection(SqlConnection connection)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public SqlParameter CreateParameter(string name, int size, object value, DbType dbType,
            ParameterDirection direction = ParameterDirection.Input)
        {
            return new SqlParameter{
                DbType = dbType,
                ParameterName = name,
                Size = size,
                Value = value,
                Direction = direction
            };
        }
        
        //----------------------------------------------------------------------------------------------------
        
        public IDataReader GetDataReader (string commandText, CommandType commandType, out SqlConnection connection,
            params SqlParameter[] parameters)
        {
            IDataReader dataReader = null;
            try
            {
                connection = new SqlConnection(ConnectionString);
                connection.Open();
                var command = new SqlCommand(commandText, connection);
                command.CommandType = commandType;
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                }

                dataReader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return dataReader;
        }
        //----------------------------------------------------------------------------------------------------

        public void Delete(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            try
            {
                using var connection = new SqlConnection(ConnectionString);
                connection.Open();
                using var command = new SqlCommand(commandText, connection);
                command.CommandType = commandType;
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                }

                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Data provider: delete method " + e.Message);
                throw;
            }
        }
        
        //----------------------------------------------------------------------------------------------------
        public void Insert(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            try
            {
                using var connection = new SqlConnection(ConnectionString);
                connection.Open();
                using var command = new SqlCommand(commandText, connection);
                command.CommandType = commandType;
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                }

                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Data provider: insert method " + e.Message);
                throw;
            }
        }
        //----------------------------------------------------------------------------------------------------
        public void Update(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            try
            {
                using var connection = new SqlConnection(ConnectionString);
                connection.Open();
                using var command = new SqlCommand(commandText, connection);
                command.CommandType = commandType;
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                }
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //public static void Main(string[] args)
        //{
        //    string connectionString =
        //        "Data Source=HOANGLONG\\HOANGLONG;Initial Catalog=MyStock;User ID=sa;Password=12345";
        //    StockDataProvider dataProvider = new StockDataProvider(connectionString);
        //    SqlConnection con = new SqlConnection(connectionString);
        //        Console.WriteLine(con);
        //}
    }
}