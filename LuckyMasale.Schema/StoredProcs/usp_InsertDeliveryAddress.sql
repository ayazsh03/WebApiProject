CREATE PROC usp_InsertDeliveryAddress
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
	INSERT INTO DeliveryAddress
	VALUES(@UserID, @OrderID, @Name, @Pincode, @Address, @Landmark, @country, @state, @city, @phone)
END

