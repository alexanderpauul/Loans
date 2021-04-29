USE LOANSYS
GO

CREATE PROCEDURE dbo.LoanPayment_GetAll
AS
	SELECT LoanPaymentId, LoanId, Balance, PaymentReceived, Comment, Identifier 
	  FROM dbo.LoanPayment