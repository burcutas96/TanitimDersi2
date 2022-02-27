using System;

namespace InterfaceOrnek3
{
    class Program
    {
        static void Main(string[] args)
        {
            IIslem hesap = new Hesap();

            Console.Write("Birinci sayıyı giriniz: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            hesap.carp(number1, number2);
            hesap.topla(number1, number2);

            Console.ReadLine();
        }
    }
}
