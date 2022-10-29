using System;

namespace classlar
{
    class Program
{
    static void Main(string[] args)
    {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.IzlenmeOranı = 87;
            kurs1.Egitmen = "engin";

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "c-d#";
            kurs2.IzlenmeOranı = 87;
            kurs2.Egitmen = "engin";

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "c#";
            kurs3.IzlenmeOranı = 87;
            kurs3.Egitmen = "engin";
//buraya eklemeler yapabilir çıkartmalar da yapabilirim.sadece yapınca dizilere de aynı işlemi yapmayı unutma.

            //Console.WriteLine(kurs1.eğitmen + " " + kurs1.kursAdi); şeklinde yazdırabilirim.
            
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};

            foreach (var kurs in kurslar) //ÖNEMLİ NOT: Kurs dizisini "kurslar"a tanımladım.Daha sonra kurs 
//dizisinin içinde ne olduğunu gösterdim new Kurs da en sonunda da tanımlamış olduğum dizinin başlığını döngüye
//soktum.Zaten döngüde de dizi içindeki elemanların yazılımını sağladım bu sayede.Yazdıracağım eleman ise yine
//kurs dizisinin içindeki eleman olacaktır.hangisini öğrenmek istersen kurs.eğitmen veya kullanıcı adı yazabilirsin.
            {
                Console.WriteLine(kurs.Egitmen + " " + kurs.KursAdi);
            }

        }        
//classlar bir objedir ve sen kendi veri tipini yazıyormuşsun gibi düşün.Benim burada oluşturduğum tip "Kurs".
//prop yazıp çift tab yapınca clas altındaki şablon açılır direkt.
    class Kurs 
     {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int IzlenmeOranı { get; set; }
//ÇOK ÖNEMLİ NOT: Web sitesinde bulunan bir şablon ve içinde bir sürü içerik düşün.Bu içeriklerin hepsi birleşip
//nesneyi oluştururlar yani şablonu.Bu nesne içinde birbirindenden farklı tipte değişkenler tutulacağı için hepsi
//class komutu ile toplanır.Burada o şablon kurs objesi olsun.ve yine unutma sen "class" koutu ile Kurs'u 
//tanımladığın için yukarıda Kurs adı altında komut açıp içeriklerini belirttim.Kurs artık nesneleşti.

        }
    }
}
