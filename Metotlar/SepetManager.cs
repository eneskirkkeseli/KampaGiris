using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention= isimlendirme kuralıdır.
        //bir yerde normal parantez görünürse orada metot çalışıyor demektir.
        //burada public void mantığu PHYTON'daki def ile aynı.
        public void Ekle(Urun yiyecek) //ilki classta belirttiğim tip ikinci altta yazarken kullanacağım isim.
            //Buradaki Ekle kısmı ise diğer sayfalarda alttaki veriyi çağıracağımız komut.
        {
            Console.WriteLine("TEBRİKLER SEPETE EKLENDİ. :"+yiyecek.urunAdi+" "+yiyecek.urunAcıklama);
        }


    }
}
