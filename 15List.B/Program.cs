using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> people = new List<string>
        {
            "Alice", "Bob", "Carol", "David"
        };

        Random random = new Random();

        for (int i = people.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);

            // swap people[i] and people[j]
            string temp = people[i];
            people[i] = people[j];
            people[j] = temp;
        }

        foreach (string person in people)
        {
            Console.WriteLine(person);
        }
    }
}
