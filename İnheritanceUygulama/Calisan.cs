using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritanceUygulama
{
    public class Calisan
    {
        private int id;       //set ve getde set metodunu yazmamıza gerek yok zaten atamalarını yapıcı metot ile yaptık.
        private string isim;
        private string soyisim;

        public Calisan(int id, string isim, string soyisim)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
        }

        public int getId()
        {
            return this.id;
        }
        
        public string getIsim()
        {
            return this.isim;
        }
        
        public string getSoyisim()
        {
            return this.soyisim;
        }
        


        public void BigileriGoster()
        {
            Console.WriteLine("id: "+ this.id);
            Console.WriteLine("isim: "+ this.isim);
            Console.WriteLine("soyisim: "+ soyisim);  //Burda illa this yazmamıza gerek yok, yazmasakta olur.  
        }
    }
}
