using System;

class ArmstrongProgram
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int temp = num, sum = 0;

        while (num > 0)
        {
            int digit = num % 10;
            sum += digit * digit * digit;
            num /= 10;
        }

        if (sum == temp)
            Console.WriteLine("Armstrong Number");
        else
            Console.WriteLine("Not Armstrong");
    }
}