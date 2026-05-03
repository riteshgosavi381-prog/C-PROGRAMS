using System;

class ArraySum
{
    static void Main()
    {
        Console.Write("Enter size: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
            sum += arr[i];
        }

        Console.WriteLine("Sum = " + sum);
    }
}