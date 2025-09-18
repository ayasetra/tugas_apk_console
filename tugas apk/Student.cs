
// =================== CLASS STUDENT (Inheritance) ===================
public class Student : Member
{
    public string Major { get; set; }

    public Student(string name, int id, string major) : base(name, id)
    {
        Major = major;
    }

    // Overriding
    public override void DisplayInfo()
    {
        Console.WriteLine($"[Student] ID: {Id}, Nama: {Name}, Jurusan: {Major}");
    }
}