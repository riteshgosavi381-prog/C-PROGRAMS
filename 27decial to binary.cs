using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        string binary = Convert.ToString(num, 2);

        Console.WriteLine("Binary = " + binary);
    }
}