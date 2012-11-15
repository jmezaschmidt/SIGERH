ALTER PROCEDURE [dbo].[sp_verSolicitudesColaboradorTipo]

@cedula int,
@tipoSolicitud nvarchar(20)
	
AS
BEGIN
	BEGIN TRY
		
		SELECT idSolicitud, fechaSolicitud, motivo, fechaInicial, fechaFinal, EstadoSolicitud
		FROM dbo.Solicitud INNER JOIN dbo.EstadoSolicitud ON idEstadoSolicitud = FK_idEstadoSolicitud
		INNER JOIN dbo.TipoSolicitud On idTipoSolicitud = FK_idTipoSolicitud
		INNER JOIN dbo.Expediente ON idExpediente = FK_idExpediente
		INNER JOIN dbo.Colaborador ON idColaborador = FK_idColaborador where cedula = @cedula AND tipoSolicitud = @tipoSolicitud
				
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