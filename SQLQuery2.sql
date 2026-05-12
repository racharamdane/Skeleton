USE [p2800530]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblMedicalRecord_FilterByPatientId]
		@PatientId = PatientId

SELECT	@return_value as 'Return Value'

GO
