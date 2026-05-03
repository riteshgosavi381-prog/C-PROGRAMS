using System;

class LinearSearch
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };

        Console.Write("Enter element to search: ");
        int key = Convert.ToInt32(Console.ReadLine());

        int pos = -1;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == key)
            {
                pos = i;
                break;
            }
        }

        Console.WriteLine(pos != -1 ? "Found at index " + pos : "Not Found");
    }
}