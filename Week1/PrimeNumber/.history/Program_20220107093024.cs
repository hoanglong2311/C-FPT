namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());

            while (number <= 2)
            {
                Console.WriteLine("Enter a number greater than 2");
                number = int.Parse(Console.ReadLine());
            }

            if (number == 1)
            {
                Console.WriteLine("1 is not a prime number");
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine("{0} is not a prime number", number);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("{0} is a prime number", number);
                    }
                }
            }
        }
    }
}
