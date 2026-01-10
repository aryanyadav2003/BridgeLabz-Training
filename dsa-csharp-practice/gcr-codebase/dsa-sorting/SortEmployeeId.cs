using System;
using System.Security.Cryptography;
class SortemployeeId
{
    static void InsertionSort(int[] ids)
    {
        int n=ids.Length;
        for(int i = 1; i < n; i++)
        {
            int key=ids[i];
            int j=i-1;
            while(j>0 && ids[j] > key)
            {
                ids[j+1]=ids[j];
                j--;
            }
            ids[j+1]=key;
        }
    }
    static void Main()
    {
        int[] employeeIds = { 104, 101, 109, 102, 106 };

        Console.WriteLine("Before Sorting:");
        foreach (int id in employeeIds)
            Console.Write(id + " ");

        InsertionSort(employeeIds);

        Console.WriteLine("\nAfter Sorting:");
        foreach (int id in employeeIds)
            Console.Write(id + " ");
}}