USE LOANSYS
GO

CREATE PROCEDURE dbo.LoanType_Add
(
       @LoanTypeId int, @TypeName nvarchar, @MonthValue int, @Registered datetime, @Identifier uniqueidentifier
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.LoanType
	            (
				 LoanTypeId, TypeName, MonthValue, Registered, Identifier
				)
		 VALUES (
		         @LoanTypeId, @TypeName, @MonthValue, @Registered, @Identifier
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH