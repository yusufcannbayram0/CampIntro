using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    public class SepetManager
    {
        //naming convention - isimlendirme kuralı
        //syntax - yazım şekilleri
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " ürünü sepete başarıyla eklendi.");
        }
        public void Delete(Product product)
        {
            Console.WriteLine(product.ProductName + " ürünü sepetten başarıyla silindi.");
        }
        public void Add2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine(urunAdi + " ürünü sepete başarıyla eklendi.");
        }
    }
}
