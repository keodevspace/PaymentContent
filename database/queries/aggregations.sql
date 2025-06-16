SELECT 
    COUNT(*) AS TotalPayments,
    SUM(Amount) AS TotalAmount,
    AVG(Amount) AS AverageAmount,
    MIN(Amount) AS MinimumAmount,
    MAX(Amount) AS MaximumAmount
FROM 
    Payments
WHERE 
    PaymentDate >= DATEADD(MONTH, -1, GETDATE()); 

SELECT 
    CustomerId,
    COUNT(*) AS TotalPayments,
    SUM(Amount) AS TotalAmount
FROM 
    Payments
GROUP BY 
    CustomerId
HAVING 
    SUM(Amount) > 1000; 

SELECT 
    ProductId,
    COUNT(*) AS TotalSales,
    SUM(Amount) AS TotalRevenue
FROM 
    Payments
JOIN 
    Products ON Payments.ProductId = Products.Id
GROUP BY 
    ProductId; 

SELECT 
    YEAR(PaymentDate) AS PaymentYear,
    MONTH(PaymentDate) AS PaymentMonth,
    COUNT(*) AS TotalPayments,
    SUM(Amount) AS TotalAmount
FROM 
    Payments
GROUP BY 
    YEAR(PaymentDate), MONTH(PaymentDate)
ORDER BY 
    PaymentYear, PaymentMonth;