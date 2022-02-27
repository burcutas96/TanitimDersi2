using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritanceUygulama
{
    public class Yazilimci : Calisan
    {
        private string diller;
        public Yazilimci(int _id, string _isim, string _soyisim, string diller) :base(_id, _isim, _soyisim)
        {
            this.diller = diller;
        }

        public void formatAt(string isletimSistemi)
        {
            Console.WriteLine(getIsim() + " şuan da " + isletimSistemi + " işletim sistemine format atıyor.");
        }
    }
}
