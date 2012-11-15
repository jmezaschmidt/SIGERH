ALTER PROCEDURE [dbo].[sp_verCapacitacionesProyecto]

@proyecto nvarchar(50)
	
AS
BEGIN

	BEGIN TRY
		
		SELECT DISTINCT idCapacitacion, Capacitacion.nombre Capacitacion, fechaInicial, Capacitacion.fechaFinal FechaFinal, dbo.Capacitacion.descripcion Descripcion, duracion
		FROM dbo.Proyecto INNER JOIN dbo.CapacitacionesXExpediente ON idProyecto = FK_idProyecto
		INNER JOIN dbo.Capacitacion ON idCapacitacion = FK_idCapacitacion where Proyecto.nombre = @proyecto 
		
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