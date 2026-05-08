using System;

class ToggleCase
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string s = Console.ReadLine();

        string result = "";

        foreach (char c in s)
        {
            if (char.IsUpper(c))
                result += char.ToLower(c);
            else
                result += char.ToUpper(c);
        }

        Console.WriteLine(result);
    }
}