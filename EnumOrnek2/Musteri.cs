using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumOrnek2
{
    public class Musteri
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string cinsiyet { get; set; }
        public string emailAdres { get; set; }

        public Musteri(int id, string isim, string soyisim, string cinsiyet, string emailAdres)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
            this.cinsiyet = cinsiyet;
            this.emailAdres = emailAdres;
        }


        public static ArrayList musteriler = new ArrayList();
        //ArrayListi static olarak tanımlamamızın nedeni: Çünkü müşteri nesnesini oluşturduğumuzda static olarak tanımlamasaydım
        //her bir müşteri referansında bu ArrayList sıfırdan başlayacaktı. Çünkü burdaki ArrayList her bir oluşturulmuş objeye
        //özgü olacaktı sadece. O an ondan oluşturulmuş objeye erişilebilecekti. Ama ben diyorum ki müşteri sınıfı üzerinden
        //herkes burdaki ArrayListe erişebilsin

       
        public MusteriDurum MusteriEkle(Musteri M1)
        {
            musteriler.Add(M1);

            return MusteriDurum.kayitBasarili;
        }
    }
}
