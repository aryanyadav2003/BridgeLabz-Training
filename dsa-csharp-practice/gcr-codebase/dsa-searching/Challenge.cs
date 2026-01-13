using System;
class Challenge
{
    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n=int.Parse(Console.ReadLine());
        int[] arr=new int[n];
        Console.WriteLine("Enter array elements:");
        for(int i = 0; i < n; i++)
        {
            arr[i]=int.Parse(Console.ReadLine());
        }
        int missing=FindFirstMissing(arr);
        Console.WriteLine("First Missing Positive Integer: " + missing);
        Console.Write("Enter target element to search: ");
        int target = int.Parse(Console.ReadLine());
        Array.Sort(arr);
        int index=BinarySearch(arr,target);
        if (index != -1) Console.WriteLine("Target found at index: " + index);
        else Console.WriteLine("Target not found.");
    }
    static int FindFirstMissing(int[] arr)
    {
        bool[] visited=new bool[arr.Length+1];
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i]>0 && arr[i] <= arr.Length)
            {
                visited[arr[i]] = true;
            }
        }
          for (int i = 1; i <= arr.Length; i++)
        {
            if (!visited[i])
                return i;
        }
        return arr.Length + 1;
    }
     static int BinarySearch(int[] arr, int target)
    {
        int low = 0, high = arr.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return -1;
    }
}