-- Select 
--ANSII
Select ContactName Adi, CompanyName Sirketadi, City Sehir from Customers

Select * from Customers where City = 'London'

-- case insensitive
Select * from Products where CategoryID = 1 or CategoryID = 3

Select * from Products where CategoryID = 1 and UnitPrice>=10

select * from Products order by CategoryID, ProductName  -- order by : sıralama, id içinde name de sıralanabilir.
select * from Products order by UnitPrice asc  --ascending: artan
select * from Products order by UnitPrice desc --descending: azalan
select * from Products where categoryid=1 order by UnitPrice desc 

select count(*) Adet from Products where CategoryID = 2   

select CategoryID, count(*) from Products where UnitPrice > 20 group by CategoryID having count(*) < 10 --having: kümülatif sorguya yazılır.


select products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories --hem products hem categories.
on Products.CategoryID = Categories.CategoryID -- on: koşul
where products.UnitPrice > 10


--DTO: data transformation object



select * from products p inner join [Order Details] od
on p.productid = od.ProductID
inner join orders o
on o.OrderID = od.OrderID


select * from Customers c inner join Orders o
on c.CustomerID = o.CustomerID

-- inner join : sadece tablolardaki eşleşen dataları getirir. eşleşmeyenleri getirmez.


select * from products p left join [Order Details] od
on p.productid = od.ProductID


select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null  --sisteme kayıt olup sipariş vermeyen müşterileri listeledi

-- left join : yazıma göre, solda olup sağda olmayanları da getir demek.

-- right join : yazıma göre, sağda olup solda olmayanları getir demek.





-- HOMEWORK --
-- Find out how much money we have made in total from each product.

--Hint: Group by will be used

--Hint: Tables Products, Orders, Order Details will be joined.

--Hint: Sum will be used.

SELECT p.ProductName [Ürün Adı], 
               SUM(od.UnitPrice * od.Quantity) [Kazanılan Toplam Miktar]
FROM Products p
LEFT JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductName
ORDER BY [Kazanılan Toplam Miktar] DESC