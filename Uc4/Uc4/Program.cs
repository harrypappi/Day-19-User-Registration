// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your mobile number:");
        string mobileNumber = Console.ReadLine();

        if (IsValidMobileNumber(mobileNumber))
        {
            Console.WriteLine("Valid mobile number.");
        }
        else
        {
            Console.WriteLine("Invalid mobile number.");
        }
    }

    static bool IsValidMobileNumber(string mobileNumber)
    {
        string pattern = @"^91\s\d{10}$";

      
        Regex regex = new Regex(pattern);

        
        return regex.IsMatch(mobileNumber);
    }
}
