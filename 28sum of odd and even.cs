using System;

class EvenOddSum
{
    static void Main()
    {
        Console.Write("Enter limit: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int even = 0, odd = 0;

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
                even += i;
            else
                odd += i;
        }

        Console.WriteLine("Even Sum = " + even);
        Console.WriteLine("Odd Sum = " + odd);
    }
}