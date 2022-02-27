using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismOrnek
{
    public class Kare : Sekil
    {
        public int kenar { get; set; }

        public Kare(string isim, int kenar) :base(isim)
        {
            this.kenar = kenar;
        }

        public override void SekilHesapla()
        {
            base.SekilHesapla();
            Console.WriteLine(isim + "'nin alanı: "+ (kenar*kenar));
        }

        public override void SekilBilgileriGoster()
        {
            base.SekilBilgileriGoster();
            Console.WriteLine("kenar uzunluğu: "+ kenar);
        }

    }
}
