using System;
using System.Collections;
class ReverseList
{
    static void ReverseArrayList(ArrayList list)
    {
        int start = 0;
        int end = list.Count - 1;

        while (start < end)
        {
            object temp = list[start];
            list[start] = list[end];
            list[end] = temp;

            start++;
            end--;
        }
    }
    static void Main()
    {
        ArrayList list=new ArrayList(){1,2,3,4,5};
        Console.WriteLine("Original ArrayList:");
        Print(list);

        ReverseArrayList(list);

        Console.WriteLine("Reversed ArrayList:");
        Print(list);
    }
    static void Print(ArrayList list)
    {
        foreach(var item in list)
        {
            Console.Write(item+" ");
        }
        Console.WriteLine();
    }
}