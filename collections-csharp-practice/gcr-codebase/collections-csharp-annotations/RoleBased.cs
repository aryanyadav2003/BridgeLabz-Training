using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
public class RoleAllowedAttribute : Attribute
{
    public string Role { get; }

    public RoleAllowedAttribute(string role)
    {
        Role = role;
    }
}
public static class UserContext
{
    public static string CurrentRole { get; set; }
}
public class AdminService
{
    [RoleAllowed("ADMIN")]
    public void DeleteUser()
    {
        Console.WriteLine("User deleted successfully!");
    }

    public void ViewUser()
    {
        Console.WriteLine("User details displayed.");
    }
}
public static class AccessValidator
{
    public static void InvokeIfAllowed(object obj, string methodName)
    {
        MethodInfo method = obj.GetType().GetMethod(methodName);

        RoleAllowedAttribute attribute =
            method.GetCustomAttribute<RoleAllowedAttribute>();

        if (attribute != null &&
            attribute.Role != UserContext.CurrentRole)
        {
            Console.WriteLine("Access Denied!");
            return;
        }

        method.Invoke(obj, null);
    }
}
class Program
{
    static void Main()
    {
        AdminService service = new AdminService();
        UserContext.CurrentRole = "USER";
        Console.WriteLine("Current Role: USER");
        AccessValidator.InvokeIfAllowed(service, "DeleteUser");

        Console.WriteLine();
        UserContext.CurrentRole = "ADMIN";
        Console.WriteLine("Current Role: ADMIN");
        AccessValidator.InvokeIfAllowed(service, "DeleteUser");

        Console.WriteLine();
        AccessValidator.InvokeIfAllowed(service, "ViewUser");
    }
}
