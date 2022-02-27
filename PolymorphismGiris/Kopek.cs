using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismGiris
{
    class Kopek : Hayvan
    {
        public Kopek(string isim) :base(isim)
        {
        }

        public override void Konus()
        {
            Console.WriteLine(isim + " havlıyor...");
        }
    }
}
