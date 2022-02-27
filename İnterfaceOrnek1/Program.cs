using System;

namespace İnterfaceOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            IArabaSur araba = new Araba();

            araba.Calistir();
            araba.vitesDegistir(2);
            araba.Sur();
            araba.parkEt();
            araba.Durdur();
            Console.ReadLine();
        }
    }
}
