using System;
using System.Collections.Generic;
class SortStackRecursion
{
    static void SortStack(Stack<int> stack)
    {
        if (stack.Count == 0)
            return;

        int top = stack.Pop();
        SortStack(stack);
        InsertSorted(stack, top);
    }
    static void InsertSorted(Stack<int> stack, int element)
    {
        if (stack.Count == 0 || stack.Peek() <= element)
        {
            stack.Push(element);
            return;
        }
        int top = stack.Pop();
        InsertSorted(stack, element);
        stack.Push(top);
    }
    static void Main()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(30);
        stack.Push(10);
        stack.Push(20);
        stack.Push(5);
        SortStack(stack);
        Console.WriteLine("Sorted Stack (Top to Bottom):");
        foreach (int x in stack)
            Console.Write(x + " ");
    }
}
