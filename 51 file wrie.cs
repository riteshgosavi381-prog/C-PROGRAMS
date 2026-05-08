using System;
using System.IO;

class FileWrite
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        File.WriteAllText("data.txt", text);

        Console.WriteLine("File saved successfully!");
    }
}