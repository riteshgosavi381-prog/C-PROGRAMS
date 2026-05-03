using System;

class StrongNumber
{
    static int Fact(int n)
    {
        int f = 1;
        for (int i = 1; i <= n; i++)
            f *= i;
        return f;
    }

    static void Main()
    {
        Console.Write("Enter number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int temp = num, sum = 0;

        while (num > 0)
        {
            int digit = num % 10;
            sum += Fact(digit);
            num /= 10;
        }

        if (sum == temp)
            Console.WriteLine("Strong Number");
        else
            Console.WriteLine("Not Strong");
    }
}