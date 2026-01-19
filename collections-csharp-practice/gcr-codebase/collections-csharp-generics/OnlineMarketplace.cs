using System;
abstract class Product
{
    public double Price{get;set;}

}
class BookCategory:Product{}
class ClothingCategory : Product { }
class Catalog<T> where T : Product
{
    public T Item{get;set;}
}
class DiscountService
{
    public static void ApplyDiscount<T>(T product, double percentage)
        where T : Product
    {
        product.Price -= product.Price * (percentage / 100);
    }
}

class Program
{
    static void Main()
    {
        BookCategory book = new BookCategory { Price = 500 };
        DiscountService.ApplyDiscount(book, 10);

        Console.WriteLine($"Discounted Price: {book.Price}");
    }
}