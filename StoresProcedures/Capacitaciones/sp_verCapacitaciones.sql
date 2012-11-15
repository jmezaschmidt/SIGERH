ALTER PROCEDURE [dbo].[sp_verCapacitaciones]

AS
BEGIN

	BEGIN TRY
		
		SELECT idCapacitacion, Capacitacion.nombre Capacitacion, fechaInicial, fechaFinal, dbo.Capacitacion.descripcion Descripcion, duracion
		FROM dbo.Capacitacion
		
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