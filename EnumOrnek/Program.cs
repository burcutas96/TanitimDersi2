using System;

namespace EnumOrnek
{
    class Program
    {
        enum Gun { Pazartesi = 1, Salı = 2, Carsamba = 3, Persembe = 4, Cuma = 5, Cumartesi = 6, Pazar = 7 };

        static void Main(string[] args)
        {
            //Burada secilenGun salıyı direkt sayı olarak tutuyor, yani salı ismiyle tutmuyor.

            int secilenGun = (int)Gun.Carsamba;

            if (secilenGun == (int)Gun.Cumartesi || secilenGun == (int)Gun.Pazar)
            {
                Console.WriteLine("Hafta sonu seçtiniz.");
            }
            else
            {
                Console.WriteLine("Hafta içi seçtiniz.");
            }
            Console.ReadLine();
        }
    }
}
