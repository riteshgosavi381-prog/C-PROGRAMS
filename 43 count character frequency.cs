using System;

class CharFrequency
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string s = Console.ReadLine();

        foreach (char c in s)
        {
            int count = 0;
            foreach (char ch in s)
            {
                if (c == ch)
                    count++;
            }
            Console.WriteLine(c + " : " + count);
        }
    }
}