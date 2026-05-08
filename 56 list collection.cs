using System;
using System.Collections.Generic;

class ListExample
{
    static void Main()
    {
        List<int> list = new List<int>();

        list.Add(10);
        list.Add(20);
        list.Add(30);

        foreach (int i in list)
            Console.WriteLine(i);
    }
}