using System;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] aylar = new string[] {"ocak","şubat","mart" };  -Tipik bir array örneği.
            //Console.WriteLine(aylar[0]);
            //Console.WriteLine(aylar[1]);
            //Console.WriteLine(aylar[2]);
            
            //İş hayatında genellikle array kullanılmaz.Bunun nedeni biz DB i kaynaktan aldığımız için ekleme gibi durumlarında arrayin kullanışsız olmasıdır.Bunun yerine list kullanılır.
            
            //Burada biz ekleme fazladan bir ay tanımlaması yapamıyoruz ancak aylar = new string[5] deriz.Bu da eleman sayısını arttırsa da eski kaynaktaki veriyi işlevsiz hale getirir.

            List<string> isimler2 = new List<string> { "ocak", "şubat", "mart" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("mayıs");  //ekleyeceğim ürün veya obje veya nesneyi direkt add ile ekledim list'e ve döndürdüğümüz zaman liste kendini otomatik oalrak arttırdı ve ekledi.Bu sayede biz istediğimiz kadar eleman ekleyebiliriz list komutuna add ile.Burada sadece ekledik list'e.Ancak görebilmek için cw ile yazdırmak gerek. 
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[2]);
        }
    }
}
