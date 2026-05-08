using System;
using System.Collections.Generic;

class FrequencyDict
{
    static void Main()
    {
        int[] arr = { 1, 2, 2, 3, 3, 3 };

        Dictionary<int, int> freq = new Dictionary<int, int>();

        foreach (int num in arr)
        {
            if (freq.ContainsKey(num))
                freq[num]++;
            else
                freq[num] = 1;
        }

        foreach (var item in freq)
            Console.WriteLine(item.Key + " => " + item.Value);
    }
}