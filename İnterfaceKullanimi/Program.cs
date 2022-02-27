using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaceKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //İnterface Nedir?: C# Interface, yapısı gereği diğer sınıflara yol gösterici, rehberlik yapmak için oluşturulan, kendisinden
            //implement edilen bir sınıfa doldurulması zorunlu olan bazı özelliklerin aktarılmasını sağlayan bir kavramdır.

            Musteri musteri = new Musteri();

            musteri.Ekle();
            musteri.Sil();
            string ad = musteri.PersonelEkle();
            Console.WriteLine(ad);

            Console.ReadLine();


        }
    }
}
