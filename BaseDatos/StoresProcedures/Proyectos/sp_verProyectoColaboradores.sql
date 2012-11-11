CREATE PROCEDURE [dbo].[sp_verProyectosColaborador]

@cedula int
	
AS
BEGIN
	BEGIN TRY
		
		SELECT Colaborador.nombre Proyecto, descripcion, fechaInicio, EstadoProyecto   
		FROM dbo.Colaborador INNER JOIN dbo.Expediente ON idColaborador = FK_idColaborador
		INNER JOIN dbo.ProyectosXExpediente ON idExpediente = FK_idExpediente
		INNER JOIN dbo.Proyecto ON idProyecto = FK_idProyecto 
		INNER JOIN dbo.EstadoProyecto ON idEstadoProyecto = FK_idEstadoProyecto
		where cedula = @cedula	
	
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