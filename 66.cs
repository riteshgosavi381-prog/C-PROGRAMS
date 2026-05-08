using System;

class HappyNumber
{
    static int SumOfSquares(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            int d = n % 10;
            sum += d * d;
            n /= 10;
        }
        return sum;
    }

    static void Main()
    {
        Console.Write("Enter number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int result = num;

        while (result != 1 && result != 4)
            result = SumOfSquares(result);

        Console.WriteLine(result == 1 ? "Happy Number" : "Not Happy");
    }
}