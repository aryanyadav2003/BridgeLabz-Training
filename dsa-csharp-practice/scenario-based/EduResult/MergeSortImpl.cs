using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDiscountSort.EduResults
{
    internal class MergeSortImpl
    {
        public static void MergeSort(Student[] arr,int left,int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }
        public static void Merge(Student[] arr,int left,int mid,int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;
            Student[] L = new Student[n1];
            Student[] R = new Student[n2];
            for(int i = 0; i < n1; i++)
            {
                L[i] = arr[left + i];
            }
            for(int j = 0; j < n2; j++)
            {
                R[j] = arr[mid + j + 1];
            }
            int iIdx = 0;
            int jIdx = 0; 
            int k = left;
            while(iIdx<n1 && jIdx < n2)
            {
                if (L[iIdx].Score >= R[jIdx].Score)
                {
                    arr[k++] = L[iIdx++];
                }
                else
                {
                    arr[k++] = R[jIdx++];
                }
            }
            while (iIdx < n1)
            {
                arr[k++] = L[iIdx++];
            }
            while (jIdx < n2)
            {
                arr[k++] = R[jIdx++];
            }
        }
    }
}
