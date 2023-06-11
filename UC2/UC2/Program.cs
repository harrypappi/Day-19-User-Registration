// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your last name:");
        string lastName = Console.ReadLine();

        if (IsValidLastName(lastName))
        {
            Console.WriteLine("Valid last name.");
        }
        else
        {
            Console.WriteLine("Invalid last name.");
        }
    }

    static bool IsValidLastName(string lastName)
    {
        // Regular expression pattern to match tjis char
        string pattern = @"^[A-Z][a-zA-Z]{2,}$";

      
        Regex regex = new Regex(pattern);

        // Check if the last name matches the pattern
        return regex.IsMatch(lastName);
    }
}
