using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class CarLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hazırlandı.");
        }
    }
}
