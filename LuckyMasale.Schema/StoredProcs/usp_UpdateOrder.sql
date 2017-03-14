CREATE PROC usp_UpdateOrder
@OrderID INT,
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
	UPDATE [Order]
	SET UserID = @UserID,
	PaymentStatusID = @PaymentStatusID,
	TransactionID = @TransactionID,
	TrackingNumber = @TrackingNumber,
	SubTotal = @SubTotal,
	OrderTotal = @OrderTotal,
	Tax = @Tax,
	ShippingCharges = @ShippingCharges,
	OrderDate = @OrderDate,
	DeliveryDate = @DeliveryDate,
	SpecialInstruction = @SpecialInstruction
	WHERE OrderID = @OrderID
END

