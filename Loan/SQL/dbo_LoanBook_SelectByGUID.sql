USE LOANSYS
GO

CREATE PROCEDURE dbo.LoanBook_GetByGUID
(
	@value NVARCHAR(100)
)
AS
	SELECT LoanId, Amount, RateId, LoanTypeId, ClientId, Registered, Identifier 
	  FROM dbo.LoanBook 
	 WHERE LoanId = @value