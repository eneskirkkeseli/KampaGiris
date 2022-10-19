using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class yemekSepeti

    {
        public void Hazır(yemekSepeti sepet) 
        {
            Console.WriteLine("HAZIRLANMAKTE OLAN YEMEĞİNİZ : "+sepet.adi+sepet.acıklama);
            Console.WriteLine("ÜRÜN TUTARI : "+sepet.fiyati+sepet.fiyatBirim);
        }


        public string adi { get; set; }
        public int fiyati { get; set; }
        public string acıklama { get; set; }
        public string fiyatBirim { get; set; }
    }

}
