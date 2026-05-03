using System;

class PrimeRange
{
    static void Main()
    {
        Console.Write("Enter start: ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter end: ");
        int end = Convert.ToInt32(Console.ReadLine());

        for (int i = start; i <= end; i++)
        {
            int count = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                    count++;
            }

            if (count == 2)
                Console.Write(i + " ");
        }
    }
}