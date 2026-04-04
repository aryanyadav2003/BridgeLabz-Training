using System;
class Sort
{
    static void Main()
    {
        HashSet<int> set=new HashSet<int>{ 5, 3, 9, 1};
        List<int> list=new List<int>(set);
        for(int i = 0; i < list.Count - 1; i++)
        {
            for(int j = i+1; j < list.Count; j++)
            {
                if (list[i] > list[j])
                {
                    int temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                }
            }
        }
        foreach(int i in list)
        {
            Console.Write(i + " ");
        }
    }
}