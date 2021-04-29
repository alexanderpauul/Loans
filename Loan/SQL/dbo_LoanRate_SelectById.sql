USE LOANSYS
GO

CREATE PROCEDURE dbo.LoanRate_GetById
(
	@value NVARCHAR(100)
)
AS
	SELECT RateId, RateAge, RateValue, Registered, Identifier 
	  FROM dbo.LoanRate 
	 WHERE RateId = @value