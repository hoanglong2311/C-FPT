namespace Exercise1
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() => string.Format("({0},{1})", X, Y);
        public Point Move(double deltaX, double deltaY) => new Point(X + deltaX, Y + deltaY);
    }


}