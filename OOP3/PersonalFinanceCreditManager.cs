﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class PersonalFinanceCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hazırlandı.");
        }
    }
}
