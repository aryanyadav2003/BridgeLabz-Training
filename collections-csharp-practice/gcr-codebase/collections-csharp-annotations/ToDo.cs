using System;
using System.Reflection;
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class TodoAttribute : Attribute
{
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; }

    public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}
public class ProjectFeatures
{
    [Todo("Implement user authentication", "Deepak", "HIGH")]
    [Todo("Add password reset functionality", "Deepak")]
    public void UserModule()
    {
        Console.WriteLine("User module");
    }

    [Todo("Optimize database queries", "Rohit", "HIGH")]
    public void DatabaseModule()
    {
        Console.WriteLine("Database module");
    }

    [Todo("Improve UI responsiveness", "Neha")]
    public void UIModule()
    {
        Console.WriteLine("UI module");
    }
}
class Program
{
    static void Main()
    {
        Type type = typeof(ProjectFeatures);
        MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);
        Console.WriteLine("Pending Todo Tasks:");
        foreach (MethodInfo method in methods)
        {
            object[] todos = method.GetCustomAttributes(typeof(TodoAttribute), false);
            foreach (TodoAttribute todo in todos)
            {
                Console.WriteLine($"Method     : {method.Name}");
                Console.WriteLine($"Task       : {todo.Task}");
                Console.WriteLine($"AssignedTo : {todo.AssignedTo}");
                Console.WriteLine($"Priority   : {todo.Priority}");
                Console.WriteLine("---------------------------");
            }
        }
    }
}
