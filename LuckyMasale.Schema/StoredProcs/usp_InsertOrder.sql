CREATE PROC usp_InsertOrder
@UserID INT,
@PaymentStatusID INT,
@TransactionID INT,
@TrackingNumber VARCHAR(50),
@SubTotal FLOAT,
@OrderTotal FLOAT,
@Tax FLOAT,
@ShippingCharges FLOAT,
@OrderDate DATETIME,
@DeliveryDate DATETIME,
@SpecialInstruction VARCHAR(MAX)
AS
BEGIN
	INSERT INTO [Order]
	VALUES(@UserID, @PaymentStatusID, @TransactionID, @TrackingNumber, @SubTotal, @OrderTotal, @Tax, @ShippingCharges,
	@OrderDate, @DeliveryDate, @SpecialInstruction)
	
	RETURN SCOPE_IDENTITY()
END
