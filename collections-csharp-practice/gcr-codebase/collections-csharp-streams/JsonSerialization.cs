using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
class Program
{
    static string filePath = "employees.json";
    static void Main()
    {
        List<Employee> employees = new List<Employee>();
        employees.Add(new Employee(1, "Amit", "HR", 40000));
        employees.Add(new Employee(2, "Neha", "IT", 60000));
        employees.Add(new Employee(3, "Ravi", "Finance", 50000));
        SaveEmployees(employees);
        LoadEmployees();
    }
    static void SaveEmployees(List<Employee> employees)
    {
        try
        {
            string jsonData = JsonSerializer.Serialize(employees);
            File.WriteAllText(filePath, jsonData);
            Console.WriteLine("Employees saved successfully.\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error while saving: " + ex.Message);
        }
    }
    static void LoadEmployees()
    {
        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            string jsonData = File.ReadAllText(filePath);
            List<Employee> employees =
                JsonSerializer.Deserialize<List<Employee>>(jsonData);
            Console.WriteLine("Employee List:");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(
                    $"ID: {emp.Id}, Name: {emp.Name}, Dept: {emp.Department}, Salary: {emp.Salary}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error while loading: " + ex.Message);
        }
    }
}
