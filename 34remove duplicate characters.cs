using System;
using System.Linq;

class RemoveDuplicates
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string s = Console.ReadLine();

        string result = new string(s.Distinct().ToArray());

        Console.WriteLine(result);
    }
}