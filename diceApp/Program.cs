using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace diceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 6;
            int firstDie, secondDie;
            string roll_again = "y";
            Random random = new Random();

            while (roll_again.Equals("y"))
            {
                firstDie = random.Next(min, max);
                secondDie = random.Next(min, max);
                Console.WriteLine("You played: {0}, {1}", firstDie, secondDie);
                Console.WriteLine("Play again ? y / n ");
                roll_again = Console.ReadLine();

            }
            Console.ReadKey();
        }
    }
}
