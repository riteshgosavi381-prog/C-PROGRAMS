using System;

class CountTypes
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string s = Console.ReadLine();

        int upper = 0, lower = 0, digit = 0;

        foreach (char c in s)
        {
            if (char.IsUpper(c)) upper++;
            else if (char.IsLower(c)) lower++;
            else if (char.IsDigit(c)) digit++;
        }

        Console.WriteLine($"Upper: {upper}, Lower: {lower}, Digits: {digit}");
    }
}