using System;
interface IReservable
{
    void ReserveItem();
    bool CheckAvailability();
}
abstract class LibraryItem
{
    protected int itemId;
    protected string title;
    protected string author;
    public LibraryItem(int itemId,string title,string author)
    {
        this.itemId = itemId;
        this.title = title;
        this.author = author;
    }
    public abstract int GetLoanDuration();
    public void GetItemDetails()
    {
        Console.WriteLine($"ID: {itemId}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
    }
}
class Book : LibraryItem, IReservable
{
    private bool isAvailable = true;
    public Book(int id,string title,string author):base(id,title,author){}
    public override int GetLoanDuration()
    {
        return 14;
    }
    public void ReserveItem()
    {
        isAvailable=false;
        Console.WriteLine("Book reserved.");
    }
    public bool CheckAvailability()
    {
        return isAvailable;
    }
}
class Magazine : LibraryItem, IReservable
{
    private bool isAvailable=true;
    public Magazine(int id,string title,string author):base(id,title,author){}
    public override int GetLoanDuration()
    {
        return 7;
    }
    public void ReserveItem()
    {
        isAvailable=false;
        Console.WriteLine("Magazine reserved.");
    }
    public bool CheckAvailability()
    {
        return isAvailable;
    }
}
class DVD : LibraryItem, IReservable
{
    private bool isAvailable=true;
    public DVD(int id,string title,string author):base(id,title,author){}
    public override int GetLoanDuration()
    {
        return 3;
    }
    public void ReserveItem()
    {
        isAvailable=false;
        Console.WriteLine("DVD reserved.");
    }
    public bool CheckAvailability()
    {
        return isAvailable;
    }
}
class LibraryManagementSystem
{
    static void Main()
    {
       LibraryItem item1 = new Book(1, "C# Basics", "John");
       LibraryItem item2 = new Magazine(2, "Tech Monthly", "Editor");
       LibraryItem item3 = new DVD(3, "Inception", "Nolan");
       DisplayItem(item1);
       DisplayItem(item2);
       DisplayItem(item3);
       Book book = new Book(4, "OOP in C#", "James");
       book.ReserveItem();
       Console.WriteLine("Available: " + book.CheckAvailability());
    }
      static void DisplayItem(LibraryItem item)
    {
        item.GetItemDetails();
        Console.WriteLine("Loan Duration: " + item.GetLoanDuration() + " days");
        Console.WriteLine("---------------------");
    }
}