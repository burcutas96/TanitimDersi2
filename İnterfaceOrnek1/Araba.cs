using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaceOrnek1
{
    public class Araba : IArabaSur
    {
        public void Calistir()
        {
            Console.WriteLine("Araba Çalıştırıldı... Haydi Bismillah");
        }

        public void Durdur()
        {
            Console.WriteLine("Okula geldik :) Hadi geçmiş olsun...");
        }

        public void parkEt()
        {
            Console.WriteLine("Park etme işlemi yapılıyor. Dikkat edin!");
        }

        public void Sur()
        {
            Console.WriteLine("Fazla hız yapmadan sürmeye devam.");
        }

        public void vitesDegistir(int vites)
        {
            Console.WriteLine("{0}. vitese geçildi. Hızını ona göre ayarla.", vites);
        }
    }
}
