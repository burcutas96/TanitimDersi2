using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritanceUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan uygulamasına hoşgeldiniz.");

            while (true)
            {
                Console.WriteLine("1- Yazılımcı işlemleri");
                Console.WriteLine("2- Yönetici işlemleri");
                Console.WriteLine("Çıkış için q'ya basın");
                string secilenIslem = Console.ReadLine();
                Console.WriteLine("");

                if (secilenIslem == "q")
                {
                    Console.WriteLine("Programdan çıkış yapıldı"); 
                    Console.WriteLine("İyi günler dileriz...");
                    break;
                }
                else if (secilenIslem == "1")
                {
                    Yazilimci yazilimci = new Yazilimci(1, "Burcu", "Taş", "Css, C#");
                    
                    while (true)
                    {
                        Console.WriteLine("Yazılımcı işlemi seçiniz: ");
                        Console.WriteLine("1- Format at");
                        Console.WriteLine("2- Yazılımcının bilgilerini göster");
                        Console.WriteLine("Çıkış için q'ya basınız");
                        string YazilimciIslem = Console.ReadLine();
                        Console.WriteLine("");

                        if (YazilimciIslem == "q")
                        {
                            Console.WriteLine("Yazılımcı işlemlerinden çıkış yapılıyor.");
                            break;
                        }
                        else if (YazilimciIslem == "1")
                        {
                            Console.Write("İşletim sistemi giriniz: ");
                            string isletim = Console.ReadLine();
                            yazilimci.formatAt(isletim);
                        }
                        else if (YazilimciIslem == "2")
                        {
                            yazilimci.BigileriGoster();
                        }
                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir işlem giriniz!");
                        }
                        Console.WriteLine("");
                    }
                }

                else if (secilenIslem == "2")
                {
                    Yonetici yonetici = new Yonetici(2, "Laçin", "Kaya", 11);
                    
                    while (true)
                    {
                        Console.WriteLine("Yönetici işlemi seçiniz: ");
                        Console.WriteLine("1- Zam yap");
                        Console.WriteLine("2- Yöneticinin bilgilerini göster");
                        Console.WriteLine("Çıkış için q'ya basınız");
                        string YoneticiIslem = Console.ReadLine();
                        Console.WriteLine("");

                        if (YoneticiIslem == "q")
                        {
                            Console.WriteLine("Yönetici işlemlerinden çıkış yapılıyor.");
                            break;
                        }
                        else if (YoneticiIslem == "1")
                        {
                            Console.Write("Zam miktarını giriniz: ");
                            int zamMiktari = Convert.ToInt32(Console.ReadLine());

                            yonetici.ZamYap(zamMiktari);

                        }
                        else if (YoneticiIslem == "2")
                        {
                            yonetici.BigileriGoster();
                        }
                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir işlem giriniz!");
                        }
                        Console.WriteLine("");
                    }
                   
                }

                else
                {
                    Console.WriteLine("Lütfen çalışan uygulaması için geçerli bir işlem seçiniz!");
                }
            }
            Console.ReadLine();
        }
    }
}
