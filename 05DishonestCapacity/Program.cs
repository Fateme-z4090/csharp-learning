using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter TB or GB for the advertised unit:");
        string unit = Console.ReadLine();

        double discrepancy;

        // Calculate discrepancy
        if (unit == "TB" || unit == "tb")
        {
            discrepancy = 1000000000000 / 1099511627776.0;
        }
        else if (unit == "GB" || unit == "gb")
        {
            discrepancy = 1000000000 / 1073741824.0;
        }
        else
        {
            Console.WriteLine("Invalid unit.");
            return;
        }

        Console.WriteLine("Enter the advertised capacity:");
        string inputCapacity = Console.ReadLine();

        // Convert string to double
        double advertisedCapacity = double.Parse(inputCapacity);

        // Calculate real capacity and round
        double realCapacityValue = Math.Round(advertisedCapacity * discrepancy, 2);

        // Convert to string for concatenation
        string realCapacity = realCapacityValue.ToString();

        Console.WriteLine("The actual capacity is " + realCapacity + " " + unit);
    }
}