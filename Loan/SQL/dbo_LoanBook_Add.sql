USE LOANSYS
GO

CREATE PROCEDURE dbo.LoanBook_Add
(
       @LoanId int, @Amount decimal, @RateId int, @LoanTypeId int, @ClientId int, @Registered datetime, @Identifier uniqueidentifier
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.LoanBook
	            (
				 LoanId, Amount, RateId, LoanTypeId, ClientId, Registered, Identifier
				)
		 VALUES (
		         @LoanId, @Amount, @RateId, @LoanTypeId, @ClientId, @Registered, @Identifier
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH