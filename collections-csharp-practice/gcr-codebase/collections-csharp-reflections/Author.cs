using System;
using System.Reflection;
[AttributeUsage(AttributeTargets.Class)]
public class AuthorAttribute : Attribute
{
    public string Name { get; }

    public AuthorAttribute(string name)
    {
        Name = name;
    }
}
[Author("Aryan Yadav")]
class MyClass
{
    public void Display()
    {
        Console.WriteLine("Inside MyClass");
    }
}
class Program
{
    static void Main()
    {
        Type type = typeof(MyClass);
        AuthorAttribute authorAttr = (AuthorAttribute)Attribute.GetCustomAttribute(type, typeof(AuthorAttribute));
        if (authorAttr != null)
        {
            Console.WriteLine($"Author of {type.Name}: {authorAttr.Name}");
        }
        else
        {
            Console.WriteLine("No Author attribute found.");
        }
        MyClass obj = new MyClass();
        obj.Display();
    }
}
