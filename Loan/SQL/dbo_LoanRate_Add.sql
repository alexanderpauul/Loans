USE LOANSYS
GO

CREATE PROCEDURE dbo.LoanRate_Add
(
       @RateId int, @RateAge int, @RateValue decimal, @Registered datetime, @Identifier uniqueidentifier
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.LoanRate
	            (
				 RateId, RateAge, RateValue, Registered, Identifier
				)
		 VALUES (
		         @RateId, @RateAge, @RateValue, @Registered, @Identifier
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH