using System;
using System.IO;

class FileAppend
{
    static void Main()
    {
        Console.Write("Enter text to append: ");
        string text = Console.ReadLine();

        File.AppendAllText("data.txt", "\n" + text);

        Console.WriteLine("Data appended!");
    }
}