using System;
class NthNode
{
    static void Main()
    {
        LinkedList<string> list=new LinkedList<string>();
        list.AddLast("A");
        list.AddLast("B");
        list.AddLast("C");
        list.AddLast("D");
        list.AddLast("E");
        int n=2;
        LinkedListNode<string> first=list.First;
        LinkedListNode<string> second=list.First;
        for(int i = 0; i < n; i++)
        {
            if (first == null)
            {
                Console.WriteLine("N is larger than list size");
                return;
            }
            first=first.Next;
        }
        while (first != null)
        {
            first=first.Next;
            second=second.Next;
        }
        Console.WriteLine("Nth element from end: " + second.Value);
    }
}