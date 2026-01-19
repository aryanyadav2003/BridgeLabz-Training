using System;
using System.Collections.Generic;
abstract class WarehouseItem
{
    public string Name{get;set;}
    public abstract void Display();
}
class Electronics : WarehouseItem
{
    public override void Display() =>
        Console.WriteLine($"Electronics Item: {Name}");
}

class Groceries : WarehouseItem
{
    public override void Display() =>
        Console.WriteLine($"Grocery Item: {Name}");
}

class Furniture : WarehouseItem
{
    public override void Display() =>
        Console.WriteLine($"Furniture Item: {Name}");
}
class Storage<T> where T : WarehouseItem
{
    private List<T> items=new List<T>();
    public void AddItem(T item)=>items.Add(item);
     public void DisplayItems()
    {
        foreach (var item in items)
            item.Display();
    }
}
class Program
{
    static void Main()
    {
        Storage<Electronics> electronicsStore = new Storage<Electronics>();
        electronicsStore.AddItem(new Electronics { Name = "Laptop" });

        electronicsStore.DisplayItems();
    }
}