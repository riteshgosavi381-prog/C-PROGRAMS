using System;

class BinarySearch
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };

        Console.Write("Enter number: ");
        int key = Convert.ToInt32(Console.ReadLine());

        int low = 0, high = arr.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] == key)
            {
                Console.WriteLine("Found at index " + mid);
                return;
            }
            else if (arr[mid] < key)
                low = mid + 1;
            else
                high = mid - 1;
        }

        Console.WriteLine("Not Found");
    }
}