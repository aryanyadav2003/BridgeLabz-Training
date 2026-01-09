using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
class TargetSum
{  
    static void HasPair(int[] arr,int target)
    {
        HashSet<int> set=new HashSet<int>();
        foreach(int num in arr)
        {
            int required=target-num;
            if (set.Contains(required))
            {
                Console.WriteLine($"Pair found: {num} + {required} = {target}");
            }
            set.Add(num);
        }

    }
    static void Main()
    {
        int[] arr={8,7,2,5,3,1};
        int target=10;
        HasPair(arr,target);
    }
}