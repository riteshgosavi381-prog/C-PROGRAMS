using System;
using System.Collections.Generic;

class DictionaryExample
{
    static void Main()
    {
        Dictionary<int, string> data = new Dictionary<int, string>();

        data.Add(1, "Ritesh");
        data.Add(2, "Amit");

        foreach (var item in data)
            Console.WriteLine(item.Key + " -> " + item.Value);
    }
}