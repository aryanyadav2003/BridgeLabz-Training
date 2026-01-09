using System;
class SubarraysWithSumZero
{
    static void FindSubarrays(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = i; j < n; j++)
            {
                sum += arr[j];
                if (sum == 0)
                {
                    Console.WriteLine($"Subarray found from index {i} to {j}");
                }
            }
        }
    }
    static void Main()
    {
        int[] arr = { 3, 4, -7, 3, 1, 3, 1, -4 };
        FindSubarrays(arr);
    }
}
