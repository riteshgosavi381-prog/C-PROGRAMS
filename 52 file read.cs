using System;
using System.IO;

class FileRead
{
    static void Main()
    {
        if (File.Exists("data.txt"))
        {
            string content = File.ReadAllText("data.txt");
            Console.WriteLine("File Content:\n" + content);
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }
}