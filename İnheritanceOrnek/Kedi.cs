using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritance2
{
    public class Kedi : Omurgali
    {
        public override string OzellikleriGoster()
        {
            string name = this.GetType().Name;

            return name + " isimli hayvanın boyu: " + Boy + " agirligi: " + Agirlik; 
        }
    }
}
