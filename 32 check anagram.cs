using System;
using System.Linq;

class Anagram
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string s1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string s2 = Console.ReadLine();

        var a = String.Concat(s1.OrderBy(c => c));
        var b = String.Concat(s2.OrderBy(c => c));

        Console.WriteLine(a == b ? "Anagram" : "Not Anagram");
    }
}