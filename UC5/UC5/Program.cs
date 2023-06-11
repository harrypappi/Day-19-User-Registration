using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your password:");
        string password = Console.ReadLine();

        if (IsValidPassword("password"))
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

       
        return true;
    }
}
