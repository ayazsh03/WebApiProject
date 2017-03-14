CREATE PROC usp_InsertOrderProduct
@ProductId INT,
@OrderID INT,
@Price FLOAT,
@Quantity INT
AS
BEGIN
	INSERT INTO OrderProduct
	VALUES(@ProductId, @OrderID, @Price, @Quantity)
END

