using System;
using System.IO;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string filePath = "users.csv";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("CSV file not found.");
            return;
        }
        string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        string phonePattern = @"^\d{10}$";
        string[] lines = File.ReadAllLines(filePath);
        Console.WriteLine("Invalid Records:\n");
        for (int i = 1; i < lines.Length; i++) 
        {
            string[] data = lines[i].Split(',');
            string id = data[0];
            string name = data[1];
            string email = data[2];
            string phone = data[3];
            bool isValid = true;
            if (!Regex.IsMatch(email, emailPattern))
            {
                Console.WriteLine($"Row {i + 1}: Invalid Email → {email}");
                isValid = false;
            }
            if (!Regex.IsMatch(phone, phonePattern))
            {
                Console.WriteLine($"Row {i + 1}: Invalid Phone Number → {phone}");
                isValid = false;
            }

            if (!isValid)
            {
                Console.WriteLine($"Record: {lines[i]}");
                Console.WriteLine();
            }
        }
    }
}
