

// =================== CLASS TEACHER (Inheritance) ===================
public class Teacher : Member
{
    public string Subject { get; set; }

    public Teacher(string name, int id, string subject) : base(name, id)
    {
        Subject = subject;
    }

    // Overriding
    public override void DisplayInfo()
    {
        Console.WriteLine($"[Teacher] ID: {Id}, Nama: {Name}, Mata Kuliah: {Subject}");
    }
}