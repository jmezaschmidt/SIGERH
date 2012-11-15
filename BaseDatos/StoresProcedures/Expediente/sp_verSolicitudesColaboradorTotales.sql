CREATE PROCEDURE [dbo].[sp_verSolicitudesColaborador]

@cedula int
	
AS
BEGIN
	BEGIN TRY
		
		SELECT idSolicitud, TipoSolicitud, motivo, fechaInicial, fechaFinal, EstadoSolicitud
		FROM dbo.Solicitud INNER JOIN dbo.EstadoSolicitud ON idEstadoSolicitud = FK_idEstadoSolicitud
		INNER JOIN dbo.TipoSolicitud On idTipoSolicitud = FK_idTipoSolicitud
		INNER JOIN dbo.Expediente ON idExpediente = FK_idExpediente
		INNER JOIN dbo.Colaborador ON idColaborador = FK_idColaborador where cedula = @cedula
				
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