using System;

class RemoveVowels
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string s = Console.ReadLine();

        string result = "";

        foreach (char c in s)
        {
            if (!"aeiouAEIOU".Contains(c))
                result += c;
        }

        Console.WriteLine(result);
    }
}