// =================== CLASS BOOK ===================
public class Book
{
    // Encapsulation (Data Hiding)
    private string title;
    private string author;

    // Property untuk mengakses field private
    public string Title
    {
        get { return title; }
        private set { title = value; }
    }
    public string Author
    {
        get { return author; }
        private set { author = value; }
    }

    // Constructor
    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public void DisplayBook()
    {
        Console.WriteLine($"Judul: {Title}, Penulis: {Author}");
    }
}
