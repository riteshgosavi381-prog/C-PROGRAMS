using System;

class PowerProgram
{
    static void Main()
    {
        Console.Write("Enter base: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter exponent: ");
        int e = Convert.ToInt32(Console.ReadLine());

        int result = 1;

        for (int i = 0; i < e; i++)
        {
            result *= b;
        }

        Console.WriteLine("Result = " + result);
    }
}