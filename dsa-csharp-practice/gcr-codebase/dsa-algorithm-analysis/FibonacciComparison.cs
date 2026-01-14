using System;
class FibonacciComaprison
{
    static int recursiveCalls=0;
    static int iterativeSteps=0;
    static void Main()
    {
        int n=10;
        FibonacciRecursive(n);
        FibonacciIterative(n);
        Console.WriteLine("Fibonacci Number: " + n);
        Console.WriteLine("Recursive Calls  : " + recursiveCalls);
        Console.WriteLine("Iterative Steps  : " + iterativeSteps);
    }
    static int FibonacciRecursive(int n)
    {
        recursiveCalls++;
        if (n <= 1)
        {
            return n;
        }
        return FibonacciRecursive(n-1)+FibonacciRecursive(n-2);
    }
    static int FibonacciIterative(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        int a=0,b=1,sum=0;
        for(int i = 2; i <= n; i++)
        {
            iterativeSteps++;
            sum=a+b;
            a=b;
            b=sum;
        }
        return b; 
    }
}