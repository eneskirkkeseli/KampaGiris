using System;

namespace odevClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun ıtem1 = new Urun();
            ıtem1.ıtemAdı = "Hero's Valor";
            ıtem1.ıtemFıyatı = 3500;
            ıtem1.ıtemAdetı = 10;
            ıtem1.ıtemSeviyesi = 7;
            ıtem1.paraBirimi = "TL";
            ıtem1.ıtemİsareti = "+";

            Urun ıtem2 = new Urun();
            ıtem2.ıtemAdı = "Raptor";
            ıtem2.ıtemFıyatı = 1599;
            ıtem2.ıtemAdetı = 47;
            ıtem2.ıtemSeviyesi = 9;
            ıtem2.paraBirimi = "TL";
            ıtem2.ıtemİsareti = "+";

            Urun ıtem3 = new Urun();
            ıtem3.ıtemAdı = "İron Necklace";
            ıtem3.ıtemFıyatı = 2500;
            ıtem3.ıtemAdetı = 46;
            ıtem3.ıtemSeviyesi = 3;
            ıtem3.paraBirimi = "TL";
            ıtem3.ıtemİsareti = "+";

            Urun[] uruns = new Urun[] { ıtem1, ıtem2, ıtem3 };

            foreach (var Urun in uruns)
            {
                Console.WriteLine(Urun.ıtemAdı);
                Console.WriteLine(Urun.ıtemFıyatı + " " + Urun.paraBirimi);
                Console.WriteLine(Urun.ıtemİsareti + Urun.ıtemSeviyesi);
                Console.WriteLine(Urun.ıtemAdetı);
            }


            for (int i =0; i <=0; i++)
            {
                Console.WriteLine(ıtem1.ıtemAdı);
                Console.WriteLine(ıtem1.ıtemFıyatı + " " + ıtem1.paraBirimi);
                Console.WriteLine(ıtem1.ıtemİsareti + ıtem1.ıtemSeviyesi);
                Console.WriteLine(ıtem1.ıtemAdetı);
            }
            Console.WriteLine("ıtem1bitti");


        }
    }
              
}
