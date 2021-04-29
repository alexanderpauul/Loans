USE LOANSYS
GO

CREATE PROCEDURE dbo.LoanBook_Edit
(
       @LoanId int, @Amount decimal, @RateId int, @LoanTypeId int, @ClientId int, @Registered datetime, @Identifier uniqueidentifier
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.LoanBook 
		   SET LoanId = @LoanId, Amount = @Amount, RateId = @RateId, LoanTypeId = @LoanTypeId, ClientId = @ClientId, Registered = @Registered, Identifier = @Identifier
		 WHERE LoanId = @LoanId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH