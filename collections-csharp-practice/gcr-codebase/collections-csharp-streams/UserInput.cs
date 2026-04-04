using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "UserInfo.txt";
        StreamReader reader = null;
        StreamWriter writer = null;
        try
        {
            reader = new StreamReader(Console.OpenStandardInput());
            reader.AutoFlush = true;
            Console.Write("Enter your name: ");
            string name = reader.ReadLine();
            Console.Write("Enter your age: ");
            string age = reader.ReadLine();
            Console.Write("Enter your favorite programming language: ");
            string language = reader.ReadLine();
            writer = new StreamWriter(filePath);
            writer.WriteLine("User Information");
            writer.WriteLine("----------------");
            writer.WriteLine("Name: " + name);
            writer.WriteLine("Age: " + age);
            writer.WriteLine("Favorite Language: " + language);
            Console.WriteLine("\nData saved successfully to file.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            if (reader != null)
                reader.Close();
            if (writer != null)
                writer.Close();
        }
    }
}
