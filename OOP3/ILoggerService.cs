using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal interface ILoggerService //Bundan sonra interfacelere service adıyla açıcaz. Kısaca loglama işlemi bir sistemin, bir cihazın ve sistem üzerindeki kullanıcıların hareketlerini kaydeden yapıdır. Saat kaçta nasıl kaç kere giriş yaptığını gösterir.
    {
        void Log();
    }
}
