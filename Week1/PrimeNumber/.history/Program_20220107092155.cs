namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());

            //enter number in while loop
            while (number < 2)
            {
                Console.WriteLine("Enter a number greater than 2");
                int number = int.Parse(Console.ReadLine());

            }
            //check if number is prime

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
