using System;
using BusinessObject;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace DataAccess
{
    public class OrderDetailDAO : BaseDAL
    {
        //Using  Signleton pattern
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();
        
        private OrderDetailDAO() { }
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<OrderDetailObject> GetOrderDetailList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "SELECT OrderId, ProductId, UnitPrice, " +
                "Quantity, Discount FROM OrderDetail";
            var orders = new List<OrderDetailObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    orders.Add(new OrderDetailObject
                    {
                        OrderID = dataReader.GetInt32(0),
                        ProductID = dataReader.GetInt32(1),
                        UnitPrice = dataReader.GetDecimal(2),
                        Quantity = dataReader.GetInt32(3),
                        Discount = dataReader.GetDouble(4),
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
            return orders;
        }

        public OrderDetailObject GetOrderDetailByID(int orderId, int productId)
        {
            OrderDetailObject orderDetail = null;
            IDataReader dataReader = null;
            string SQLSelect = "SELECT OrderId, ProductId, UnitPrice, Quantity, Discount FROM OrderDetail WHERE OrderId = @OrderId AND ProductId = @ProductId";
            try
            {
                var parameters = new List<SqlParameter>();
                parameters.Add(dataProvider.CreateParameter("@OrderId", 4, orderId, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@ProductId", 4, productId, DbType.Int32));
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, parameters.ToArray());
                if (dataReader.Read())
                {
                    orderDetail = new OrderDetailObject
                    {
                        OrderID = dataReader.GetInt32(0),
                        ProductID = dataReader.GetInt32(1),
                        UnitPrice = dataReader.GetDecimal(2),
                        Quantity = dataReader.GetInt32(3),
                        Discount = dataReader.GetDouble(4),
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
            return orderDetail;
        }

        public void AddNew(OrderDetailObject orderDetail)
        {
            try
            {
                OrderDetailObject od = GetOrderDetailByID(orderDetail.OrderID, orderDetail.ProductID);
                if (od != null)
                {
                    string SQLInsert = "INSERT Product VALUES (@OrderId, @ProductId, @UnitPrice, @Quantity, @Discount)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@OrderId", 4, orderDetail.OrderID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@ProductId", 40, orderDetail.ProductID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@UnitPrice", 8, orderDetail.UnitPrice, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@Quantity", 4, orderDetail.Quantity, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@Discount", 8, orderDetail.Discount, DbType.Double));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("This Order detail is already exist.");
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

        public void Update(OrderDetailObject orderDetail)
        {
            try
            {
                OrderDetailObject od = GetOrderDetailByID(orderDetail.OrderID, orderDetail.ProductID);
                if (od != null)
                {
                    string SQLUpdate = "UPDATE OrderDetail SET UnitPrice = @UnitPrice, Quantity = @Quantity, Discount = @Discount " +
                        "WHERE OrderId = @OrderId AND ProductId = @ProductId";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@OrderId", 4, orderDetail.OrderID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@ProductId", 40, orderDetail.ProductID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@UnitPrice", 8, orderDetail.UnitPrice, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@Quantity", 4, orderDetail.Quantity, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@Discount", 8, orderDetail.Discount, DbType.Double));
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

        public void Remove(int orderId, int productId)
        {
            try
            {
                OrderDetailObject od = GetOrderDetailByID(orderId, productId);
                if (od != null)
                {
                    string SQLDelete = "DELETE OrderDetail WHERE OrderId = @OrderId AND ProductId = @ProductId";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@OrderId", 4, orderId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@ProductId", 40, productId, DbType.Int32));
                    dataProvider.Delete(SQLDelete, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The Order detail does not already exist.");
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
