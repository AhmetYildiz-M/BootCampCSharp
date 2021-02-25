Select * from Customers

Select CustomerID, CompanyName
from Customers;

Select ContactName, City from Customers;

Select * from Customers;

Select distinct Country from Customers; --("Distinct" farklı olan değerleri sıralama komutudur. Burada müşterilere ait farklı ülkeler sıralanmıştır.)

Select Country from Customers; --(Distinct kullanılmadan sıralandığında aynı ülkeler tekrar tekrar sıralanır. )

Select Count(Distinct Country) From Customers;

Select Count(Distinct Country) DistinctCountries from Customers --(MS Access'te yazarken SELECT Count(*) AS DistinctCountries  FROM (SELECT DISTINCT Country FROM Customers); şeklinde yazılır.)

Select * from Customers where CustomerID= 'ALFKI'

Select ProductName, ProductID, UnitPrice
from Products where UnitPrice = 10;

Select * from Customers where City = 'Berlin' and PostalCode = 12209;

Select * from Customers where City = 'Berlin' or City = 'London';

/*Operator        Description
    =            Equal
           Greater than
    <            Less than
    >=            Greater than or equal
    <=            Less than or equal
    <>            Not equal. Note: In some versions of SQL this operator may be written as !=
    BETWEEN        Between a certain range
    LIKE        Search for a pattern
    IN            To specify multiple possible values for a column */

Select * from Products where UnitPrice = 18;

Select * from Products where UnitPrice > 30;

Select * from Products where UnitPrice > 30;

Select * from Products where UnitPrice >= 30;

Select * from Products where UnitPrice <= 30;

Select * from Products where UnitPrice <> 30;

Select * from Products where UnitPrice between 50 and 60;

Select * from Customers where City like 's%'; --(S ile başlayan şehir isimlerini getirmektedir. 
--Stun içerisinde spesifik bir şeyi aramak için kullanılır.)

Select * from Customers where City in ('Paris','London'); --(Stun içerisinde birden çok veriyi aramak için kullanılır.)

Select UnitPrice, ProductId
from Products
where ProductID >= 3 and UnitPrice >= 10;

Select UnitPrice, ProductId
from Products
where ProductID >= 3 or UnitPrice >= 10;

Select ContactName, City
from Customers
where not City = 'London' 

Select * from Customers
where  Country = 'Germany' and (City = 'Berlin' or City = 'München');

Select * from Customers
where not Country = 'Germany' and not Country = 'USA'

Select * from Customers
order by Country;

Select * from [Order Details]
order by UnitPrice asc

Select * from Customers
Order by Country Asc, ContactName Desc;

Select * from Customers
order by City desc;

Insert into Customers (Customer, Address, City, PostalCode) --(Tablo icersindeki bir satirda deigisim yapmak icin kullanilir. 
--Tum satilara ya da satirda yer alan bir kac bilgiyide guncelleyebiliriz.)
Values ('Cardinal', 'Tom B. Erichsen', 'Skagen 21', '4006');

Select ContactName, City, Region --(Null degeri bulmak icin = < ya da <> gibi operatorler kullanilmaz. is null ya da is not null kullanilir)
from Customers
where Region is null;

Select ContactName, Region, City
from Customers
where Region is not null;


