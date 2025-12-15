using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("please type your name: ");
            string name = Console.ReadLine();

            if (name == "your name")
            {
                break;
            }

            Console.WriteLine("Thank you");
        }
    }
}