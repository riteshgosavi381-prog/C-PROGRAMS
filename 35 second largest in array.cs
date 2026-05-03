using System;
using System.Linq;

class SecondLargest
{
    static void Main()
    {
        int[] arr = { 10, 20, 5, 40, 30 };

        var second = arr.Distinct().OrderByDescending(x => x).Skip(1).First();

        Console.WriteLine("Second Largest = " + second);
    }
}