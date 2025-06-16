-- Basic CRUD Operations for Payments, Customers, and Products

-- Create
-- Insert a new payment
INSERT INTO Payments (Amount, Date, CustomerId, ProductId)
VALUES (@Amount, @Date, @CustomerId, @ProductId);

-- Insert a new customer
INSERT INTO Customers (Name, Email)
VALUES (@Name, @Email);

-- Insert a new product
INSERT INTO Products (Name, Price)
VALUES (@Name, @Price);

-- Read
-- Select all payments
SELECT * FROM Payments;

-- Select all customers
SELECT * FROM Customers;

-- Select all products
SELECT * FROM Products;

-- Update
-- Update a payment
UPDATE Payments
SET Amount = @Amount, Date = @Date, CustomerId = @CustomerId, ProductId = @ProductId
WHERE Id = @Id;

-- Update a customer
UPDATE Customers
SET Name = @Name, Email = @Email
WHERE Id = @Id;

-- Update a product
UPDATE Products
SET Name = @Name, Price = @Price
WHERE Id = @Id;

-- Delete
-- Delete a payment
DELETE FROM Payments
WHERE Id = @Id;

-- Delete a customer
DELETE FROM Customers
WHERE Id = @Id;

-- Delete a product
DELETE FROM Products
WHERE Id = @Id;