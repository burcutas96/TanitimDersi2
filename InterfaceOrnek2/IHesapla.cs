using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek2
{
    public interface IHesapla
    {
        double yariCap { get; set; }
        double Cap { get; }
        double Cevre { get; }
        double Alan { get; }

    }
}
