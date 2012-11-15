CREATE PROCEDURE [dbo].[sp_eliminarProyectoColaborador]

@nombre nvarchar(50),
@cedula int
	
AS
BEGIN
	BEGIN TRY
		DECLARE @resultado bit
		
		SET @resultado = 1
		
		DELETE FROM dbo.ProyectosXExpediente where 
		FK_idExpediente = (SELECT idExpediente FROM dbo.Expediente INNER JOIN Colaborador ON idColaborador = FK_idColaborador where cedula = @cedula) 
		AND FK_idProyecto = (SELECT idProyecto FROM dbo.Proyecto where nombre = @nombre)				 		
		
		SELECT @resultado
		 	
	END TRY
	
	BEGIN CATCH
		declare @ErrorNumber int = ERROR_NUMBER()
		declare @ErrorSeverity int = ERROR_SEVERITY()
		declare @ErrorState int = ERROR_STATE()
		declare @Message nvarchar(200) = ERROR_MESSAGE()
		SET @resultado = 0
		SELECT @resultado
	END CATCH		
END
GO