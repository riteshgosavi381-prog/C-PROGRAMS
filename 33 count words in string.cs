using System;

class WordCount
{
    static void Main()
    {
        Console.Write("Enter sentence: ");
        string s = Console.ReadLine();

        int count = s.Split(' ').Length;

        Console.WriteLine("Words = " + count);
    }
}