ALTER PROCEDURE [dbo].[sp_asignarEstadoProyecto]

@nombre nvarchar(50),
@cedula nvarchar(20)
	
AS
BEGIN
	BEGIN TRY
		
		INSERT into dbo.ProyectosXExpediente (FK_idExpediente, FK_idProyecto, habilitado) values
		((SELECT idExpediente FROM dbo.Expediente INNER JOIN Colaborador ON idColaborador = FK_idColaborador where cedula = @cedula),
		 (SELECT idProyecto FROM dbo.Proyecto where nombre = @nombre), 1)
		 	
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