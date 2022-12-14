using System.Collections.Generic;

namespace OOP3
{
    internal class Credits
    {
        private static void Main(string[] args)
        {
            var personalManager = new PersonalFinanceCreditManager();

            ICreditManager carManager = new CarLoanManager(); //interfaceler de classın referans numarasını tutabilir.

            HouseLoanManager houseManager = new HouseLoanManager();

            List<ICreditManager> credits = new List<ICreditManager>() { personalManager, houseManager, carManager };

            ILoggerService databaseLoggerService = new DataBaseLoggerService();


            var numbers = new List<int> { 1, 2, 3, 4 };

            var loggers = new List<ILoggerService> { new DataBaseLoggerService(), new FileLoggerService() }; //bu şekilde de list alarak yapılabilir.

            BasvuruManager basvuruManager = new BasvuruManager();

            basvuruManager.BasvuruYap(personalManager, loggers); //hiç yukarıdaki satır gibi newlemeden içeride de tanımlayabiliriz bu şekilde. Log u kaydedildi gibi düşün.

            //basvuruManager.BasvuruYap(personalManager); //artık bu kısma hangi krediyi girersen gir hesabı otomatik yapacak. Bu bilgi çok önemli sınavlarda karşına çıkacak iş için. Aile ağacı gibi düşün aklında tabloyu oluşturabilirsen biter bu iş.
        }
    }
}