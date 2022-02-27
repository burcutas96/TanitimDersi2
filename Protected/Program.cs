using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected
{
    class Program
    {
        static void Main(string[] args)
        {
            //Protedted erişim belirleyicisi tekrar...
            //Super class, Base class = Mirası veren class
            //Sub class, alt class = Mirası alan class

            Papatya papatya = new Papatya();

            papatya.PapatyaBilgileri();

            Console.ReadLine();
        }
    }
}
