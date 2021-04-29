USE LOANSYS
GO

CREATE PROCEDURE dbo.Client_Edit
(
       @ClientId int, @FullName nvarchar, @DateOfBirth datetime, @Registered datetime, @Identifier uniqueidentifier
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.Client 
		   SET ClientId = @ClientId, FullName = @FullName, DateOfBirth = @DateOfBirth, Registered = @Registered, Identifier = @Identifier
		 WHERE ClientId = @ClientId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH