using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo
{
    public class Product
    {
        public int ProductID { get; set; } //Primary Key
        public int CategoryID { get; set; } //Foreign Key
        public string ProductName { get; set; }
        public string QuantityPerUnit{ get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStoct { get; set; }
    }
}
