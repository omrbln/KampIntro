using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //interface leri birbirinin alternatiflari olan ama kod içerikleri farklı olan durumlar için kullanırız
    //Bu örnekte kredi türlerinin hepsinde hesaplama, geri ödem planı vardır.
    //Ama kodları farklıdır. Faiz oranları, dosyamasrafı, farklı kurallar, kredinin türlerine göre bu hesaplama işeri değişkenlik gösteirir.
    interface ILoanManager
    {
        void Calculate();
        void DoSomething();
    }
}
