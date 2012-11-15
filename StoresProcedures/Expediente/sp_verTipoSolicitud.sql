CREATE PROCEDURE [dbo].[sp_verTipoSolicitud]

--Parametros
@cedula int
	
AS
BEGIN

	BEGIN TRY
	
		SELECT TipoSolicitud FROM dbo.TipoSolicitud
	
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