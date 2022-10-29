
using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            var product2 = new Product {Id=2,UnitsInStock=5,ProductName="Kalem",CategoryId=5,UnitPrice=35 }; //Farklı yazım şekliyle aynı tanımladık.

            
            var productManager1 = new ProductManager();
            productManager1.Add(product1);
            Console.WriteLine(product1.ProductName);


        }

    }
}
