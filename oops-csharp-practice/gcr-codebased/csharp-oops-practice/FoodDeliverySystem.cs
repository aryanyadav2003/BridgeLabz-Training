using System;
interface IDiscountable
{
    double ApplyDiscount();
    void GetDiscountDetails();
}
abstract class FoodItem
{
    public string itemName;
    public double price;
    public int quantity;
    public FoodItem(string name,double price,int quantity)
    {
        this.itemName=name;
        this.price=price;
        this.quantity=quantity;
    } 
    public abstract double CalculateTotalPrice();
    public abstract double ApplyDiscount();
    public abstract void GetDiscountDetails();
    public void GetItemDetails()
    {
        Console.WriteLine("Item name : " + itemName);
        Console.WriteLine("Price : " + price );
        Console.WriteLine("Quantity : " + quantity);
    }
}
class VegItem : FoodItem, IDiscountable
{
    public VegItem(string name,double price,int quantity):base(name,price,quantity){}
    public override double CalculateTotalPrice()
    {
        return price*quantity;
    }
    public override double ApplyDiscount()
    {
        return CalculateTotalPrice()*0.10;
    }
    public override void GetDiscountDetails()
    {
        Console.WriteLine("Veg Item Discount: 10%");
    }
}
class NonVegItem : FoodItem, IDiscountable
{
    public NonVegItem(string name,double price,int quantity):base(name, price, quantity) { }
    public override double CalculateTotalPrice()
    {
        return (price*quantity)+50;
    }
    public override double ApplyDiscount()
    {
        return CalculateTotalPrice()*0.05;
    }
    public override void GetDiscountDetails()
    {
        Console.WriteLine("Non-Veg Item Discount: 5%");
    }
}
class FoodDeliverySystem
{
    static void Main()
    {
        FoodItem item1 = new VegItem("Paneer Burger", 120, 2);
        FoodItem item2 = new NonVegItem("Chicken Burger", 250, 1);
        DisplayItem(item1);
        Console.WriteLine();
        DisplayItem(item2);
    }
     static void DisplayItem(FoodItem item)
    {
        item.GetItemDetails();
        Console.WriteLine("Total Price : " + item.CalculateTotalPrice());
        item.GetDiscountDetails();
        Console.WriteLine("Discount Amount : " + item.ApplyDiscount());
    }
}