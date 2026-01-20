using System;
class SymmetricDiff
{
    static void Main()
    {
        HashSet<int> set1=new HashSet<int>{1,2,3};
        HashSet<int> set2=new HashSet<int>{3,4,5};
        HashSet<int> ans=new HashSet<int>();
        foreach(int i in set1)
        {
            if (!set2.Contains(i))
            {
                ans.Add(i);
            }
        }
        foreach(int i in set2)
        {
            if (!ans.Contains(i))
            {
                ans.Add(i);
            }
        }
        foreach(int  i in ans)
        {
            Console.Write(i + " ");
        }
    }
}