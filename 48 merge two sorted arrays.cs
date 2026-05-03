using System;

class MergeSorted
{
    static void Main()
    {
        int[] a = { 1, 3, 5 };
        int[] b = { 2, 4, 6 };

        int[] c = new int[a.Length + b.Length];

        Array.Copy(a, 0, c, 0, a.Length);
        Array.Copy(b, 0, c, a.Length, b.Length);

        Array.Sort(c);

        foreach (int i in c)
            Console.Write(i + " ");
    }
}