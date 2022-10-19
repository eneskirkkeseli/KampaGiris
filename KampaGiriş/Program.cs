using System;

namespace KampaGiriş
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety: tip güvenliği (yazdırmak istediğin metin başlarında türlerini yazmazsan çalışmaz)
            //string kategoriEtiketi = "Kategori"; alias=kategoriEtiketi değişkenimiz=Kategori
            //kendini tekrar etmemek(do not repeat yourself) için değişken ata.Yoksa her metni sayfada arayıp değişme durumu sıkıntı olur.
            //alias = değer tutucu demektir. Buradaki aliasımız "kategoriEtiketi".
            //Her satır sonuna muhakkak ; koymayı unutma.
            string kategoriEtiketi = "Kategori";
            Console.WriteLine(kategoriEtiketi);
            //PHYTONda print yazdırırken, c# ta "Console.WriteLine" yazınca ekrana bir şeyler yazdırabilirsin.
            //For Example: Console.WriteLine("Hello World"); gibi
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            //2 durumlu konularda kullanacağımız komut "bool" olacaktır.Mesela sisteme giriş yapıldı mı yapılmadı mı gibi.
            bool sistemeGirisYapildiMmi = false;
            //eğer if yazımından sonra iki kere tb tuşuna basarsan otomatik şemayı verir.Aşağıda olduğu gibi.
            //gerçek hayatta "false" kısmı veri kaynağından gelir.O yüzden kafan karışmasın.Mantığı anla.
            //bool komutundaki verilere göre if komutunda yönlendirmeler olacak onu da unutma.
            if (sistemeGirisYapildiMmi == true)
            {
                Console.WriteLine("Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap");
            }
        }
    }
}
