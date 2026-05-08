using System;
using System.IO;

class ContactSaver
{
    static void Main()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter phone: ");
        string phone = Console.ReadLine();

        string data = $"Name: {name}, Phone: {phone}\n";

        File.AppendAllText("contacts.txt", data);

        Console.WriteLine("Contact saved!");
    }
}