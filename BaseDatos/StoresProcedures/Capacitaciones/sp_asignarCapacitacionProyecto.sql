ALTER PROCEDURE [dbo].[sp_asignarCapacitacionProyecto]

@nombreProyecto nvarchar(50),
@idCapacitacion int

AS
BEGIN
	--BEGIN TRY
		
		DECLARE @idProyecto int		
		SET @idProyecto = (Select idProyecto FROM dbo.Proyecto where nombre = @nombreProyecto)
		
		DECLARE @idExpediente int
		
		DECLARE cursorColaboradores CURSOR FOR
		SELECT idExpediente from dbo.Expediente INNER JOIN dbo.ProyectosXExpediente ON idExpediente = FK_idExpediente where FK_idProyecto = @idProyecto
		
		OPEN cursorColaboradores
		
		FETCH NEXT FROM cursorColaboradores INTO @idExpediente
		
		WHILE @@FETCH_STATUS = 0
		BEGIN
			
			INSERT INTO dbo.CapacitacionesXExpediente (FK_idCapacitacion, FK_idExpediente, FK_idProyecto)
			values(@idCapacitacion, @idExpediente, @idProyecto)
			
			FETCH NEXT FROM cursorColaboradores INTO @idExpediente
		END
		CLOSE cursorColaboradores 
		DEALLOCATE cursorColaboradores
		
		 	
	--END TRY
	
	--BEGIN CATCH
	--	declare @ErrorNumber int = ERROR_NUMBER()
	--	declare @ErrorSeverity int = ERROR_SEVERITY()
	--	declare @ErrorState int = ERROR_STATE()
	--	declare @Message nvarchar(200) = ERROR_MESSAGE()
	--	RAISERROR (@Message, @ErrorNumber, @ErrorSeverity, @ErrorState)
	--END CATCH		
END
GO