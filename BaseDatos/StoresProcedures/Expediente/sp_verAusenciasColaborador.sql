CREATE PROCEDURE [dbo].[sp_verAusenciasColaborador]

@cedula int
	
AS
BEGIN
	BEGIN TRY
		
		Select idAusencia, fecha FROM dbo.Ausencia INNER JOIN Expediente ON idExpediente = FK_idExpediente
		INNER JOIN dbo.Colaborador ON idColaborador = FK_idColaborador where cedula = @cedula
	
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