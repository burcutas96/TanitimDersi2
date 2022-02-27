using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Burada secilengun salıyı direkt isim olarak tutuyor, yani salı değerine denk gelen numarayla tutmuyor.
            Gunler secilengun = Gunler.salı;

            if (secilengun == Gunler.cumartesi || secilengun == Gunler.pazar)
            {
                Console.WriteLine("Hafta sonunu seçtiniz");
            }
            else
            {
                Console.WriteLine("Hafta içini seçtiniz");
            }
            Console.ReadLine();
        }
    }
}
