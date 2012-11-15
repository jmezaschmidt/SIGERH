CREATE PROCEDURE [dbo].[sp_verPuestos]

--Parametros

AS
BEGIN
	BEGIN TRY
		
		Select puesto FRom dbo.Puesto
	
	END TRY
	
	BEGIN CATCH
		declare @ErrorNumber int = ERROR_NUMBER()
		declare @ErrorSeverity int = ERROR_SEVERITY()
		declare @ErrorState int = ERROR_STATE()
		declare @Message nvarchar(200) = ERROR_MESSAGE()
		Select 0
	END CATCH		
END
GO