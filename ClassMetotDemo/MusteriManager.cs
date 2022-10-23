using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Giris(MusteriGiris musteriManager)
        {
            Console.WriteLine("Başarıyla Sisteme Giriş Yaptınız Sayın " + musteriManager.Adi1+" "+musteriManager.Soyadi1);
        }

        public void Listele(MusteriKayit musteriManager) 
        {
            Console.WriteLine(musteriManager.musteriAdi+" "+musteriManager.musteriSoyadi);
        }


    }

}
