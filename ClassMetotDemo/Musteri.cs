using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class Musteri
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int SonBasarılıGirisGun { get; set; }
        public int SonBasarılıGirisAy { get; set; }
        public int SonBasarılıGirisYil { get; set; }
        public double BakiyeBilgisi { get; set; }
        public double IBAN { get; set; }
        public int KartNo1 { get; set; }
        public int KartNo2 { get; set; }
        public int KartNo3 { get; set; }
        public string ulkeKodu { get; set; }
        public string paraBirimi { get; set; }
    }
}

class MusteriGiris
{
    public string ID { get; set; }
    public int Password { get; set; }
    public string Adi1 { get; set; }
    public string Soyadi1 { get; set; }

}


class MusteriKayit
{
    public string musteriAdi { get; set; }
    public string musteriSoyadi { get; set; }
    public int MusteriDogumGun { get; set; }
    public int MusteriDogumAy { get; set; }
    public int MusteriDogumYıl { get; set; }
    public double telefonNo { get; set; }
    public string ePosta { get; set; }
    public int SMS { get; set; }
}