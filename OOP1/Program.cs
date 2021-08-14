using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 1;
            product1.ProductName = "Bilgisayar";
            product1.UnitPrice = 5000;
            product1.UnitsInStock = 8;

            Product product2 = new Product() {Id = 2,CategoryId=2,ProductName="Masa",UnitPrice=500,UnitsInStock=4 };


            //PascalCase   //camelCase
            //case sensitive - büyük/küçük harf duyarlı
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
