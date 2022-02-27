using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi = new Kedi
            {
                Boy = 52,
                Agirlik = 18
            };

            string ozellikler = kedi.OzellikleriGoster();

            Console.WriteLine(ozellikler);

            Console.WriteLine("");

            Kopek kopek = new Kopek
            {
                Boy = 58,
                Agirlik = 23
            };

            string ozellikler2 = kopek.OzellikleriGoster();

            Console.WriteLine(ozellikler2);

            Console.WriteLine("");

            Sinek sinek = new Sinek()
            {
                Agirlik = 0.5,
                Boy = 1
            };

            Console.WriteLine(sinek.OzellikleriGoster());
            

            
            Console.ReadLine();
        }
    }
}
