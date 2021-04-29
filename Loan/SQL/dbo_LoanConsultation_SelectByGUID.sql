USE LOANSYS
GO

CREATE PROCEDURE dbo.LoanConsultation_GetByGUID
(
	@value NVARCHAR(100)
)
AS
	SELECT ConsultationId, Registered, Age, Amount, Months, AmountFee, IPClient 
	  FROM dbo.LoanConsultation 
	 WHERE ConsultationId = @value