using System;
using System.IO;
class FileNotFound
{
    static void Main()
    {
        string filePath = "data.txt";
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine("File Contents:");
                Console.WriteLine(content);
            }
        }
        catch (IOException)
        {
            Console.WriteLine("File not found");
        }
    }
}
