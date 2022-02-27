using System;

namespace InterfaceOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            double YariCap = 0;
            try
            {
                Console.Write("Yarı çapı girin: ");
                YariCap = double.Parse(Console.ReadLine());
                IHesapla daire = new Daire(YariCap);
                Console.WriteLine("Yarçap: {0}", daire.yariCap);
                Console.WriteLine("Çap: {0}", daire.Cap);
                Console.WriteLine("Çevre: {0}", daire.Cevre);
                Console.WriteLine("Alan: {0}", daire.Alan);
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz Değer");
            }
            Console.ReadLine();
        }
    }
}
