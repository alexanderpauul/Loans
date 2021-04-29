
USE master;
GO

CREATE DATABASE LOANSYS;
GO

USE LOANSYS;
GO

-- TO STORAGE LOAN RATE PER AGE 
CREATE TABLE LoanRate (
	RateId INT PRIMARY KEY IDENTITY(1,1),
	RateAge INT NOT NULL,
	RateValue DECIMAL (10,2) DEFAULT 0,
	Registered DATETIME DEFAULT GETDATE(),
	Identifier UNIQUEIDENTIFIER DEFAULT NEWID()
);
GO
			  
-- TO STORAGE CLIENTS  
CREATE TABLE Client (
	ClientId INT PRIMARY KEY IDENTITY(1,1),
	FullName NVARCHAR(128) NOT NULL,
	DateOfBirth DATETIME NOT NULL,
	Registered DATETIME DEFAULT GETDATE(),
	Identifier UNIQUEIDENTIFIER DEFAULT NEWID()
); 
GO

-- TO STORAGE LOAN TYPE CONSIDERING MONTHS
CREATE TABLE LoanType (
    LoanTypeId INT PRIMARY KEY IDENTITY(1,1),
	TypeName NVARCHAR(128) NOT NULL,
	MonthValue INT NOT NULL,
	Registered DATETIME DEFAULT GETDATE(),
	Identifier UNIQUEIDENTIFIER DEFAULT NEWID()
); 
GO

-- TO STORAGE LOANS 
CREATE TABLE LoanBook (
	LoanId INT PRIMARY KEY IDENTITY(1,1),
	Amount DECIMAL (10,2) DEFAULT 0,
	RateId INT FOREIGN KEY REFERENCES LoanRate(RateId),
	LoanTypeId INT FOREIGN KEY REFERENCES LoanType(LoanTypeId),
	ClientId INT FOREIGN KEY REFERENCES Client(ClientId),
	Registered DATETIME DEFAULT GETDATE(),
	Identifier UNIQUEIDENTIFIER DEFAULT NEWID()
);
GO

-- TO STORATE PAYMENTS RECEIVED
CREATE TABLE LoanPayment (
	LoanPaymentId INT PRIMARY KEY IDENTITY(1,1),
	LoanId INT FOREIGN KEY REFERENCES LoanBook(LoanId),
	Payment DECIMAL(10,2) DEFAULT 0,
	Balance DECIMAL(10,2) DEFAULT 0,
    PaymentReceived DATETIME NULL,
	Comment NVARCHAR(256) NULL,
	Identifier UNIQUEIDENTIFIER DEFAULT NEWID()
); 
GO

-- TO STORAGE CONSULTATION
CREATE TABLE LoanConsultation (
	ConsultationId INT PRIMARY KEY IDENTITY(1,1),
	Registered DATETIME DEFAULT GETDATE(),
	Age INT NOT NULL,
	Amount DECIMAL (10,2) DEFAULT 0,
	Months INT NOT NULL,
	AmountFee DECIMAL (10,2) DEFAULT 0,
	IPClient NVARCHAR(32) NOT NULL,
);
GO

-- FEE CALCULATION COULD BE THROUG SQL FUNCTION OR A METHOD IN THE APP BUSINESS LAYER.
-- IN THIS SAMPLE I GOING TO USE APP BUSINESS LAYER OPTION, ANYWAY LET'S CREATE THE FUNCTION.

CREATE FUNCTION FeeCalculation (
	@Amount DECIMAL (10,2),
	@RateValue DECIMAL (10,2),
	@MonthValue INT
)
RETURNS DECIMAL (10,2)
AS
BEGIN
	DECLARE @Fee DECIMAL (10,2)
	SET @Fee = (@Amount * @RateValue)/@MonthValue
	RETURN @Fee
END;
GO

-- DEFAULT DATA
INSERT INTO LoanRate (RateAge, RateValue) 
     VALUES ('18', 1.20),
	        ('19', 1.18), 
			('20', 1.16), 
			('21', 1.14), 
			('22', 1.12), 
			('23', 1.10), 
			('24', 1.08), 
			('25', 1.05);
GO

INSERT INTO LoanType (TypeName, MonthValue) 
     VALUES ('3 Meses', 3),
	        ('6 Meses', 6),
			('9 Meses', 9),
			('12 Meses', 12);
GO

--Store Procedure
CREATE PROCEDURE dbo.LoanConsultation_Add
(
	   @Age int, 
	   @Amount decimal (10,2), 
	   @Months int, 
	   @AmountFee decimal (10, 2), 
	   @IPClient nvarchar
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.LoanConsultation
	            (Age, Amount, Months, AmountFee, IPClient)
		 VALUES (@Age, @Amount, @Months, @AmountFee, @IPClient)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH
GO


CREATE PROCEDURE dbo.LoanRate_GetAll
AS
	SELECT RateId, RateAge, RateValue, Registered, Identifier 
	  FROM dbo.LoanRate
GO


CREATE PROCEDURE dbo.LoanType_GetAll
AS
	SELECT LoanTypeId, TypeName, MonthValue, Registered, Identifier 
	  FROM dbo.LoanType
GO

CREATE PROCEDURE dbo.LoanConsultation_GetAll
AS
	SELECT ConsultationId, Registered, Age, Amount, Months, AmountFee, IPClient 
	  FROM dbo.LoanConsultation
GO

CREATE PROCEDURE dbo.LoanRate_GetByAge
(
	@value INT
)
AS
	SELECT RateId, RateAge, RateValue, Registered, Identifier 
	  FROM dbo.LoanRate 
	 WHERE RateAge = @value
GO

-- SELECT * FROM LoanRate
-- SELECT * FROM LoanType
-- SELECT * FROM LoanConsultation


-- SELECT dbo.FeeCalculation(9000, 1.2, 3) FEE
-- USE master
-- SELECT @@SERVERNAME
-- DROP DATABASE LOANSYS 


