using System;
class RotationPoint
{
    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n=int.Parse(Console.ReadLine());
        int[] arr=new int[n];
        for(int i = 0; i < n; i++)
        {
            arr[i]=int.Parse(Console.ReadLine());
        }
        int rotationIndex=FindRotationPoint(arr);
        Console.WriteLine("Index of smallest element (rotation point): " + rotationIndex);
        Console.WriteLine("Smallest element: " + arr[rotationIndex]);
    
    }
    static int FindRotationPoint(int[] arr)
    {
        int low=0;
        int high=arr.Length-1;
        while (low < high)
        {
            int mid=(low+high)/2;
            if (arr[mid] > arr[high])
            {
                low=mid+1;
            }
            else
            {
                high=mid;
            }
        }
        return low;
    }
}