USE LOANSYS
GO

CREATE PROCEDURE dbo.LoanType_Edit
(
       @LoanTypeId int, @TypeName nvarchar, @MonthValue int, @Registered datetime, @Identifier uniqueidentifier
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.LoanType 
		   SET LoanTypeId = @LoanTypeId, TypeName = @TypeName, MonthValue = @MonthValue, Registered = @Registered, Identifier = @Identifier
		 WHERE LoanTypeId = @LoanTypeId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH