using System;
using System.IO;

class Program
{
    static void Main()
    {
        string originalImage = "input.jpg";
        string newImage = "output.jpg";

        try
        {
            if (!File.Exists(originalImage))
            {
                Console.WriteLine("Image file not found.");
                return;
            }
            byte[] imageBytes = File.ReadAllBytes(originalImage);
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                File.WriteAllBytes(newImage, ms.ToArray());
            }

            Console.WriteLine("Image converted and saved successfully.");
            long originalSize = new FileInfo(originalImage).Length;
            long newSize = new FileInfo(newImage).Length;
            if (originalSize == newSize)
                Console.WriteLine("Verification successful: Files are identical.");
            else
                Console.WriteLine("Verification failed: Files differ.");
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
