using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
public class ImportantMethodAttribute : Attribute
{
    public string Level { get; }
    public ImportantMethodAttribute(string level = "HIGH")
    {
        Level = level;
    }
}
public class Service
{
    [ImportantMethod] 
    public void ProcessOrder()
    {
        Console.WriteLine("Processing order...");
    }
    [ImportantMethod("MEDIUM")]
    public void GenerateReport()
    {
        Console.WriteLine("Generating report...");
    }
    public void HelperMethod()
    {
        Console.WriteLine("Helper method (not important)");
    }
}
class Program
{
    static void Main()
    {
        Type type = typeof(Service);
        MethodInfo[] methods = type.GetMethods(
            BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly
        );
        Console.WriteLine("--- Important Methods ---");
        foreach (MethodInfo method in methods)
        {
            ImportantMethodAttribute attribute =
                (ImportantMethodAttribute)Attribute.GetCustomAttribute(method,typeof(ImportantMethodAttribute));
            if (attribute != null)
            {
                Console.WriteLine($"Method: {method.Name}, Importance Level: {attribute.Level}");
            }
        }
    }
}
