using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobil
{
    public class Class
    {
        public string warna { get; set; }
        public int jumlahPintu { get; set; }
        public string merek { get; set; }
        public string model { get; set; }
        public int tahunKeluaran { get; set; }
        public int kecepatan { get; set; }
        public string suara { get; set; }

        public void Gas(int a)
        {
            Console.WriteLine("Mobil {0} berjalan dengan kecepatan {1}\n", model, a);
        }
        public void Klakson(string a)
        {
            Console.WriteLine("{0}\n", suara);
        }
        public void TampilaknInfo()
        {
            Console.WriteLine("Mobil saya berwarna {0}, merek {1} model {2} keluaran tahun {3}" +
                "dengan jumlah pintu sebanyak {4}", warna, merek, model, tahunKeluaran, jumlahPintu);
        }
    }
}
