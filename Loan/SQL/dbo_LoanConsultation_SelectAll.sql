USE LOANSYS
GO

CREATE PROCEDURE dbo.LoanConsultation_GetAll
AS
	SELECT ConsultationId, Registered, Age, Amount, Months, AmountFee, IPClient 
	  FROM dbo.LoanConsultation