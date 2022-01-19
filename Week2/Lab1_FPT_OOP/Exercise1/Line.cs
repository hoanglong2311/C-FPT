namespace Exercise1
{
    public class Line : Shape
    {
        public Point Start { get; set; }
        public Point End { get; set; }

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        public override void Show()
        {
            Console.WriteLine("Line from ({0},{1}) to ({2},{3})", Start.X, Start.Y, End.X, End.Y);
        }
    }
}