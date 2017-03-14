CREATE PROC usp_UpdateOrderProduct
@OrderProductID INT,
@ProductId INT,
@OrderId INT,
@Price FLOAT,
@Quantity FLOAT
AS
BEGIN 
	UPDATE OrderProduct
	SET ProductId = @ProductId,
	OrderId = @OrderId,
	Price = @Price,
	Quantity = @Quantity
	WHERE OrderProductID = @OrderProductID
END
