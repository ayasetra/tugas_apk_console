using System;
using System.Collections.Generic;
using System.Diagnostics;
using tugas_apk;


class Program
{
    static void Main()
    {
        // daftar mobil dengan inheritance
        var mobils = new List<Mobil>
        {
           // Sedan
            new Sedan("Honda Civic", 500_000_000),
            new Sedan("Toyota Camry", 650_000_000),

            // SUV
            new SUV("Toyota Fortuner", 700_000_000),
            new SUV("Hyundai Palisade", 850_000_000),

            // Truck
            new Truck("Hino Ranger", 1_200_000_000),
            new Truck("Isuzu Giga", 1_000_000_000)
        };

        var cust = new Customer("Andi");
        var cust1 = new Customer("Agus");
        var cust2 = new Customer("Bekti");
        var cust3 = new Customer("Yudex");

        Console.WriteLine("== DAFTAR MOBIL ==");
        mobils.ForEach(m => m.Info());  // Polymorphism (Info() berbeda tiap jenis mobil)

        Console.WriteLine("\n== TRANSAKSI ==");
        new Purchase(cust, mobils[1]).Info(); // Andi beli Fortuner
        new Purchase(cust1, mobils[3]).Info();
        new Purchase(cust2, mobils[4]).Info();
        new Purchase(cust3, mobils[2]).Info();


        Console.ReadKey();
    } 
}
