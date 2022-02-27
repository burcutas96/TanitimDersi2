using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek3
{
    public class Hesap : IIslem
    {
        public void carp(int sayi1, int sayi2)
        {
            Console.WriteLine("İki sayının çarpımı: " + (sayi1 * sayi2));
        }

        public void topla(int sayi1, int sayi2)
        {
            Console.WriteLine("İki sayının toplamı: "+ (sayi1 + sayi2));
        }
    }
}
