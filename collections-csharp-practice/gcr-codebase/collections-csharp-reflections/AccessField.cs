using System;
using System.Reflection;
class Person
{
    private int age = 22;
}
class AccessField
{
    static void Main()
    {
        Person person = new Person();
        Type type = typeof(Person);
        FieldInfo field = type.GetField("age",BindingFlags.NonPublic | BindingFlags.Instance);
        field.SetValue(person, 30);
        int value = (int)field.GetValue(person);
        Console.WriteLine("Modified Age: " + value);
    }
}
