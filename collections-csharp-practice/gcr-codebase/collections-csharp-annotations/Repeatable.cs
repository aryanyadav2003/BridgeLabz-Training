using System;
using System.Reflection;
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class BugReportAttribute : Attribute
{
    public string Description { get; }

    public BugReportAttribute(string description)
    {
        Description = description;
    }
}
public class IssueTracker
{
    [BugReport("NullReferenceException occurs when input is null")]
    [BugReport("Performance issue with large datasets")]
    public void ProcessData()
    {
        Console.WriteLine("Processing data...");
    }
}
class Program
{
    static void Main()
    {
        IssueTracker tracker = new IssueTracker();
        tracker.ProcessData();
        Console.WriteLine("--- Bug Reports ---");
        Type type = typeof(IssueTracker);
        MethodInfo method = type.GetMethod("ProcessData");
        object[] bugReports = method.GetCustomAttributes(typeof(BugReportAttribute), false);
        foreach (BugReportAttribute bug in bugReports)
        {
            Console.WriteLine($"• {bug.Description}");
        }
    }
}
