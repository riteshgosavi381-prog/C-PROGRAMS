using System;

class Automorphic
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int square = num * num;

        if (square.ToString().EndsWith(num.ToString()))
            Console.WriteLine("Automorphic");
        else
            Console.WriteLine("Not Automorphic");
    }
}