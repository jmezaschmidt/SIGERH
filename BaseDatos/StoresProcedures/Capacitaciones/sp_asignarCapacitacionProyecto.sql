ALTER PROCEDURE [dbo].[sp_asignarCapacitacionProyecto]

@nombreProyecto nvarchar(50),
@idCapacitacion int

AS
BEGIN
	BEGIN TRY
		
		DECLARE @resultado bit
		SET @resultado = 1
				
		DECLARE @idProyecto int		
		SET @idProyecto = (Select idProyecto FROM dbo.Proyecto where nombre = @nombreProyecto)
		
		DECLARE @idExpediente int
		
		DECLARE cursorColaboradores CURSOR FOR
		SELECT idExpediente from dbo.Expediente INNER JOIN dbo.ProyectosXExpediente ON idExpediente = FK_idExpediente where FK_idProyecto = @idProyecto
		
		OPEN cursorColaboradores
		
		FETCH NEXT FROM cursorColaboradores INTO @idExpediente
		
		WHILE @@FETCH_STATUS = 0
		BEGIN		
			IF EXISTS(SELECT * FROM dbo.CapacitacionesXExpediente where FK_idExpediente = @idExpediente AND FK_idCapacitacion = @idCapacitacion)
			BEGIN
				UPDATE dbo.CapacitacionesXExpediente SET FK_idProyecto = (SELECT idProyecto FROM dbo.Proyecto where nombre = @nombreProyecto)
				where FK_idExpediente = @idExpediente AND FK_idCapacitacion = @idCapacitacion
			END
			ELSE
			BEGIN
				INSERT INTO dbo.CapacitacionesXExpediente (FK_idCapacitacion, FK_idExpediente, FK_idProyecto)
				values(@idCapacitacion, @idExpediente, @idProyecto)			
			END			
			FETCH NEXT FROM cursorColaboradores INTO @idExpediente
		END
		CLOSE cursorColaboradores 
		DEALLOCATE cursorColaboradores
		
		SELECT @resultado
		 	
	END TRY
	
	BEGIN CATCH
		declare @ErrorNumber int = ERROR_NUMBER()
		declare @ErrorSeverity int = ERROR_SEVERITY()
		declare @ErrorState int = ERROR_STATE()
		declare @Message nvarchar(200) = ERROR_MESSAGE()
		SET @resultado = 1
		SELECT @resultado
	END CATCH		
END
GO