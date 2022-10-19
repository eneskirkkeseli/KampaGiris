using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.urunAdi = "Tavuk";
            urun1.urunFiyati = 49.90;
            urun1.urunGramı = 220;
            urun1.urunAcıklama = "Teriyaki";

            Urun urun2 = new Urun();
            urun2.urunAdi = "Ezine";
            urun2.urunFiyati = 54.90;
            urun2.urunGramı = 180;
            urun2.urunAcıklama = "Peyniri";

            Urun urun3 = new Urun();
            urun3.urunAdi = "Jambon";
            urun3.urunFiyati = 43.95;
            urun3.urunGramı = 230;
            urun3.urunAcıklama = "Cheddar Mega";

            Urun urun4 = new Urun();
            urun4.urunAdi = "Dana Bacon";
            urun4.urunFiyati = 54.90;
            urun4.urunGramı = 185;
            urun4.urunAcıklama = "Füme Etli";

            Urun urun5 = new Urun();
            urun5.urunAdi = "Hindi";
            urun5.urunFiyati = 39.90;
            urun5.urunGramı = 185;
            urun5.urunAcıklama = "Fümeli";

            Urun[] yiyecekler = new Urun[] { urun1, urun2, urun3, urun4, urun5 };
            
            //type safe için "var" olan kısma classla belirlediğimiz tipi giriyoruz.
            foreach (Urun döngü1 in yiyecekler)
            {
                Console.WriteLine(döngü1.urunAdi + döngü1.urunAcıklama);
                Console.WriteLine(döngü1.urunFiyati);
                Console.WriteLine(döngü1.urunGramı);
                Console.WriteLine("----------------------");
            }

            Console.WriteLine("-----------------METOTLAR-------------------");
            //instance - örnek demek.
            //hızlı Console.WriteLine yazmak için: cw yazıp tab+tab yapıyoruz.
            SepetManager sepet = new SepetManager(); //öncelikle oluşturduğum sepetmanager tanımladım sisteme.
            sepet.Ekle(urun1); //daha sonra belirlemiş olduğum adla sayfaya çağırdım.Bunu sepet adıyla her sayfada
            //yapabilirim.Unutma burada ekleyi sepetmanagerdan oluşturduk ve sayfalarda çağırdık.Daha sonra 
            //public void Ekle (Urun yiyecek) parametrelerini atayıp hangi sayfada hangi kısmı çağıracağımızı 
            //belirtiyoruz.Burada urun1.Sonra çalıştırınca sepetManager da bulunan yazıyı o çağırım için yapacaktır.
            sepet.Ekle(urun2);
            sepet.Ekle(urun3);
            sepet.Ekle(urun4);
            sepet.Ekle(urun5);

        }
    }
}
//do not repeat yourself(kendini tekrarlama) mak için metotlar kullanılır.
//clean code(temiz kod yazılımı)
//Best Practice(En iyi ugulama)
//Id atamaları o ürünün diğer ürünlerden ayıran özelliğidir.Classlarda Prop atayınca verdiğimiz atamalardan biri
//Id atamsı olursa aklına gelsin.
//property= özellik demektir.