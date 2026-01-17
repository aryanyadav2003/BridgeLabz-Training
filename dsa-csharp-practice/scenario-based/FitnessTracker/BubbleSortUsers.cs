using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDiscountSort.FitnessTracker
{
    internal class BubbleSortUsers
    {
        public static void Sort(User[] users)
        {
            int n = users.Length;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n - i - 1; j++)
                {
                    if (users[j].Steps > users[j + 1].Steps)
                    {
                        User temp = users[j];
                        users[j] = users[j + 1];
                        users[j + 1] = temp;
                    }
                }
            }
        }
    }
}
