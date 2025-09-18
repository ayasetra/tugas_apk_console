using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_apk
{
    internal class Customer
    {
        public string Nama { get; }
        public double Saldo { get; private set; }
        public Customer(string nama, double saldo)
        {
            Nama = nama;
            Saldo = saldo;
        }
        public void Info()
        {
            Console.WriteLine($"Nama: {Nama}, Saldo: {Saldo:C}");
        }
        public bool BeliMobil(Mobil mobil)
        {
            if (Saldo >= mobil.Harga)
            {
                Saldo -= mobil.Harga;
                Console.WriteLine($"{Nama} berhasil membeli {mobil.Merk} seharga {mobil.Harga:C}. Sisa saldo: {Saldo:C}");
                return true;
            }
            else
            {
                Console.WriteLine($"{Nama} tidak memiliki cukup saldo untuk membeli {mobil.Merk}.");
                return false;
            }
        }
    }
}
