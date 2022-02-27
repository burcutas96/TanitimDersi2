using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaceKullanimi
{
    public class Musteri : IMusteri, IPersonel
    {
        public int MyProperty { get ; set ; }

        public void Ekle()
        {
            Console.WriteLine("Müşteri Eklendi");
        }
        public void Sil()
        {
            Console.WriteLine("Müşteri silindi");
        }
        public void Guncelle()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
        public void Getir()
        {
            Console.WriteLine("Müşteri getirildi");
        }

        public string PersonelEkle()
        {
            string isim = "Ayşe";
            return isim;
        }

        
    }
}
