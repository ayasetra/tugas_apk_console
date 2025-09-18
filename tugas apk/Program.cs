using System;
using System.Collections.Generic;





// =================== MAIN PROGRAM ===================
class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        // Tambah buku (Overloading)
        library.AddBook("Belajar C#", "Budi");
        library.AddBook(new Book("OOP dengan Java", "Ani"));

        // Tambah member (Inheritance + Polymorphism)
        Student s1 = new Student("Andi", 1, "Informatika");
        Teacher t1 = new Teacher("Pak Joko", 2, "Pemrograman");

        library.AddMember(s1);
        library.AddMember(t1);

        // Tampilkan semua data
        library.ShowAllBooks();
        library.ShowAllMembers();

        Console.ReadKey();
    }
}
