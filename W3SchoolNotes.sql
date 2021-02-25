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

Select COUNT(ProductID) AS CountOFProductID --(Bu komut ile verilen stun ya da tablo içerisindeki toplam sayı verilir.)
From Products

Select AVG(UnitPrice) AS AverageOfPrice
From Products

Select SUM(Quantity) AS SumOfQuantity
From [Order Details]

Select * from Customers
where ContactName LIKE 'Ahmet%' --(LIKE operatörü ile tablo içerisinde herhangi bir satır ya da stunda bir başta, sonda, ortada bir harf ya da bir kelime aratabiliriz. Bunun için iki özel işaret kullanılır _ ve % işareti
--bu işaretler aranılan içeriğin yerini belirlemede kullanılır.)

Select * from Customers
Where ContactName LIKE '_r%'	

Select * from Customers
where ContactName NOT LIKE 'Juan' --(NOt LIKE opratörü ise tam tersidir. Belirlenen yer de olmayanı bulur.)

Select * from Customers 
where ContactName LIKE 'a%o'

--Wildcard Characters in MS Access

/*Symbol	Description													Example
	*		Represents zero or more characters							bl* finds bl, black, blue, and blob
	?		Represents a single character								h?t finds hot, hat, and hit
	[]		Represents any single character within the brackets			h[oa]t finds hot and hat, but not hit
	!		Represents any character not in the brackets				h[!oa]t finds hit, but not hot and hat
	-		Represents a range of characters							c[a-b]t finds cat and cbt
	#	R	epresents any single numeric character						2#5 finds 205, 215, 225, 235, 245, 255, 265, 275, 285, and 295 */

--Wildcard Characters in SQL Server

/*Symbol	Description													Example
	%		Represents zero or more characters							bl% finds bl, black, blue, and blob
	_		Represents a single character								h_t finds hot, hat, and hit
	[]		Represents any single character within the brackets			h[oa]t finds hot and hat, but not hit
	^		Represents any character not in the brackets				h[^oa]t finds hit, but not hot and hat
	-		Represents a range of characters							c[a-b]t finds cat and cbt */

	/*LIKE Operator								Description
	WHERE CustomerName LIKE 'a%'				Finds any values that starts with "a"
	WHERE CustomerName LIKE '%a'				Finds any values that ends with "a"
	WHERE CustomerName LIKE '%or%'				Finds any values that have "or" in any position
	WHERE CustomerName LIKE '_r%'				Finds any values that have "r" in the second position
	WHERE CustomerName LIKE 'a_%_%'				Finds any values that starts with "a" and are at least 3 characters in length
	WHERE ContactName LIKE 'a%o'				Finds any values that starts with "a" and ends with "o" */

SELECT * FROM Customers
WHERE City LIKE 'ber%';

SELECT * FROM Customers
WHERE City LIKE '%es%';

SELECT * FROM Customers
WHERE City LIKE '_ondon';

SELECT * FROM Customers
WHERE City LIKE 'L_n_on';

SELECT * FROM Customers   --(b, s ve p ile başlayan tüm şehirleri seçer)
WHERE City LIKE '[bsp]%';


SELECT * FROM Customers   --(a ve c arasında yer alan tüm şehirleri seçer)
WHERE City LIKE '[a-c]%';

SELECT * FROM Customers
WHERE City NOT LIKE '[bsp]%';

Select * from Customers 
where Country IN ('Germany', 'France', 'UK');

SELECT * FROM Customers
WHERE Country NOT IN ('Germany', 'France', 'UK');

SELECT * FROM Customers
WHERE Country IN (SELECT Country FROM Suppliers);

SELECT * FROM Products
WHERE UnitPrice BETWEEN 10 AND 20;

SELECT * FROM Products
WHERE UnitPrice NOT BETWEEN 10 AND 20;

SELECT * FROM Products
WHERE UnitPrice BETWEEN 10 AND 20
AND CategoryID NOT IN (1,2,3);

SELECT * FROM Products
WHERE ProductName BETWEEN 'Carnarvon Tigers' AND 'Mozzarella di Giovanni'
ORDER BY ProductName;

SELECT * FROM Products
WHERE ProductName BETWEEN 'Carnarvon Tigers' AND 'Gorgonzola Telino'
ORDER BY ProductName;

SELECT * FROM Products
WHERE ProductName NOT BETWEEN 'Carnarvon Tigers' AND 'Mozzarella di Giovanni'
ORDER BY ProductName;

SELECT * FROM Orders
WHERE OrderDate BETWEEN '1996-07-01' AND '1996-07-31';

SELECT CustomerID AS ID, ContactName AS Customer
FROM Customers;

SELECT ContactName AS Customer, ContactName AS [Contact Person]
FROM Customers;

SELECT ContactName, Address + ', ' + PostalCode + ' ' + City + ', ' + Country AS Address
FROM Customers;

SELECT ContactName, CONCAT(Address,', ',PostalCode,', ',City,', ',Country) AS Address
FROM Customers;

SELECT o.OrderID, o.OrderDate, c.ContactName
FROM Customers AS c, Orders AS o
WHERE c.ContactName='Around the Horn' AND c.CustomerID=o.CustomerID;

SELECT Orders.OrderID, Orders.OrderDate, Customers.ContactName
FROM Customers, Orders
WHERE Customers.ContactName='Around the Horn' AND Customers.CustomerID=Orders.CustomerID;

Select * from Customers
order by CustomerID asc

SELECT Orders.OrderID, Customers.ContactName, Orders.OrderDate
FROM Orders
INNER JOIN Customers ON Orders.CustomerID=Customers.CustomerID;

SELECT Orders.OrderID, Customers.CompanyName
From Orders
INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID

SELECT Orders.OrderID, Customers.ContactName
FROM Orders
INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID

SELECT DISTINCT Customers.ContactName, Orders.OrderID
FROM Customers
LEFT JOIN Orders ON Customers.CustomerID = Orders.CustomerID
ORDER BY Customers.ContactName;

SELECT Orders.OrderID, Employees.LastName, Employees.FirstName
FROM Orders
RIGHT JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID
ORDER BY Orders.OrderID;

SELECT Customers.ContactName, Orders.OrderID
FROM Customers
FULL OUTER JOIN Orders ON Customers.CustomerID=Orders.CustomerID
ORDER BY Customers.ContactName;

SELECT A.ContactName AS CustomerName1, B.ContactName AS CustomerName2, A.City
FROM Customers A, Customers B
WHERE A.CustomerID <> B.CustomerID
AND A.City = B.City
ORDER BY A.City;

SELECT City, Country FROM Customers
WHERE Country='Germany'
UNION
SELECT City, Country FROM Suppliers
WHERE Country='Germany'
ORDER BY City;

SELECT City FROM Customers
UNION ALL
SELECT City FROM Suppliers
ORDER BY City;

SELECT COUNT(CustomerID), Country
FROM Customers
GROUP BY Country

SELECT COUNT(CustomerID), Country
FROM Customers
GROUP BY Country
ORDER BY COUNT(CustomerID) DESC;

SELECT Customers.ContactName, COUNT(Orders.OrderID) AS NumberOfOrders FROM Orders
LEFT JOIN Customers ON Orders.CustomerID = Customers.CustomerID
GROUP BY ContactName;

SELECT Country, COUNT(CustomerID) AS CountOfCustomerID 
FROM Customers
GROUP BY Country
HAVING COUNT(CustomerID) > 5;

SELECT Country, COUNT(CustomerID) AS CountOfCustomerID
FROM Customers
GROUP BY Country
HAVING COUNT(CustomerID) > 5
ORDER BY COUNT(CustomerID) DESC;

SELECT Employees.LastName, COUNT(Orders.OrderID) AS NumberOfOrders
FROM (Orders
INNER JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID)
GROUP BY LastName
HAVING COUNT(Orders.OrderID) > 10;

SELECT Employees.LastName, COUNT(Orders.OrderID) AS NumberOfOrders
FROM Orders
INNER JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID
WHERE LastName = 'Davolio' OR LastName = 'Fuller'
GROUP BY LastName
HAVING COUNT(Orders.OrderID) > 25;

SELECT CompanyName
FROM Suppliers
WHERE EXISTS (SELECT ProductName FROM Products WHERE Products.SupplierID = Suppliers.supplierID AND UnitPrice < 20);

SELECT CompanyName
FROM Suppliers
WHERE EXISTS (SELECT ProductName FROM Products WHERE Products.SupplierID = Suppliers.supplierID AND UnitPrice = 22);

SELECT ProductName
FROM Products
WHERE ProductID = ANY (SELECT ProductID FROM [Order Details] WHERE Quantity = 10);

SELECT ProductName
FROM Products
WHERE ProductID = ANY (SELECT ProductID FROM [Order Details] WHERE Quantity > 99);

SELECT ProductName
FROM Products
WHERE ProductID = ALL (SELECT ProductID FROM [Order Details] WHERE Quantity = 10);

SELECT CustomerID, ContactName INTO CustomersBackup2017
FROM Customers;

SELECT * INTO CustomersGermany
FROM Customers
WHERE Country = 'Germany';

SELECT Customers.ContactName, Orders.OrderID
INTO CustomersOrderBackup2017
FROM Customers
LEFT JOIN Orders ON Customers.CustomerID = Orders.CustomerID;

INSERT INTO Customers (CustomerName, ContactName, Address, City, PostalCode, Country)
SELECT SupplierName, ContactName, Address, City, PostalCode, Country FROM Suppliers;

INSERT INTO Customers (CustomerName, City, Country)
SELECT SupplierName, City, Country FROM Suppliers;

INSERT INTO Customers (CustomerName, City, Country)
SELECT SupplierName, City, Country FROM Suppliers
WHERE Country='Germany';

SELECT OrderID, Quantity,
CASE
    WHEN Quantity > 30 THEN 'The quantity is greater than 30'
    WHEN Quantity = 30 THEN 'The quantity is 30'
    ELSE 'The quantity is under 30'
END AS QuantityText
FROM [Order Details];

SELECT ContactName, City, Country
FROM Customers
ORDER BY
(CASE
    WHEN City IS NULL THEN Country
    ELSE City
END);

SELECT ProductName, UnitPrice * (UnitsInStock + UnitsOnOrder)
FROM Products;

SELECT ProductName, UnitPrice * (UnitsInStock + IIF(IsNull(UnitsOnOrder), 0, UnitsOnOrder))
FROM Products;



