using System;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri<string> musteri = new Musteri<string>();

            musteri.id = "1";
            musteri.isim = "Burcu";
            musteri.soyisim = "Taş";
            musteri.email = "burcu.tas@gmail.com";

            Console.WriteLine(musteri.example_2("All Right"));

            Console.ReadLine();
        }
    }
}
