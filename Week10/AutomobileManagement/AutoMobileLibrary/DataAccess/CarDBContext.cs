using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using AutoMobileLibrary.BussinessObject;

namespace AutoMobileLibrary.DataAccess
{
    public class CarDBContext : BaseDAL
    {
        //using singleton pattern
        private static CarDBContext instance = null;
        private static readonly object instanceLock = new object();

        private CarDBContext()
        {
        }

        public static CarDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarDBContext();
                    }

                    return instance;
                }
            }
        }

        public IEnumerable<Car> GetCarList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "select CarID, CarName, Manufacturer, Price, ReleasedYear from Cars";
            var cars = new List<Car>();
            try
            {
                dataReader = DataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    cars.Add(new Car
                    {
                        CarId = dataReader.GetInt32(0),
                        CarName = dataReader.GetString(1),
                        Manufacturer = dataReader.GetString(2),
                        Price = dataReader.GetDecimal(3),
                        ReleaseYear = dataReader.GetInt32(4)
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }

                CloseConnection();
            }

            return cars;
        }

        //---------------------------------------------------------------------------------------------------------------------
        public Car GetCarByID(int carID)
        {
            Car car = null;
            IDataReader dataReader = null;
            string SQLSelect = "select CarID, CarName, Manufacturer, Price, ReleasedYear from Cars where CarID = @CarID";
            try
            {
                dataReader = DataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection,
                    DataProvider.CreateParameter("@CarID", 4, carID, DbType.Int32));
                while (dataReader.Read())
                {
                    car = new Car
                    {
                        CarId = dataReader.GetInt32(0),
                        CarName = dataReader.GetString(1),
                        Manufacturer = dataReader.GetString(2),
                        Price = dataReader.GetDecimal(3),
                        ReleaseYear = dataReader.GetInt32(4)
                    };
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }

                CloseConnection();
            }

            return car;
        }

        //---------------------------------------------------------------------------------------------------------------------
        public void AddCar(Car car)
        {
            try
            {
                Car pro = GetCarByID(car.CarId);
                if (pro == null)
                {
                    string SQLInsert =
                        "insert into Cars (CarName, Manufacturer, Price, ReleasedYear) values (@CarName, @Manufacturer, @Price, @ReleaseYear)";

                    var parameters = new List<SqlParameter>();
                    parameters.Add(DataProvider.CreateParameter("@CarName", 50, car.CarName, DbType.String));
                    parameters.Add(DataProvider.CreateParameter("@Manufacturer", 50, car.Manufacturer, DbType.String));
                    parameters.Add(DataProvider.CreateParameter("@Price", 50, car.Price, DbType.Decimal));
                    parameters.Add(DataProvider.CreateParameter("@ReleaseYear", 4, car.ReleaseYear, DbType.Int32));
                    DataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("add :This car is already exist");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }
        //---------------------------------------------------------------------------------------------------------------------
        public void Update(Car car)
        {
            try
            {
                Car c = GetCarByID(car.CarId);
                if (c != null)
                {
                    string SQLUpdate =
                        "update Cars set CarName = @CarName, Manufacturer = @Manufacturer, Price = @Price, ReleasedYear = @ReleaseYear where CarID = @CarID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(DataProvider.CreateParameter("@CarName", 50, car.CarName, DbType.String));
                    parameters.Add(DataProvider.CreateParameter("@Manufacturer", 50, car.Manufacturer, DbType.String));
                    parameters.Add(DataProvider.CreateParameter("@Price", 50, car.Price, DbType.Decimal));
                    parameters.Add(DataProvider.CreateParameter("@ReleaseYear", 4, car.ReleaseYear, DbType.Int32));
                    parameters.Add(DataProvider.CreateParameter("@CarID", 4, car.CarId, DbType.Int32));
                    DataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                    
                }
                else
                {
                    throw new Exception("update: This car is not exist");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }
        //---------------------------------------------------------------------------------------------------------------------
        public void Delete(int carId)
        {
            try
            {
                Car c = GetCarByID(carId);
                if (c != null)
                {
                    string SQLDelete = "delete from Cars where CarID = @CarID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(DataProvider.CreateParameter("@CarID", 4, carId, DbType.Int32));
                    DataProvider.Delete(SQLDelete, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("Delete: This car is not exist");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}