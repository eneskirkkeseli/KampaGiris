using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ICreditManager //interface dediğimiz durum eğer birisi bu interface yi kullanırsa belirlenen methodları kullanmak zorunda. Başlığın başına I harfi koymamızın nedeni INTERFACE olduğunu göstermek için. Mantık olarak da Base classta bulunan ınterface ye ait olan methodlara childlar da bağlı olduğu için kullanmak zorundalar. Dolayısıyla kaç tane method varsa onlarda da kullanılır ve sonuca ulaşılır. Burada bulunan void Calculate methodu otomatik olarak childlarda da bulunmalıdır ki çalışabilsinler. Ve interfaceler seni gereksiz codelardan kaçınmanı sağlar. Birbirinin alternatifi olan ama code içerikleri farklı olan durumlar için interface kullanırız. Bakınca kredilerin hepsinde hesaplamalar var ancak içerikleri türlere göre değişkenlik gösteriyor. Hesaplaması olsun içerikleri olsun.
    {
        void Calculate();
    }
}
