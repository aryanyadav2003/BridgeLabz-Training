using System;
class Book{
    public static string LibraryName = "Central Library";
    public readonly string ISBN;

    public string Title;
    public string Author;
    public Book(string ISBN, string Title, string Author){
        this.ISBN = ISBN;     
        this.Title = Title;   
        this.Author = Author;  
    }

    public static void DisplayLibraryName(){
        Console.WriteLine("Library Name: " + LibraryName);
    }

    public void DisplayBookDetails(){
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
    }
}

class LibrarySystem{
    static void Main(){
        Book book1 = new Book("ISBN-101", "C# Programming", "Herbert Schildt");
        Book book2 = new Book("ISBN-102", "Java Fundamentals", "James Gosling");

        Book.DisplayLibraryName();

        if (book1 is Book)
        {
            Console.WriteLine("\nBook 1 Details:");
            book1.DisplayBookDetails();
        }

        if (book2 is Book)
        {
            Console.WriteLine("\nBook 2 Details:");
            book2.DisplayBookDetails();
        }
    }
}
