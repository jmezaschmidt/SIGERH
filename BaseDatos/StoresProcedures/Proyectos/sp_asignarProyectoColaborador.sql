ALTER PROCEDURE [dbo].[sp_asignarProyectoColaborador]

@nombre nvarchar(50),
@cedula int
	
AS
BEGIN
	BEGIN TRY
		DECLARE @resultado bit
		
		SET @resultado = 1
		
		IF NOT EXISTS (SELECT idExpediente FROM Colaborador 
						INNER JOIN dbo.Expediente ON idColaborador = FK_idColaborador 
						INNER JOIN dbo.ProyectosXExpediente ON idExpediente = FK_idExpediente
						INNER JOIN dbo.Proyecto ON idProyecto = FK_idProyecto
						where dbo.Proyecto.nombre = @nombre AND cedula = @cedula)
		BEGIN
		INSERT into dbo.ProyectosXExpediente (FK_idExpediente, FK_idProyecto, habilitado) values
		((SELECT idExpediente FROM dbo.Expediente INNER JOIN Colaborador ON idColaborador = FK_idColaborador where cedula = @cedula),
		 (SELECT idProyecto FROM dbo.Proyecto where nombre = @nombre), 1)				 
		END		
		
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