using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstraction");
            mobil mobil = new mobil();

            mobil.Melaju();
            Console.WriteLine("Warna Mobil :{0} ", mobil.Warna);
            Console.WriteLine("Kecepatan Mobil : {0} ", mobil.Kecepatan);
            Console.WriteLine("Jumlah roda Mobil : {0} ", mobil.JumlahRoda);
            Console.WriteLine("---------------------");

            Console.ReadKey();

        }
    }
}
