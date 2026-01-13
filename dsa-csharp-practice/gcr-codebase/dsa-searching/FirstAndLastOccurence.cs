using System;
class FirstAndLastOccurence
{
    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n=int.Parse(Console.ReadLine());
        int[] arr=new int[n];
        Console.WriteLine("Enter array elements : ");
        for(int i = 0; i < n; i++)
        {
            arr[i]=int.Parse(Console.ReadLine());
        }
        Console.Write("Enter target element: ");
        int target = int.Parse(Console.ReadLine());
        int first=-1;
        int last=-1;
        for(int i = 0; i < n; i++)
        {
            if (arr[i] == target)
            {
                if (first == -1)
                {
                    first=i;
                }
                last=i;
            }
        }
        if (first == -1)
        {
            Console.WriteLine("Element not found");
        }
        else
        {
            Console.WriteLine("First Occurence index: " + first);
            Console.WriteLine("Last Occurence index: " + last);
        }
    }
}