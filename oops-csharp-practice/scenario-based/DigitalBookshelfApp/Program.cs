// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
class Program
{
    static void Main()
    {
        IBook manager=new BookManager();
        while (true)
        {
            Console.WriteLine("\n===== BookBuddy =====");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Search by Author");
            Console.WriteLine("3. Sort Books");
            Console.WriteLine("4. Display All Books");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter book title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter author name: ");
                    string author = Console.ReadLine();
                    manager.AddBook(title, author);
                    break;
                case 2:
                    Console.Write("Enter author name: ");
                    string searchAuthor = Console.ReadLine();
                    manager.SearchByAuthor(searchAuthor);
                    break;
                case 3:
                    manager.SortBooksAlphabetically();
                    break;
                case 4:
                    manager.DisplayBooks();
                    break;
                case 5:
                    Console.WriteLine("Exiting..");
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
