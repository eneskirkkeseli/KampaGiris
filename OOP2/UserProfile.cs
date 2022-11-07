using System;

namespace OOP2
{
    internal class UserProfile
    {
        static void Main(string[] args)
        {
            var customer1 = new IndıvidualCustomer { Id = 1, FirstName = "Enes", LastName = "KIRKKESELİ", TcNo = "12345678", CustomerNumber = "2025" };
            var customer2 = new CoorporateCustomer { Id = 2, CompanyName = "Speed İnşaat Ltd.", CustomerNumber = "2026", TaxNumber = "246810" };
            Customer customer3 = new IndıvidualCustomer { Id = 3, FirstName = "Fatih", LastName = "KÜÇÜK", TcNo = "13245679", CustomerNumber = "2027" };

            var customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

        }
    }
}
