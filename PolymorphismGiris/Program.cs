using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            Hayvan hayvan = new Hayvan("Hayvan");
            hayvan.Konus();

            Hayvan kedi = new Kedi("minnoş");     // <-Kedi classının objesini oluşruruken böyle bir şey yapabiliriz. Çünkü kedi classı hayvan
            kedi.Konus();                        //classını miras aldığı için kedi sınıfından oluşturmuş olduğum objemi hayvan classım karşılayabilir.

            Kopek kopek = new Kopek("karabaş");
            kopek.Konus();
            

            Console.ReadLine();

            /*
            HayvanlariKonustur(new Kedi("Minnoş"));
            HayvanlariKonustur(new Kopek("Karabaş"));
            Console.ReadLine();
            //Aşağıdaki metodun kullanımını göstermek için yazıldı.
            */

        }


        //Aşağıdaki de farklı bir kullanım. Türkçesi: HayvanlariKonustur adındaki metodumuzda Hayvan tipinde bir class istemiş olduk. 
        //Yani ya "new Hayvan()" yazıcaz ya da hayvan classını miras alan bir class yazıcaz.
        //Eğer Balık adında bir class oluşturup Hayvan classını miras aldırmamış olsaydık hata alırdık.
        public static void HayvanlariKonustur(Hayvan hayvan)
        {
            hayvan.Konus();
        }


    }
}
