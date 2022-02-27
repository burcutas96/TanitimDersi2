using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritance3
{
    class Program
    {
        static void Main(string[] args)
        {
            //sealed anahtar kelimesi: sealed anahtar kelimesi ile işaretlenmiş classları hiç bir class miras alamaz. 


            Musteri musteri = new Musteri();

            musteri.personel_id = 1;
            musteri.personelSoyad = "Taş";
            musteri.Ad(); //Eğer bu metodu yazmazsak atama işlemi gerçekleşmemiş olur.
            
            musteri.PersonelBilgi();


            Console.ReadLine();
        }
    }
}
