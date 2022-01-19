namespace Exercise1
{
    public class PolyLine : Shape
    {
        public Point Start { get; set; }
        public Point End { get; set; }

        public PolyLine(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        public override void Show()
        {
            Console.WriteLine("Line from ({0},{1}) to ({2},{3})", Start.X, Start.Y, End.X, End.Y);
        }

        public string ToString => string.Format("Line from ({0},{1}) to ({2},{3})", Start.X, Start.Y, End.X, End.Y);
    }
}