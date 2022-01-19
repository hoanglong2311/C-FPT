namespace Exercise1
{
    public class ShapeManagement
    {

        public void LineManagement()
        {
            Console.WriteLine("Enter the start point of the line:");
            Console.Write("X: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end point of the line:");
            Console.Write("X: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            double y2 = double.Parse(Console.ReadLine());
            Point start = new Point(x1, y1);
            Point end = new Point(x2, y2);
            Line line = new Line(start, end);
            line.Show();
        }

        public void CircleManagement()
        {
            Console.WriteLine("Enter the position of the circle:");
            double x = double.Parse(Console.ReadLine());


        }
    }
}