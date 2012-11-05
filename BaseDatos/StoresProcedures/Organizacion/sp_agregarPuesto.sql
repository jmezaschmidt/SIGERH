ALTER PROCEDURE [dbo].[sp_agregarPuesto]

--Parametros
@puesto nvarchar(50)	
	
AS
BEGIN
	BEGIN TRY
		
		INSERT into dbo.Puesto(puesto) values (@puesto)	
	
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