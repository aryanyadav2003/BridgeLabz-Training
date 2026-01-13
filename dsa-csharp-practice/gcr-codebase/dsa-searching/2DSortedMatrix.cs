using System;
class TwoDSortedMatrix
{
    static void Main()
    {
        Console.Write("Enter number of rows : ");
        int rows=int.Parse(Console.ReadLine());
        Console.Write("Enter number of cloumns : ");
        int cols=int.Parse(Console.ReadLine());
        int[,] matrix=new int[rows,cols];
        Console.WriteLine("Enter matrix elements (row-wise sorted):");
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                matrix[i,j]=int.Parse(Console.ReadLine());
            }
        }
        Console.Write("Enter target value: ");
        int target=int.Parse(Console.ReadLine());
        bool found=false;
        for(int i = 0; i < rows; i++)
        {
            int left=0;
            int right=cols-1;
            while (left <= right)
            {
                int mid=(left+right)/2;
                if (matrix[i, mid] == target)
                {
                    Console.WriteLine($"Target found at row {i},column {mid}");
                    found=true;
                    break;
                }
                else if (matrix[i, mid] < target)
                {
                    left=mid+1;
                }
                else
                {
                    right=mid-1;
                }
            }
            if (found)
            {
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine("Target not found in matrix");
        }
    }
}