using System;
class Book{
    public string title;
    public string author;
    public double price;
    public void DisplayBookDetails(){
        Console.WriteLine("Book Title  : " + title);
        Console.WriteLine("Author : " + author);
        Console.WriteLine("Price  : " + price);
    }
}
class BookDetails{
    static void Main(){
        Book book = new Book();
        Console.Write("Enter Title: ");
        book.title = Console.ReadLine();

        Console.Write("Enter Author: ");
        book.author = Console.ReadLine();

        Console.Write("Enter Price: ");
        book.price = double.Parse(Console.ReadLine());

        book.DisplayBookDetails();
    }
}
