Select ProductName, 
SUM(od.UnitPrice * od.Quantity) AS [Total Revenue]
From Products p
INNER JOIN [Order Details] od ON p.ProductID = od.ProductID
INNER JOIN Orders o ON o.OrderID = od.OrderID
Group By p.ProductName