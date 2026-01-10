using System;

class CountingSortAges
{
    static void CountingSort(int[] ages)
    {
        int minAge = 10;
        int maxAge = 18;

        int range = maxAge - minAge + 1;
        int[] count = new int[range];
        int[] output = new int[ages.Length];
        for (int i = 0; i < ages.Length; i++)
        {
            count[ages[i] - minAge]++;
        }
        for (int i = 1; i < count.Length; i++)
        {
            count[i] += count[i - 1];
        }
        for (int i = ages.Length - 1; i >= 0; i--)
        {
            int age = ages[i];
            int index = count[age - minAge] - 1;
            output[index] = age;
            count[age - minAge]--;
        }
        for (int i = 0; i < ages.Length; i++)
        {
            ages[i] = output[i];
        }
    }
    static void Main()
    {
        int[] ages = { 12, 15, 10, 14, 13, 18, 11, 12 };

        Console.WriteLine("Before Sorting:");
        foreach (int a in ages)
            Console.Write(a + " ");

        CountingSort(ages);

        Console.WriteLine("\nAfter Sorting:");
        foreach (int a in ages)
            Console.Write(a + " ");
    }
}
