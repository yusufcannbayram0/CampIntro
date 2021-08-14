using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Elma";
            product1.Price = 15;
            product1.Description = "Amasya elması";

            Product product2 = new Product();
            product2.Id = 2;
            product2.ProductName = "Karpuz";
            product2.Price = 80;
            product2.Description = "Diyarbakır karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductName + " : " + product.Price);
            }

            Console.WriteLine("----------------------- Metotlar --------------------------------");

            //instance - örnek ( class örneği )
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);


            sepetManager.Add2("Armut", "Yeşil Armut", 12);
        }
    }
}

//Dont repeat yourself - DRY - Clean Code - Best Practice(Doğru uygulama teknikleri)
