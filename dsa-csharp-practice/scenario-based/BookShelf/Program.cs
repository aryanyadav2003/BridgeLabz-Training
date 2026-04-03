// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
class Program
{
    static void Main()
    {
        BookShelf shelf = new BookShelf();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(" BookShelf – Library Organizer");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Borrow Book");
            Console.WriteLine("3. Display Books by Genre");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Book ID: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.Write("Title: ");
                    string title = Console.ReadLine();

                    Console.Write("Author: ");
                    string author = Console.ReadLine();

                    Console.Write("Genre: ");
                    string genre = Console.ReadLine();

                    shelf.AddBook(new Book(id, title, author, genre));
                    break;

                case 2:
                    Console.Write("Enter Book ID to borrow: ");
                    int borrowId = int.Parse(Console.ReadLine());

                    shelf.BorrowBook(borrowId);
                    break;

                case 3:
                    Console.Write("Enter Genre: ");
                    string searchGenre = Console.ReadLine();

                    shelf.DisplayByGenre(searchGenre);
                    break;

                case 4:
                    Console.WriteLine("Exiting BookShelf System...");
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}

