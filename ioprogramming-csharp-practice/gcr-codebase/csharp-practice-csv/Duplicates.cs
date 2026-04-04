using System;
using System.IO;
using System.Collections.Generic;
class Duplicates
{
    static void Main()
    {
        string filePath = "students.csv";
        string[] lines = File.ReadAllLines(filePath);
        HashSet<string> seenIds = new HashSet<string>();
        HashSet<string> printed = new HashSet<string>();
        Console.WriteLine("Duplicate Records:\n");
        for (int i = 1; i < lines.Length; i++) 
        {
            string[] data = lines[i].Split(',');
            string id = data[0];
            if (seenIds.Contains(id))
            {
                if (!printed.Contains(id))
                {
                    Console.WriteLine(lines[i]);
                    printed.Add(id);
                }
            }
            else
            {
                seenIds.Add(id);
            }
        }
    }
}
