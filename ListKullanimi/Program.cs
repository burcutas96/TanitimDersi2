using System;
using System.Collections.Generic;
using System.Linq;

namespace ListKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> asalSayilar = new List<int>()
            {
                1, 5, 7, 8, 16
            };

            
            for (int i = 0; i < asalSayilar.Count; i++)
            {
                Console.WriteLine(asalSayilar[i]);
            }


           

            Console.WriteLine("");
            bool deger = asalSayilar.Contains(2);

            if (deger)
            {
                Console.WriteLine("2 sayısı listede mevcut");
            }
            else
            {
                Console.WriteLine("2 sayısı listede mevcut değil");
            }




            int indexNo = asalSayilar.BinarySearch(14);

            Console.WriteLine(indexNo);





            string[] dizi = new string[3];
            dizi[0] = "Ayşe";
            dizi[1] = "Fatma";
            dizi[2] = "Pakize";

            //diziyi listeye aşağıdaki gibi çevirebilirsiniz.
            List<string> isimler = new List<string>(dizi);

            foreach (string isim in isimler)
            {
                Console.WriteLine(isim);
            }
            


            Console.WriteLine("");
            List<Kisi> kisi1 = new List<Kisi>();

            kisi1.Add(new Kisi { ad = "Burcu", soyad= "Taş" });

            foreach (Kisi icerik in kisi1)
            {
                Console.WriteLine(icerik.ad + " " + icerik.soyad);
            }

            Console.ReadLine();
        }
    }
}
