using System;
class Book{
  public string Title;
  public string Author;
  public double Price;
  
  public Book(){
    Title = "Atomic Habits";
	Author = "James Clear";
	Price = 0.0;
  }
  public Book(string title,string author,double price){
     Title=title;
	 Author=author;
	 Price=price;
  }
   public void ShowDetails(){
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Price: " + Price);
    }
  class BookInfo{
    static void Main(){
	  Book b1 = new Book();
	  b1.ShowDetails();
	  Console.WriteLine();
	  Book b2 = new Book("Clean Code", "Robert C. Martin", 450);
       b2.ShowDetails();
	}
  }
}