using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class TemelSinif
    {
        public void Metot1()
        {
            Console.WriteLine("Abstract sınıf içerisinde tanımlanmış olan metot çağırıldı.");  //metodun bodysi
        }

        public abstract void Metot2();  //metodun imzası
    }
}
