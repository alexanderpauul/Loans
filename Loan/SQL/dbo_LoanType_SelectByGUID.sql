USE LOANSYS
GO

CREATE PROCEDURE dbo.LoanType_GetByGUID
(
	@value NVARCHAR(100)
)
AS
	SELECT LoanTypeId, TypeName, MonthValue, Registered, Identifier 
	  FROM dbo.LoanType 
	 WHERE LoanTypeId = @value