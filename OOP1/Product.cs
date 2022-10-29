using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    internal class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; } 
        public int UnitsInStock { get; set; }

        //CRUD Operasyonu bir veriyi ekleme kaldırma listeleme yükleme gibi işlemleri kapsar ve biz bunu kodlarda classlarla yaparız.
        //CRUD= Create(oluştur) Read(oku) Update(yükle) Delete(kaldır)

    }
}
