CREATE PROCEDURE [dbo].[sp_crearVacacionesGlobales]

@fechaInicial datetime,
@fechaFinal	datetime,
@motivo nvarchar(100)
	
AS
BEGIN
	BEGIN TRY
		
		
		DECLARE @resultado bit
		SET @resultado = 1
		
		INSERT INTO dbo.Solicitud (fechaSolicitud, fechaInicial, fechaFinal, motivo, FK_idTipoSolicitud, FK_idEstadoSolicitud) values
		(GETDATE(), @fechaInicial, @fechaFinal, @motivo, 		
		(SELECT idTipoSolicitud FROM dbo.TipoSolicitud where tipoSolicitud = 'Vacaciones Globales'),
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