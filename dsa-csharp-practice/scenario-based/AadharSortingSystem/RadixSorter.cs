using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDiscountSort.AadharSortingSystem
{
    internal class RadixSorter
    {
        public void Sort(AadharRecord[] records)
        {
            long max=GetMax(records);
            for(long exp = 1; max / exp > 0; exp *= 10)
            {
                CountingSort(records, exp);
            }
        }
        private long GetMax(AadharRecord[] records)
        {
            long max = records[0].AadharNumber;
            for(int i = 1; i < records.Length; i++)
            {
                if (records[i].AadharNumber > max)
                {
                    max= records[i].AadharNumber;
                }
            }
            return max;
        }
        private void CountingSort(AadharRecord[] records, long exp)
        {
            int n = records.Length;
            AadharRecord[] output = new AadharRecord[n];
            int[] count = new int[10];

            // Frequency count
            for (int i = 0; i < n; i++)
            {
                int digit = (int)((records[i].AadharNumber / exp) % 10);
                count[digit]++;
            }

            // Prefix sum (MOST IMPORTANT LINE)
            for (int i = 1; i < 10; i++)
                count[i] += count[i - 1];

            // Build output (RIGHT → LEFT for stability)
            for (int i = n - 1; i >= 0; i--)
            {
                int digit = (int)((records[i].AadharNumber / exp) % 10);

                int index = count[digit] - 1;   
                output[index] = records[i];
                count[digit]--;
            }

            // Copy back
            for (int i = 0; i < n; i++)
                records[i] = output[i];
        }

    }
}
