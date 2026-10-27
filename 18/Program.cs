using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "My number is 415-555-4242.";
        string pattern = @"\d{3}-\d{3}-\d{4}";

        Match match = Regex.Match(text, pattern);

        if (match.Success)
        {
            Console.WriteLine("Phone number found: " + match.Value);
            Console.WriteLine("Starting index: " + match.Index);
            Console.WriteLine("Number of characters: " + match.Length);
        }
        else
        {
            Console.WriteLine("No phone number found.");
        }
    }
}
