using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected
{
    public class Papatya : Bitki   //Sub Class
    {
        public void PapatyaBilgileri()
        {
            id = 1;
            ismi = "Papatya";
            rengi = "Sarı";

            Console.WriteLine("Bitki id: "+ id);
            Console.WriteLine("Bitki ismi: "+ ismi);
            Console.WriteLine("Bitki rengi: "+ rengi);
        }
    }
}
