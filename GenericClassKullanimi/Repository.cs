using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassKullanimi
{
    //veri tabanı ile muhattap olacak classlara genellikle Repository adı verilir.
    public class Repository<T>
    {
        
        public List<T> Getir()
        {
            //Bu metotla, veri tabanında ilgili tabloya git ve oradan kayıtları getir diyoruz. Gelen kayıtlarda bana
            //T tipinde dönmüş olacak. 

            //Mesela T'ye Musteri girersek Musteri tipinde bir liste dön, Personel verirse Personel tipinde bir liste
            //dön demiş olacağız.
            return null;
        }

        public string Ekle(T data)
        {
            //Bu metotla, veri tabanına git ilgili tabloya T tipindeki datayı ekle demiş oluyoruz.

            return "Data başarılı bir şekilde eklenmiştir.";
        }
    }
}
