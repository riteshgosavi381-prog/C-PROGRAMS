using System;

class CheckSorted
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        bool isSorted = true;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                isSorted = false;
                break;
            }
        }

        Console.WriteLine(isSorted ? "Sorted" : "Not Sorted");
    }
}