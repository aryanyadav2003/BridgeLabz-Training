using System;
using System.Collections.Generic;
class LongestConsecutiveSequence
{
    static int FindLongest(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }
        HashSet<int> set=new HashSet<int>();
        foreach(int num in nums)
        {
            set.Add(num);
        }
        int longest=0;
        foreach(int num in set)
        {
            if (!set.Contains(num - 1))
            {
                int currNum=num;
                int currLength=1;
                while (set.Contains(currNum + 1))
                {
                    currNum++;
                    currLength++;
                }
                longest=Math.Max(longest,currLength);
            }
        }
        return longest;
    }
    static void Main()
    {
        int[] nums = { 100, 4, 200, 1, 3, 2 };
        Console.WriteLine("Longest Consecutive Sequence Length: " + FindLongest(nums));
    }
}