using System;
class SearchComparison
{
    static void Main()
    {
        int n=1000000;
        int target=n-1;
        int[] data=new int[n];
        for(int i = 0; i < n; i++)
        {
            data[i]=i;
        }
        int linearSteps = LinearSearch(data, target);
        int binarySteps = BinarySearch(data, target);

        Console.WriteLine("Dataset Size: " + n);
        Console.WriteLine("Linear Search Steps: " + linearSteps);
        Console.WriteLine("Binary Search Steps: " + binarySteps);
    }
    static int LinearSearch(int[] arr,int target)
    {
        int steps=0;
        for(int i = 0; i < arr.Length; i++)
        {
            steps++;
            if (arr[i] == target)
            {
                return steps;
            }
        }
        return steps;
    }
    static int BinarySearch(int[] arr,int target)
    {
        int steps=0;
        int low=0;
        int high=arr.Length-1;
        while (low <= high)
        {
            steps++;
            int mid=(low+high)/2;
            if (arr[mid] == target)
            {
                return steps;
            }
            else if (arr[mid] < target)
            {
                low=mid+1;
            }
            else
            {
                high=mid-1;
            }
        }
        return steps;
    }
}