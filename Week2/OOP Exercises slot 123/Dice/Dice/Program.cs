// See https://aka.ms/new-console-template for more information
namespace Dice
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            int sides = 0;
            int guess = 0;
            Dice dice = new Dice();
            

            Console.WriteLine("Enter the sides of Dice : ");
            sides = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the guess number : ");
            guess = Convert.ToInt32(Console.ReadLine());
            
            
            if (guess == dice.Roll(sides))
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Fail!");
            }
        }
    }
}