namespace GuessingGame
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 1 and 100");
            int randomNumber = new Random().Next(1, 100);

            int number;
            int guessCount = 0;
            bool isGuessed = false;

            while (!isGuessed && guessCount <= 7)
            {
                Console.Write("Enter a number: ");
                number = int.Parse(Console.ReadLine());
                guessCount++;
                if (number > randomNumber)
                {
                    Console.WriteLine($"Your {guessCount}th guess was too high! Try again");

                }
                else if (number < randomNumber)
                {
                    Console.WriteLine($"Your {guessCount}th guess was too low! Try again");
                }
                else
                {
                    isGuessed = true;
                }

            }

        }
    }
}
