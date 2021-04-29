USE LOANSYS
GO

CREATE PROCEDURE dbo.LoanType_GetById
(
	@value NVARCHAR(100)
)
AS
	SELECT LoanTypeId, TypeName, MonthValue, Registered, Identifier 
	  FROM dbo.LoanType 
	 WHERE LoanTypeId = @value