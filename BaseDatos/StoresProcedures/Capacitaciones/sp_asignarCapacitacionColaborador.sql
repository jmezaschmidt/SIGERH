ALTER PROCEDURE [dbo].[sp_asignarCapacitacionColaborador]

@idCapacitacion int,
@cedula int
	
AS
BEGIN
	BEGIN TRY
	
		DECLARE @resultado bit
		SET @resultado = 1
		IF NOT EXISTS (SELECT idExpediente FROM dbo.CapacitacionesXExpediente INNER JOIN dbo.Expediente ON FK_idExpediente = idExpediente 
						INNER JOIN dbo.Colaborador ON idColaborador = FK_idColaborador where cedula = @cedula AND FK_idCapacitacion = @idCapacitacion)
		BEGIN
		INSERT into dbo.CapacitacionesXExpediente(FK_idCapacitacion, FK_idExpediente) values
		(@idCapacitacion, (Select idExpediente FROM dbo.Expediente INNER JOIN dbo.Colaborador ON idColaborador = FK_idColaborador where cedula = @cedula))
		END
		
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