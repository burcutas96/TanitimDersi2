using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class Musteri<T>
    {
        public T id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public T email { get; set; }

        public T example_2(T parameter)
        {
            return parameter;
        }
    }
}
