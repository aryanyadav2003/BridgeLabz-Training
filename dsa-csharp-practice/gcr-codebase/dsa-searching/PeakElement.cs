using System;
class PeakElement
{
    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine()!);
        }
        int peakIndex = FindPeak(arr);
        Console.WriteLine("Peak element found at index: " + peakIndex);
        Console.WriteLine("Peak element value: " + arr[peakIndex]);
    }
    static int FindPeak(int[] arr)
    {
        int low=0;
        int high=arr.Length-1;
        while (low < high)
        {
            int mid=(low+high)/2;
            if (arr[mid] < arr[mid + 1])
            {
                low=mid+1;
            }else high=mid;
        }
        return low;
    }
}