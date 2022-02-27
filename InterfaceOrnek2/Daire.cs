using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek2
{
    public class Daire : IHesapla
    {
        private double rad;
        public Daire(double yariCap)
        {
            this.rad = 0.00D;
            this.rad = yariCap;
        }
        public double yariCap
        {
            get
            {
                return rad;
            }

            set
            {
                if (rad <= 0)
                {
                    rad = 0;
                }
                else
                {
                    rad = value;
                }
            }
        }

        public double Cap
        {
            get
            {
                return rad * 2;
            }
        }

        public double Cevre 
        {
            get
            {
                return rad * 2 * 3.14159;
            }
        }
        

        public double Alan
        {
            get
            {
                return rad * rad * 3.14159;
            }
        }
    }
}
