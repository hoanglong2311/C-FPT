// See https://aka.ms/new-console-template for more information
namespace Excersise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a =  ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Input b =  ");
            int b = int.Parse(Console.ReadLine());

            char c;
            //enter operator in while loop
            while (true)
            {
                Console.WriteLine("Input operator (+, -, *, /)");
                c = char.Parse(Console.ReadLine());
                if (c == '+' || c == '-' || c == '*' || c == '/')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong operator");
                }
            }

            //calculate
            int result = 0;
            switch (c)
            {
                case '+':
                    result = a + b;
                    Console.WriteLine($"{a} + {b} = {result}");
                    break;
                case '-':
                    result = a - b;
                    Console.WriteLine($"{a} - {b} = {result}");
                    break;
                case '*':
                    result = a * b;
                    Console.WriteLine($"{a} * {b} = {result}");
                    break;
                case '/':
                    result = a / b;
                    Console.WriteLine($"{a} / {b} = {result}");
                    break;
            }
        }
    }
}

