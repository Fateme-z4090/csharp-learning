using System;
using System.Text.RegularExpressions;

string text = """
Call Alice at 415-555-4242.
Call Bob at (415) 555-4243.
Call Carol at 415.555.4244.
Call David at 555-4245.
""";

string pattern = @"(\d{3}|\(\d{3}\))?[\s.-]?\d{3}[\s.-]\d{4}";

MatchCollection matches = Regex.Matches(text, pattern);

Console.WriteLine($"Numbers found: {matches.Count}");
Console.WriteLine();

foreach (Match match in matches)
{
    Console.WriteLine($"Full number: {match.Value}");

    if (match.Groups[1].Success)
    {
        Console.WriteLine($"Area code: {match.Groups[1].Value}");
    }
    else
    {
        Console.WriteLine("Area code: not provided");
    }

    Console.WriteLine();
}