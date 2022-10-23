using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            MusteriKayit olustur = new MusteriKayit();
            olustur.musteriAdi = "Şevket Enes";
            olustur.musteriSoyadi = "KIRKKESELİ";
            olustur.telefonNo = 05412365489;
            olustur.MusteriDogumGun = 18;
            olustur.MusteriDogumAy = 09;
            olustur.MusteriDogumYıl = 1995;
            olustur.ePosta = "enes@gmail.com";
            olustur.SMS = 2462;

            MusteriKayit olustur1 = new MusteriKayit();
            olustur1.musteriAdi = "Ayşe Esin";
            olustur1.musteriSoyadi = "KIRKKESELİ";
            olustur1.telefonNo = 05412369874;
            olustur1.MusteriDogumGun = 26;
            olustur1.MusteriDogumAy = 09;
            olustur1.MusteriDogumYıl = 1999;
            olustur1.ePosta = "esin@gmail.com";
            olustur1.SMS = 1357;

            MusteriKayit olustur2 = new MusteriKayit();
            olustur2.musteriAdi = "Sibel";
            olustur2.musteriSoyadi = "KIRKKESELİ";
            olustur2.telefonNo = 05451279653;
            olustur2.MusteriDogumGun = 04;
            olustur2.MusteriDogumAy = 12;
            olustur2.MusteriDogumYıl = 1976;
            olustur2.ePosta = "sibel@gmail.com";
            olustur2.SMS = 1598;

            MusteriKayit olustur3 = new MusteriKayit();
            olustur3.musteriAdi = "Emre";
            olustur3.musteriSoyadi = "ŞEHİTOĞLU";
            olustur3.telefonNo = 05412381354;
            olustur3.MusteriDogumGun = 12;
            olustur3.MusteriDogumAy = 04;
            olustur3.MusteriDogumYıl = 1995;
            olustur3.ePosta = "emre@gmail.com";
            olustur3.SMS = 1453;

            MusteriKayit[] kayit = new MusteriKayit[] {olustur,olustur1,olustur2,olustur3};

            foreach (MusteriKayit kayits in kayit)
            {
                Console.WriteLine("Lütfen Adınızı Girin: "+kayits.musteriAdi);
                Console.WriteLine("Lütfen Soyadınızı Girin: "+kayits.musteriSoyadi);
                Console.WriteLine("Lütfen Doğum Tarihinizi Girin: "+kayits.MusteriDogumGun+"/"+kayits.MusteriDogumAy+"/"+kayits.MusteriDogumYıl);
                Console.WriteLine("Lütfen Telefon Numaranızı Girin: "+kayits.telefonNo);
                Console.WriteLine("Lütfen ePosta Adresinizi Girin: "+kayits.ePosta);
                Console.WriteLine("Telefonunuza Gelen SMS Kodunu İlgili Alana Giriniz: "+kayits.SMS);
                Console.WriteLine("Kaydınız Başarıyla Gerçekleştirildi Sayın " + kayits.musteriAdi+" "+kayits.musteriSoyadi);
                Console.WriteLine("-------KAYIT SONU--------");
            }


            MusteriGiris giris = new MusteriGiris();
            giris.ID = "Uzun";
            giris.Password = 1234;
            giris.Adi1 = "Şevket Enes";
            giris.Soyadi1 = "KIRKKESELİ";

            MusteriGiris giris1 = new MusteriGiris();
            giris1.ID = "Sinirli";
            giris1.Password = 2468;
            giris1.Adi1 = "Sibel";
            giris1.Soyadi1 = "KIRKKESELİ";

            MusteriGiris giris2 = new MusteriGiris();
            giris2.ID = "Polis";
            giris2.Password = 1357;
            giris2.Adi1 = "Emre";
            giris2.Adi1 = "ŞEHİTOĞLU";
            
            MusteriGiris giris3 = new MusteriGiris();
            giris3.ID = "Öğretmen";
            giris3.Password = 9876;
            giris3.Adi1 = "Ayşe Esin";
            giris3.Soyadi1 = "KIRKKESELİ";


            MusteriGiris[] musterilerGiris = new MusteriGiris[] { giris, giris1, giris2, giris3 };

            foreach (MusteriGiris dongu1 in musterilerGiris)
            {
                Console.WriteLine("Lütfen ID Girin: "+dongu1.ID);
                Console.WriteLine("Lütfen Password Girin: "+dongu1.Password);
                MusteriManager getir = new MusteriManager();
                getir.Giris(dongu1);
                Console.WriteLine("-----BİTTİ-----");
            }


            Musteri profil = new Musteri();
            profil.Adi = "Sibel";
            profil.Soyadi = "KIRKKESELİ";
            profil.ulkeKodu = "TR";
            profil.IBAN = 123456999;
            profil.KartNo1 = 1166;
            profil.KartNo2 = 331255;
            profil.KartNo3 = 8742;
            profil.SonBasarılıGirisGun = 27;
            profil.SonBasarılıGirisAy = 09;
            profil.SonBasarılıGirisYil = 2022;
            profil.BakiyeBilgisi = 50374.51;
            profil.paraBirimi = "TL";

            Musteri profil1 = new Musteri();
            profil1.Adi = "Şevket Enes";
            profil1.Soyadi = "KIRKKESELİ";
            profil1.ulkeKodu = "TR";
            profil1.IBAN = 123456789;
            profil1.KartNo1 = 1122;
            profil1.KartNo2 = 334455;
            profil1.KartNo3 = 8899;
            profil1.SonBasarılıGirisGun = 18;
            profil1.SonBasarılıGirisAy = 10;
            profil1.SonBasarılıGirisYil = 2022;
            profil1.BakiyeBilgisi = 1865.67;
            profil1.paraBirimi = "TL";

            Musteri profil2 = new Musteri();
            profil2.Adi = "Ayşe Esin";
            profil2.Soyadi = "KIRKKESELİ";
            profil2.ulkeKodu = "TR";
            profil2.IBAN = 123456789;
            profil2.KartNo1 = 1122;
            profil2.KartNo2 = 334455;
            profil2.KartNo3 = 8899;
            profil2.SonBasarılıGirisGun = 18;
            profil2.SonBasarılıGirisAy = 09;
            profil2.SonBasarılıGirisYil = 2022;
            profil2.BakiyeBilgisi = 1865.67;
            profil2.paraBirimi = "TL";

            Musteri profil3 = new Musteri();
            profil3.Adi = "Emre";
            profil3.Soyadi = "ŞEHİTOĞLU";
            profil3.ulkeKodu = "TR";
            profil3.IBAN = 423678789;
            profil3.KartNo1 = 1542;
            profil3.KartNo2 = 378459;
            profil3.KartNo3 = 7635;
            profil3.SonBasarılıGirisGun = 20;
            profil3.SonBasarılıGirisAy = 10;
            profil3.SonBasarılıGirisYil = 2022;
            profil3.BakiyeBilgisi = 12500.86;
            profil3.paraBirimi = "TL";

            Musteri[] musteriProfil = new Musteri[] { profil, profil1, profil2, profil3 };

            foreach (Musteri profilim in  musteriProfil)
            {
                Console.WriteLine("Sn. "+profilim.Adi+" "+profilim.Soyadi);
                Console.WriteLine("Son Başarılı Giriş: "+profilim.SonBasarılıGirisGun + "/" + profilim.SonBasarılıGirisAy + "/" + profilim.SonBasarılıGirisYil);
                Console.WriteLine("IBAN: "+profilim.ulkeKodu+"-"+profilim.IBAN);
                Console.WriteLine("Kart Numarası: "+profilim.KartNo1+"-"+profilim.KartNo2+"-"+profilim.KartNo3);
                Console.WriteLine("Mevcut Paranız: "+profilim.BakiyeBilgisi+profilim.paraBirimi);
                Console.WriteLine("-------PROFİL OLUŞTURULDU-------");
            }

        }
    }
}
