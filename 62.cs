using System;

interface IAnimal
{
    void Sound();
}

class Dog : IAnimal
{
    public void Sound()
    {
        Console.WriteLine("Bark");
    }
}

class InterfaceDemo
{
    static void Main()
    {
        IAnimal obj = new Dog();
        obj.Sound();
    }
}