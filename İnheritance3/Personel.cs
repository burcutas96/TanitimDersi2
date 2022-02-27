using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritance3
{
    public class Personel  //erişim belirleyicisinden sonra 'sealed' anahtar kelimesi gelir.
    {
        public int personel_id { get; set; }
        protected string personelAd { get; set; } //bu değişkene musteri classının içinde bir metot aracılığıyla atama yapabilirim.
        internal string personelSoyad { get; set; }
        private int personelMaas { get; set; }

        public void PersonelBilgi()
        {
            Console.WriteLine("Personelin adı: "+ personelAd);
            Console.WriteLine("Personelin soyadı: "+ personelSoyad);
            Console.WriteLine("Personelin id: " + personel_id);
            Console.WriteLine("Personelin maaşı: "+ personelMaas);
        }
    }
}
