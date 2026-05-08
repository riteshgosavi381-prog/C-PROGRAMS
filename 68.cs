using System;

class MissingNumber
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 5 };

        int n = arr.Length + 1;
        int total = n * (n + 1) / 2;

        int sum = 0;
        foreach (int i in arr)
            sum += i;

        Console.WriteLine("Missing Number = " + (total - sum));
    }
}