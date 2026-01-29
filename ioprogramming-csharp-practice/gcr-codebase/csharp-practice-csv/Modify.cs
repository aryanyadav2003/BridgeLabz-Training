using System;
using System.IO;
class Modify
{
    static void Main()
    {
        string inputFile = "employees.csv";
        string outputFile = "employees_updated.csv";
        if (!File.Exists(inputFile))
        {
            Console.WriteLine("Input CSV file not found.");
            return;
        }
        string[] lines = File.ReadAllLines(inputFile);
        using (StreamWriter writer = new StreamWriter(outputFile))
        {
            writer.WriteLine(lines[0]);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');

                int id = int.Parse(data[0]);
                string name = data[1];
                string department = data[2];
                double salary = double.Parse(data[3]);
                if (department.Equals("IT", StringComparison.OrdinalIgnoreCase))
                {
                    salary += salary * 0.10;
                }
                writer.WriteLine($"{id},{name},{department},{salary}");
            }
        }
        Console.WriteLine("Updated CSV file created successfully.");
    }
}
