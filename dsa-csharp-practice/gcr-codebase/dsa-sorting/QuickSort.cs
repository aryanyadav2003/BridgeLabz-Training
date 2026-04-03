using System;
using System.Collections.Concurrent;
class QuickSort
{
    static void QuickSortAlgo(int[] prices,int low,int high)
    {
        if (low < high)
        {
            int pivotIndex=Partition(prices,low,high);
            QuickSortAlgo(prices,low,pivotIndex-1);
            QuickSortAlgo(prices,pivotIndex+1,high);
        }
    }
    static int Partition(int[] prices, int low, int high)
    {
        int pivot = prices[low];  
        int i = low + 1;
        int j = high;

        while (i <= j)
        {
            while (i <= high && prices[i] <= pivot)
                i++;

            while (prices[j] > pivot)
                j--;

            if (i < j)
            {
                int temp = prices[i];
                prices[i] = prices[j];
                prices[j] = temp;
            }
    }
        prices[low] = prices[j];
        prices[j] = pivot;

        return j;
    }
     static void Main()
    {
        int[] prices = { 450, 120, 300, 200, 150 };

        Console.WriteLine("Before Sorting:");
        foreach (int p in prices)
            Console.Write(p + " ");

        QuickSortAlgo(prices, 0, prices.Length - 1);

        Console.WriteLine("\nAfter Sorting (Ascending):");
        foreach (int p in prices)
            Console.Write(p + " ");
    }
}