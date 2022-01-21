namespace Bai4
{
    public class Seat : ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }

        public Seat()
        {
            this.Model = "Seat";
            this.Color = "Black";
        }

        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        public string Start()
        {
            return "Engine start";
        }
        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            return $"{this.Model} {this.Color}\n{this.Start()}\n{this.Stop()}";
        }

    }
}