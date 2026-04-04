using System;
class UnionIntersection
{
    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };
        HashSet<int> union=new HashSet<int>();
        HashSet<int> intersection = new HashSet<int>();
        foreach(int i in set1)
        {
            union.Add(i);
        }
        foreach(int i in set2)
        {
            if (union.Contains(i))
            {
                intersection.Add(i);
            }
            union.Add(i);
        }
        Console.Write("Union : ");
        foreach(var v in union)
        {
            Console.Write(v + " ");
        }
        Console.WriteLine();
        Console.Write("Intersection : ");
         foreach(var v in intersection)
        {
            Console.Write(v + " ");
        }
    }
}