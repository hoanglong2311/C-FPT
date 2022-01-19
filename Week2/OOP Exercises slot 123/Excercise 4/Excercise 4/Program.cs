// See https://aka.ms/new-console-template for more information

using System.Formats.Asn1;
using System.Threading.Channels;

namespace Excersise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a= 0, b = 0;
            Fraction fraction1 = new Fraction(1, 2);
            Tag:
            fraction1.Input();
            fraction1.Reduce();
            fraction1.Display();

            int choice;
            Boolean flag = false;
            while (!flag)
            {
                Console.WriteLine("Enter a funtion");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction"); 
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the second fraction");
                        fraction1.InputFraction(ref a, ref b);
                        fraction1.Add(a,b);
                        fraction1.Reduce();
                        fraction1.Display();
                        break;
                    case 5:
                        flag = true;
                        break;
                }
            }

        }
    }

}