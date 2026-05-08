using System;

class Overload
{
    static int Add(int a, int b) => a + b;
    static double Add(double a, double b) => a + b;

    static void Main()
    {
        Console.WriteLine(Add(2, 3));
        Console.WriteLine(Add(2.5, 3.5));
    }
}