ALTER PROCEDURE [dbo].[sp_verProyectosCapacitacion]

@idCapacitacion int
	
AS
BEGIN

	BEGIN TRY
		
		SELECT DISTINCT nombre, descripcion, fechaInicio, fechaFinal, EstadoProyecto FROM 
		dbo.Proyecto INNER JOIN dbo.EstadoProyecto ON idEstadoProyecto = FK_idEstadoProyecto		
		INNER JOIN dbo.CapacitacionesXExpediente ON FK_idProyecto = idProyecto where FK_idCapacitacion = @idCapacitacion
		
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