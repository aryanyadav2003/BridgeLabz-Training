using System;
abstract class Product
{
    protected string name;
    protected double price;

    public abstract double CalculateDiscount();
    public abstract double CalculateTax();
    public double FinalPrice()
    {
        return price + CalculateTax() - CalculateDiscount();
    }
    public void Display()
    {
        Console.WriteLine(name + " Final Price: " + FinalPrice());
    }
}

class Electronics : Product
{
    public Electronics(string n, double p)
    {
        name = n;
        price = p;
    }

    public override double CalculateDiscount()
    {
        return price * 0.10;
    }

    public override double CalculateTax()
    {
        return price * 0.18;
    }
}
class Clothing : Product
{
    public Clothing(string n, double p)
    {
        name = n;
        price = p;
    }

    public override double CalculateDiscount()
    {
        return price * 0.20;
    }

    public override double CalculateTax()
    {
        return price * 0.12;
    }
}
class Groceries : Product
{
    public Groceries(string n, double p)
    {
        name = n;
        price = p;
    }
    public override double CalculateDiscount()
    {
        return price * 0.05;
    }

    public override double CalculateTax()
    {
        return 0; 
    }
}

class ECommercePlatform
{
    static void Main()
    {
        Product[] products =new Product[3];
        Electronics e1 = new Electronics("Laptop",50000);
        Clothing e2=new Clothing("Shirt",2000);
        Groceries e3=new Groceries("Rice",100);
        products[0]=e1;
        products[1]=e2;
        products[2]=e3;
        for (int i = 0; i < products.Length; i++)
        {
            products[i].Display();
        }
    }
}
