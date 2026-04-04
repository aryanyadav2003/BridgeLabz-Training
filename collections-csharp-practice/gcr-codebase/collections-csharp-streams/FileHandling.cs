using System;
using System.IO;
using System.Text;
class Program
{
    static void Main()
    {
        string sourcePath = "source.txt";
        string destinationPath = "destination.txt";
        if (!File.Exists(sourcePath))
        {
            Console.WriteLine("Source file does not exist.");
            return;
        }
        FileStream readStream = null;
        FileStream writeStream = null;

        try
        {
            readStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read);
            writeStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write);
            byte[] buffer = new byte[readStream.Length];
            readStream.Read(buffer, 0, buffer.Length);
            writeStream.Write(buffer, 0, buffer.Length);
            Console.WriteLine("File copied successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
        finally
        {
            if (readStream != null)
                readStream.Close();

            if (writeStream != null)
                writeStream.Close();
        }
    }
}
