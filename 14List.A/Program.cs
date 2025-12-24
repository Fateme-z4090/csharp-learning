using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> catNames = new List<string>();

        while (true)
        {
            Console.WriteLine(
                "Enter the name of cat " + (catNames.Count + 1) +
                " (Or enter nothing to stop.):"
            );

            string name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
                break;

            // List concatenation equivalent
            catNames.Add(name);
        }

        Console.WriteLine("The cat names are:");
        foreach (string name in catNames)
        {
            Console.WriteLine(" " + name);
        }
    }
}

