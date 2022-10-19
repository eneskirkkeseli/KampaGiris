using System;

namespace örneklendirme
{
    class Program
    {
        static void Main(string[] args)
        {
            string enes = "uzun";
            Console.WriteLine(enes);
            string[] kategori = new string[] { "a", "b", "c" };
            for (int i = 0; i < kategori.Length; i++)
            {
                Console.WriteLine(kategori[i]);
            }
            foreach (var sınıf in kategori)
            {
                Console.WriteLine(sınıf);
            }
            bool siteyeGirişVar = true;
            if (siteyeGirişVar == false)
            {
                Console.WriteLine("Alışveriş Listesi");
            }
            else
            {
                Console.WriteLine("Girilmedi.");
            }
            string[] benim = new string[] { "enes", "esin", "sibel" };
            int Enes = 28;
            int sibel = 56;
            int esin = 24;
            if (Enes > sibel)
            {
                Console.WriteLine("yanlış");
            }
            else if (Enes < esin)
            {
                Console.WriteLine("yanlış");
            }
            else
            {
                Console.WriteLine("doğru");
            }
            for (int i = 1; i < benim.Length; i++)
            {
                Console.WriteLine(benim[i]);
            }
            foreach (var x in benim)
            {
                Console.WriteLine(x);
            }
            string kullaniciAdi = "x";
            string sifre = "y";
            string sonuc = (kullaniciAdi == "x" && sifre == "y") ? "giris basarılı" : "giris basarısız";
            Console.WriteLine(sonuc);
            Asınıfı ogrenci = new Asınıfı();
            ogrenci.ogrenciAdı = "Enes";
            ogrenci.ogrenciSoyadı = "KIRKKESELİ";
            ogrenci.ogrenciPuanı = 85;
            ogrenci.ogrenciOrtalaması = 46.5;

            Asınıfı ogrenci1 = new Asınıfı();
            ogrenci1.ogrenciAdı = "esin";
            ogrenci1.ogrenciSoyadı = "KIRKKESELİ";
            ogrenci1.ogrenciPuanı = 90;
            ogrenci1.ogrenciOrtalaması = 86.5;

            Asınıfı ogrenci2 = new Asınıfı();
            ogrenci2.ogrenciAdı = "sibel";
            ogrenci2.ogrenciSoyadı = "KIRKKESELİ";
            ogrenci2.ogrenciPuanı = 68;
            ogrenci2.ogrenciOrtalaması = 70.6;




            Asınıfı[] ogrenciler = new Asınıfı[] { ogrenci, ogrenci1, ogrenci2 };

            foreach (var Asınıfı in ogrenciler)
            {
                Console.WriteLine(Asınıfı.ogrenciAdı + " " + Asınıfı.ogrenciSoyadı);
            }
        }


    class Asınıfı
        {
            public string ogrenciAdı { get; set; }
            public string ogrenciSoyadı { get; set; }
            public int ogrenciPuanı { get; set; }
            public double ogrenciOrtalaması { get; set; }
        }
        
    }
}
