using System;

class DuplicateElements
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 2, 4, 1 };

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    Console.WriteLine("Duplicate: " + arr[i]);
                    break;
                }
            }
        }
    }
}