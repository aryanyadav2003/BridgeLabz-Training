using System;
class Book{
    public string Title;
    public int PublicationYear;

    public void DisplayInfo(){
        Console.WriteLine("Book Title: " + Title);
        Console.WriteLine("Publication Year: " + PublicationYear);
    }
}
class Author : Book{
    public string Name;
    public string Bio;

    public void DisplayInfo(){
        Console.WriteLine("Book Title: " + Title);
        Console.WriteLine("Publication Year: " + PublicationYear);
        Console.WriteLine("Author Name: " + Name);
        Console.WriteLine("Author Bio: " + Bio);
    }
}
class LibrarySystem{
    static void Main(){
        Author a = new Author{
        Title = "Clean Code",
        PublicationYear = 2008,
        Name = "Robert C. Martin",
        Bio = "Software engineer and author"};

        a.DisplayInfo();
    }
}
