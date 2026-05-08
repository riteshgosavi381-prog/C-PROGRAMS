using System;

class AgeException : Exception
{
    public AgeException(string msg) : base(msg) {}
}

class CustomExceptionDemo
{
    static void CheckAge(int age)
    {
        if (age < 18)
            throw new AgeException("You are underage!");
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            CheckAge(age);
            Console.WriteLine("Access granted");
        }
        catch (AgeException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}