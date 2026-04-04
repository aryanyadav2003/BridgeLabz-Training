using System;
using System.IO;
class SearchRecords
{
    static void Main()
    {
        string filePath = "employees.csv";
        if (!File.Exists(filePath))
        {
            Console.WriteLine("CSV file not found.");
            return;
        }
        Console.Write("Enter employee name to search: ");
        string searchName = Console.ReadLine();
        string[] lines = File.ReadAllLines(filePath);
        bool found = false;
        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');
            string name = data[1];
            if (name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
            {
                string department = data[2];
                string salary = data[3];
                Console.WriteLine("Employee Found:");
                Console.WriteLine($"Name       : {name}");
                Console.WriteLine($"Department : {department}");
                Console.WriteLine($"Salary     : {salary}");
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine("Employee not found.");
        }
    }
}
