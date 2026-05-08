using System;

class Base
{
    public virtual void Show()
    {
        Console.WriteLine("Base Class");
    }
}

class Derived : Base
{
    public override void Show()
    {
        Console.WriteLine("Derived Class");
    }
}

class OverrideDemo
{
    static void Main()
    {
        Base obj = new Derived();
        obj.Show();
    }
}