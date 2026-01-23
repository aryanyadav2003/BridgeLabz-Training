using System;

class MultipleException
{
    static void Main()
    {
        try
        {
            // Initialize array (set to null to test NullReferenceException)
            int[] arr = { 10, 20, 30, 40, 50 };
            Console.Write("Enter index: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine($"Value at index {index}: {arr[index]}");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid index!");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Array is not initialized!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }
}
