using System;
class SortStudentMarks
{
    static void BubbleSort(int[] marks)
    {
        int n=marks.Length;
        bool swapped;
        for(int i = 0; i < n - 1; i++)
        {
            swapped=false;
            for(int j = 0; j < n - i - 1; j++)
            {
                if (marks[j] > marks[j + 1])
                {
                    int temp=marks[j];
                    marks[j]=marks[j+1];
                    marks[j+1]=temp;
                    swapped=true;
                }
            }
            if (!swapped)
            {
                break;
            }
        }
    }
    static void Main()
    {
        int[] marks ={ 78, 45, 89, 32, 67, 90 };
        Console.WriteLine("Before Sorting:");
        foreach (int m in marks)
            Console.Write(m + " ");
        BubbleSort(marks);
        Console.WriteLine("\nAfter Sorting:");
        foreach (int m in marks)
            Console.Write(m + " ");
}
}