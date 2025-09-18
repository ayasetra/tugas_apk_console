using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_apk
{
    internal class Mobil
    {
        public string Merk { get; }
        public double Harga { get; }

        public Mobil(string merk, double harga)
        {
            Merk = merk; 
            Harga = harga;
        }
        public virtual void Info()
        {
            Console.WriteLine($"{Merk} - Harga {Harga:C}");
        }
    }
}
