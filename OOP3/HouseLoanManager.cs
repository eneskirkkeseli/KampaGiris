using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class HouseLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Ev kredisi ödeme planı hazırlandı.");
        }
    }
}
