using System;
class Product{
    public string ProductName;
    public double Price;
	
    public int TotalProducts = 0;

    public Product(string name, double price){
        ProductName = name;
        Price = price;
        TotalProducts++;
    }

    public void DisplayProductDetails()
    {
        Console.WriteLine("Product Name: " + ProductName);
        Console.WriteLine("Price: " + Price);
    }

    public static void DisplayTotalProducts()
    {
        Console.WriteLine("Total Products Created: " + TotalProducts);
    }
}
class ProductProgram{
    static void Main(){
        Product p1 = new Product("Laptop", 55000);
        Product p2 = new Product("Mouse", 800);
        Product p3 = new Product("Keyboard", 1500);

        Console.WriteLine("Product 1 Details:");
        p1.DisplayProductDetails();

        Console.WriteLine();

        Console.WriteLine("Product 2 Details:");
        p2.DisplayProductDetails();

        Console.WriteLine();

        Product.DisplayTotalProducts();
    }
}
