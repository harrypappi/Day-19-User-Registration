// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your first name:");
        string firstName = Console.ReadLine();

        if (IsValidFirstName(firstName))
        {
            Console.WriteLine("Valid first name.");
        }
        else
        {
            Console.WriteLine("Invalid first name.");
        }
    }

    static bool IsValidFirstName(string firstName)
    {
        // Regular expression pattern to match the criteria
        string pattern = @"^[A-Z][a-zA-Z]{2,}$";

        // Create a Regex object
        Regex regex = new Regex(pattern);

        // Check if the first name matches the pattern
        return regex.IsMatch(firstName);
    }
}
