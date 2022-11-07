using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class BasvuruManager
    {
        public void BasvuruYap(ICreditManager creditManager, List<ILoggerService> loggerService) //Anlayacağın üzere bu interface yi yazmamızın nedeni tüm kredi türlerinin buna bağlı olarak kalması ve hesaplanmasındandır. Dolayısıyla hangi kredi gelirse gelsin creditmanager interfacesi içindeki ilgili alana gidip işlemlerini yaptıracaktır. Bu ayrı ayrı hesaplanmasının önüne geçer ve rahatlatır. Burada birden fazla log olduğu için loggerservice yi list yaptık her gelen logu burada döndürdük.
        {
            creditManager.Calculate();
            foreach (var logger in loggerService)
            {
                logger.Log();
            }
        }

        public void KrediOnbilgilendirmesiYap(List<ICreditManager> krediler) //Şunu diyoruz: Bana türü ICreditManager olan listeleri getir.
        {
            foreach (var credit in krediler) //burada döndürmemizin nedeni müşteriye tüm kredilerin hesaplanması için seçenekleri göndermek.
            {
                credit.Calculate(); //burada da Calculate e gönderiyoruz hesaplaması için.
            }
        }
    }
}
