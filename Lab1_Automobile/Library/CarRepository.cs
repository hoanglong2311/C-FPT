using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class CarRepository : ICarRepository
    {
        void ICarRepository.Delete(int id) => DBContext.Instance.Delete(id);

        Car ICarRepository.GetCarByID(int id) => DBContext.Instance.GetCarByID(id);

        IEnumerable<Car> ICarRepository.GetCars() => DBContext.Instance.GetCars;

        void ICarRepository.Insert(Car car) => DBContext.Instance.Add(car);

        void ICarRepository.Update(Car car) => DBContext.Instance.Update(car);
    }
}
