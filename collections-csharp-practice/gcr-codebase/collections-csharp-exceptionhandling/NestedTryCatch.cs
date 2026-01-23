using System;
class NestedTryCatch
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };
        Console.Write("Enter index: ");
        int index = int.Parse(Console.ReadLine());
        Console.Write("Enter divisor: ");
        int divisor = int.Parse(Console.ReadLine());
        try
        {
            try
            {
                int value = arr[index];
                try
                {
                    int result = value / divisor;
                    Console.WriteLine("Result: " + result);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero!");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid array index!");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter valid numbers.");
        }
    }
}
