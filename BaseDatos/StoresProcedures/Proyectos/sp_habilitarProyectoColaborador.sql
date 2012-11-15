CREATE PROCEDURE [dbo].[sp_habilitarProyectoColaborador]

@nombre nvarchar(50),
@cedula nvarchar(20),
@habilitado bit
	
AS
BEGIN
	BEGIN TRY
		
		UPDATE dbo.ProyectosXExpediente SET habilitado = @habilitado where 
		FK_idExpediente = (SELECT idExpediente FROM dbo.Expediente INNER JOIN Colaborador ON idColaborador = FK_idColaborador where cedula = @cedula) AND
		FK_idProyecto = (SELECT idProyecto FROM dbo.Proyecto where nombre = @nombre)
		 	
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