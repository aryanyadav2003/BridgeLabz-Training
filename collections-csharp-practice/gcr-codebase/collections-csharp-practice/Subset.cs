using System;
class Subset
{
    static void Main()
    {
        HashSet<int> setA = new HashSet<int> { 2, 3 };
        HashSet<int> setB = new HashSet<int> { 1, 2, 3 , 4 };
        bool isSubset=true;
        foreach(int i in setA)
        {
            if (!setB.Contains(i))
            {
                isSubset=false;
                break;
            }
        }
        Console.WriteLine(isSubset);
    }
}