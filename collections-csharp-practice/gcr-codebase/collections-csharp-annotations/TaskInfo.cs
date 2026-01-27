using System;
using System.Reflection;
[AttributeUsage(AttributeTargets.Method)]
public class TaskInfoAttribute : Attribute
{
    public string Priority { get; }
    public string AssignedTo { get; }
    public TaskInfoAttribute(string priority, string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}
public class TaskManager
{
    [TaskInfo("High", "Aryan")]
    public void CompleteTask()
    {
        Console.WriteLine("Task completed successfully.");
    }
}
class TaskInfo
{
    static void Main()
    {
        TaskManager manager = new TaskManager();
        manager.CompleteTask();

        Console.WriteLine("---Task Info---");

        Type type = typeof(TaskManager);
        MethodInfo method = type.GetMethod("CompleteTask");

        TaskInfoAttribute taskInfo =
            (TaskInfoAttribute)Attribute.GetCustomAttribute(method,typeof(TaskInfoAttribute));
        if (taskInfo != null)
        {
            Console.WriteLine($"Priority   : {taskInfo.Priority}");
            Console.WriteLine($"Assigned To: {taskInfo.AssignedTo}");
        }
    }
}
