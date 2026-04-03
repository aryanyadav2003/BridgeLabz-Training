using System;
class FirstNegative
{
    static void Main(){
    Console.Write("Enter number of elements:");
    int n=int.Parse(Console.ReadLine());
    int[] arr=new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = int.Parse(Console.ReadLine());
    }
    int index=-1;
    for(int i = 0; i < n; i++)
        {
            if (arr[i] < 0)
            {
                index=i;
                break;
            }
        }
         if (index != -1)
        {
            Console.WriteLine("First negative number: " + arr[index]);
            Console.WriteLine("Found at index: " + index);
        }
        else
        {
            Console.WriteLine("No negative number found.");
        }
    }
}