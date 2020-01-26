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

                //ask how many sided dice, & validates user input. If given an int, returns numberOfSides
                Console.Write("How many sides do your dice have?: ");
                string temp = Console.ReadLine();
                int numberOfSides;
                while ((!int.TryParse(temp, out numberOfSides)) || (numberOfSides <= 0)) 
                {

                    Console.Write("Invalid entry. Please enter a whole number:");
                    temp = Console.ReadLine();
                    int.TryParse(temp, out numberOfSides);
                }

                //ask how many dice to roll, & validates user input. If given an int greater than 0, returns numberOfRolls
                Console.Write("How many dice would you like to roll?: ");
                string temp2 = Console.ReadLine();
                int numberOfRolls;
                while((!int.TryParse(temp2, out numberOfRolls)) || (numberOfRolls <= 0))
                {
                    Console.Write("Invalid entry. Please enter a whole number greater than one: ");
                    temp2 = Console.ReadLine();
                    int.TryParse(temp2, out numberOfRolls);
                }

                //prints results to console
                Console.WriteLine("\nResults:\n----------");
                for (int i = 0; i < numberOfRolls ; i++)
                {
                    Console.WriteLine($"Dice {i + 1}: {DiceRoller(numberOfSides)}");

                }

                //prompt to continue
                Console.WriteLine("\nWould you like to roll another pair? (y/n)");
                keepGoing = Console.ReadLine();
                while (keepGoing != "y" && keepGoing != "n")
                {
                    Console.WriteLine("Please enter 'y' or 'n'.");
                    keepGoing = Console.ReadLine();
                }
            }
            Console.WriteLine("\nThanks for stopping by!");
        }

        //returns a random number between (1 - max)
        public static int DiceRoller(int max)
        {
            Random random = new Random();
            return random.Next(1, max);
        }
    }
}
