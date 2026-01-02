using System;
class Product{
   public static double Discount = 5.0;
   public readonly int ProductID;
   public string ProductName;
   public double Price;
   public int Quantity;
   
   public Product(int ProductID, string ProductName, double Price, int Quantity){
    this.ProductID = ProductID;       
    this.ProductName = ProductName;   
    this.Price = Price;
    this.Quantity = Quantity;
    }
	public static void UpdateDiscount(double newDiscount){
	  if(newDiscount >=0 && newDiscount <=100){
	    Discount = newDiscount;
	  }
	  else{
	   Console.WriteLine("Invalid discount percentage");
	  }
	}
	public void DisplayProductDetails()
    {
        Console.WriteLine("Product ID: " + ProductID);
        Console.WriteLine("Product Name: " + ProductName);
        Console.WriteLine("Price: ₹" + Price);
        Console.WriteLine("Quantity: " + Quantity);
        Console.WriteLine("Discount: " + Discount + "%");
    }
}
class ShoppingCartSystem{
  static void Main(){
     Product p1 = new Product(101, "Laptop", 55000, 1);
     Product p2 = new Product(102, "Headphones", 2000, 2);
	 
	 Product.UpdateDiscount(10);
	 
	 if(p1 is Product){
            Console.WriteLine("\nProduct 1 Details:");
            p1.DisplayProductDetails();
        }
     if(p2 is Product){
            Console.WriteLine("\nProduct 2 Details:");
            p2.DisplayProductDetails();
        }
  }
}