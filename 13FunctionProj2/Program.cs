using System;
using System.Threading;

class Program
{
    static void Main()
    {
        try
        {
            while (true) // Main program loop
            {
                // Draw lines with increasing length
                for (int i = 1; i <= 8; i++)
                {
                    Console.WriteLine(new string('-', i * i));
                    Thread.Sleep(100);
                }

                // Draw lines with decreasing length
                for (int i = 7; i >= 2; i--)
                {
                    Console.WriteLine(new string('-', i * i));
                    Thread.Sleep(100);
                }
            }
        }
        catch (Exception)
        {
            Environment.Exit(0);
        }
    }
}