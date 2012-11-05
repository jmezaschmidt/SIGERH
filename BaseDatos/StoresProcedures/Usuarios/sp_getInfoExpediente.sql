ALTER PROCEDURE [dbo].[sp_verInfoExpediente]

@cedula int
	
AS
BEGIN
	BEGIN TRY
		
		Select * FROM dbo.Colaborador INNER JOIN dbo.Usuario ON FK_idColaborador = idColaborador
	
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