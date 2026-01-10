using System;
class MergeSort
{
    static void MergeSortAlgo(int[] prices,int left,int right)
    {
        if (left < right)
        {
            int mid=(left+right)/2;
            MergeSortAlgo(prices,left,mid);
            MergeSortAlgo(prices,mid+1,right);
            Merge(prices,left,mid,right);
        }
    }
    static void Merge(int[] prices,int left,int mid,int right)
    {
        int n1=mid-left+1;
        int n2=right-mid;
        int[] L=new int[n1];
        int[] R=new int[n2];
        for(int i = 0; i < n1; i++)
        {
            L[i]=prices[left+i];
        }
        for(int j = 0; j < n2; j++)
        {
            R[j]=prices[mid+1+j];
        }
        int iIndex = 0, jIndex = 0, k = left;
        while(iIndex<n1 && jIndex < n2)
        {
            if (L[iIndex]<=R[jIndex])
                prices[k++]=L[iIndex++];
            else
                prices[k++]=R[jIndex++];
        }
         while (iIndex < n1)
            prices[k++] = L[iIndex++];

        while (jIndex < n2)
            prices[k++] = R[jIndex++];
    }
    static void Main()
    {
        int[] prices = { 450, 120, 300, 200, 150 };

        Console.WriteLine("Before Sorting:");
        foreach (int p in prices)
            Console.Write(p + " ");

        MergeSortAlgo(prices, 0, prices.Length - 1);

        Console.WriteLine("\nAfter Sorting (Ascending):");
        foreach (int p in prices)
            Console.Write(p + " ");
    }
}