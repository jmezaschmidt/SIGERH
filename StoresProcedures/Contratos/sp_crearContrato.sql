ALTER PROCEDURE [dbo].[sp_crearContrato]

@cedula int,
@cantidadHoras int
	
AS
BEGIN
	BEGIN TRY
	
		DECLARE @resultado bit
		SET @resultado = 1
		UPDATE dbo.Contrato SET habilitado = 0 where habilitado = 1
	
		INSERT INTO dbo.Contrato(cantidadHorasLaborales, fechaCreacion, habilitado, FK_idExpediente)
		Values(@cantidadHoras, GETDATE(), 1, (SElect idExpediente FROM dbo.Expediente INNER JOIN dbo.Colaborador ON idColaborador = FK_idColaborador where cedula = @cedula))
		Select @resultado
	END TRY
	
	BEGIN CATCH
		declare @ErrorNumber int = ERROR_NUMBER()
		declare @ErrorSeverity int = ERROR_SEVERITY()
		declare @ErrorState int = ERROR_STATE()
		declare @Message nvarchar(200) = ERROR_MESSAGE()
		SET @resultado = 1
		Select @resultado		
	END CATCH
END
GO