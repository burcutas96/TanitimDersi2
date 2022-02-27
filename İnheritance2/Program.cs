using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritance1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi = new Kedi();

            kedi.isim = "Minnoş";
            kedi.kilo = 10;
            kedi.renk = "siyah";
            kedi.ayakSayisi = 4;
            kedi.cinsiyet = "erkek";

            kedi.SesCikar();
            Console.WriteLine("");
            kedi.HayvanBilgileri();

            Console.ReadLine();
        }
    }
}
