using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("What is your name?");
        Console.Write("> ");

        string myName = Console.ReadLine();

        Console.WriteLine("Nice to meet you " + myName);

        Console.WriteLine("The Length of your name is:");
        Console.WriteLine(myName.Length);

        Console.WriteLine("What is your age ?");
        Console.Write("> ");

        string myAge = Console.ReadLine();

        int ageAsNumber = int.Parse(myAge);
        Console.WriteLine("You will be " + (ageAsNumber + 1).ToString() + " in a year.");
    } 
}