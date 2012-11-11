CREATE PROCEDURE [dbo].[sp_verCapacitacion]

@cedula int
	
AS
BEGIN

	BEGIN TRY
		
		SELECT idCapacitacion, Capacitacion.nombre Capacitacion, descripcion, duracion
		FROM dbo.Colaborador INNER JOIN dbo.Expediente ON idColaborador = FK_idColaborador
		INNER JOIN dbo.CapacitacionesXExpediente ON idExpediente = FK_idExpediente
		INNER JOIN dbo.Capacitacion ON idCapacitacion = FK_idCapacitacion where cedula = @cedula
		
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