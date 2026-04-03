// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
class Program
{
    static void Main()
    {
        IMovie manager=new MovieManager();
        while (true)
        {
            Console.WriteLine("\n===== CinemaTime =====");
            Console.WriteLine("1. Add Movie");
            Console.WriteLine("2. Search Movie");
            Console.WriteLine("3. Display All Movies");
            Console.WriteLine("4. Generate Report");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");
            int choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                  Console.Write("Enter movie title: ");
                  string title=Console.ReadLine();
                  Console.Write("Enter show time (HH:MM): ");
                  string time = Console.ReadLine();
                  manager.AddMovie(title, time);
                  break;
                case 2:
                  Console.Write("Enter search keyword : ");
                  string keyword=Console.ReadLine();
                  manager.SearchMovie(keyword);
                  break;
                case 3:
                   manager.DisplayAllMovies();
                   break;
                case 4:
                    manager.GenerateReport();
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    return;   
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}