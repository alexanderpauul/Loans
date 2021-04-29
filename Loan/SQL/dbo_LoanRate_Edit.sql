USE LOANSYS
GO

CREATE PROCEDURE dbo.LoanRate_Edit
(
       @RateId int, @RateAge int, @RateValue decimal, @Registered datetime, @Identifier uniqueidentifier
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.LoanRate 
		   SET RateId = @RateId, RateAge = @RateAge, RateValue = @RateValue, Registered = @Registered, Identifier = @Identifier
		 WHERE RateId = @RateId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH