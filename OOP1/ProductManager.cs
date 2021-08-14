using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    public class ProductManager // Manager - Operasyonların yazıldığı yer
    {
        public void Add(Product product)
        {
            Console.WriteLine("Ürün eklendi : " + product.ProductName);
        }
        public void Delete(Product product)
        {
            Console.WriteLine("Ürün silindi : " + product.ProductName);
        }
        public void Update(Product product)
        {
            Console.WriteLine("Ürün güncellendi : " + product.ProductName);
        }
    }
}
