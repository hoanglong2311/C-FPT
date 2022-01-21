namespace Bai4
{
    public class Tesla : IElectronicCar, ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Battery { get; set; }

        public Tesla()
        {
            this.Model = "Tesla";
            this.Color = "Red";
            this.Battery = 100;
        }

        public Tesla(string model, string color, int battery)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = battery;
        }

        public string Start()
        {
            return "Started";
        }

        public string Stop()
        {
            return "Stopped";
        }

        public override string ToString()
        {
            return $"{this.Model} - {this.Color} - {this.Battery}% - {this.Start()} - {this.Stop()}";
        }
    }
}