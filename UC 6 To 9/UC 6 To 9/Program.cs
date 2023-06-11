// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your password:");
        string password = Console.ReadLine();

        if (IsValidPassword(password))
        {
            Console.WriteLine("Valid password.");
        }
        else
        {
            Console.WriteLine("Invalid password.");
        }
    }

    static bool IsValidPassword(string password)
    {
      
        if (password.Length < 8)
        {
            return false;
        }

        // Rule 2: At least 1 uppercase letter
        if (!Regex.IsMatch(password, "[A-Z]"))
        {
            return false;
        }

        // Rule 3: At least 1 numeric digit
        if (!Regex.IsMatch(password, "[0-9]"))
        {
            return false;
        }

        // Rule 4: Exactly 1 special character
        if (!Regex.IsMatch(password, "[!@#$%^&*()]"))
        {
            return false;
        }

        // All rules passed, password is valid
        return true;
    }
}
