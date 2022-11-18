// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
var toplamTestResult = ToplamUnitTest();

var customer = new Customer
{
    Id = 1, No = 1231, tc = 21312331
};
Console.WriteLine(customer.Id);

var customer1 = new Customer { Id = 2, tc = 21321412, No = 25 };

Console.WriteLine(customer1.Id);


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

class Customer
{
    public int Id { get; set; }
    public int tc { get; set; }
    public int No { get; set; }
}







