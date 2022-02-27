using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismOrnek
{
    public class Ucgen : Sekil
    {
        public int tabanAlani { get; set; }
        public int yukseklik { get; set; }

        public Ucgen (string isim, int tabanAlani, int yukseklik) : base(isim)
        {
            this.tabanAlani = tabanAlani;
            this.yukseklik = yukseklik;
        }

        public override void SekilHesapla()
        {
            base.SekilHesapla();
            Console.WriteLine(isim + "'nin alanı: " + (tabanAlani * yukseklik) / 2);
        }

        public override void SekilBilgileriGoster()
        {
            base.SekilBilgileriGoster();
            Console.WriteLine("Taban alanı: "+ tabanAlani);
            Console.WriteLine("Yüksekliği: "+ yukseklik);
        }
    }
}
