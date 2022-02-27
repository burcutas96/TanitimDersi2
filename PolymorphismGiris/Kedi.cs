using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismGiris
{
    class Kedi : Hayvan
    {
        public Kedi(string _isim) :base(_isim)
        {
        }

        public override void Konus()
        {
            Console.WriteLine(isim + " miyavlıyor...");
        }
    }
}
