using System.Collections.Generic;
using AutoMobileLibrary.BussinessObject;
using AutoMobileLibrary.DataAccess;

namespace AutoMobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        public IEnumerable<Car> GetCars()
        {
            return CarDBContext.Instance.GetCarList();
        }

        public Car GetCarById(int carId)
        {
            return CarDBContext.Instance.GetCarByID(carId);
        }

        public void InsertCar(Car car)
        {
            CarDBContext.Instance.AddCar(car);
        }

        public void UpdateCar(Car car)
        {
            CarDBContext.Instance.Update(car);
        }

        public void DeleteCar(int carId)
        {
            CarDBContext.Instance.Delete(carId);
        }
    }
}