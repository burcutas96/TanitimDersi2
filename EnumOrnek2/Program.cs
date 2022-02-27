using System;

namespace EnumOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri(1, "Burcu", "Taş", "kız", "burcu.tas@gmail.com");

            MusteriDurum DonenDurum = musteri.MusteriEkle(musteri);


            if (DonenDurum == MusteriDurum.kayitBasarili)
            {
                Console.WriteLine("Müşteri başarılı bir şekilde eklendi.");
            }
            else if (DonenDurum == MusteriDurum.kayitBasarisiz)
            {
                Console.WriteLine("Müşteri eklenemedi.");
            }
            else
            {
                Console.WriteLine("Bağlantı hatası oluştu");
            }

            Console.ReadLine();
        }
    }
}
