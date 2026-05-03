using System;

class Calculator
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operator (+,-,*,/): ");
        char op = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b = Convert.ToDouble(Console.ReadLine());

        switch (op)
        {
            case '+': Console.WriteLine(a + b); break;
            case '-': Console.WriteLine(a - b); break;
            case '*': Console.WriteLine(a * b); break;
            case '/': Console.WriteLine(a / b); break;
            default: Console.WriteLine("Invalid operator"); break;
        }
    }
}