using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDiscountSort.AadharSortingSystem
{
    internal class SearchService
    {
        public AadharRecord BinarySearch(AadharRecord[] records,long target)
        {
            int left=0,right=records.Length-1;
            while (left <= right)
            {
                int mid=(left+right)/2;
                if (records[mid].AadharNumber == target)
                {
                    return records[mid];
                }
                else if (records[mid].AadharNumber < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return null;
        }
    }
}
