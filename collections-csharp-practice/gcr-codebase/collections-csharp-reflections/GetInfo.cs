using System;
using System.Reflection;
class Sample
{
    public int Id;
    private string Name;
    public Sample() { }
    public Sample(int id)
    {
        Id = id;
    }
    public void Display() { }
    private void ShowName() { }
}
class GetInfo
{
    static void Main()
    {
        Console.Write("Enter class name (Sample): ");
        string className = Console.ReadLine();
        Type type = Type.GetType(className);
        if (type == null)
        {
            Console.WriteLine("Class not found!");
            return;
        }
        Console.WriteLine("\n--- Methods ---");
        foreach (MethodInfo method in type.GetMethods(
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
        {
            Console.WriteLine(method.Name);
        }
        Console.WriteLine("\n--- Fields ---");
        foreach (FieldInfo field in type.GetFields(
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
        {
            Console.WriteLine(field.Name);
        }
        Console.WriteLine("\n--- Constructors ---");
        foreach (ConstructorInfo ctor in type.GetConstructors())
        {
            Console.WriteLine(ctor.ToString());
        }
    }
}
