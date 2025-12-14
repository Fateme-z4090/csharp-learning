using System;

class Program
{
    static void Main()
    {
        string name = "Carol";
        int age = 3000;

        if(name == "Alice")
        {
            Console.WriteLine("Hi, Alice!");
        }
        else if(age < 12)
        {
            Console.WriteLine("You are not Alice Kiddo!");
        }
        else if(age > 100)
        {
            Console.WriteLine("You  are not Alice grannie.");
        }
        else if(age > 2000)
        {
            Console.WriteLine("unlike You Alice is not an undead, immortal vampire");
        }
    }
}
