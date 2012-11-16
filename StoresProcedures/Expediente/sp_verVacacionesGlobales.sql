CREATE PROCEDURE [dbo].[sp_verVacacionesGlobales]
	
AS
BEGIN
	BEGIN TRY
		SELECT idSolicitud, fechaInicial, fechaFinal, motivo, EstadoSolicitud 
		FROM dbo.EstadoSolicitud INNER JOIN dbo.Solicitud ON idEstadoSolicitud = FK_idEstadoSolicitud
		INNER JOIN dbo.TipoSolicitud ON idTipoSolicitud = FK_idTipoSolicitud where TipoSolicitud = 'Vacaciones Globales'
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