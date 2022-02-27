using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritanceYapiciMetot
{
    class Kedi : Memeli
    {
        public string Turu;
        
        public Kedi()
        {
            Console.WriteLine("Kedi oluşturuldu.");
        }

        public void TurGoster()
        {
            Console.WriteLine(Turu + " Kedisi");
        }

    }
}
