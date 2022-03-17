using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Car
    {
        public Car()
        {
        }

        public int CarID { get; set; }
        public string CarName { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public int Year { get; set; }

        public Car(int carID, string carName, string manufacturer, decimal price, int releaseYear)
        {
            CarID = carID;
            CarName = carName;
            Manufacturer = manufacturer;
            Price = price;
            Year = releaseYear;
        }
    }
}
