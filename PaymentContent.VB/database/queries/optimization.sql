-- Using indexes to optimize a SELECT query
SELECT *
FROM Payments
WHERE CustomerId = @CustomerId
AND PaymentDate >= @StartDate
AND PaymentDate <= @EndDate;

-- Using EXISTS instead of IN for better performance
SELECT p.*
FROM Products p
WHERE EXISTS (
    SELECT 1
    FROM Payments pay
    WHERE pay.ProductId = p.Id
);

-- Using Common Table Expressions (CTE) for better readability and performance
WITH RecentPayments AS (
    SELECT *
    FROM Payments
    WHERE PaymentDate >= DATEADD(MONTH, -1, GETDATE())
)
SELECT CustomerId, SUM(Amount) AS TotalAmount
FROM RecentPayments
GROUP BY CustomerId;

-- Avoiding SELECT *
SELECT Id, Amount, PaymentDate
FROM Payments
WHERE PaymentStatus = 'Completed';

-- Using proper JOINs instead of subqueries
SELECT c.Name, SUM(p.Amount) AS TotalPayments
FROM Customers c
JOIN Payments p ON c.Id = p.CustomerId
GROUP BY c.Name;