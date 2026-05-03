using System;

class PerfectNumber
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i < num; i++)
        {
            if (num % i == 0)
                sum += i;
        }

        Console.WriteLine(sum == num ? "Perfect Number" : "Not Perfect");
    }
}