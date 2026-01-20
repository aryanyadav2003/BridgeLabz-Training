using System;
class ReverseLinkedList
{
    static LinkedList<int> ReverseLL(LinkedList<int> list)
    {
        LinkedList<int> reversed=new LinkedList<int>();
        LinkedListNode<int> current=list.Last;
        while (current != null)
        {
            reversed.AddLast(current.Value);
            current=current.Previous;
        }
        return reversed;
    }
    static void Main()
    {
        LinkedList<int> list=new LinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(3);
        list.AddLast(4);
        list.AddLast(5);
        Console.WriteLine("Original LinkedList:");
        Print(list);
        LinkedList<int> reversed=ReverseLL(list);
        Console.WriteLine("Reversed LinkedList:");
        Print(reversed);
    }
    static void Print(LinkedList<int> list)
    {
        foreach (int item in list)
            Console.Write(item + " ");
        Console.WriteLine();
    }
}