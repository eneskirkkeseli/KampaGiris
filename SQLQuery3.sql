
--select
-- * burada tüm kolonların çağrılmasını sağlar. Özel olarak almak istediğin kolonları sorgulamak için isimlerini yazarsın.
select City, ContactName from Customers

-- burada tüm kolonlar arasındaki London şehirlerinin nasıl çekileceğini gördük.
-- where sorgusu böyle yapılır :
select * from Customers where City = 'London'

select * from Products where CategoryID = 1 or CategoryID = 3

select * from Products where CategoryID = 1 and UnitPrice >= 10

-- order by sırala demek. Burada tüm ürünler içinde birim fiyatlarını sırala dedik :
select * from Products order by UnitPrice desc --descending=azalan demek
-- Tüm tablodaki ürünler kolonundan CategoryID = 1 olan ürünleri UnitPriceları artan şekilde sırala(Order by) :
select * from Products where CategoryID = 1 order by UnitPrice asc --ascending=artan demek
-- Tablodaki satır sayılarının bulunması şu şekilde olur : (12)
select count(*) from Products where CategoryID = 2
-- Ürünler içindeki CategoryID i group by ile tekrar etmeyecek şekilde listeledik :
-- Ayrıca burada count ile de o Idlere ait satır sayılarını görebiliriz.
-- Group by aslında istediğin kısımları listeler bu mantığı unutma.
select CategoryID, count(*) from Products group by CategoryID
-- having burada kümülatif sorgu olan counta yazılır.
select CategoryID, count(*) from Products group by CategoryID having count(*)<10

select CategoryID, count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10
-- Belirli alanlardaki kolonları da aşağıda yıldız yerine girdiğimiz yerleri alırız.
-- Aşağıdaki code c# ta DTA olarak geçer ve açılımı Data Transformation Object olarak geçer.
-- Joinle tablolar birleştirilir.
-- buradaki on = durumundaki şartındaki anlamına gelir.
-- Products.CategoryID = Categories.CategoryID bunlar eşitse ya yana getir diyoruz burada.
-- iki tablo join edilecekse iki tablonun da ortak kolonları bulunur.
select Products.ProductID, Categories.CategoryName, Products.ProductName
from Products inner join Categories --hangi tablolar join edilecekse yaz
on Products.CategoryID = Categories.CategoryID -- hangi kolonları join edilecekse yaz.
where Products.UnitPrice>10
-- 2. örnekte kısaltma kullandık. Yanlarında kısatma aliasları girilir ve onlarla çağırılır.
select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
-- left şunu söyler solda olu sağda olmayanları da getir.
select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID
-- Buradaki null Customerslarda olup Orderslarda olmayan kullanıcıları getirmek için yazılır.
-- Left yerine Right yazılırsa da sağda olup solda olmayanları kapsar.
select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null --Burada da solda olup sağda olmayan CustomerID li kullanıcılar.

select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o on o.OrderID = od.OrderID -- bu şekilde join işlemi devam edebilir.