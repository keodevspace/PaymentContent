INSERT INTO Customers (Id, Name, Email) VALUES
(1, 'John Doe', 'john.doe@example.com'),
(2, 'Jane Smith', 'jane.smith@example.com'),
(3, 'Alice Johnson', 'alice.johnson@example.com');

INSERT INTO Products (Id, Name, Price) VALUES
(1, 'Product A', 19.99),
(2, 'Product B', 29.99),
(3, 'Product C', 39.99);

INSERT INTO Payments (Id, CustomerId, ProductId, Amount, PaymentDate) VALUES
(1, 1, 1, 19.99, '2023-06-01'),
(2, 2, 2, 29.99, '2023-06-02'),
(3, 3, 3, 39.99, '2023-06-03');