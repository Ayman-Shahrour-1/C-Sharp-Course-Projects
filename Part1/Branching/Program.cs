using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] sender)
        {
            // Requirement 1: The first line of the program must be exactly as specified below
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user for the package weight
            Console.WriteLine("Please enter the package weight:");
            double weight = Convert.ToDouble(Console.ReadLine());

            // Requirement 2: Check if weight is greater than 50
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                // Keeps the console open so the user can read the message before closing
                Console.ReadLine(); 
                return; // Ends the program immediately
            }

            // Prompt the user for the package width
            Console.WriteLine("Please enter the package width:");
            double width = Convert.ToDouble(Console.ReadLine());

            // Prompt the user for the package height
            Console.WriteLine("Please enter the package height:");
            double height = Convert.ToDouble(Console.ReadLine());

            // Prompt the user for the package length
            Console.WriteLine("Please enter the package length:");
            double length = Convert.ToDouble(Console.ReadLine());

            // Requirement 3: Check if the sum of the dimensions is greater than 50
            double dimensionsTotal = width + height + length;
            if (dimensionsTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine(); 
                return; // Ends the program immediately
            }

            // Requirement 4: Calculate the quote 
            // Formula: (Width * Height * Length * Weight) / 100
            double volume = width * height * length;
            double quote = (volume * weight) / 100;

            // Requirement 5: Display the quote to the user formatted as a currency dollar amount
            // The ":F2" format specifier ensures exactly two decimal places (e.g., $528.00)
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");

            // Prevent the console from closing automatically at the end of execution
            Console.ReadLine();
        }
    }
}
