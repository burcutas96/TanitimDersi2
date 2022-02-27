using System;

namespace GenericClassKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository<Musteri> repositoryMusteri = new Repository<Musteri>();

            Musteri musteri = new Musteri();
            musteri.id = 1;
            musteri.isim = "Burcu";
            musteri.soyisim = "Taş";
            musteri.cinsiyet = "kız";
            musteri.dogumTarih = new DateTime(2002, 3, 7);
            musteri.emailAdres = "burcu.tas@gmail.com";

            repositoryMusteri.Getir();
            repositoryMusteri.Ekle(musteri);



            Repository<Urun> repositoryUrun = new Repository<Urun>();

            Urun urun = new Urun();
            urun.urunid = 1;
            urun.urunIsmi = "Kalem";
            urun.urunFiyat = 13;

            Console.WriteLine(repositoryUrun.Ekle(urun)); 
            repositoryUrun.Getir();

            Console.ReadLine();

        }
    }
}
