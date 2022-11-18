using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal interface ILoggerService //Bundan sonra interfacelere service adıyla açıcaz. Kısaca loglama işlemi bir sistemin, bir cihazın ve sistem üzerindeki kullanıcıların hareketlerini kaydeden yapıdır. Saat kaçta nasıl kaç kere giriş yaptığını gösterir. Unutmuyoruz interfaceler soyut ve özellikleri altındakilerine aktarılır. Classlar ise somut nesnelerdir.
    {
        void Log();
    }
}
