using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOnemi
{
    public class SqlServer : IMusteri
    {
        public void Ekle()
        {
            Console.WriteLine("Sql Server ekledi");
        }
        public void Sil()
        {
            Console.WriteLine("Sql Server sildi");
        }
        public void Guncelle()
        {
            Console.WriteLine("Sql Server güncelledi");
        }
    }
}
