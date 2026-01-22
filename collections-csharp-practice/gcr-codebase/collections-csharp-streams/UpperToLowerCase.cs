using System;
using System.IO;
using System.Text;
class Program
{
    static void Main()
    {
        string sourceFile = "input.txt";
        string destinationFile = "output.txt";

        if (!File.Exists(sourceFile))
        {
            Console.WriteLine("Source file not found.");
            return;
        }
        try
        {
            using (FileStream fsRead = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
            using (BufferedStream bsRead = new BufferedStream(fsRead))
            using (StreamReader reader = new StreamReader(bsRead, Encoding.UTF8))
            using (FileStream fsWrite = new FileStream(destinationFile, FileMode.Create, FileAccess.Write))
            using (BufferedStream bsWrite = new BufferedStream(fsWrite))
            using (StreamWriter writer = new StreamWriter(bsWrite, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line.ToLower());
                }
            }
            Console.WriteLine("File converted successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
