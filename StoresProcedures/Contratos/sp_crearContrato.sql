ALTER PROCEDURE [dbo].[sp_crearContrato]

@cedula int,
@cantidadHoras int
	
AS
BEGIN
	BEGIN TRY
	
		UPDATE dbo.Contrato SET habilitado = 0 where habilitado = 1
	
		INSERT INTO dbo.Contrato(cantidadHorasLaborales, fechaCreacion, habilitado, FK_idExpediente)
		Values(@cantidadHoras, GETDATE(), 1, (SElect idExpediente FROM dbo.Expediente INNER JOIN dbo.Colaborador ON idColaborador = FK_idColaborador where cedula = @cedula))
		
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