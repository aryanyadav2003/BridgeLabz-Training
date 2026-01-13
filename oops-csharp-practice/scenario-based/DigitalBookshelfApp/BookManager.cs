using System;
using System.Diagnostics.Contracts;
class BookManager : IBook
{
    private string[] books=new string[0];
    private int count=0;
    public void AddBook(string title,string author)
    {
        string book=title + " - " + author;
        string[] newBooks = new string[count + 1];
        for (int i = 0; i < count; i++)
        {
            newBooks[i] = books[i];
        }
        newBooks[count] = book;
        books = newBooks;
        count++;

        Console.WriteLine("Book added");
    }
    public void SearchByAuthor(string author)
    {
        bool found=false;
        for(int i = 0; i < count; i++)
        {
            string[] parts = books[i].Split(" - ");
            if (parts[1].Equals(author, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(books[i]);
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine("No books found for this author");
        }
    }
    public void SortBooksAlphabetically()
    {
        for(int i = 0; i < count - 1; i++)
        {
            for(int j = i; j < count; j++)
            {
                if (string.Compare(books[i], books[j]) > 0)
                {
                    string temp=books[i];
                    books[i]=books[j];
                    books[j]=temp;
                }
            }
        }
        Console.WriteLine("Books sorted alphabetically");
    }
    public void DisplayBooks()
    {
        if (count == 0)
        {
            Console.WriteLine("No books available");
        }
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(books[i]);
        }
    }
}