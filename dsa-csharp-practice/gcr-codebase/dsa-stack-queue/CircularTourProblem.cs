using System;
class CircularTour
{   
    static int FindStartPoint(int[] petrol,int[] distance)
    {
        int n=petrol.Length;
        for(int start = 0; start < n; start++)
        {
            int surplus=0;
            int count=0;
            int i=start;
         while (count < n)
            {
                surplus += petrol[i] - distance[i];
                if (surplus < 0)
                    break;
                i=(i+1)%n;
                count++;
            }
            if (count == n)
                return start;
        }
        return -1;
    }
    static void Main()
    {
        int[] petrol={6,3,7};
        int[] distance={4,6,3};
        int start=FindStartPoint(petrol,distance);
        if (start == -1)
        {
            Console.WriteLine("No possible tour");
        }
        else
        {
            Console.WriteLine("Start at petrol pump index: " + start);
        }
    }
}