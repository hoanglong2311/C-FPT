using BusinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DataAccess
{
    public class CategoryDAO : BaseDAL
    {
        // Using Singleton pattern
        private static CategoryDAO instance = null;
        private static readonly object instanceLock = new object();

        private CategoryDAO() { }
        public static CategoryDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CategoryDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<CategoryObject> GetCategoryList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "SELECT CategoryId, CategoryName, [Description] FROM Category";
            var categories = new List<CategoryObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    categories.Add(new CategoryObject
                    {
                        CategoryId = dataReader.GetInt32(0),
                        CategoryName = dataReader.GetString(1),
                        Description = dataReader.GetString(2)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return categories;
        }
    }
}
