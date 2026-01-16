    public class Book
    {
        public int BookId;
        public string Title;
        public string Author;
        public string Genre;
        public Book(int id, string title, string author, string genre)
        {
            BookId = id;
            Title = title;
            Author = author;
            Genre = genre;
        }
        public override string ToString()
        {
            return $"{BookId} - {Title} by {Author}";
        }
    }

