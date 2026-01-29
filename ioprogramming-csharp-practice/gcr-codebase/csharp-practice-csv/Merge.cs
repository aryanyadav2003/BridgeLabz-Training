using System;
using System.IO;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        string file1 = "students1.csv";
        string file2 = "students2.csv";
        string outputFile = "students_merged.csv";
        Dictionary<string, string[]> map = new Dictionary<string, string[]>();
        string[] lines2 = File.ReadAllLines(file2);
        for (int i = 1; i < lines2.Length; i++) 
        {
            string[] data = lines2[i].Split(',');
            map[data[0]] = new string[] { data[1], data[2] };
        }
        string[] lines1 = File.ReadAllLines(file1);
        using (StreamWriter writer = new StreamWriter(outputFile))
        {
            writer.WriteLine("ID,Name,Age,Marks,Grade");

            for (int i = 1; i < lines1.Length; i++)
            {
                string[] data = lines1[i].Split(',');
                string id = data[0];
                if (map.ContainsKey(id))
                {
                    writer.WriteLine(
                        id + "," + data[1] + "," + data[2] + "," +
                        map[id][0] + "," + map[id][1]
                    );
                }
            }
        }
        Console.WriteLine("CSV files merged successfully.");
    }
}
