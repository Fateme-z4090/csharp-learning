using System;

class Program
{
    static void Main()
    {
        while(true)
        {
            Console.WriteLine("Who are you? ");
            string name = Console.ReadLine();

            if (name != "Joe")
            {
                continue;
            }

            Console.WriteLine("What is password Joe? ");
            string password = Console.ReadLine();

            if(password == "swordfish")
            {
                break;
            }  
        }

        Console.WriteLine("Access granted");
    }
}