using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            AltSinif altSinif = new AltSinif();

            altSinif.Metot1();
            altSinif.Metot2();

            //TemelSinif temelsinif = new TemelSinif(); diye abstract classlardan bir örnek oluşturulamaz.

            Console.ReadLine();
        }
    }
}
