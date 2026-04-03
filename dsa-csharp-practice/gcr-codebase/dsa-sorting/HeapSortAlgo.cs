using System;
class HeapSort
{
    static void Heapify(int[] salaries, int n, int i)
    {
        int largest = i;      
        int left = 2 * i + 1;  
        int right = 2 * i + 2; 
        if (left < n && salaries[left] > salaries[largest])
            largest = left;
        if (right < n && salaries[right] > salaries[largest])
            largest = right;
        if (largest != i)
        {
            int temp = salaries[i];
            salaries[i] = salaries[largest];
            salaries[largest] = temp;
            Heapify(salaries, n, largest);
        }
    }
    static void HeapSortAlgo(int[] salaries)
    {
        int n = salaries.Length;
        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(salaries, n, i);
        for (int i = n - 1; i > 0; i--)
        {
            int temp = salaries[0];
            salaries[0] = salaries[i];
            salaries[i] = temp;

            Heapify(salaries, i, 0);
        }
    }

    static void Main()
    {
        int[] salaries = { 45000, 70000, 30000, 90000, 60000 };

        Console.WriteLine("Before Sorting:");
        foreach (int s in salaries)
            Console.Write(s + " ");

        HeapSortAlgo(salaries);

        Console.WriteLine("\nAfter Sorting (Ascending):");
        foreach (int s in salaries)
            Console.Write(s + " ");
    }
}
