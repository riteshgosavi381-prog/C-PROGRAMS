using System;
using System.Collections;

class StackDemo
{
    static void Main()
    {
        Stack stack = new Stack();

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        while (stack.Count > 0)
            Console.WriteLine(stack.Pop());
    }
}