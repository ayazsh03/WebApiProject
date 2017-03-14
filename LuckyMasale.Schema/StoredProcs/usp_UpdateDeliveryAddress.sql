CREATE PROC usp_UpdateDeliveryAddress
@DeliveryAddressID INT,
@UserID INT,
@OrderID INT,
@Name VARCHAR(100),
@Pincode VARCHAR(10),
@Address VARCHAR(255),
@Landmark VARCHAR(255),
@country VARCHAR(50),
@state VARCHAR(50),
@city VARCHAR(50),
@phone VARCHAR(15)
AS
BEGIN
	UPDATE DeliveryAddress
	SET UserID = @UserID,
	OrderID = @OrderID,
	Name = @Name,
	Pincode = @Pincode,
	Address = @Address,
	Landmark = @Landmark,
	country = @country,
	state = @state,
	city = @city,
	phone = @phone
	WHERE DeliveryAddressID = @DeliveryAddressID
END
