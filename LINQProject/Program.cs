using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category> 
            { 
                new Category{CategoryID=1 , CategoryName="Bilgisayar"},            
                new Category{CategoryID=2 , CategoryName="Televizyon"}            
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductID=1, CategoryID=1, ProductName="Acer Laptop", QuantityPerUnit="32 GB Ram", UnitPrice=7899, UnitsInStock=5},
                new Product{ProductID=2, CategoryID=1, ProductName="Huawei Laptop", QuantityPerUnit="16 GB Ram", UnitPrice=6799, UnitsInStock=8},
                new Product{ProductID=3, CategoryID=1, ProductName="Monster Laptop", QuantityPerUnit="8 GB Ram", UnitPrice=9990, UnitsInStock=2},
                new Product{ProductID=4, CategoryID=2, ProductName="LG LCD TV", QuantityPerUnit="Full HD", UnitPrice=5699, UnitsInStock=12},
                new Product{ProductID=5, CategoryID=2, ProductName="Samsung LCD TV", QuantityPerUnit="Full HD", UnitPrice=4490, UnitsInStock=1}
            };
            //foreach (var p in products)
            //{
            //    if (p.UnitPrice>= 5000)
            //    {
            //        Console.WriteLine(p.ProductName);
            //    }
            //}

            var GetOverHere = products.Where(p=> p.UnitPrice>6800 && p.CategoryID ==1).ToList(); //Bu şartları sağlayanları listeye dönüştürdüm.
            foreach (var product in GetOverHere)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("-------LING CODE TEST-------");

            var result = products.Any(p => p.ProductName == "Acer Laptop"); //any kodu bool değerindedir. Dolayısıyla sonuç true ya da false olur.
            Console.WriteLine(result); //result = true dönecek çünkü bu ürün elimizde var.

            Console.WriteLine("-------ANY CODE TEST SUCCESSFUL-------");

            var result1  = products.Find(p=> p.ProductID == 4); //Burada girilen ürünün detayını ekrana göstermek için ProductID ile gidilebilir.
            Console.WriteLine(result1.ProductName); //Burada ise ID 1 olan ürünün istediğin detayına ulaşabilirsin.

            Console.WriteLine("-------FİND CODE TEST SUCCESSFUL-------");

            var result3 = products.Where(p=> p.ProductName.Contains("top")).OrderByDescending(p=> p.UnitPrice);
            //Burada where ile adında "top" geçen ürünleri countains(içeriğinde demek) komutuyla çağırdık. Daha sonra arka planda orderbydescending ile de ürün fiyatlarına göre ucuzdan pahalıya doğru sıralamak istedik. Bunu ekrana yazdırmak için ise tüm ürünleri foreacle döndük ve içinde "top" geçenleri yukarıdaki komutla buldurup fiyatlarına göre de sıraladık ve yazdırdık. Eğer birim fiyatı aynı olan ürünleri de kendi aralarında sıralamak istiyorsak mesela isimlerine göre bu durumda da thanby(asc) veya thanbydescending kullanılır bu durumda kod devamı şu şekilde devam eder:
            //var result3 = products.Where(p=> p.ProductName.Contains("top")).OrderByDescending(p=> p.UnitPrice).ThanBy(p => p.ProductName);
            foreach (var product in result3)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("-------WHERE, CONTAİNS AND ORDERBY(asc-desc) CODE TEST SUCCESSFUL-------");
        }
    }

    class Product
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }

    class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
