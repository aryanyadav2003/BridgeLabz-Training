using System;
using System.IO;
class Employees
{
    static void Main()
    {
        string filePath = "employees.csv";
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("ID,Name,Department,Salary");
            writer.WriteLine("1,Aryan,IT,50000");
            writer.WriteLine("2,Rahul,HR,45000");
            writer.WriteLine("3,Neha,Finance,55000");
            writer.WriteLine("4,Priya,Marketing,48000");
            writer.WriteLine("5,Karan,IT,60000");
        }
        Console.WriteLine("Employee data written to CSV file successfully.");
    }
}
