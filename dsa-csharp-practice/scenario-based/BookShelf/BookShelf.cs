public class BookShelf
{
    private Dictionary<string,BookNode> genreCatalog;
    private HashSet<int> uniqueBook;
    public BookShelf()
    {
        genreCatalog=new Dictionary<string,BookNode>();
        uniqueBook=new HashSet<int>();
    }
    //Add Book
    public void AddBook(Book book)
    {
        if (uniqueBook.Contains(book.BookId))
        {
            Console.WriteLine("Duplicate books not allowed");
            return;
        }
        BookNode newNode=new BookNode(book);
        if (!genreCatalog.ContainsKey(book.Genre))
        {
            genreCatalog[book.Genre]=newNode;
        }
        else
        {
            BookNode temp=genreCatalog[book.Genre];
            while (temp.next != null)
            {
                temp=temp.next;
            }
            temp.next=newNode;
        }
        uniqueBook.Add(book.BookId);
        Console.WriteLine("Book added successfully");
    }
    //Borrow book i.e remove
    public void BorrowBook(int BookId)
    {
        foreach(var genre in genreCatalog.Keys)
        {
            BookNode curr=genreCatalog[genre];
            BookNode prev=null;
            while (curr != null)
            {
                if (curr.Data.BookId == bookId)
                {
                    if (prev == null)
                    {
                        genreCatalog[genre]=curr.Next;
                    }
                    else
                    {
                        prev.Next=curr.Next;
                    }
                    uniqueBook.Remove(bookId);
                    Console.WriteLine("Book borrowed successfully.");
                    return;
                }
                prev=curr;
                curr=curr.Next;
            }
        }
        Console.WriteLine("Book not found");
    }
    //Display book by genre
    public void DisplayByGenre(string genere)
    {
        if (!genereCatalog.ContainsKey(genre))
        {
            Console.WriteLine("Genre not found");
        }
        BookNode temp=genreCatalog[genre];
        if (temp == null)
        {
            Console.WriteLine("No books available");
            return;
        }
        Console.WriteLine($"Book in {genre}");
        while (temp != null)
        {
            Console.WriteLine(temp.Data);
            temp=temp.next;
        }
    }

}