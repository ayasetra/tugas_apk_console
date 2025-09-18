using System;
using System.Collections.Generic;
using tugas_apk;


class Program
{
    static void Main(string[] args)
    {
     var Mobil = new List<Mobil>
        {
            new Mobil("Toyota", 300000000),
            new Mobil("Honda", 250000000),
            new Mobil("Suzuki", 200000000)
        };
        var Customer = new List<Customer>
        {
            new Customer("Alice", 500000000),
            new Customer("Bob", 150000000)
        };
        foreach (var customer in Customer)
        {
            customer.Info();
            foreach (var car in Mobil)
            {
                car.Info();
                customer.BeliMobil(car);
            }
            Console.WriteLine();
        }
    }
}
