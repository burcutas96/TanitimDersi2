using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritanceYapiciMetot
{
    class Memeli
    {
        protected double boy;
        protected double agirlik;
        
        public Memeli()
        {
            Console.WriteLine("Memeli hayvan oluşturuldu.");
        }

        public void OzellikGoster()
        {
            Console.WriteLine("Boy = "+ boy);
            Console.WriteLine("Ağırlık = "+ agirlik);
        }
    }
}
