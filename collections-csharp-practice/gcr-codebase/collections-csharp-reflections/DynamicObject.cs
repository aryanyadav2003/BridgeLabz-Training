using System;
using System.Reflection;
class Student
{
    public int Id;
    public string Name;
    public Student()
    {
        Id = 1;
        Name = "Aryan";
    }
    public void Display()
    {
        Console.WriteLine($"Student Id: {Id}, Name: {Name}");
    }
}
class DynamicObject
{
    static void Main()
    {
        Type type = typeof(Student);
        object studentObj = Activator.CreateInstance(type);
        MethodInfo displayMethod = type.GetMethod("Display");
        displayMethod.Invoke(studentObj, null);
    }
}
