ALTER PROCEDURE [dbo].[sp_crearExpediente]

--Parametros
@idUsuario int
	
AS
BEGIN

	BEGIN TRY
	
		INSERT into dbo.Expediente(fechaCreacion, habilitado, FK_idColaborador) values (GETDATE(), 1, @idUsuario)
	
	END TRY
	
	BEGIN CATCH
		declare @ErrorNumber int = ERROR_NUMBER()
		declare @ErrorSeverity int = ERROR_SEVERITY()
		declare @ErrorState int = ERROR_STATE()
		declare @Message nvarchar(200) = ERROR_MESSAGE()
		ROLLBACK
		RAISERROR (@Message, @ErrorNumber, @ErrorSeverity, @ErrorState)
	END CATCH	
END
GO