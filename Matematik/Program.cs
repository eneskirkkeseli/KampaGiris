using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            
            yemekSepeti Kebap = new yemekSepeti();
            Kebap.adi = "Lahmacun";
            Kebap.acıklama = "Ezme, Yeşillik ile";
            Kebap.fiyati = 20;
            Kebap.fiyatBirim = "TL";

            yemekSepeti Kebap1 = new yemekSepeti();
            Kebap1.adi = "Antep Lahmacun";
            Kebap1.acıklama = "Ezme, Yeşillik ile";
            Kebap1.fiyati = 28;
            Kebap1.fiyatBirim = "TL";

            yemekSepeti Kebap2 = new yemekSepeti();
            Kebap2.adi = "Karışık Kebap";
            Kebap2.fiyati = 130;
            Kebap2.fiyatBirim = "TL";

            yemekSepeti[] KebapciYusuf = new yemekSepeti[] {Kebap,Kebap1,Kebap2 };

            foreach (yemekSepeti uruns in KebapciYusuf)
            {
                Console.WriteLine(uruns.adi+" "+ uruns.acıklama);
                Console.WriteLine(uruns.fiyati+" "+ uruns.fiyatBirim);
                Console.WriteLine("---------FİNİSH---------");
            }

            Console.WriteLine("--------SAYFA BİTTİ---------");
            yemekSepeti sepets = new yemekSepeti();
            sepets.Hazır(Kebap);
            sepets.Hazır(Kebap1);
            sepets.Hazır(Kebap2);

        }
    }
}
