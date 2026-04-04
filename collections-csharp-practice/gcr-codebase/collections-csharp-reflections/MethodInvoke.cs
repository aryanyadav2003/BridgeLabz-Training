using System;
using System.Reflection;
class MathOperations
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;
}
class MethodInvoke
{
    static void Main()
    {
        MathOperations math = new MathOperations();
        Type type = typeof(MathOperations);

        Console.WriteLine("Available methods: Add, Subtract, Multiply");
        Console.Write("Enter method name to invoke: ");
        string methodName = Console.ReadLine();

        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());
        MethodInfo method = type.GetMethod(methodName,BindingFlags.Public | BindingFlags.Instance);

        if (method != null)
        {
            object result = method.Invoke(math, new object[] { num1, num2 });
            Console.WriteLine($"Result: {result}");
        }
        else
        {
            Console.WriteLine("Method not found!");
        }
    }
}
