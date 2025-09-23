using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_apk
{
    class Mobil
    {
        public string Merk { get; }
        public double Harga { get; }

        public Mobil(string merk, double harga)
        {
            Merk = merk; Harga = harga;
        }

        public virtual void Info()
        {
            Console.WriteLine($"{Merk} - Harga {Harga:C}");
        }
    }
    class Sedan : Mobil
    {
        public Sedan(string merk, double harga) : base(merk, harga) { }
        public override void Info()
        {
            Console.WriteLine($"[Sedan] {Merk} - Harga {Harga:C} (nyaman untuk keluarga)");
        }
    }

    class SUV : Mobil
    {
        public SUV(string merk, double harga) : base(merk, harga) { }
        public override void Info()
        {
            Console.WriteLine($"[SUV] {Merk} - Harga {Harga:C} (cocok untuk offroad)");
        }
    }

    class Truck : Mobil
    {
        public Truck(string merk, double harga) : base(merk, harga) { }
        public override void Info()
        {
            Console.WriteLine($"[Truck] {Merk} - Harga {Harga:C} (muatan berat)");
        }
    }


}
