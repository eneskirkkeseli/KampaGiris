using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    internal class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+ "eklendi.");
        }

        public void Update(Product product) //methodlarda kullanılan void git getir,ekle,sil gibi emir işlemlerini yaptırır.İstenilen belirli bilgileri yazdırırız bu sayede.Ancak bu komutta tekrardan dönüş alamayız başka sayfada.Return ile yaptığımız int,string gibi tipli metodlarda ise hangi sayfada olursa olsun çağırdığımız işlemleri tekrardan yaptırabilir ve çalıştırırız.Bu voidle mümkün değil çünkü ilgili alan ve oluşturduğun sınırlar içinde tek seferde yapar ve çıkar.

        {
            Console.WriteLine(product.ProductName+ "güncellendi.");
        }


    }
}
