using System;
using System.Collections.Concurrent;
class SortingComparison
{
    static int bubbleSteps=0;
    static int mergeSteps = 0;
    static int quickSteps = 0;
    static void Main()
    {
        int n=10000;
        int[] arr1 = GenerateArray(n);
        int[] arr2 = GenerateArray(n);
        int[] arr3 = GenerateArray(n);
        BubbleSort(arr1);
        MergeSort(arr2, 0, arr2.Length - 1);
        QuickSort(arr3, 0, arr3.Length - 1);
        Console.WriteLine("Dataset Size: " + n);
        Console.WriteLine("Bubble Sort Steps : " + bubbleSteps);
        Console.WriteLine("Merge Sort Steps  : " + mergeSteps);
        Console.WriteLine("Quick Sort Steps  : " + quickSteps);
    }
    static int[] GenerateArray(int n)
    {
        int[] arr=new int[n];
        for(int i = 0; i < n; i++)
        {
            arr[i]=n-i;
        }
        return arr;
    }
    static void BubbleSort(int[] arr)
    {
        for(int i = 0; i < arr.Length - 1; i++)
        {
            for(int j = 0; j < arr.Length - i - 1; j++)
            {
                bubbleSteps++;
                if (arr[j] > arr[j + 1])
                {
                    int temp=arr[j];
                    arr[j]=arr[j+1];
                    arr[j+1]=temp;
                }
            }
        }
    }
    static void MergeSort(int[] arr,int left,int right)
    {
        if (left < right)
        {
            mergeSteps++;
            int mid=(left+right)/2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }
    static void Merge(int[] arr, int left, int mid, int right)
    {
        int[] temp = new int[right - left + 1];
        int i = left, j = mid + 1, k = 0;
        while (i <= mid && j <= right)
        {
            mergeSteps++;
            if (arr[i] <= arr[j])
                temp[k++] = arr[i++];
            else
                temp[k++] = arr[j++];
        }
        while (i <= mid) temp[k++] = arr[i++];
        while (j <= right) temp[k++] = arr[j++];
        for (int x = 0; x < temp.Length; x++)
            arr[left + x] = temp[x];
    }
    static void QuickSort(int[] arr,int low,int high)
    {
        if (low < high)
        {
            quickSteps++;
            int p=Partition(arr,low,high);
            QuickSort(arr,low,p-1);
            QuickSort(arr,p+1,high);
        }
    }
     static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;
        for (int j = low; j < high; j++)
        {
            quickSteps++;
            if (arr[j] < pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        int t = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = t;
        return i + 1;
    }
}