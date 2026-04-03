using System;
class SildingMaximumWindow
{ 
    static void PrintArray(int[] arr,int k)
    {
        int n=arr.Length;
        for(int i = 0; i <=n-k; i++)
        {
            int max=arr[i];
            for(int j = i; j < i + k; j++)
            {
                if (arr[j] > max)
                {
                    max=arr[j];
                }
            }
            Console.Write(max+ " ");
        }
    }
    static void Main()
    {
        int[] arr = { 1, 3, -1, -3, 5, 3, 6, 7 };
        int k = 3;
        PrintArray(arr,k);
    }
}