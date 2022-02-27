using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritance1
{
    public class Kedi : Kopek
    {
        public void SesCikar()
        {
            Console.WriteLine("Kedi ses çıkarıyor...");
        }

        public void HayvanBilgileri()
        {
            Console.WriteLine("Hayvanın ismi: "+ isim);
            Console.WriteLine("Hayvanın rengi: "+ renk);
            Console.WriteLine("Hayvanın kilosu: "+ kilo);
            Console.WriteLine("Hayvanın ayak sayısı: "+ ayakSayisi);
            Console.WriteLine("Hayvanın cinsiyeti: "+ cinsiyet);
        }
    }
}
