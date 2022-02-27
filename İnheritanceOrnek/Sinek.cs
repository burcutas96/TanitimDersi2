using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritance2
{
    class Sinek : Omurgali
    {
        public override string OzellikleriGoster()
        {

            var name = this.GetType().Name;


            return name + " isimli hayvanın boyu: " + this.Boy + " agirligi: " + this.Agirlik;
        }
    }
}
