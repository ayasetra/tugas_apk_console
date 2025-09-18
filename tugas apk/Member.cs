// =================== CLASS MEMBER ===================
public class Member
{
    private string name;
    private int id;

    public string Name
    {
        get { return name; }
        protected set { name = value; }
    }
    public int Id
    {
        get { return id; }
        protected set { id = value; }
    }

    // Constructor
    public Member(string name, int id)
    {
        Name = name;
        Id = id;
    }

    // Virtual method (akan di-override)
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"[Member] ID: {Id}, Nama: {Name}");
    }
}