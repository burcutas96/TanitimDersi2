using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismOrnek
{
    public class Sekil //base class
    {
        public string isim;

        public Sekil(string isim)
        {
            this.isim = isim;
        }

        public virtual void SekilHesapla()
        {
            Console.WriteLine("Şeklin alanı hesaplanıyor...");
        }

        public virtual void SekilBilgileriGoster()
        {
            Console.WriteLine(isim + "'nin bilgileri!");
        }


    }
}
