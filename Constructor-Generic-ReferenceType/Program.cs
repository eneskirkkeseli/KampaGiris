using System;
using System.Collections.Generic;

namespace Constructor_Generic_ReferenceType
{
    internal class Program
    {
        #region Constructor
        static void MainConstructor(string[] args)
        {
            //CONSTRUCTOR: (KURUCU METOTLAR)
            //Bir classı ilk kez çalıştırdığımız blocktur. Biz classı ise ilk defa new ile çalıştırırız. Ve biz bir sınıfı newlediğimizde çalışmasını istediğimiz codelar varsa constructor yapısını kullanır ve ekleriz.
            Customer customer = new Customer(25,"Enes","KIRKKESELİ","Erzurum"); //Parametre girilmesi gerekirse aşağıda olduğu gibi belirtilen parametreler girilmelidir. Bunun nedeni aşağıda bulunan constructorda Id, FirstName, LastName ve Cityi belirttiğimiz için otomatik olarak parantez içinde bu verilerin girmesini isteyecek.

            Customer customer1 = new Customer { City = "Erzurum", Id = 25, FirstName = "Enes", LastName = "KIRKKESELİ" }; //Burada belirttiğimiz durum alt alta yazılımın kısa halidir ve bu şekilde de yazılabilir.
            customer1.FirstName = "Enes";
            customer1.LastName = "KIRKKESELİ"; //Bu kullanımın kısaltılmış hali yukarıdaki gibidir.


            Customer customer2 = new Customer(); //Bu methodun çalışma nedeni ise aşağıda parametresiz bir constructor eklediğimiz için. Eğer eklenmeseydi parametresiz bir constructor özelliklerini belirttiğimiz kurucu, default const u ezeceği için bu bölüm kızacaktı ve çalışmayacaktı boş bir const atana kadar.


            Console.WriteLine(customer1.Id); //Artık aşağıda parametre tanımlandığı için const ta burayı ekrana yazdırabiliriz.
        }
        #endregion
        #region Generics
        static void MainGeneric(string[] args)
        {
            //GENERİCS: 
            //<> ifadesi generic yapılarda bulunur.List gibi.
            List<string> list = new List<string>();
            list.Add("Diyarbakır");
            Console.WriteLine(list.Count);
            
            Plakalar<string> Cities = new Plakalar<string>();
            Cities.Add("Erzurum");
            Cities.Add("Adana");
            Cities.Add("Bursa");
            Cities.Add("İstanbul");
            Cities.Add("Ankara");
            Console.WriteLine(Cities);
        }
        #endregion
    }
    #region ConstructorClass
    class Customer
    {
        public Customer(int id, string firstName, string lastName, string city) //void veya başka bir şey dönmüyor. Bu yapı Constructor olur. "ctor" + tab + tab ile oluşur. Normalde yukarıda tanımını yaptığımız customer classı bu constructor metodu olmasa da default constructor olarak arka planda çalışır. Biz burada sadece özel olarak çalışmasını isteyeceğimiz constructor metodunu ekledik. Bu block Customer classının newlenmediği sürece çalışmaz çünkü ona bağlıdır. Dolayısıyla newleyerek ilk classı tanımlarız. Class tanımlandığı için otomatik olarak da bu block çalışır. Ayrıca constructorlara parametreler ekleyebiliriz. Bu class parametrelerini aşağıda atamamızın nedeni Console.Writeline da özel olarak yazdırmak istediğimiz verileri çağırabilmek için.
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public Customer() //Parametresi olmayan costructor = default constructor denir. Burası kalkarsa yukarıdaki parametreler kızar.
        {

        }
        
        public int Id{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
    #endregion
    #region GenericClass
    class Plakalar<T> //Generic classtır. Burada T type tan gelir. İstediğimiz class veya tipi tanımlayabiliriz.
    {
        T[] _array; //Asıl dizimiz bu.
        T[] _tempArray; //Geçici bir dizi oluşturduk. Asıl dizi elemanlarını buraya eşitleyelim diye.
        
        public Plakalar() //Constructor Method
        {            
            _array = new T[0]; //Burada _array 0 elemanlı dedik.
        }
        
        // eski list {"34","25"} => yeni list {"34","25","16"}
        public void Add(T items) //Burada verdiğimiz T hangi tipi gönderirsek ona dönüşür. Onu da ekleyeceğin şeylerde ister. Void olduğundan git yap dedik direkt.
        {
            _tempArray = _array; //_arrayi _temparraye eşitledik
            _array = new T[_array.Length+1]; //burada ise eleman sayısı her eklendik. Ve diziyi tanımlayıp bir fazlası olsun dedik.
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i]; // Burada ise _array de tuttuğumuz tüm elemanları 2. oluşturduğumuz _tempArray e sabitledik
            }
            _array[_array.Length - 1] = items; //Artık ne gönderirse tam olarak yazacak. Dolayısıyla bu satırla eksik eleman veya fazla eleman sıkıntısı ortadan kalkacak.
        }
    }
    #endregion
}
