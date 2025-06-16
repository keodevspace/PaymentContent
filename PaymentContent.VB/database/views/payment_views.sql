CREATE VIEW vw_PaymentDetails AS
SELECT 
    p.Id AS PaymentId,
    p.Amount,
    p.Date,
    c.Name AS CustomerName,
    pr.Name AS ProductName
FROM 
    Payments p
JOIN 
    Customers c ON p.CustomerId = c.Id
JOIN 
    Products pr ON p.ProductId = pr.Id;

CREATE VIEW vw_TotalPayments AS
SELECT 
    c.Id AS CustomerId,
    c.Name AS CustomerName,
    COUNT(p.Id) AS TotalPayments,
    SUM(p.Amount) AS TotalAmount
FROM 
    Customers c
LEFT JOIN 
    Payments p ON c.Id = p.CustomerId
GROUP BY 
    c.Id, c.Name;