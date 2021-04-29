USE LOANSYS
GO

CREATE PROCEDURE dbo.Client_Add
(
       @ClientId int, @FullName nvarchar, @DateOfBirth datetime, @Registered datetime, @Identifier uniqueidentifier
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.Client
	            (
				 ClientId, FullName, DateOfBirth, Registered, Identifier
				)
		 VALUES (
		         @ClientId, @FullName, @DateOfBirth, @Registered, @Identifier
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH