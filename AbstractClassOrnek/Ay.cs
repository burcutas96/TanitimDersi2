using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassOrnek
{
    public abstract class Ay
    {
        public int GunSaati()
        {
            return 24;
        }

        public virtual int KacGundenOlusur()
        {
            return 31;
        }

        public abstract int KacıncıAy();
    }
}
