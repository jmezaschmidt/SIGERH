ALTER PROCEDURE [dbo].[sp_asignarCapacitacionColaborador]

@idCapacitacion int,
@cedula int
	
AS
BEGIN
	BEGIN TRY
	
		INSERT into dbo.CapacitacionesXExpediente(FK_idCapacitacion, FK_idExpediente) values
		(@idCapacitacion, (Select idExpediente FROM dbo.Expediente INNER JOIN dbo.Colaborador ON idColaborador = FK_idColaborador where cedula = @cedula))
		 	
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