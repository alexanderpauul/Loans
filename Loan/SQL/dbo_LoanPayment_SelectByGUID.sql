USE LOANSYS
GO

CREATE PROCEDURE dbo.LoanPayment_GetByGUID
(
	@value NVARCHAR(100)
)
AS
	SELECT LoanPaymentId, LoanId, Balance, PaymentReceived, Comment, Identifier 
	  FROM dbo.LoanPayment 
	 WHERE LoanPaymentId = @value