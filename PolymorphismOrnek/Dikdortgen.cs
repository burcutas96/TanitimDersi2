using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismOrnek
{
    public class Dikdortgen : Sekil
    {
        public int kisaKenar;
        public int uzunKenar;

        public Dikdortgen(string isim, int kisaKenar, int uzunKenar) :base(isim)
        {
            this.kisaKenar = kisaKenar;
            this.uzunKenar = uzunKenar;
        }

        public override void SekilHesapla()
        {
            base.SekilHesapla();
            Console.WriteLine(isim + "'nin alanı: " + (kisaKenar * uzunKenar) );
        }

        public override void SekilBilgileriGoster()
        {
            base.SekilBilgileriGoster();
            Console.WriteLine("Kısa kenar uzunluğu: "+ kisaKenar);
            Console.WriteLine("Uzun kenar uzunluğu: "+ uzunKenar);
        }
    }
}
