namespace GuessingGame
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 1 and 100");
            int number = int.Parse(Console.ReadLine());
            int guess = 0;
            int guessCount = 0;
            int high = 100;
            int low = 1;
            bool isGuessed = false;
            while (!isGuessed)
            {
                guess = (high + low) / 2;
                Console.WriteLine("Is your number " + guess + "?");
                string answer = Console.ReadLine();
                guessCount++;
                if (answer == "h")
                {
                    high = guess;
                }
                else if (answer == "l")
                {
                    low = guess;
                }
                else if (answer == "y")
                {
                    isGuessed = true;
                }
            }
            Console.WriteLine("Your number is " + guess + " and it took " + guessCount + " guesses");
            Console.ReadLine();
        }
    }
}
