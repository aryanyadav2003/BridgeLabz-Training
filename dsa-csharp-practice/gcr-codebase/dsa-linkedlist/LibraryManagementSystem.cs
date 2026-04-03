using System;
class Book
{
    public int BookId;
    public string Title;
    public string Author;
    public string Genre;
    public bool IsAvailable;
    public Book Next;
    public Book Prev;
    public Book(int id, string title, string author, string genre, bool available){
        BookId = id;
        Title = title;
        Author = author;
        Genre = genre;
        IsAvailable = available;
        Next = null;
        Prev = null;
    }
}
class LibraryList
{
    private Book head;
    private Book tail;
    public void AddAtBeginning(int id, string title, string author, string genre, bool available)
    {
        Book newNode = new Book(id, title, author, genre, available);
        if (head == null)
        {
            head = tail = newNode;
            return;
        }
        newNode.Next = head;
        head.Prev = newNode;
        head = newNode;
    }
    public void AddAtEnd(int id, string title, string author, string genre, bool available)
    {
        Book newNode = new Book(id, title, author, genre, available);
        if (tail == null)
        {
            head = tail = newNode;
            return;
        }
        tail.Next = newNode;
        newNode.Prev = tail;
        tail = newNode;
    }
    public void AddAtPosition(int pos, int id, string title, string author, string genre, bool available)
    {
        if (pos == 1)
        {
            AddAtBeginning(id, title, author, genre, available);
            return;
        }
        Book temp = head;
        int count = 1;
        while (count < pos - 1 && temp != null)
        {
            temp = temp.Next;
            count++;
        }
        if (temp == null)
        {
            Console.WriteLine("Invalid position");
            return;
        }
        if (temp.Next == null)
        {
            AddAtEnd(id, title, author, genre, available);
            return;
        }
        Book newNode = new Book(id, title, author, genre, available);
        newNode.Next = temp.Next;
        newNode.Prev = temp;
        temp.Next.Prev = newNode;
        temp.Next = newNode;
    }
    public void RemoveById(int id)
    {
        Book temp = head;
        while (temp != null)
        {
            if (temp.BookId == id)
            {
                if (temp == head)
                {
                    head = head.Next;
                    if (head != null) head.Prev = null;
                }
                else if (temp == tail)
                {
                    tail = tail.Prev;
                    tail.Next = null;
                }
                else
                {
                    temp.Prev.Next = temp.Next;
                    temp.Next.Prev = temp.Prev;
                }
                Console.WriteLine("Book removed");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Book not found");
    }
    public void SearchByTitle(string title)
    {
        Book temp = head;
        bool found = false;
        while (temp != null)
        {
            if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                DisplayBook(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("Book not found");
    }
    public void SearchByAuthor(string author)
    {
        Book temp = head;
        bool found = false;
        while (temp != null)
        {
            if (temp.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
            {
                DisplayBook(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("Book not found");
    }
    public void UpdateAvailability(int id, bool status)
    {
        Book temp = head;
        while (temp != null)
        {
            if (temp.BookId == id)
            {
                temp.IsAvailable = status;
                Console.WriteLine("Availability updated");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Book not found");
    }
    public void DisplayForward()
    {
        Book temp = head;
        if (temp == null)
        {
            Console.WriteLine("No books available");
            return;
        }
        while (temp != null)
        {
            DisplayBook(temp);
            temp = temp.Next;
        }
    }
    public void DisplayReverse()
    {
        Book temp = tail;
        if (temp == null)
        {
            Console.WriteLine("No books available");
            return;
        }
        while (temp != null)
        {
            DisplayBook(temp);
            temp = temp.Prev;
        }
    }
    public void CountBooks()
    {
        int count = 0;
        Book temp = head;
        while (temp != null)
        {
            count++;
            temp = temp.Next;
        }
        Console.WriteLine("Total Books: " + count);
    }
    private void DisplayBook(Book b)
    {
        Console.WriteLine("ID: " + b.BookId +", Title: " + b.Title +", Author: " + b.Author +", Genre: " + b.Genre +", Available: " + b.IsAvailable);
    }
}
class LibraryManagementSystem
{
    static void Main()
    {
        LibraryList library = new LibraryList();
        library.AddAtEnd(1, "Clean Code", "Robert Martin", "Programming", true);
        library.AddAtEnd(2, "The Alchemist", "Paulo Coelho", "Fiction", true);
        library.AddAtBeginning(3, "Atomic Habits", "James Clear", "Self Help", false);
        Console.WriteLine("All Books (Forward):");
        library.DisplayForward();
        Console.WriteLine("All Books (Reverse):");
        library.DisplayReverse();
        Console.WriteLine("Search by Author:");
        library.SearchByAuthor("Paulo Coelho");
        Console.WriteLine("Update Availability:");
        library.UpdateAvailability(3, true);
        Console.WriteLine("Remove Book ID 1:");
        library.RemoveById(1);
        Console.WriteLine("Final Library:");
        library.DisplayForward();
        Console.WriteLine("Count Books:");
        library.CountBooks();
    }
}

