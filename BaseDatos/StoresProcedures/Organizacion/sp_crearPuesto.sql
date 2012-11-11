CREATE PROCEDURE [dbo].[sp_crearPuesto]

--Parametros
@puesto nvarchar(50)	
	
AS
BEGIN
	BEGIN TRY
		
		INSERT into dbo.Puesto(puesto) values (@puesto)	
		SElect 1
	
	END TRY
	
	BEGIN CATCH
		declare @ErrorNumber int = ERROR_NUMBER()
		declare @ErrorSeverity int = ERROR_SEVERITY()
		declare @ErrorState int = ERROR_STATE()
		declare @Message nvarchar(200) = ERROR_MESSAGE()
		Select 0
	END CATCH		
END
GO