using System;

class Program
{
    static void Main()
    {
        int total = 0;

        for (int num = 0; num <= 100; num++)
        {
            total = total + num;
        }

        Console.WriteLine(total);
    }
}