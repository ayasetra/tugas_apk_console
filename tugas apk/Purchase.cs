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

        public void Info()
        {
            Console.WriteLine($"{Cust.Nama} membeli {Mobil.Merk} seharga {Mobil.Harga:C}");
        }
    }
}
