using System;
using System.Linq;

class LinqStats
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40 };

        Console.WriteLine("Max: " + arr.Max());
        Console.WriteLine("Min: " + arr.Min());
        Console.WriteLine("Avg: " + arr.Average());
    }
}