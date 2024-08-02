using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Console
{
    public class Islem
    {
        public int topla(int sayi1 ,int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Sonuç: " + sonuc);
            return sonuc;
        }

        public int kare(int sayi)
        {
            int sonuc = sayi * sayi;
            Console.WriteLine("Sonuç: " + sonuc);
            return sonuc;
        }
    }
}
