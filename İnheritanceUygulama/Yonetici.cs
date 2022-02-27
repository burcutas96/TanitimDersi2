using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritanceUygulama
{
    public class Yonetici : Calisan
    {
        private int SorumluKisiSayisi;
        public Yonetici(int id, string isim, string soyisim, int SorumluKisiSayisi) :base(id, isim, soyisim)
        {
            this.SorumluKisiSayisi = SorumluKisiSayisi;
        }

        public void ZamYap(int ZamMiktari)
        {
            Console.WriteLine(getIsim() + ", çalışanlara " + ZamMiktari + " TL zam yapıyor.");
        }
    }
}
