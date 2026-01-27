using System;
using System.Reflection;
[AttributeUsage(AttributeTargets.Field)]
public class MaxLengthAttribute : Attribute
{
    public int Length { get; }

    public MaxLengthAttribute(int length)
    {
        Length = length;
    }
}
public class User
{
    [MaxLength(10)]
    private string username;

    public User(string username)
    {
        ValidateMaxLength(nameof(username), username);
        this.username = username;
    }

    private void ValidateMaxLength(string fieldName, string value)
    {
        FieldInfo field = this.GetType().GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);
        MaxLengthAttribute attribute =
            field.GetCustomAttribute<MaxLengthAttribute>();
        if (attribute != null && value.Length > attribute.Length)
        {
            throw new ArgumentException($"'{fieldName}' exceeds maximum length of {attribute.Length}");
        }
    }

    public string Username => username;
}

class Program
{
    static void Main()
    {
        try
        {
            User user1 = new User("Aryan"); 
            Console.WriteLine("User created: " + user1.Username);

            User user2 = new User("VeryLongUsername"); 
            Console.WriteLine("User created: " + user2.Username);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
