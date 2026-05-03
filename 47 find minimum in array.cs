using System;

class MinArray
{
    static void Main()
    {
        int[] arr = { 5, 2, 9, 1, 7 };

        int min = arr[0];

        foreach (int x in arr)
        {
            if (x < min)
                min = x;
        }

        Console.WriteLine("Minimum = " + min);
    }
}