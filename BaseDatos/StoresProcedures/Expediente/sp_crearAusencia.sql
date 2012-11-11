CREATE PROCEDURE [dbo].[sp_crearAusencia]

@cedula int,
@fecha date
	
AS
BEGIN
	BEGIN TRY
	
		INSERT INTO dbo.Ausencia(FK_idExpediente, fecha) values 
		((Select idExpediente FROM dbo.Expediente INNER JOIN dbo.Colaborador ON idColaborador = FK_idColaborador), @fecha)
		
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