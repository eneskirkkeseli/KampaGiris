using System;

namespace Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            //NOT: Biz birden fazla verimizi ayrı ayrı tanımlamaktansa dizilerde(array) tutarız bu verileri.
            //NOT: kurslar bizim dizimize atadığımız başlık.
            string[] kurslar = new string[] { "matematik", "kimya", "fizik" };
            //NOT: string[] demek ben birden fazla veriyi tek stringte tutmak istiyorum demek.
            //NOT: Kafan karışmasın new string bölümü dizidir.Bu kısım verilerden gelir.
            //NOT: Kısaca fazla ögeli verileri dizilere alıp döngülerde çalıştır.

            for (int i = 0; i <kurslar.Length; i++) //sayısını bilmiyorsan kurslar.Length veya verdiğin isim neyse o kadar sayıyı kapsar.
            //NOT: Başlangıcı i olarak gösteririz.2.si vermiş olduğun şart veya üst sınır.3. ise artış miktarı.
            {
                Console.WriteLine(kurslar[i]); //NOT: footer dediğimiz sayfa sonlarındaki yazılardır webde.
            }                                  //NOT: Bunun anlamı: Kursların 1. elemanını yazdırmak istiyorum.
            foreach (string kurs in kurslar) //Kurs buradaki takma isim gibi düşün.Değer tutucu.
                                               //NOT: foreach ile for aynı yazılım farklı.
            {
                Console.WriteLine(kurs);
            }
        }
 
    }

}
