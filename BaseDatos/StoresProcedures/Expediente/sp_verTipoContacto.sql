ALTER PROCEDURE [dbo].[sp_verTipoContacto]
	
AS
BEGIN

	BEGIN TRY
	
		SELECT TipoContacto FROM dbo.TipoContacto
	
	END TRY
	
	BEGIN CATCH
		declare @ErrorNumber int = ERROR_NUMBER()
		declare @ErrorSeverity int = ERROR_SEVERITY()
		declare @ErrorState int = ERROR_STATE()
		declare @Message nvarchar(200) = ERROR_MESSAGE()		
		RAISERROR (@Message, @ErrorNumber, @ErrorSeverity, @ErrorState)
	END CATCH	
END
GO