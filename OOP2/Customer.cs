using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    public class Customer
    // eğer bir nesnede bir değeri kullanmak zorunda gibi görünmüyorsa, o alan o nesneye ait değilmiş gibi duruyorsa  demekki soyutlama hatası vardır
    {
        public int Id { get; set; }
        public string CustomerNo { get; set; }
    }
}
