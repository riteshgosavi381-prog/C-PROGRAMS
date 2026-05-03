using System;

class ReverseNumber
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int reverse = 0;

        while (num > 0)
        {
            reverse = reverse * 10 + num % 10;
            num /= 10;
        }

        Console.WriteLine("Reversed = " + reverse);
    }
}