using System;
using System.Collections.Generic;
class QueueUsingStack
{
    Stack<int> s1=new Stack<int>();
    Stack<int> s2=new Stack<int>();
    public void Enqueue(int x)
    {
        s1.Push(x);
        Console.WriteLine(x+"enqueued");
    }
    public int Dequeue()
    {
        if(s1.Count==0 && s2.Count == 0)
        {
            Console.WriteLine("Queue is Empty");
            return -1;
        }
        if (s2.Count == 0)
        {
            while (s1.Count > 0)
            {
                s2.Push(s1.Pop());
            }
        }
        return s2.Pop();
    }
    public void Display()
    {
        if(s1.Count==0 && s2.Count == 0)
        {
            Console.WriteLine("Queue is empty");
            return;
        }
        Console.Write("Queue:");
        foreach(int x in s2)
        {
            Console.Write(x+" ");
        }
        int[] arr = s1.ToArray();
        for (int i = arr.Length - 1; i >= 0; i--){
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
    static void Main()
    {
        QueueUsingStack q=new QueueUsingStack();
        q.Enqueue(10);
        q.Enqueue(20);
        q.Enqueue(30);
        q.Display();
        Console.WriteLine("Dequeued: " + q.Dequeue());
        Console.WriteLine("Dequeued: " + q.Dequeue());
        q.Display();
    }
}