using System;
class Book{
  public string Title;
  public string Author;
  public double Price;
  public bool IsAvailable;
  
  public Book(string title, string author, double price){
    Title = title;
    Author = author;
    Price = price;
    IsAvailable = true;  
  }
  
  public void BorrowBook(){
   if(IsAvailable){
     IsAvailable=false;
	 Console.WriteLine("You have successfully borrowed the book: " + Title);
   }
   else{
      Console.WriteLine("Sorry, the book is currently not available.");
        }
  }
  public void ShowDetails(){
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Available: " + (IsAvailable ? "Yes" : "No"));
}}
class BookProgram{
   static void Main(){
     Book book1 = new Book("C# Basics", "John Doe", 350);
	 book1.ShowDetails();
     Console.WriteLine();
	 book1.BorrowBook();
	 Console.WriteLine();
     book1.BorrowBook();
   }
}