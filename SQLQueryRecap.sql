Select Products.ProductName UrunAdi , SUM([Order Details].UnitPrice) ToplamKazanilanPara from Products inner join [Order Details]
on Products.ProductID = [Order Details].ProductID inner join Orders
on Orders.OrderID = [Order Details].OrderID Group by Products.ProductName order by ToplamKazanilanPara
