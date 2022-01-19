namespace Exercise1
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(Point position, double radius)
        {
            this.position = position;
            Radius = radius;
        }

        public override void Show()
        {
            Console.WriteLine("Circle with radius {0} at ({1},{2})", Radius, position.X, position.Y);
        }

    }
}