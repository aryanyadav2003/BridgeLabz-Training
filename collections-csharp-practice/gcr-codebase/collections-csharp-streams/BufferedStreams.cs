using System;
using System.Diagnostics;
using System.IO;
class Program
{
    static void Main()
    {
        string sourceFile = "largefile.dat";
        string normalCopy = "normal_copy.dat";
        string bufferedCopy = "buffered_copy.dat";
        if (!File.Exists(sourceFile))
        {
            Console.WriteLine("Source file not found.");
            return;
        }
        Console.WriteLine("Copying using normal FileStream...");
        long normalTime = CopyWithFileStream(sourceFile, normalCopy);
        Console.WriteLine("\nCopying using BufferedStream...");
        long bufferedTime = CopyWithBufferedStream(sourceFile, bufferedCopy);
        Console.WriteLine("\n---- Performance Comparison ----");
        Console.WriteLine("Normal FileStream Time   : " + normalTime + " ms");
        Console.WriteLine("BufferedStream Time      : " + bufferedTime + " ms");
    }
    static long CopyWithFileStream(string source, string destination)
    {
        Stopwatch sw = Stopwatch.StartNew();
        using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
        using (FileStream fsWrite = new FileStream(destination, FileMode.Create, FileAccess.Write))
        {
            byte[] buffer = new byte[4096];
            int bytesRead;
            while ((bytesRead = fsRead.Read(buffer, 0, buffer.Length)) > 0)
            {
                fsWrite.Write(buffer, 0, bytesRead);
            }
        }
        sw.Stop();
        return sw.ElapsedMilliseconds;
    }
    static long CopyWithBufferedStream(string source, string destination)
    {
        Stopwatch sw = Stopwatch.StartNew();
        using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
        using (FileStream fsWrite = new FileStream(destination, FileMode.Create, FileAccess.Write))
        using (BufferedStream bsRead = new BufferedStream(fsRead, 4096))
        using (BufferedStream bsWrite = new BufferedStream(fsWrite, 4096))
        {
            byte[] buffer = new byte[4096];
            int bytesRead;
            while ((bytesRead = bsRead.Read(buffer, 0, buffer.Length)) > 0)
            {
                bsWrite.Write(buffer, 0, bytesRead);
            }
        }
        sw.Stop();
        return sw.ElapsedMilliseconds;
    }
}
