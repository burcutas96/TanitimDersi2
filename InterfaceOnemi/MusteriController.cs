using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOnemi
{
    public class MusteriController
    {
        public void MusteriEkle(IMusteri veritabanı)
        {
            veritabanı.Ekle();
        }
    }
}
