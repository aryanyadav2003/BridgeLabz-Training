using System;
class Movie
{
    public string Title;
    public string Director;
    public int Year;
    public double Rating;
    public Movie next;
    public Movie prev;
    public Movie(string title,string director,int year,double rating)
    {
        Title=title;
        Director=director;
        Year=year;
        Rating=rating;
        Next=null;
        prev=null;
    }
}
class MovieDoublyLinkedList
{
    private Movie head;
    private Movie tail;
    public void AddAtBeginning(string title, string director, int year, double rating)
    {
        Movie newNode = new Movie(title, director, year, rating);
        if (head == null)
        {
            head=tail=newNode;
            return;
        }
        newNode.next=head;
        head.prev=newNode;
        head=newNode;
    }
     public void AddAtEnd(string title, string director, int year, double rating)
    {
        Movie newNode = new Movie(title, director, year, rating);
        if (tail == null)
        {
            head = tail = newNode;
            return;
        }
        tail.Next=newNode;
        newNode.Prev=tail;
        tail=newNode;
    }
     public void AddAtPosition(int position, string title, string director, int year, double rating)
    {
        if(position == 1)
        {
            AddAtBeginning(title, director, year, rating);
            return;
        }
        Movie temp = head;
        for(int i = 1; i < position - 1 && temp != null; i++)
            temp = temp.Next;
        if(temp == null)
        {
            Console.WriteLine("Invalid position");
            return;
        }
        if(temp.Next == null)
        {
            AddAtEnd(title, director, year, rating);
            return;
        }
        Movie newNode = new Movie(title, director, year, rating);
        newNode.Next = temp.Next;
        newNode.Prev = temp;
        temp.Next.Prev = newNode;
        temp.Next = newNode;
    }
     public void RemoveByTitle(string title)
    {
        Movie temp = head;
        while(temp != null){
            if(temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase)){
                if(temp == head){
                    head = head.Next;
                    if (head != null) head.Prev = null;
                }
                else if(temp == tail)
                {
                    tail = tail.Prev;
                    tail.Next = null;
                }
                else
                {
                    temp.Prev.Next = temp.Next;
                    temp.Next.Prev = temp.Prev;
                }
                Console.WriteLine("Movie removed");
                return;
            }
            temp=temp.Next;
        }
        Console.WriteLine("Movie not found");
    }
    public void SearchByDirector(string director){
        Movie temp = head;
        bool found = false;
        while(temp != null){
            if(temp.Director.Equals(director, StringComparison.OrdinalIgnoreCase)){
                DisplayMovie(temp);
                found = true;
            }
            temp = temp.Next;
        }
        if(!found){
            Console.WriteLine("No movies found for this director");}
    }
     public void SearchByRating(double rating){
        Movie temp = head;
        bool found = false;
        while(temp != null){
            if(temp.Rating >= rating){
                DisplayMovie(temp);
                found = true;
            }
            temp = temp.Next;
        }
        if (!found){
            Console.WriteLine("No movies found with this rating");}
    }
    public void UpdateRating(string title, double newRating){
        Movie temp=head;
        while(temp != null){
            if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase)){
                temp.Rating = newRating;
                Console.WriteLine("Rating updated");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Movie not found");
    }
    public void DisplayForward()
    {
        Movie temp = head;
        if(temp == null)
        {
            Console.WriteLine("No movies available");
            return;
        }
        while(temp != null)
        {
            DisplayMovie(temp);
            temp = temp.Next;
        }
    }
    public void DisplayReverse()
    {
        Movie temp = tail;
        if (temp == null)
        {
            Console.WriteLine("No movies available");
            return;
        }
        while (temp != null)
        {
            DisplayMovie(temp);
            temp = temp.Prev;
        }
    }
    private void DisplayMovie(Movie m)
    {
        Console.WriteLine($"Title: {m.Title}, Director: {m.Director}, Year: {m.Year}, Rating: {m.Rating}");
    }
}
class MovieManagementSystem{
    static void Main(){
        MovieDoublyLinkedList movies = new MovieDoublyLinkedList();
        movies.AddAtBeginning("Inception", "Christopher Nolan", 2010, 8.8);
        movies.AddAtEnd("Interstellar", "Christopher Nolan", 2014, 8.6);
        movies.AddAtPosition(2, "Avatar", "James Cameron", 2009, 7.8);
        Console.WriteLine("Movies (Forward):");
        movies.DisplayForward();
        Console.WriteLine("Movies (Reverse):");
        movies.DisplayReverse();
        Console.WriteLine("Search by Director:");
        movies.SearchByDirector("Christopher Nolan");
        Console.WriteLine("Update Rating:");
        movies.UpdateRating("Avatar", 8.0);
        Console.WriteLine("Remove Movie:");
        movies.RemoveByTitle("Inception");
        Console.WriteLine("Final List:");
        movies.DisplayForward();
    }
}