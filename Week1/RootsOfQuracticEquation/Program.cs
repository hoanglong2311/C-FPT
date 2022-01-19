// See https://aka.ms/new-console-template for more information
namespace RootsEquation
{

    class Program
    {

        void Input(out int a, out int b, out int c)
        {
            Console.WriteLine("enter a, b, c");
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = int.Parse(Console.ReadLine());
        }

        void SolveEquation(int a, int b, int c, out double x1, out double x2)
        {
            x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
        }

        Boolean CheckEquation(int a, int b, int c)
        {
            if (a == 0)
            {
                Console.WriteLine("a can't be 0");
                return false;
            }
            else if (b * b - 4 * a * c < 0)
            {
                Console.WriteLine("no solution");
                return false;
            }
            else
            {
                return true;
            }

        }
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            Program p = new Program();
            p.Input(out a, out b, out c);
            while (!p.CheckEquation(a, b, c))
            {
                p.Input(out a, out b, out c);
            }
            double x1;
            double x2;
            p.SolveEquation(a, b, c, out x1, out x2);

            Console.WriteLine("Root of the equation is {0} and {1}", x1, x2);

        }
    }
}

