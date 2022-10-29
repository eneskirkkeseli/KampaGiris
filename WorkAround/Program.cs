// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
var toplamTestResult = ToplamUnitTest();


int Toplama(int a, int b)
{
    var toplam = a + b;
    return toplam;
}
bool ToplamUnitTest()
{
    var toplamSonuc = Toplama(1, 2);
    
    if (toplamSonuc == 3)
    {
        Console.WriteLine("Toplama testi başarılı.");
        return true;
    }
    else
    {
        Console.WriteLine("Toplama testi başarısız.");
        return false;
    }
}







