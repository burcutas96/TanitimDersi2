using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritance
{
    public class Kedi : Hayvan
    {
        //İki nokta üst üste yaparak kedi classı hayvan classını miras almış oldu.

        //Bir class birden fazla miras alamaz!!

        //Buraya bişey yazmıyorum.. Ama istersek yazabiliriz, mesela

        public void KediMetot()
        {
            Console.WriteLine("Kedi miyavlıyor...");
        }


        public string KedininGozRengi()
        {
            string renk = "Mavi";
            return renk;
        }
    }
}
