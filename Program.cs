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
            GetAppInfo();
            GreetUser();

            while (true)
            {
                // Create a new Random object
                Random random = new();

                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string? input = Console.ReadLine();

                    // Make sure input is a number
                    if (!int.TryParse(input, out guess))
                    {
                        PrintMessage(ConsoleColor.Red, "Please enter an actual number");
                        // Keep going
                        continue;

                    }

                    // Cast to int and put in guess
                    guess = Convert.ToInt32(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintMessage(ConsoleColor.Red, "Your guess is incorrect, try again");
                    }
                }

                // Output success message
                PrintMessage(ConsoleColor.Yellow, "You got it right!! Well Done");

                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                // Get Answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }

        }

        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name: ");

            // Get user input
            string? inputName = Console.ReadLine();

            Console.WriteLine($"Hello {inputName}, let's play a game...");
        }

        static void GetAppInfo()
        {
            // Start Here
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Blessing Ntoko";

            PrintMessage(ConsoleColor.Green, $"{appName}: Version {appVersion} by {appAuthor}");
        }

        static void PrintMessage(ConsoleColor color, string message)
        {
            // Change text colour
            Console.ForegroundColor = color;

            // Message to print
            Console.WriteLine(message);

            // Reset Text Colour
            Console.ResetColor();
        }
    }
}