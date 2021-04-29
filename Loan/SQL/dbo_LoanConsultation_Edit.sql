USE LOANSYS
GO

CREATE PROCEDURE dbo.LoanConsultation_Edit
(
       @ConsultationId int, @Registered datetime, @Age int, @Amount decimal, @Months int, @AmountFee decimal, @IPClient nvarchar
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.LoanConsultation 
		   SET ConsultationId = @ConsultationId, Registered = @Registered, Age = @Age, Amount = @Amount, Months = @Months, AmountFee = @AmountFee, IPClient = @IPClient
		 WHERE ConsultationId = @ConsultationId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH