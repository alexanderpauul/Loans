USE LOANSYS
GO

CREATE PROCEDURE dbo.LoanPayment_Edit
(
       @LoanPaymentId int, @LoanId int, @Payment decimal, @Balance decimal, @PaymentReceived datetime, @Comment nvarchar, @Identifier uniqueidentifier
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.LoanPayment 
		   SET LoanPaymentId = @LoanPaymentId, LoanId = @LoanId, Payment = @Payment, Balance = @Balance, PaymentReceived = @PaymentReceived, Comment = @Comment, Identifier = @Identifier
		 WHERE LoanPaymentId = @LoanPaymentId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH