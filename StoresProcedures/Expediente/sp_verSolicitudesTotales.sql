CREATE PROCEDURE [dbo].[sp_verSolicitudesTotales]
	
AS
BEGIN
	BEGIN TRY
		SELECT idSolicitud, Colaborador.nombre + ' ' + apellido1 + ' ' + apellido2 Colaborador, cedula, 
		TipoSolicitud, motivo, fechaInicial, fechaFinal, EstadoSolicitud, Departamento.nombre Departamento
		FROM dbo.Solicitud INNER JOIN dbo.EstadoSolicitud ON idEstadoSolicitud = FK_idEstadoSolicitud
		INNER JOIN dbo.TipoSolicitud On idTipoSolicitud = FK_idTipoSolicitud
		INNER JOIN dbo.Expediente ON idExpediente = FK_idExpediente
		INNER JOIN dbo.Colaborador ON idColaborador = FK_idColaborador
		INNER JOIN dbo.Departamento ON idDepartamento = FK_idDepartamento
	
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