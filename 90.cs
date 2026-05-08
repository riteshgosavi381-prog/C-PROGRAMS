using System;
using System.Linq;

class Intersection
{
    static void Main()
    {
        int[] a = { 1, 2, 3, 4 };
        int[] b = { 3, 4, 5, 6 };

        var result = a.Intersect(b);

        foreach (var x in result)
            Console.WriteLine(x);
    }
}