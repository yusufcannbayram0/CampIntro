using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    public class ResidenceCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
        }
    }
}
