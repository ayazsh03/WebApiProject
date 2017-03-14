CREATE PROC usp_DeleteOrder
@OrderID INT
AS
BEGIN
	DELETE [Order] 
	WHERE OrderID = @OrderID
END
