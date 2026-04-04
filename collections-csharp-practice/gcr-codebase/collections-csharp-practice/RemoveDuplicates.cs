using System;
using System.Dynamic;
class RemoveDuplicates
{
    static void Main()
    {
        List<int> input = new List<int> { 3, 1, 2, 2, 3, 4 };
        List<int> result=new List<int>();
        HashSet<int> seen=new HashSet<int>();
        foreach(int item in input)
        {
            if (!seen.Contains(item))
            {
                seen.Add(item);
                result.Add(item);
            }
        }
        foreach(var v in result)
        {
            Console.Write(v + " ");
        }
    }
}