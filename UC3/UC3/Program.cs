// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your email address:");
        string email = Console.ReadLine();

        if (IsValidEmail(email))
        {
            Console.WriteLine("Valid email address.");
        }
        else
        {
            Console.WriteLine("Invalid email address.");
        }
    }

    static bool IsValidEmail(string email)
    {
        // Regular expression pattern to match the criteria
        string pattern = @"^[a-zA-Z0-9]+([._]?[a-zA-Z0-9]+)*@[a-zA-Z0-9]+([.-]?[a-zA-Z0-9]+)*\.[a-zA-Z]{2,}$";

        // Create a Regex object
        Regex regex = new Regex(pattern);

        // Check if the email matches the pattern
        return regex.IsMatch(email);
    }
}
