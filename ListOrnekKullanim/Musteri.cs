using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOrnekKullanim
{
    public class Musteri
    {
        //constructor metotlar hep yukarıda kalmalı anlam karmaşası yaşanmasın.
        public Musteri()
        {

        }

        //aynı şekilde burası da öyle.
        public Musteri(int id, string isim, string soyisim, string email)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
            this.email = email;
        }



        public int id { get; set; }
        public string isim {
            get
            {
                return isim.ToLowerInvariant();    
            }
            set
            {
                isim = value;
                
            }
        }
        public string soyisim { get; set; }
        public string email { get; set; }
         

        public override string ToString()
        {
            string ifade = "id: " + this.id + " isim: " + isim + " soyisim: " + soyisim + " email: " + this.email;
            Console.WriteLine("");
            return ifade;

        }
    }
}
