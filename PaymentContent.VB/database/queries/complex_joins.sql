SELECT 
    p.Id AS PaymentId,
    p.Amount,
    p.Date,
    c.Id AS CustomerId,
    c.Name AS CustomerName,
    c.Email AS CustomerEmail,
    pr.Id AS ProductId,
    pr.Name AS ProductName,
    pr.Price
FROM 
    Payments p
JOIN 
    Customers c ON p.CustomerId = c.Id
JOIN 
    Products pr ON p.ProductId = pr.Id
WHERE 
    p.Date >= '2023-01-01'
ORDER BY 
    p.Date DESC;