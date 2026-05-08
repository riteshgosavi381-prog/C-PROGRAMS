using System;
using System.Linq;

class LinqExample
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };

        var even = arr.Where(x => x % 2 == 0);

        foreach (var i in even)
            Console.WriteLine(i);
    }
}