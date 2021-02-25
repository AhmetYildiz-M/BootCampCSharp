--Select
--ANSI
Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers

Select * from Customers where City = 'Berlin'

--Case Insensitive ( buyuk kucuk harf duyarsiz onemli olan dogru komut girilmesi ve turkce karakter olmamasi)
Select * from Products where CategoryID = 1 or CategoryID = 3

Select * from Products where CategoryID = 1 and UnitPrice >=10

Select * from Products order by UnitPrice asc --ascending (asc - fiyat artan siralama)

Select * from Products order by UnitPrice desc --descending (desc - fiyat azalan siralama)

Select count (*) Adet from Products

Select CategoryID, count(*) from Products where UnitPrice >20 group by CategoryID having count(*) <10

Select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation Object

Select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null


 
