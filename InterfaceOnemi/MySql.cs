using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOnemi
{
    public class MySql : IMusteri
    {
        public void Ekle()
        {
            Console.WriteLine("MySql ekledi");
        }
        public void Sil()
        {
            Console.WriteLine("MySql sildi");
        }
        public void Guncelle()
        {
            Console.WriteLine("MySql güncelledi");
        }
    }
}
