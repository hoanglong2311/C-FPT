using System;
using BusinessObject;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace DataAccess
{
    public class ProductDAO : BaseDAL
    {
        // Using Singleton Pattern
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();

        private ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<ProductObject> GetProductList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "SELECT ProductId, CategoryId, ProductName, " +
                "Weight, UnitPrice, UnitInStock FROM Product";
            var products = new List<ProductObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    products.Add(new ProductObject
                    {
                        ProductID = dataReader.GetInt32(0),
                        CategoryID = dataReader.GetInt32(1),
                        ProductName = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetDecimal(4),
                        UnitInStock = dataReader.GetInt32(5)
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
            return products;
        }

        public ProductObject GetProductById(int productId)
        {
            ProductObject product = null;
            IDataReader dataReader = null;
            string SQLSelect = "SELECT ProductId, CategoryId, ProductName, " +
                    "Weight, UnitPrice, UnitInStock FROM Product WHERE ProductId = @ProductId";
            try
            {
                var param = dataProvider.CreateParameter("@ProductId", 4, productId, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    product = new ProductObject
                    {
                        ProductID = dataReader.GetInt32(0),
                        CategoryID = dataReader.GetInt32(1),
                        ProductName = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetDecimal(4),
                        UnitInStock = dataReader.GetInt32(5)
                    };
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
            return product;
        }

        public void AddNew(ProductObject product)
        {
            try
            {
                ProductObject pro = GetProductById(product.ProductID);
                if (pro == null)
                {
                    string SQLInsert = "INSERT Product VALUES (@CategoryId, @ProductName, @Weight, @UnitPrice, @UnitInStock)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@CategoryId", 4, product.CategoryID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@ProductName", 40, product.ProductName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Weight", 20, product.Weight, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@UnitPrice", 8, product.UnitPrice, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@UnitInStock", 4, product.UnitInStock, DbType.Int32));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("This Product is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(ProductObject product)
        {
            try
            {
                ProductObject po = GetProductById(product.ProductID);
                if (po != null)
                {
                    string SQLUpdate = "UPDATE Product SET CategoryId = @CategoryId, ProductName = @ProductName, Weight = @Weight, UnitPrice = @UnitPrice, UnitInStock = @UnitInStock " +
                        "WHERE ProductId = @ProductId";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@ProductId", 4, product.ProductID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@CategoryId", 4, product.CategoryID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@ProductName", 40, product.ProductName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Weight", 20, product.Weight, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@UnitPrice", 8, product.UnitPrice, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@UnitInStock", 4, product.UnitInStock, DbType.Int32));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("This Product does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Remove(int productId)
        {
            try
            {
                ProductObject product = GetProductById(productId);
                if (product != null)
                {
                    string SQLDelete = "DELETE Product WHERE ProductId = @ProductId";
                    var param = dataProvider.CreateParameter("@ProductId", 4, productId, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The Product does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
