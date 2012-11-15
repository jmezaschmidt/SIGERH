CREATE PROCEDURE [dbo].[sp_eliminarCapacitacionProyecto]

@idCapacitacion int,
@nombreProyecto nvarchar(50)
	
AS
BEGIN
	BEGIN TRY
	
		DECLARE @resultado bit
		SET @resultado = 1
		
		DELETE FROM dbo.CapacitacionesXExpediente where FK_idCapacitacion = @idCapacitacion AND
		FK_idProyecto = (Select idProyecto FROM dbo.Proyecto where nombre = @nombreProyecto)
		
		
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