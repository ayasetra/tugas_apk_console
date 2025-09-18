

// =================== CLASS LIBRARY (Composition) ===================
public class Library
{
    private List<Book> books;
    private List<Member> members;

    public Library()
    {
        books = new List<Book>();
        members = new List<Member>();
    }

    // Method Overloading
    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"Buku '{book.Title}' berhasil ditambahkan.");
    }

    public void AddBook(string title, string author)
    {
        books.Add(new Book(title, author));
        Console.WriteLine($"Buku '{title}' berhasil ditambahkan.");
    }

    public void AddMember(Member member)
    {
        members.Add(member);
        Console.WriteLine($"Member '{member.Name}' berhasil ditambahkan.");
    }

    public void ShowAllBooks()
    {
        Console.WriteLine("\n=== Daftar Buku ===");
        foreach (var book in books)
        {
            book.DisplayBook();
        }
    }

    public void ShowAllMembers()
    {
        Console.WriteLine("\n=== Daftar Member ===");
        foreach (var member in members)
        {
            member.DisplayInfo();
        }
    }
}