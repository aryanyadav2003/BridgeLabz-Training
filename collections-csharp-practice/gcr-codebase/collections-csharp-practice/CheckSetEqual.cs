using System;
class CheckSetEqual
{
    static void Main(string[] args)
    {
        HashSet<int> set1=new HashSet<int>{1,2,3};
        HashSet<int> set2=new HashSet<int>{3,2,1};
        bool isEqual=true;
        if (set1.Count != set2.Count)
        {
            isEqual=false;
        }
        else
        {
            foreach(int item in set1)
            {
                if (!set2.Contains(item))
                {
                    isEqual=false;
                    break;
                }
            }
        }
        Console.WriteLine(isEqual);
    }
}