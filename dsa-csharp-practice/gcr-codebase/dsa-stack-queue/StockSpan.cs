using System;
using System.Collections.Generic;
class StockSpanProblem
{
    static void CalculateSpan(int[] price)
    {
        int n = price.Length;
        int[] span = new int[n];
        Stack<int> stack = new Stack<int>();
        stack.Push(0);
        span[0] = 1;
        for (int i = 1; i < n; i++)
        {
            while (stack.Count > 0 && price[stack.Peek()] <= price[i])
            {
                stack.Pop();
            }
            span[i] = (stack.Count == 0) ? (i + 1) : (i - stack.Peek());
            stack.Push(i);
        }
        Console.WriteLine("Day\tPrice\tSpan");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"{i}\t{price[i]}\t{span[i]}");
        }
    }
    static void Main()
    {
        int[] price = { 100, 80, 60, 70, 60, 75, 85 };
        CalculateSpan(price);
    }
}
