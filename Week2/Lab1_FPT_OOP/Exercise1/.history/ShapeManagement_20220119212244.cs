namespace Exercise1
{
    public class ShapeManagement
    {

        public void LineManagement()
        {
            Console.WriteLine("Enter the start point of the line:");
            Console.Write("X: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Y: ");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end point of the line:");
            Console.Write("X: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Y: ");
            int y2 = int.Parse(Console.ReadLine());
            Point start = new Point(x1, y1);
            Point end = new Point(x2, y2);
            Line line = new Line(start, end);
            line.Show();
        }

        public void CircleManagement()
        {
            Console.WriteLine("Enter the position of the circle:");
            Console.Write("X: ");
            int x = int.Parse(Console.ReadLine());


        }
    }
}