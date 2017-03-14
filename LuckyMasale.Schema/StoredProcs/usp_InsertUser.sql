CREATE PROC usp_InsertUser
@FirstName VARCHAR(50),
@LastName VARCHAR(50),
@DateOfBirth DATETIME,
@EmailID VARCHAR(200),
@Gender INT,
@CompanyName VARCHAR(250),
@StreetAddress1 VARCHAR(500),
@StreetAddress2 VARCHAR(500),
@PostCode VARCHAR(50),
@City VARCHAR(50),
@StateId VARCHAR(50),
@Country VARCHAR(50),
@Phone VARCHAR(50),
@Fax VARCHAR(50),
@Password VARCHAR(50),
@IsTaxExempt BIT,
@IsAdmin BIT,
@AdminComment VARCHAR(50),
@Status INT,
@RegistrationDate DATETIME2,
@OrderUser INT,
@IsEmailValidated BIT,
@UpdateDate DATETIME2
AS
BEGIN
	INSERT INTO [User]
	VALUES(@FirstName, @LastName, @DateOfBirth, @EmailId, @Gender, @CompanyName, @StreetAddress1, @StreetAddress2,
	@PostCode, @City, @StateId, @Country, @Phone, @Fax, @Password, @IsTaxExempt, @IsAdmin, @AdminComment, @Status,
	@RegistrationDate, @OrderUser, @IsEmailValidated, @UpdateDate)
	
	RETURN SCOPE_IDENTITY()
END
