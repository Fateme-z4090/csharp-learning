using System;
using System.Threading;

class Program
{
    static void Main()
    {
        int indent = 0;
        bool increasing = true;

        while (true)
        { 
            Console.WriteLine(new string(' ' , indent) + "*");
            Thread.Sleep(100);


            if (increasing)
            {
                indent++;
                if (indent == 20)
                    increasing = false;
            }
            else
            {
              indent--;
              if (indent == 0)
                  increasing = true;
            }
        } 
    }
}