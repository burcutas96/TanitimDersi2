using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Şekil uygulamasına hoşgeldiniz...");
            Console.WriteLine("");

            while (true)
            {
                Console.WriteLine("1- Dikdörtgen işlemleri");
                Console.WriteLine("2- Üçgen işlemleri");
                Console.WriteLine("3- Kare işlemleri");
                Console.WriteLine("Çıkış yapmak için q'ya basınız.");
                Console.Write("İşlem seçiniz: ");
                string secim = Console.ReadLine();
                Console.WriteLine("");

                if (secim == "q")
                {
                    Console.WriteLine("Programdan çıkış yapılıyor");
                    Console.WriteLine("İyi günler dileriz...");
                    break;
                }
                else if (secim == "1")
                {
                    Sekil dikdortgen = new Dikdortgen("dikdörtgen", 5, 6);

                    while (true)
                    {
                        Console.WriteLine("1- Şekil bilgileri");
                        Console.WriteLine("2- Şeklin alanı");
                        Console.WriteLine("Çıkış yapmak için q'ya basınız.");
                        Console.Write("Yapılacak işlemi seçiniz: ");
                        string secim2 = Console.ReadLine();
                        Console.WriteLine("");

                        if (secim2 == "q")
                        {
                            Console.WriteLine("Dikdörtgen işlemlerinden çıkılıyor...");
                            break;
                        }
                        else if (secim2 == "1")
                        {
                            dikdortgen.SekilBilgileriGoster();
                        }
                        else if (secim2 == "2")
                        {
                            dikdortgen.SekilHesapla();
                        }
                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir işlem giriniz!");
                        }
                        Console.WriteLine("");

                    }

                }

                else if (secim == "2")
                {
                    Ucgen ucgen = new Ucgen("üçgen", 6, 4);

                    while (true)
                    {
                        Console.WriteLine("1- Şekil bilgileri");
                        Console.WriteLine("2- Şeklin alanı");
                        Console.WriteLine("Çıkış yapmak için q'ya basınız.");
                        Console.Write("Yapılacak işlemi seçiniz: ");
                        string secim2 = Console.ReadLine();
                        Console.WriteLine("");

                        if (secim2 == "q")
                        {
                            Console.WriteLine("Üçgen işlemlerinden çıkılıyor...");
                            break;
                        }
                        else if (secim2 == "1")
                        {
                            ucgen.SekilBilgileriGoster();
                        }
                        else if (secim2 == "2")
                        {
                            ucgen.SekilHesapla();
                        }
                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir işlem giriniz!");
                        }
                        Console.WriteLine("");
                    }

                }
                else if (secim == "3")
                {
                    Kare kare = new Kare("kare", 5);

                    while (true)
                    { 
                        Console.WriteLine("1- Şekil bilgileri");
                        Console.WriteLine("2- Şeklin alanı");
                        Console.WriteLine("Çıkış yapmak için q'ya basınız.");
                        Console.Write("Yapılacak işlemi seçiniz: ");
                        string secim2 = Console.ReadLine();
                        Console.WriteLine("");

                        if (secim2 == "q")
                        {
                            Console.WriteLine("Kare işleminden çıkış yapılıyor.");
                            break;
                        }
                        else if (secim2 == "1")
                        {
                            kare.SekilBilgileriGoster();
                        }
                        else if (secim2 == "2")
                        {
                            kare.SekilHesapla();
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
                    Console.WriteLine("Lütfen geçerli bir işlem girin!");
                }
            }


        }
    }
}
