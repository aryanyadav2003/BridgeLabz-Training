using System;
class Book{
  public string ISBN;
  protected string title;
  private string author;
  
   public Book(string isbn, string title, string author){
        ISBN = isbn;
        this.title = title;
        this.author = author;
    }
	public void SetAuthor(string author){
	  this.author=author;
	}
	public string GetAuthor(){
	   return author;
	}
}
class EBook : Book{
   public double fileSize;
   public EBook(string isbn, string title, string author, double fileSize) : base(isbn,title,author){
      this.fileSize = fileSize;
   }
   public void DisplayDetails(){
        Console.WriteLine("ISBN: " + ISBN);        
        Console.WriteLine("Title: " + title);     
        Console.WriteLine("Author: " + GetAuthor());
        Console.WriteLine("File Size: " + fileSize + " MB");
    }
}
class LibrarySystem{
  static void Main(){
     EBook ebook = new EBook(
            "978-0131101630",
            "C# Programming",
            "Dennis Ritchie",
            2.5
        );
	  ebook.DisplayDetails();
	  
	  ebook.SetAuthor("Bjarne Stroustrup");
      Console.WriteLine("Updated Author: " + ebook.GetAuthor());
  }
}