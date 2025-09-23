using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_apk
{
    class Purchase
    {
        public Customer Cust { get; }
        public Mobil Mobil { get; }

        public Purchase(Customer cust, Mobil mobil)
        {
            Cust = cust; Mobil = mobil;
        }

        // Overriding (method Info() utama)
        public void Info()
        {
            Console.WriteLine($"{Cust.Nama} membeli {Mobil.Merk} seharga {Mobil.Harga:C}");
        }

        // Overloading (versi dengan tambahan keterangan)
        public void Info(string catatan)
        {
            Console.WriteLine($"{Cust.Nama} membeli {Mobil.Merk} seharga {Mobil.Harga:C}. Catatan: {catatan}");
        }

        // Overloading (versi dengan jumlah unit)
        public void Info(int jumlah)
        {
            Console.WriteLine($"{Cust.Nama} membeli {jumlah} unit {Mobil.Merk} dengan total {Mobil.Harga * jumlah:C}");
        }
    }
}

