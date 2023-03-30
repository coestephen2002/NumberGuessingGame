using System;
using System.Net.Configuration;

namespace NumberGuesser
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Stephen Coe";

            PrintColorMessage(appName + ": Version " + appVersion + " by " + appAuthor + ".", ConsoleColor.DarkCyan);

            Console.WriteLine("What is your name?");
            string input = Console.ReadLine();
            string name = input;

            Console.WriteLine("\nHello {0}! Let's play a game!", name);

            while (true)
            {



                Random random = new Random();
                int correctNumber = random.Next(1, 11);


                Console.Write("Guess a number between 1 and 10: ");

                int guess = 0;
                while (guess != correctNumber)
                {
                    input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage("\nEntered value was not a number. Please try again.", ConsoleColor.Red);
                        Console.Write("Guess a number between 1 and 10: ");
                        continue;
                    }

                    if (guess != correctNumber)
                    {
                        PrintColorMessage("\nWrong number. Please try again.", ConsoleColor.Red);
                        Console.Write("Guess a number between 1 and 10: ");
                    }

                }

                PrintColorMessage("\nGood Job " + name + "! YOU WIN!", ConsoleColor.Green);

                do
                {
                    Console.Write("Would you like to play again? (Y/N): ");

                    string answer = Console.ReadLine().ToUpper();
                    if (answer == "Y")
                    {
                        break;
                    }
                    else if (answer == "N")
                    {
                        Console.WriteLine("\nFarewell {0}!", name);
                        return;
                    }
                    else
                    {
                        PrintColorMessage("Invalid choice.", ConsoleColor.Red);
                    }
                } while (true);
                    
            }

        }

        private static void PrintColorMessage(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
