using System;

namespace DegerVeReferansTipler
{
    class Referance
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);

            //int, float, double, string, bool = değer tipi = steak te depolanır
            //class, array[dizi], interface = referans tipi = heap de depolanır.

            Person Person1 = new Person();
            Person1.Id = 1;
            Person1.FirstName = "Enes";
            Person1.LastName = "KIRKKESELİ";

            Customer customer = new Customer();
            customer.CreditCardNumber = "1234";

            Employee employee = new Employee();
            employee.EmployeeNumber = 5;

            Person Person2 = new Customer();
            customer.FirstName = "Ali";



            Console.WriteLine(((Customer)Person2).FirstName); //Mantığını tekrar sor ve neden çalışmadığına bak...



        }
    }
    class Person //Person classına Parent class diyelim. Altına da child classlar ekleyelim. Mantıken child classlar kalıtımı Parent classtan alacak. Dolayısıyla Parent classta hangi durumlar varsa aynıları child için de geçerli olacak. Parent class Person, ona bağlı olan Child classlar ise Employee ve Customer olacak. ÖNEMLİ NOT: Child classlarda yaptığımız değişiklikler personda görülemez. O classa özeldir sadece.
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
}
