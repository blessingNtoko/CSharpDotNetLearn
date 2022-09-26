using System;

// Namespace
namespace CSharpDotNetLearn
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // Start Here
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Blessing Ntoko";

            // Change text colour
            Console.ForegroundColor = ConsoleColor.Green;

            // Wite out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset Text Colour
            Console.ResetColor();

            // Ask users name
            Console.WriteLine("What is your name: ");

            // Get user input
            string? inputName = Console.ReadLine();

            Console.WriteLine($"Hello {inputName}, let's play a game...");

            // Set correct number
            int correctNumber = 7;

            // Init guess var
            int guess = 0;

            // Ask user for number
            Console.WriteLine("Guess a number between 1 and 10");

            // While guess is not correct
            while(guess != correctNumber)
            {
                // Get users input
                string? input = Console.ReadLine();

                // Cast to int and put in guess
                guess = Convert.ToInt32(input);

                // Match guess to correct number
                if (guess != correctNumber)
                {
                    // Change text colour
                    Console.ForegroundColor = ConsoleColor.Red;

                    // Tell user it was the wrong number
                    Console.WriteLine("Your guess is incorrect, try again");

                    // Reset Text Colour
                    Console.ResetColor();

                }
            }

            // Output success message

            // Change text colour
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Tell user they won
            Console.WriteLine("You got it right!! Well Done");

            // Reset Text Colour
            Console.ResetColor();

        }
    }
}