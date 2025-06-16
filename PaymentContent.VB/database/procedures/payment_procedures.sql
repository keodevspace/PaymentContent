CREATE PROCEDURE sp_InsertPayment
    @CustomerId INT,
    @ProductId INT,
    @Amount DECIMAL(10, 2),
    @PaymentDate DATETIME
AS
BEGIN
    INSERT INTO Payments (CustomerId, ProductId, Amount, PaymentDate)
    VALUES (@CustomerId, @ProductId, @Amount, @PaymentDate);
END;

CREATE PROCEDURE sp_GetPaymentById
    @PaymentId INT
AS
BEGIN
    SELECT * FROM Payments WHERE Id = @PaymentId;
END;

CREATE PROCEDURE sp_UpdatePayment
    @PaymentId INT,
    @Amount DECIMAL(10, 2),
    @PaymentDate DATETIME
AS
BEGIN
    UPDATE Payments
    SET Amount = @Amount, PaymentDate = @PaymentDate
    WHERE Id = @PaymentId;
END;

CREATE PROCEDURE sp_DeletePayment
    @PaymentId INT
AS
BEGIN
    DELETE FROM Payments WHERE Id = @PaymentId;
END;

CREATE PROCEDURE sp_GetAllPayments
AS
BEGIN
    SELECT * FROM Payments;
END;