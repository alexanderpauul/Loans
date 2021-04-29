USE LOANSYS
GO

CREATE PROCEDURE dbo.LoanType_GetAll
AS
	SELECT LoanTypeId, TypeName, MonthValue, Registered, Identifier 
	  FROM dbo.LoanType