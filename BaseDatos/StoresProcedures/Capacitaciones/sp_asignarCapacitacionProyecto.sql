CREATE PROCEDURE [dbo].[sp_asignarCapacitacionProyecto]

@nombreProyecto nvarchar(50),
@idCapacitacion int,
@fechaInicio date,
@fechaFinal date
	
AS
BEGIN
	BEGIN TRY
	
		INSERT into dbo.CapacitacionesXProyecto (FK_idCapacitacion, FK_idProyecto, fechaInicial, fechaFinal) values
		(@idCapacitacion, (Select idProyecto FROm dbo.Proyecto where nombre = @nombreProyecto), @fechaInicio, @fechaFinal)
		 	
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