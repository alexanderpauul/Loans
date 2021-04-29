USE LOANSYS
GO

CREATE PROCEDURE dbo.Client_GetAll
AS
	SELECT ClientId, FullName, DateOfBirth, Registered, Identifier 
	  FROM dbo.Client