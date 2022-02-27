using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi = new Kedi();

            kedi.hayvan_isim = "Boncuk";
            kedi.hayvan_cinsiyet = "Kız";
            kedi.hayvan_rengi = "Beyaz";
            // yas propertysi çıkmadı çünkü private olarak tanımlandı.

            kedi.HayvanınBilgileri();

            kedi.KediMetot();

            Console.ReadLine();
        }
    }
}
