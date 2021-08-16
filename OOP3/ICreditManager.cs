using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // interface leri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız
    // loglama -> kim ne zaman hangi operasyonu çağırdı -  sistemde olan hareketleri döktüğümüz bir dökümdür
    public interface ICreditManager
    {
        void Calculate();
    }
}
