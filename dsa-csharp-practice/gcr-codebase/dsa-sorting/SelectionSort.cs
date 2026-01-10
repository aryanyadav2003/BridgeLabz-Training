using System;
class SelectionSort
{
    static void SelectionSortAlgo(int[] scores)
    {
        int n=scores.Length;
        for(int i = 0; i < n - 1; i++)
        {
            int minIdx=i;
            for(int j = i + 1; j < n; j++)
            {
                if (scores[j] < scores[minIdx])
                {
                    minIdx=j;
                }
            }
            int temp=scores[minIdx];
            scores[minIdx]=scores[i];
            scores[i]=temp;
        }
    }
     static void Main()
    {
        int[] scores = { 78, 45, 89, 32, 67 };

        Console.WriteLine("Before Sorting:");
        foreach (int s in scores)
            Console.Write(s + " ");

        SelectionSortAlgo(scores);

        Console.WriteLine("\nAfter Sorting:");
        foreach (int s in scores)
            Console.Write(s + " ");
    }
}