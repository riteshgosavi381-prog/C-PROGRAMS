using System;

class NeonNumber
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int square = num * num;
        int sum = 0;

        while (square > 0)
        {
            sum += square % 10;
            square /= 10;
        }

        Console.WriteLine(sum == num ? "Neon Number" : "Not Neon");
    }
}