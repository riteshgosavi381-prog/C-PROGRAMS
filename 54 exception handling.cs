using System;

class ExceptionDemo
{
    static void Main()
    {
        try
        {
            Console.Write("Enter number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter divisor: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result = " + (a / b));
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero!");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}