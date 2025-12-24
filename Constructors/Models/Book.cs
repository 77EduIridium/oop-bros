namespace Constructors.Models
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Book(string title) : this(title, "Unknown", DateTime.Now.Year) { }

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public void PrintInfo() =>
            Console.WriteLine($"Title: {Title}, Author: {Author}, Year Published: {Year}");
    }
}