USE LOANSYS
GO

CREATE PROCEDURE dbo.LoanRate_GetAll
AS
	SELECT RateId, RateAge, RateValue, Registered, Identifier 
	  FROM dbo.LoanRate