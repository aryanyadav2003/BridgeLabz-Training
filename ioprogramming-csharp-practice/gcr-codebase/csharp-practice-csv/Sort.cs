using System;
using System.IO;
using System.Linq;
class Program
{
    static void Main()
    {
        string filePath = "employees.csv";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("CSV file not found.");
            return;
        }
        var topEmployees = File.ReadAllLines(filePath).Skip(1).Select(line => line.Split(',')).OrderByDescending(e => double.Parse(e[3])).Take(5);

        Console.WriteLine("Top 5 Highest-Paid Employees:");
        foreach (var e in topEmployees)
        {
            Console.WriteLine($"Name       : {e[1]}");
            Console.WriteLine($"Department : {e[2]}");
            Console.WriteLine($"Salary     : {e[3]}");
            Console.WriteLine();
        }
    }
}
