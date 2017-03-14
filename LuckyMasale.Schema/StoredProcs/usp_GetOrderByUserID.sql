CREATE PROC usp_GetOrderByUserID
@UserID INT
AS
BEGIN
	SELECT * FROM [Order]
	WHERE UserID = @UserID
END
