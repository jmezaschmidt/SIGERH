CREATE PROCEDURE [dbo].[sp_deshabilitarExpediente]

@cedula int,
@habilitado bit
	
AS
BEGIN
	BEGIN TRY
		
		UPDATE dbo.Expediente SET habilitado = @habilitado, fechaModificacion = GETDATE() where 
		idExpediente = (SELECT idExpediente FROM dbo.Expediente INNER JOIN dbo.Colaborador ON idColaborador = FK_idColaborador where cedula = @cedula)

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