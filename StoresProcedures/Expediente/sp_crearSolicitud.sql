ALTER PROCEDURE [dbo].[sp_crearSolicitud]

@cedula int,
@fechaInicial datetime,
@fechaFinal	datetime,
@motivo nvarchar(100),
@tipoSolicitud nvarchar(20)
	
AS
BEGIN
	BEGIN TRY
		
		
		DECLARE @resultado bit
		SET @resultado = 1
		
		INSERT INTO dbo.Solicitud (fechaSolicitud, fechaInicial, fechaFinal, motivo, FK_idExpediente, FK_idTipoSolicitud, FK_idEstadoSolicitud) values
		(GETDATE(), @fechaInicial, @fechaFinal, @motivo, 
		(SELECT idExpediente FROM dbo.Expediente INNER JOIN dbo.Colaborador ON idColaborador = FK_idColaborador where cedula = @cedula),
		(SELECT idTipoSolicitud FROM dbo.TipoSolicitud where tipoSolicitud = @tipoSolicitud),
		(SELECT idEstadoSolicitud FROm dbo.EstadoSolicitud where EstadoSolicitud = 'En Espera'))		
	
		Select @resultado
	END TRY
	
	BEGIN CATCH
		declare @ErrorNumber int = ERROR_NUMBER()
		declare @ErrorSeverity int = ERROR_SEVERITY()
		declare @ErrorState int = ERROR_STATE()
		declare @Message nvarchar(200) = ERROR_MESSAGE()
		Select @resultado
	END CATCH		
END
GO