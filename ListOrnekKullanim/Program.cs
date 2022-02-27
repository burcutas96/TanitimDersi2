using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOrnekKullanim
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Musteri> musteriler = new()
            {
                new Musteri { id = 4, email = "falancafilanca@gmail.com", isim = "Burcu", soyisim = "Korkmaz" },
                new Musteri(1, "BURCU", "Taş", "burcu.tas@gmail.com"),
                new Musteri(2, "MERYEM", "Çelik", "meryem.celik@gmail.com"),
                new Musteri(3, "Ahmet", "Koçak", "ahmet.kocak@gmail.com"),
                new Musteri(5, "mansur", "değirmenci", "mrmansurr@gmail.com")
            };

            

            //sana ödev;
            //firstordefault ile first metodu arasındaki farklar.
            //exits ile any arasındaki farklar
            //ve son olarak müşteriler listesine ben isim soyisim kaydederken ismin ilk harfi büyük soyismin tüm harfleri büyük olacak
            //şekilde kaydedilecek. yani yanlış yazdım diyelim şu şekil.
            //böyle bir şey yaptığımda listede böyle bir şey olmaması lazım.
            
            
            
            
            //yani program mı düzeltsin yoksa hatamı versin bir daha mı yazılsın hocam.
            //bankada çalışan arkadaş müşteri kaydederken yanlış yazdı diyelim. peki çalışan arkadaş yanlış yazdı diye
            //biz öyle mi kaydedicez. hayır program düzgün şekilde kaydedecek.Hmmm anladım hocam.
            //sana ödev olsun :) yapmak yapmamak sana kalmış ama söyliyim yazılım zor iştir :) Hocam size sorunca kyeni bilgiler öğreniyorum
            //bunlar beni bir yandan korkutuyor bir yandan mutlu ediyor. Ama emin olun bu ödev üzerinde çok çalışıcam, benim için çok zor bir ödev 
            //ama elimden geleni yapıcam size söz.
            //araştırma güdünü geliştirmen lazım. internette araştır makale oku bakalım.
            //bende bir yere kadar biliyorum sorularına cevap aldıkça gelişirsin ama ya bende bilemezsem o zaman duracak mısın?
            //o yüzden araştır ve balık tutmayı öğren :) son olarak şu bizim siyah ekranı bir daha aç bakalım öğrenmiş misin :) Hocam böyle miydi değil gibi :D:D nasıldı hocam watch run yazmıyo muyduk. watch run doğru bi kelime eksik 
            //vallahi hatırlayamadım hocam. bu hangi platform c# hangi framework .net-- peki nasıl yazılır .net mihocam
            //.net nokta koymasam onun yerine ne yazsam dotnet mi hocam aynen öyle evet? Hocam yine mi olmadı:( olmadı yerleri değiştir :OO Oldu hocam:D
            //yeni toolun gıcır  gıcır seni bekliyor :)Hocam ben daha sizin gibi profesyonel olmadım ki:)D
            //ben çok zor öğrendim kimse göstermedi bana sen takıldıkça sor ben sana yardımcı olurum
            //amerikayı tekrar keşfetmeye gerek yok ne kadar çok sorarsan o kadar çok bilgi öğrenirsin basamakları hızlı çıkarsın
            //sormazsan araştırma yoluna gitmen lazım araştırma seni sıkabilir ve çok yavaş gelişirsin. Hocam araştırmak istiyorum istiyorum ama sonuçlar 
            //ingilizce olduğu için okuyamıyorum moralim bozuluyo bir daha gruba sormak zorunda kalıyorum:(
            //şimdi bak beraber first ve firtordefaultun farkına bakalım ben sana göstereyim.
            //siyah ekranı durdurmak istersen arka arkaya ctrl + c'ye basmalısın.
            //siyah ekranın diğer durumunu göstereyim sana.
            //bak sol tarafa çok proje eklemişsin. mümkün olduğunca denerken tek tek açmaya çalış çünkü
            //visual studio derleme yaparken diğer projelere de göz atıyor yavaşlatıyor pc'yi.
            //siyah ekran yereine bu terminalide kullanabilirsin aklında bulunsun
            //araştırmayı gösteriyorum ve bırakıyorum :)
            //oldu mu :) Oldu hocam çok çok çok teşekkür ederim:) Fazlaca vaktinizi aldım:(
            //sana eklenti kurdum kelimeleri seçerek onları türkçeye çevirebilirsin.Tmmdır hocam onu kullanırım artık:)
            //kendine iyi bak takılırsan sor yine hoşça kal SAğolun hocam görüşmek üzere:)hoşça kal

            Musteri m = musteriler.First(x => x.isim == "Burcu");

            

            //dedim ki m diye değişken verdiğim değer boş değilse
            //if(m != null)
            //{
            //bu şekilde de yazılabilir. ikisinin farkı yok
            //}

            //m boş değilse yani burcu var ise
            //deneyelim.
            //geldi ama direk taş yazmadımA Aynen hocam aslında bu koşul aklıma geldi ama ben farklı bir metotla da yazılır diye düşündüm:(
            //peki şöyle yapalım bir tane daha burcu olsun listemde
            //hayda korkmaz geldi nolacak şimdi iki tane burcu var.Metot mu kullanıcaz hocam
            //hangisini, şu ana kadar gördüğümüz metotlardan birni mi hocam evetAny mi hocam
            //any evet sayılabilir ama ben taş soyisminin yazmasını istiyorum,hmm bilemedim hocam
            //

            if (m is not null)
            {
                Console.WriteLine("benim ismim " + m.isim);
            }
            else
            {
                Console.WriteLine("böyle bir kişi yok");
            }

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri);
            }
            Console.ReadLine();
        }
    }
}
