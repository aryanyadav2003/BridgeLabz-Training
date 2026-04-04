using System;
using System.IO;
class StudentData
{
    static void Main()
    {
        string filePath = "students.csv";
        if (!File.Exists(filePath))
        {
            Console.WriteLine("CSV file not found.");
            return;
        }
        string[] lines = File.ReadAllLines(filePath);
        Console.WriteLine("Student Details:\n");
        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');
            int id = int.Parse(data[0]);
            string name = data[1];
            int age = int.Parse(data[2]);
            int marks = int.Parse(data[3]);
            Console.WriteLine($"ID    : {id}");
            Console.WriteLine($"Name  : {name}");
            Console.WriteLine($"Age   : {age}");
            Console.WriteLine($"Marks : {marks}");
            Console.WriteLine("");
        }
    }
}
