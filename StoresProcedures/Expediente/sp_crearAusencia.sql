ALTER PROCEDURE [dbo].[sp_crearAusencia]

@cedula int,
@fecha date
	
AS
BEGIN
	BEGIN TRY
	
		DECLARE @resultado bit
		
		SET @resultado = 1
		
		INSERT INTO dbo.Ausencia(FK_idExpediente, fecha) values 
		((Select idExpediente FROM dbo.Expediente INNER JOIN dbo.Colaborador ON idColaborador = FK_idColaborador where cedula = @cedula), @fecha)
		
		SELECT @resultado
		
	END TRY
	
	BEGIN CATCH
		declare @ErrorNumber int = ERROR_NUMBER()
		declare @ErrorSeverity int = ERROR_SEVERITY()
		declare @ErrorState int = ERROR_STATE()
		declare @Message nvarchar(200) = ERROR_MESSAGE()
		PRINT @Message
		SET @resultado = 0
		SELECT @resultado
	END CATCH
END
GO