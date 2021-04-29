USE LOANSYS
GO

CREATE PROCEDURE dbo.LoanBook_GetAll
AS
	SELECT LoanId, Amount, RateId, LoanTypeId, ClientId, Registered, Identifier 
	  FROM dbo.LoanBook