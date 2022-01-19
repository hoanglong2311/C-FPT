namespace Exercise1
{
    public class Rectangle : Shape
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }

        public Rectangle(Point topLeft, Point bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }

        public override void Show()
        {
            Console.WriteLine("Rectangle from ({0},{1}) to ({2},{3})", TopLeft.X, TopLeft.Y, BottomRight.X, BottomRight.Y);
        }
        public string ToString => string.Format("Rectangle from ({0},{1}) to ({2},{3})", TopLeft.X, TopLeft.Y, BottomRight.X, BottomRight.Y);

    }
}