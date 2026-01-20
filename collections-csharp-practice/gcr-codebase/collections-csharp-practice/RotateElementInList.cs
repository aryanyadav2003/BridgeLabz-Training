using System;
class RotateElementList
{
    static void Main()
    {
        List<int> numbers=new List<int>{10,20,30,40,50};
        int k=2;
        List<int> rotated=new List<int>();
        for(int i = k; i < numbers.Count; i++)
        {
            rotated.Add(numbers[i]);
        }
        for(int i = 0; i < k; i++)
        {
            rotated.Add(numbers[i]);
        }
        foreach(var v in rotated)
        {
            Console.Write(v + " ");
        }
    }
}