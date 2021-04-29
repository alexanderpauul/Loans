USE LOANSYS
GO

CREATE PROCEDURE dbo.Client_GetByGUID
(
	@value NVARCHAR(100)
)
AS
	SELECT ClientId, FullName, DateOfBirth, Registered, Identifier 
	  FROM dbo.Client 
	 WHERE ClientId = @value