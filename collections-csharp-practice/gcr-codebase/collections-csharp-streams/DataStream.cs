using System;
using System.IO;
class Program
{
    static void Main()
    {
        string filePath = "student.dat";

        WriteStudentData(filePath);
        ReadStudentData(filePath);
    }
    static void WriteStudentData(string filePath)
    {
        try
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                // Writing primitive data
                writer.Write(101);               // Roll Number (int)
                writer.Write("Aryan Yadav");     // Name (string)
                writer.Write(8.75);              // GPA (double)

                Console.WriteLine("Student data written successfully.\n");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Write Error: " + ex.Message);
        }
    }

    static void ReadStudentData(string filePath)
    {
        try
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                int rollNo = reader.ReadInt32();
                string name = reader.ReadString();
                double gpa = reader.ReadDouble();
                Console.WriteLine("Student Data Retrieved:");
                Console.WriteLine("Roll No : " + rollNo);
                Console.WriteLine("Name    : " + name);
                Console.WriteLine("GPA     : " + gpa);
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Read Error: " + ex.Message);
        }
    }
}
