using System;

namespace Day_2___After_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            string keepGoing = "y";

            while (keepGoing == "y")
            {
                Console.WriteLine("\nWelcome to Kyle's Magic Dice Roller!");
                Console.WriteLine("-----------------------------------\n");

                //get input, & validate
                Console.WriteLine("How many sides do your dice have?");
                string temp = Console.ReadLine();
                int numberOfSides;
                bool isInt = int.TryParse(temp, out numberOfSides);
                while ((isInt == false) || (numberOfSides <= 0)) 
                {

                    Console.WriteLine("Invalid entry. Please enter a whole number.");
                    temp = Console.ReadLine();
                    isInt = int.TryParse(temp, out numberOfSides);
                }

                //output
                int result1 = DiceRoller(numberOfSides);
                int result2 = DiceRoller(numberOfSides);
                Console.WriteLine("");
                Console.WriteLine($"Dice 1: {result1}");
                Console.WriteLine($"Dice 2: {result2}");

                //prompt to continue
                Console.WriteLine("\nWould you like to roll another pair? (y/n)");
                keepGoing = Console.ReadLine();
                while (keepGoing != "y" && keepGoing != "n")
                {
                    Console.WriteLine("Please enter 'y' or 'n'.");
                    keepGoing = Console.ReadLine();
                }
            }
        }

        //here ye be a magic method
        //it'll be a random number generator
        //it'll return a single int, between 1 and (a lot).. something like
        public static int DiceRoller(int max)
        {
            Random random = new Random();
            return random.Next(1, max);
        }
    }
}
