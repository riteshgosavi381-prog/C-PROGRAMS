using System;

class FactorialRecursion
{
    static int Fact(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        return n * Fact(n - 1);
    }

    static void Main()
    {
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Factorial = " + Fact(n));
    }
}