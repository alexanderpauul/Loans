USE LOANSYS
GO

CREATE PROCEDURE dbo.LoanPayment_Add
(
       @LoanPaymentId int, @LoanId int, @Payment decimal, @Balance decimal, @PaymentReceived datetime, @Comment nvarchar, @Identifier uniqueidentifier
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.LoanPayment
	            (
				 LoanPaymentId, LoanId, Balance, PaymentReceived, Comment, Identifier
				)
		 VALUES (
		         @LoanPaymentId, @LoanId, @Payment, @Balance, @PaymentReceived, @Comment, @Identifier
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH