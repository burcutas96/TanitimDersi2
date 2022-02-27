using System;

namespace AbstractClassOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Ocak ocak = new Ocak();
            Console.WriteLine("Ocak kaç gündür: "+ ocak.KacGundenOlusur()); 

            Subat subat = new Subat();
            Console.WriteLine("Şubat kaç gündür: " + subat.KacGundenOlusur());

            Mart mart = new Mart();
            Console.WriteLine("Mart kaç gündür: " + mart.KacGundenOlusur());

            Console.ReadLine();
        }
    }
}
