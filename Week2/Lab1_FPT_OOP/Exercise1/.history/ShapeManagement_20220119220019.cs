namespace Exercise1
{
    public class ShapeManagement
    {

        public void LineManagement()
        {
            Console.WriteLine("---------Line Management---------");

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
            Console.WriteLine("---------Circle Management---------");
            Console.WriteLine("Enter the position of the center circle:");
            Console.Write("X: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            double y = double.Parse(Console.ReadLine());
            Point pointStart = new Point(x, y);
            Console.WriteLine("Enter the radius of the circle:");
            double radius = double.Parse(Console.ReadLine());
            Circle circle = new Circle(pointStart, radius);
            circle.Show();
        }

        public void RectangleManagement()
        {
            Console.WriteLine("---------Rectangle Management---------");
            Console.WriteLine("Enter the top left point of the rectangle:");
            Console.Write("X: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            double y1 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the bottom right point of the rectangle:");
            Console.Write("X: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            double y2 = double.Parse(Console.ReadLine());
            Point topLeft = new Point(x1, y1);
            Point bottomRight = new Point(x2, y2);
            Rectangle rectangle = new Rectangle(topLeft, bottomRight);
            rectangle.Show();
        }

        public void PolyLineManagement()
        {
            Console.WriteLine("---------PolyLine Management---------");
            Console.WriteLine("Enter the start point of the polyline");
        }
    }
}