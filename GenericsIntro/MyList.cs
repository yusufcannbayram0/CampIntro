using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    public class MyList<T>
    {
        T[] items;
        //constructor - kısa yoldan açmak için ctor yazıp 2 kere tab'a basmamız yeterli
        public MyList() // class'ı newlediğimizde ilk olarak constructor çalışır
        {
            items = new T[0]; // başlangıçta 0 elemanlı bir array oluştu
        }
        public void Add(T item)
        {
            T[] tempArray = items; // items'ın referansı geçici referansa aktarıldı. Çünkü alt satırda newlendiği için referans numarası değişir ve elemanlar gider
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
        public int Length
        {
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return items; }
        }
    }
}
