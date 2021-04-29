USE LOANSYS
GO

CREATE PROCEDURE dbo.LoanConsultation_Add
(
       @ConsultationId int, @Registered datetime, @Age int, @Amount decimal, @Months int, @AmountFee decimal, @IPClient nvarchar
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.LoanConsultation
	            (
				 ConsultationId, Registered, Age, Amount, Months, AmountFee, IPClient
				)
		 VALUES (
		         @ConsultationId, @Registered, @Age, @Amount, @Months, @AmountFee, @IPClient
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH