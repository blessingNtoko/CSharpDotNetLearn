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
        }
    }
}