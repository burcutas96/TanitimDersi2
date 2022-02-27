using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOnemi
{
    class Program
    {
        static void Main(string[] args)
        {
            //İnterfaceimizi implemente eden classlarımızdan oluşturduğumuz örneği interface karşılayabilir.

            MusteriController musteriController = new MusteriController();

            musteriController.MusteriEkle(new MySql());
            musteriController.MusteriEkle(new SqlServer());

            Console.ReadLine();
        }
    }
}
