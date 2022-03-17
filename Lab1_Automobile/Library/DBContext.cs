using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class DBContext
    {
        private static List<Car> cars = new List<Car>()
        {
        };

        private static DBContext instance = null;
        private static readonly object insLock = new();

        private DBContext()
        {
        }

        public static DBContext Instance
        {
            get
            {
                lock (insLock)
                {
                    if(instance == null)
                    {
                        instance = new DBContext();
                    }
                    return instance;
                }
            }
        }

        public List<Car> GetCars => cars;

        public Car GetCarByID (int id)
        {
            return cars.SingleOrDefault(c => c.CarID == id);
        }

        public void Add (Car car)
        {
            if (GetCarByID(car.CarID) == null)
            {
                cars.Add(car);
            }
            else
            {
                throw new Exception("Car existed");
            }
        }

        public void Update(Car car)
        {
            Car c = GetCarByID(car.CarID);
            if (c != null)
            {
                var index = cars.IndexOf(c);
                cars[index] = car;
            }
            else
            {
                throw new Exception("Car did not exist");
            }
        }

        public void Delete(int Id)
        {
            Car c = GetCarByID(Id);
            if (c != null)
            {
                cars.Remove(c);
            }
            else
            {
                throw new Exception("Car did not exist");
            }
        }
    }
}
