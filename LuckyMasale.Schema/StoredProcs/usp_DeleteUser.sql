CREATE PROC usp_DeleteUser
@UserId INT
AS
BEGIN 
	DELETE [User]
	WHERE UserId = @UserId
END

